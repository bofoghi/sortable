namespace sortableChallenge
{
    partial class frmMain
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
            this.btnOpenProductFile = new System.Windows.Forms.Button();
            this.btnOpenListingFile = new System.Windows.Forms.Button();
            this.txtProductFile = new System.Windows.Forms.TextBox();
            this.txtListingFile = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.nudMinSimScore = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSimScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenProductFile
            // 
            this.btnOpenProductFile.Location = new System.Drawing.Point(410, 52);
            this.btnOpenProductFile.Name = "btnOpenProductFile";
            this.btnOpenProductFile.Size = new System.Drawing.Size(106, 23);
            this.btnOpenProductFile.TabIndex = 0;
            this.btnOpenProductFile.Text = "Open &Product File";
            this.btnOpenProductFile.UseVisualStyleBackColor = true;
            this.btnOpenProductFile.Click += new System.EventHandler(this.btnOpenProductFile_Click);
            // 
            // btnOpenListingFile
            // 
            this.btnOpenListingFile.Location = new System.Drawing.Point(410, 112);
            this.btnOpenListingFile.Name = "btnOpenListingFile";
            this.btnOpenListingFile.Size = new System.Drawing.Size(106, 23);
            this.btnOpenListingFile.TabIndex = 1;
            this.btnOpenListingFile.Text = "Open &Listing File";
            this.btnOpenListingFile.UseVisualStyleBackColor = true;
            this.btnOpenListingFile.Click += new System.EventHandler(this.btnOpenListingFile_Click);
            // 
            // txtProductFile
            // 
            this.txtProductFile.Location = new System.Drawing.Point(17, 28);
            this.txtProductFile.Name = "txtProductFile";
            this.txtProductFile.Size = new System.Drawing.Size(499, 20);
            this.txtProductFile.TabIndex = 2;
            // 
            // txtListingFile
            // 
            this.txtListingFile.Location = new System.Drawing.Point(17, 87);
            this.txtListingFile.Name = "txtListingFile";
            this.txtListingFile.Size = new System.Drawing.Size(499, 20);
            this.txtListingFile.TabIndex = 3;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(17, 194);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "&Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.Black;
            this.rtbConsole.ForeColor = System.Drawing.Color.White;
            this.rtbConsole.Location = new System.Drawing.Point(98, 144);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(418, 98);
            this.rtbConsole.TabIndex = 6;
            this.rtbConsole.Text = "";
            // 
            // nudMinSimScore
            // 
            this.nudMinSimScore.DecimalPlaces = 2;
            this.nudMinSimScore.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudMinSimScore.Location = new System.Drawing.Point(208, 121);
            this.nudMinSimScore.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinSimScore.Name = "nudMinSimScore";
            this.nudMinSimScore.ReadOnly = true;
            this.nudMinSimScore.Size = new System.Drawing.Size(56, 20);
            this.nudMinSimScore.TabIndex = 7;
            this.nudMinSimScore.ThousandsSeparator = true;
            this.nudMinSimScore.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "min similarity threshold:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinSimScore);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.txtListingFile);
            this.Controls.Add(this.txtProductFile);
            this.Controls.Add(this.btnOpenListingFile);
            this.Controls.Add(this.btnOpenProductFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submission for: Sortable Challenge, by: Brad OFOGHI  (br_ofoghi@yahoo.com)";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSimScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProductFile;
        private System.Windows.Forms.Button btnOpenListingFile;
        private System.Windows.Forms.TextBox txtProductFile;
        private System.Windows.Forms.TextBox txtListingFile;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.NumericUpDown nudMinSimScore;
        private System.Windows.Forms.Label label1;
    }
}

