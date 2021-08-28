
namespace FindDuplicatedFiles
{
    partial class MainForm
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
            this.selectFirstFolderBtn = new System.Windows.Forms.Button();
            this.selectSecondFolderBtn = new System.Windows.Forms.Button();
            this.firstFolderPathTB = new System.Windows.Forms.TextBox();
            this.secondFolderPathTB = new System.Windows.Forms.TextBox();
            this.logTB = new System.Windows.Forms.TextBox();
            this.firstFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.secondFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // selectFirstFolderBtn
            // 
            this.selectFirstFolderBtn.Location = new System.Drawing.Point(468, 12);
            this.selectFirstFolderBtn.Name = "selectFirstFolderBtn";
            this.selectFirstFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFirstFolderBtn.TabIndex = 0;
            this.selectFirstFolderBtn.Text = "Browse";
            this.selectFirstFolderBtn.UseVisualStyleBackColor = true;
            this.selectFirstFolderBtn.Click += new System.EventHandler(this.SelectFirstFolderBtn_Click);
            // 
            // selectSecondFolderBtn
            // 
            this.selectSecondFolderBtn.Location = new System.Drawing.Point(468, 53);
            this.selectSecondFolderBtn.Name = "selectSecondFolderBtn";
            this.selectSecondFolderBtn.Size = new System.Drawing.Size(75, 22);
            this.selectSecondFolderBtn.TabIndex = 1;
            this.selectSecondFolderBtn.Text = "Browse";
            this.selectSecondFolderBtn.UseVisualStyleBackColor = true;
            this.selectSecondFolderBtn.Click += new System.EventHandler(this.SelectSecondFolderBtn_Click);
            // 
            // firstFolderPathTB
            // 
            this.firstFolderPathTB.Location = new System.Drawing.Point(12, 12);
            this.firstFolderPathTB.Name = "firstFolderPathTB";
            this.firstFolderPathTB.ReadOnly = true;
            this.firstFolderPathTB.Size = new System.Drawing.Size(439, 23);
            this.firstFolderPathTB.TabIndex = 2;
            this.firstFolderPathTB.Text = "Select folder";
            // 
            // secondFolderPathTB
            // 
            this.secondFolderPathTB.Location = new System.Drawing.Point(12, 52);
            this.secondFolderPathTB.Name = "secondFolderPathTB";
            this.secondFolderPathTB.ReadOnly = true;
            this.secondFolderPathTB.Size = new System.Drawing.Size(439, 23);
            this.secondFolderPathTB.TabIndex = 3;
            this.secondFolderPathTB.Text = "Select folder";
            // 
            // logTB
            // 
            this.logTB.Location = new System.Drawing.Point(12, 95);
            this.logTB.Multiline = true;
            this.logTB.Name = "logTB";
            this.logTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTB.Size = new System.Drawing.Size(531, 222);
            this.logTB.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 329);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.secondFolderPathTB);
            this.Controls.Add(this.firstFolderPathTB);
            this.Controls.Add(this.selectSecondFolderBtn);
            this.Controls.Add(this.selectFirstFolderBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Duplicated Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFirstFolderBtn;
        private System.Windows.Forms.Button selectSecondFolderBtn;
        private System.Windows.Forms.TextBox firstFolderPathTB;
        private System.Windows.Forms.TextBox secondFolderPathTB;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.FolderBrowserDialog firstFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog secondFolderBrowser;
    }
}

