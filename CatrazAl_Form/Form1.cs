using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CatrazAl.Business;
using CatrazAl.Data.Models;

namespace CatrazAl_Form
{
    public class MainForm : Form
    {
        private Panel sidebarPanel;
        private Panel contentPanel;
        private Label logoLabel;

        public MainForm()
        {
            InitializeComponent();
            SetupModules();
        }

        private void InitializeComponent()
        {
            this.Text = "CatrazAl - Prison Management System";
            this.Size = new Size(1100, 700);
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // Sidebar Panel setup
            sidebarPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.White
            };

            // Logo area in sidebar
            logoLabel = new Label
            {
                Text = "CatrazAl\nManager",
                Dock = DockStyle.Top,
                Height = 80,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                BackColor = Color.FromArgb(28, 28, 28)
            };
            sidebarPanel.Controls.Add(logoLabel);

            // Main Content Area
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            this.Controls.Add(contentPanel);
            this.Controls.Add(sidebarPanel);
        }

        private void SetupModules()
        {
            // Initialize Business Logic Layer
            var prisonerBiz = new PrisonerBusiness();
            var cellBiz = new CellBusiness();
            var blockBiz = new PrisonBlockBusiness();
            var guardBiz = new GuardBusiness();
            var shiftBiz = new ShiftBusiness();
            var crimeBiz = new CrimeBusiness();
            var punishBiz = new PunishmentBusiness();
            var medBiz = new MedicalRecordBusiness();
            var visitBiz = new VisitBusiness();

            // Create dynamically generated panels for each entity using our Generic CrudPanel
            AddNavigationButton("Prisoners", new CrudPanel<Prisoner>("Manage Prisoners",
                prisonerBiz.GetAll, prisonerBiz.Add, prisonerBiz.Update, prisonerBiz.Delete, p => p.PrisonerId));

            AddNavigationButton("Cells", new CrudPanel<Cell>("Manage Cells",
                cellBiz.GetAll, cellBiz.Add, cellBiz.Update, cellBiz.Delete, c => c.CellId));

            AddNavigationButton("Prison Blocks", new CrudPanel<PrisonBlock>("Manage Prison Blocks",
                blockBiz.GetAll, blockBiz.Add, blockBiz.Update, blockBiz.Delete, b => b.PrisonBlockId));

            AddNavigationButton("Guards", new CrudPanel<Guard>("Manage Guards",
                guardBiz.GetAll, guardBiz.Add, guardBiz.Update, guardBiz.Delete, g => g.GuardId));

            AddNavigationButton("Shifts", new CrudPanel<Shift>("Manage Shifts",
                shiftBiz.GetAll, shiftBiz.Add, shiftBiz.Update, shiftBiz.Delete, s => s.ShiftId));

            AddNavigationButton("Crimes", new CrudPanel<Crime>("Manage Crimes",
                crimeBiz.GetAll, crimeBiz.Add, crimeBiz.Update, crimeBiz.Delete, c => c.CrimeId));

            AddNavigationButton("Punishments", new CrudPanel<Punishment>("Manage Punishments",
                punishBiz.GetAll, punishBiz.Add, punishBiz.Update, punishBiz.Delete, p => p.PunishmentId));

            AddNavigationButton("Medical Records", new CrudPanel<MedicalRecord>("Manage Medical Records",
                medBiz.GetAll, medBiz.Add, medBiz.Update, medBiz.Delete, m => m.RecordId));

            AddNavigationButton("Visits", new CrudPanel<Visit>("Manage Visits",
                visitBiz.GetAll, visitBiz.Add, visitBiz.Update, visitBiz.Delete, v => v.VisitId));
        }

        private void AddNavigationButton(string title, UserControl targetPanel)
        {
            Button btn = new Button
            {
                Text = title,
                Dock = DockStyle.Top,
                Height = 50,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0),
                Cursor = Cursors.Hand
            };

            btn.Click += (s, e) =>
            {
                contentPanel.Controls.Clear();
                targetPanel.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(targetPanel);
            };

            // Add below the logo (Docking pushes newer items down, so we bring to front)
            sidebarPanel.Controls.Add(btn);
            btn.BringToFront();
        }
    }

    /// <summary>
    /// A generic panel that creates a DataGridView and PropertyGrid 
    /// dynamically based on the specific Class properties.
    /// </summary>
    public class CrudPanel<T> : UserControl where T : class, new()
    {
        private Func<List<T>> _getAll;
        private Action<T> _add;
        private Action<T> _update;
        private Action<int> _delete;
        private Func<T, int> _getId;

        private DataGridView grid;
        private PropertyGrid propertyGrid;

        public CrudPanel(string title, Func<List<T>> getAll, Action<T> add, Action<T> update, Action<int> delete, Func<T, int> getId)
        {
            _getAll = getAll;
            _add = add;
            _update = update;
            _delete = delete;
            _getId = getId;

            InitializeLayout(title);
            RefreshData();
        }

        private void InitializeLayout(string title)
        {
            // Title Bar
            Label lblTitle = new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 18F, FontStyle.Regular),
                Height = 50,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0),
                BackColor = Color.White
            };
            this.Controls.Add(lblTitle);

            // Split Container
            SplitContainer split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 600, // 600px for Grid, rest for Edit panel
                BackColor = Color.LightGray
            };

            // Grid View (Read list)
            grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None
            };
            grid.SelectionChanged += Grid_SelectionChanged;

            // Edit Panel
            Panel editPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };

            propertyGrid = new PropertyGrid
            {
                Dock = DockStyle.Fill,
                ToolbarVisible = false,
                PropertySort = PropertySort.NoSort
            };

            // Toolbar
            Panel toolBar = new Panel { Dock = DockStyle.Bottom, Height = 50, Padding = new Padding(10) };
            Button btnNew = new Button { Text = "New Record", Dock = DockStyle.Left, Width = 120 };
            Button btnSave = new Button { Text = "Save Changes", Dock = DockStyle.Left, Width = 120 };
            Button btnDelete = new Button { Text = "Delete Record", Dock = DockStyle.Right, Width = 120, BackColor = Color.Salmon };

            btnNew.Click += BtnNew_Click;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

            toolBar.Controls.Add(btnSave);
            toolBar.Controls.Add(btnNew);
            toolBar.Controls.Add(btnDelete);

            editPanel.Controls.Add(propertyGrid);
            editPanel.Controls.Add(toolBar);

            split.Panel1.Controls.Add(grid);
            split.Panel2.Controls.Add(editPanel);

            this.Controls.Add(split);
        }

        private void RefreshData()
        {
            try
            {
                grid.DataSource = null; // Reset binding
                grid.DataSource = _getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                propertyGrid.SelectedObject = grid.SelectedRows[0].DataBoundItem;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // Clear selection and prep a brand new object in the editor
            grid.ClearSelection();
            propertyGrid.SelectedObject = new T();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (propertyGrid.SelectedObject is T item)
            {
                try
                {
                    int id = _getId(item);
                    if (id == 0)
                        _add(item);     // Id is 0, so it's a new record
                    else
                        _update(item);  // Exists, update it

                    MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data. Ensure input formats (like FK constraints) are correct.\n\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (propertyGrid.SelectedObject is T item)
            {
                var id = _getId(item);
                if (id == 0) return; // Unsaved new record

                var result = MessageBox.Show($"Are you sure you want to delete this record (ID: {id})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _delete(id);
                        RefreshData();
                        propertyGrid.SelectedObject = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Could not delete record. It may be linked to other records.\n\nDetails: {ex.Message}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}