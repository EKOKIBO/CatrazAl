namespace Cells
{
    partial class FILETR
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkedListBox1 = new CheckedListBox();
            CONFIRM = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "ID", "AGE", "FIRST", "SECOND", "LAST", "DATE", "MONEY", "HAPPYNESS", "SADNESS" });
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(288, 184);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // CONFIRM
            // 
            CONFIRM.Location = new Point(93, 220);
            CONFIRM.Name = "CONFIRM";
            CONFIRM.Size = new Size(110, 47);
            CONFIRM.TabIndex = 1;
            CONFIRM.Text = "CONFIRM";
            CONFIRM.UseVisualStyleBackColor = true;
            CONFIRM.Click += CONFIRM_Click;
            // 
            // FILETR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 293);
            Controls.Add(CONFIRM);
            Controls.Add(checkedListBox1);
            Name = "FILETR";
            Text = "FILETR";
            FormClosed += FILETR_FormClosed;
            Load += FILETR_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button CONFIRM;
    }
}