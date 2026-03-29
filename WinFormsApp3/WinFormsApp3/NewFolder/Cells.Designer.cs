namespace Cells
{
    partial class Cells
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            incert = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.Layout += dataGridView1_Layout;
            // 
            // button1
            // 
            button1.Location = new Point(3, 343);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 1;
            button1.Text = "FILLTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // incert
            // 
            incert.Location = new Point(137, 343);
            incert.Name = "incert";
            incert.Size = new Size(108, 54);
            incert.TabIndex = 3;
            incert.Text = "ADD";
            incert.UseVisualStyleBackColor = true;
            incert.Click += incert_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 343);
            button2.Name = "button2";
            button2.Size = new Size(121, 54);
            button2.TabIndex = 4;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            // 
            // Cells
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(incert);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Cells";
            Size = new Size(600, 400);
            Load += Cells_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button incert;
        private Button button2;
    }
}
