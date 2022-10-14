namespace Sprawdzianus
{
    public partial class FormSprawdzianus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSprawdzianus));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonTests = new System.Windows.Forms.Button();
            this.buttonTimetable = new System.Windows.Forms.Button();
            this.labelSectionTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSprawdzianus_FormClosing);
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Controls.Add(this.buttonSettings);
            this.panelNavigation.Controls.Add(this.buttonSubjects);
            this.panelNavigation.Controls.Add(this.buttonTests);
            this.panelNavigation.Controls.Add(this.buttonTimetable);
            this.panelNavigation.Location = new System.Drawing.Point(813, 80);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panelNavigation.Size = new System.Drawing.Size(200, 472);
            this.panelNavigation.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonClose.Location = new System.Drawing.Point(0, 402);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonClose.Size = new System.Drawing.Size(200, 70);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSettings.Location = new System.Drawing.Point(0, 240);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(200, 70);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubjects.FlatAppearance.BorderSize = 0;
            this.buttonSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSubjects.Location = new System.Drawing.Point(0, 170);
            this.buttonSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSubjects.Size = new System.Drawing.Size(200, 70);
            this.buttonSubjects.TabIndex = 2;
            this.buttonSubjects.Text = "Przedmioty";
            this.buttonSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonTests
            // 
            this.buttonTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTests.FlatAppearance.BorderSize = 0;
            this.buttonTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonTests.Location = new System.Drawing.Point(0, 100);
            this.buttonTests.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTests.Size = new System.Drawing.Size(200, 70);
            this.buttonTests.TabIndex = 1;
            this.buttonTests.Text = "Sprawdziany";
            this.buttonTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTests.UseVisualStyleBackColor = true;
            this.buttonTests.Click += new System.EventHandler(this.buttonTests_Click);
            // 
            // buttonTimetable
            // 
            this.buttonTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimetable.FlatAppearance.BorderSize = 0;
            this.buttonTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonTimetable.Location = new System.Drawing.Point(0, 30);
            this.buttonTimetable.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTimetable.Name = "buttonTimetable";
            this.buttonTimetable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTimetable.Size = new System.Drawing.Size(200, 70);
            this.buttonTimetable.TabIndex = 0;
            this.buttonTimetable.Text = "Terminarz";
            this.buttonTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTimetable.UseVisualStyleBackColor = true;
            this.buttonTimetable.Click += new System.EventHandler(this.buttonTimetable_Click);
            // 
            // labelSectionTitle
            // 
            this.labelSectionTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelSectionTitle.Location = new System.Drawing.Point(0, 0);
            this.labelSectionTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelSectionTitle.Name = "labelSectionTitle";
            this.labelSectionTitle.Size = new System.Drawing.Size(813, 80);
            this.labelSectionTitle.TabIndex = 1;
            this.labelSectionTitle.Text = "Menu";
            this.labelSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pLogo);
            this.panelDesktop.Location = new System.Drawing.Point(0, 80);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(813, 472);
            this.panelDesktop.TabIndex = 2;
            // 
            // pLogo
            // 
            this.pLogo.Image = global::Sprawdzianus.Properties.Resources.logo;
            this.pLogo.Location = new System.Drawing.Point(297, 111);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(201, 189);
            this.pLogo.TabIndex = 0;
            this.pLogo.TabStop = false;
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.Size = new System.Drawing.Size(80, 80);
            this.buttonCloseChildForm.TabIndex = 0;
            this.buttonCloseChildForm.Text = "X";
            this.buttonCloseChildForm.UseVisualStyleBackColor = true;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.labelAppTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelNavigation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDesktop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTitleBar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 552);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.Location = new System.Drawing.Point(813, 0);
            this.labelAppTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(200, 80);
            this.labelAppTitle.TabIndex = 8;
            this.labelAppTitle.Text = "Sprawdzianus";
            this.labelAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.buttonCloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelSectionTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(813, 80);
            this.panelTitleBar.TabIndex = 9;
            // 
            // FormSprawdzianus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSprawdzianus";
            this.Text = "Sprawdzianus";
            this.panelNavigation.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonTimetable;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonTests;
        private System.Windows.Forms.Label labelSectionTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.PictureBox pLogo;
    }
}

