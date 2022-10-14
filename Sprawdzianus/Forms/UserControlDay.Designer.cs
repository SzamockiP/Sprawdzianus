namespace Sprawdzianus.Forms
{
    partial class UserControlDay
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
            this.labelDay = new System.Windows.Forms.Label();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(5, 5);
            this.labelDay.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(34, 13);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Dzien";
            // 
            // listBoxTests
            // 
            this.listBoxTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(5, 21);
            this.listBoxTests.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(86, 39);
            this.listBoxTests.TabIndex = 1;
            this.listBoxTests.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTests_MouseDoubleClick);
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxTests);
            this.Controls.Add(this.labelDay);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(104, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.ListBox listBoxTests;
    }
}
