namespace ARMOtt
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchDirectory = new System.Windows.Forms.TextBox();
            this.tbNameMask = new System.Windows.Forms.TextBox();
            this.tbContentMask = new System.Windows.Forms.TextBox();
            this.tvResultTree = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFileOnCheck = new System.Windows.Forms.TextBox();
            this.tbScannedFiles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory for search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(316, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Content mask";
            // 
            // tbSearchDirectory
            // 
            this.tbSearchDirectory.Location = new System.Drawing.Point(15, 25);
            this.tbSearchDirectory.Name = "tbSearchDirectory";
            this.tbSearchDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbSearchDirectory.Size = new System.Drawing.Size(295, 20);
            this.tbSearchDirectory.TabIndex = 5;
            // 
            // tbNameMask
            // 
            this.tbNameMask.Location = new System.Drawing.Point(15, 64);
            this.tbNameMask.Name = "tbNameMask";
            this.tbNameMask.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNameMask.Size = new System.Drawing.Size(376, 20);
            this.tbNameMask.TabIndex = 6;
            // 
            // tbContentMask
            // 
            this.tbContentMask.Location = new System.Drawing.Point(15, 103);
            this.tbContentMask.Name = "tbContentMask";
            this.tbContentMask.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbContentMask.Size = new System.Drawing.Size(376, 20);
            this.tbContentMask.TabIndex = 7;
            // 
            // tvResultTree
            // 
            this.tvResultTree.Location = new System.Drawing.Point(15, 220);
            this.tvResultTree.Name = "tvResultTree";
            this.tvResultTree.Size = new System.Drawing.Size(376, 218);
            this.tvResultTree.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current file on check";
            // 
            // tbFileOnCheck
            // 
            this.tbFileOnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tbFileOnCheck.Location = new System.Drawing.Point(15, 181);
            this.tbFileOnCheck.Name = "tbFileOnCheck";
            this.tbFileOnCheck.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbFileOnCheck.Size = new System.Drawing.Size(376, 20);
            this.tbFileOnCheck.TabIndex = 10;
            // 
            // tbScannedFiles
            // 
            this.tbScannedFiles.Location = new System.Drawing.Point(191, 142);
            this.tbScannedFiles.Name = "tbScannedFiles";
            this.tbScannedFiles.Size = new System.Drawing.Size(119, 20);
            this.tbScannedFiles.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Count of scanned files";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Search time";
            // 
            // tbSearchTime
            // 
            this.tbSearchTime.Location = new System.Drawing.Point(326, 142);
            this.tbSearchTime.Name = "tbSearchTime";
            this.tbSearchTime.Size = new System.Drawing.Size(65, 20);
            this.tbSearchTime.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Found files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSearchTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbScannedFiles);
            this.Controls.Add(this.tbFileOnCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tvResultTree);
            this.Controls.Add(this.tbContentMask);
            this.Controls.Add(this.tbNameMask);
            this.Controls.Add(this.tbSearchDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARMO test task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearchDirectory;
        private System.Windows.Forms.TextBox tbNameMask;
        private System.Windows.Forms.TextBox tbContentMask;
        private System.Windows.Forms.TreeView tvResultTree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileOnCheck;
        private System.Windows.Forms.TextBox tbScannedFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearchTime;
        private System.Windows.Forms.Label label8;
    }
}

