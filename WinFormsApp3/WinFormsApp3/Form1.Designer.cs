namespace Cells
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            userControl11 = new Cells();
            CELLS = new Button();
            button2 = new Button();
            userControl21 = new Crimes();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            guardsdb1 = new GuardsDB();
            medicalRecords1 = new MedicalRecords();
            prisonBlock1 = new PrisonBlock();
            prisoners1 = new Prisoners();
            punishment1 = new Punishment();
            shift1 = new Shift();
            visits1 = new Visits();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userControl11.BackColor = SystemColors.ControlDark;
            userControl11.Location = new Point(130, -2);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(661, 452);
            userControl11.TabIndex = 0;
            // 
            // CELLS
            // 
            CELLS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CELLS.Location = new Point(0, 0);
            CELLS.Name = "CELLS";
            CELLS.Size = new Size(130, 50);
            CELLS.TabIndex = 1;
            CELLS.Text = "CELLS";
            CELLS.UseVisualStyleBackColor = true;
            CELLS.Click += this.button1_Click;
            CELLS.MouseMove += this.CELLS_MouseMove;
            // 
            // button2
            // 
            button2.Location = new Point(0, 50);
            button2.Name = "button2";
            button2.Size = new Size(130, 50);
            button2.TabIndex = 2;
            button2.Text = "CRIME";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            button2.MouseMove += this.CELLS_MouseMove;
            // 
            // userControl21
            // 
            userControl21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userControl21.BackColor = SystemColors.ActiveCaption;
            userControl21.Location = new Point(130, 4);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(661, 446);
            userControl21.TabIndex = 3;
            userControl21.Load += this.userControl21_Load;
            // 
            // button3
            // 
            button3.Location = new Point(0, 100);
            button3.Name = "button3";
            button3.Size = new Size(130, 50);
            button3.TabIndex = 4;
            button3.Text = "GUARD";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            button3.MouseMove += this.CELLS_MouseMove;
            // 
            // button4
            // 
            button4.Location = new Point(0, 150);
            button4.Name = "button4";
            button4.Size = new Size(130, 50);
            button4.TabIndex = 5;
            button4.Text = "MEDICAL RECORD";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            button4.MouseMove += this.CELLS_MouseMove;
            // 
            // button5
            // 
            button5.Location = new Point(0, 200);
            button5.Name = "button5";
            button5.Size = new Size(130, 50);
            button5.TabIndex = 6;
            button5.Text = "PRISON BLOCK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += this.button5_Click;
            button5.MouseMove += this.CELLS_MouseMove;
            // 
            // button6
            // 
            button6.Location = new Point(0, 250);
            button6.Name = "button6";
            button6.Size = new Size(130, 50);
            button6.TabIndex = 7;
            button6.Text = "PRISONER";
            button6.UseVisualStyleBackColor = true;
            button6.Click += this.button6_Click;
            button6.MouseMove += this.CELLS_MouseMove;
            // 
            // button7
            // 
            button7.Location = new Point(0, 300);
            button7.Name = "button7";
            button7.Size = new Size(130, 50);
            button7.TabIndex = 8;
            button7.Text = "PUNISHMENT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += this.button7_Click;
            button7.MouseMove += this.CELLS_MouseMove;
            // 
            // button8
            // 
            button8.Location = new Point(0, 350);
            button8.Name = "button8";
            button8.Size = new Size(130, 50);
            button8.TabIndex = 9;
            button8.Text = "SHIFTS";
            button8.UseVisualStyleBackColor = true;
            button8.Click += this.button8_Click;
            button8.MouseMove += this.CELLS_MouseMove;
            // 
            // button9
            // 
            button9.Location = new Point(0, 400);
            button9.Name = "button9";
            button9.Size = new Size(130, 50);
            button9.TabIndex = 10;
            button9.Text = "VISITS";
            button9.UseVisualStyleBackColor = true;
            button9.Click += this.button9_Click;
            button9.MouseMove += this.CELLS_MouseMove;
            // 
            // guardsdb1
            // 
            guardsdb1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guardsdb1.Location = new Point(136, -2);
            guardsdb1.Name = "guardsdb1";
            guardsdb1.Size = new Size(650, 452);
            guardsdb1.TabIndex = 11;
            guardsdb1.Load += this.guardsdb1_Load;
            // 
            // medicalRecords1
            // 
            medicalRecords1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            medicalRecords1.Location = new Point(130, -2);
            medicalRecords1.Name = "medicalRecords1";
            medicalRecords1.Size = new Size(661, 452);
            medicalRecords1.TabIndex = 12;
            // 
            // prisonBlock1
            // 
            prisonBlock1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prisonBlock1.Location = new Point(130, 0);
            prisonBlock1.Name = "prisonBlock1";
            prisonBlock1.Size = new Size(661, 452);
            prisonBlock1.TabIndex = 13;
            // 
            // prisoners1
            // 
            prisoners1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prisoners1.Location = new Point(130, -2);
            prisoners1.Name = "prisoners1";
            prisoners1.Size = new Size(661, 452);
            prisoners1.TabIndex = 14;
            // 
            // punishment1
            // 
            punishment1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            punishment1.Location = new Point(130, -2);
            punishment1.Name = "punishment1";
            punishment1.Size = new Size(656, 452);
            punishment1.TabIndex = 15;
            // 
            // shift1
            // 
            shift1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shift1.BackgroundImageLayout = ImageLayout.None;
            shift1.Location = new Point(125, -2);
            shift1.Name = "shift1";
            shift1.Size = new Size(661, 452);
            shift1.TabIndex = 16;
            shift1.Load += this.shift1_Load;
            // 
            // visits1
            // 
            visits1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            visits1.Location = new Point(136, 0);
            visits1.Name = "visits1";
            visits1.Size = new Size(655, 452);
            visits1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(146, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 451);
            Controls.Add(pictureBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(CELLS);
            Controls.Add(shift1);
            Controls.Add(punishment1);
            Controls.Add(prisoners1);
            Controls.Add(prisonBlock1);
            Controls.Add(guardsdb1);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(medicalRecords1);
            Controls.Add(visits1);
            Name = "Form1";
            Text = "CatrazAl";
            Load += this.Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Cells userControl11;
        private Button CELLS;
        private Button button2;
        public Crimes userControl21;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private GuardsDB guardsdb1;
        private MedicalRecords medicalRecords1;
        private PrisonBlock prisonBlock1;
        private Prisoners prisoners1;
        private Punishment punishment1;
        private Shift shift1;
        private Visits visits1;
        private PictureBox pictureBox1;
    }
}
