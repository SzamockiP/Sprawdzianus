namespace Sprawdzianus.Forms
{
    partial class FormTests
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
            this.tableContent = new System.Windows.Forms.TableLayoutPanel();
            this.listViewTests = new System.Windows.Forms.ListView();
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClassroom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableAddTest = new System.Windows.Forms.TableLayoutPanel();
            this.labelDateTitle = new System.Windows.Forms.Label();
            this.labelSubjectTitle = new System.Windows.Forms.Label();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddEditTest = new System.Windows.Forms.Button();
            this.labelIDTitle = new System.Windows.Forms.Label();
            this.numericUpDownClassroom = new System.Windows.Forms.NumericUpDown();
            this.labelStatusTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.tableContent.SuspendLayout();
            this.tableAddTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassroom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableContent
            // 
            this.tableContent.ColumnCount = 2;
            this.tableContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableContent.Controls.Add(this.listViewTests, 0, 0);
            this.tableContent.Controls.Add(this.tableAddTest, 1, 0);
            this.tableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContent.Location = new System.Drawing.Point(0, 0);
            this.tableContent.Name = "tableContent";
            this.tableContent.RowCount = 1;
            this.tableContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContent.Size = new System.Drawing.Size(800, 450);
            this.tableContent.TabIndex = 2;
            // 
            // listViewTests
            // 
            this.listViewTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnDate,
            this.columnClassroom,
            this.columnState});
            this.listViewTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTests.FullRowSelect = true;
            this.listViewTests.GridLines = true;
            this.listViewTests.HideSelection = false;
            this.listViewTests.Location = new System.Drawing.Point(10, 10);
            this.listViewTests.Margin = new System.Windows.Forms.Padding(10);
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(356, 430);
            this.listViewTests.TabIndex = 0;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            this.listViewTests.View = System.Windows.Forms.View.Details;
            this.listViewTests.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTests_MouseDoubleClick);
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Przedmiot";
            this.columnSubject.Width = 95;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Data";
            this.columnDate.Width = 138;
            // 
            // columnClassroom
            // 
            this.columnClassroom.Text = "Sala";
            this.columnClassroom.Width = 47;
            // 
            // columnState
            // 
            this.columnState.Text = "Status";
            this.columnState.Width = 71;
            // 
            // tableAddTest
            // 
            this.tableAddTest.ColumnCount = 2;
            this.tableAddTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.06977F));
            this.tableAddTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.93023F));
            this.tableAddTest.Controls.Add(this.labelDateTitle, 0, 1);
            this.tableAddTest.Controls.Add(this.labelSubjectTitle, 0, 0);
            this.tableAddTest.Controls.Add(this.listBoxSubjects, 1, 0);
            this.tableAddTest.Controls.Add(this.maskedTextBoxDate, 1, 1);
            this.tableAddTest.Controls.Add(this.buttonAddEditTest, 1, 4);
            this.tableAddTest.Controls.Add(this.labelIDTitle, 0, 2);
            this.tableAddTest.Controls.Add(this.numericUpDownClassroom, 1, 2);
            this.tableAddTest.Controls.Add(this.labelStatusTitle, 0, 3);
            this.tableAddTest.Controls.Add(this.panel1, 1, 3);
            this.tableAddTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAddTest.Location = new System.Drawing.Point(406, 10);
            this.tableAddTest.Margin = new System.Windows.Forms.Padding(30, 10, 50, 10);
            this.tableAddTest.Name = "tableAddTest";
            this.tableAddTest.RowCount = 5;
            this.tableAddTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableAddTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableAddTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableAddTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableAddTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableAddTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableAddTest.Size = new System.Drawing.Size(344, 430);
            this.tableAddTest.TabIndex = 1;
            // 
            // labelDateTitle
            // 
            this.labelDateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDateTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDateTitle.Location = new System.Drawing.Point(0, 184);
            this.labelDateTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelDateTitle.Name = "labelDateTitle";
            this.labelDateTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelDateTitle.Size = new System.Drawing.Size(100, 61);
            this.labelDateTitle.TabIndex = 6;
            this.labelDateTitle.Text = "Termin";
            this.labelDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSubjectTitle
            // 
            this.labelSubjectTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSubjectTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSubjectTitle.Location = new System.Drawing.Point(0, 0);
            this.labelSubjectTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelSubjectTitle.Name = "labelSubjectTitle";
            this.labelSubjectTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelSubjectTitle.Size = new System.Drawing.Size(100, 184);
            this.labelSubjectTitle.TabIndex = 5;
            this.labelSubjectTitle.Text = "Przedmiot";
            this.labelSubjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.Items.AddRange(new object[] {
            "Angielski",
            "Matematyka",
            "Polski",
            "Geografia",
            "Biologia",
            "Fizyka",
            "PAD\t",
            "BSK"});
            this.listBoxSubjects.Location = new System.Drawing.Point(100, 10);
            this.listBoxSubjects.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(224, 164);
            this.listBoxSubjects.TabIndex = 12;
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDate.Culture = new System.Globalization.CultureInfo("en-US");
            this.maskedTextBoxDate.Location = new System.Drawing.Point(100, 204);
            this.maskedTextBoxDate.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.maskedTextBoxDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(224, 20);
            this.maskedTextBoxDate.TabIndex = 13;
            // 
            // buttonAddEditTest
            // 
            this.buttonAddEditTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddEditTest.FlatAppearance.BorderSize = 0;
            this.buttonAddEditTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEditTest.Location = new System.Drawing.Point(140, 387);
            this.buttonAddEditTest.Margin = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.buttonAddEditTest.Name = "buttonAddEditTest";
            this.buttonAddEditTest.Size = new System.Drawing.Size(164, 23);
            this.buttonAddEditTest.TabIndex = 17;
            this.buttonAddEditTest.Text = "Dodaj / Edytuj";
            this.buttonAddEditTest.UseVisualStyleBackColor = true;
            this.buttonAddEditTest.Click += new System.EventHandler(this.buttonAddEditTest_Click);
            // 
            // labelIDTitle
            // 
            this.labelIDTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIDTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIDTitle.Location = new System.Drawing.Point(0, 245);
            this.labelIDTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelIDTitle.Name = "labelIDTitle";
            this.labelIDTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelIDTitle.Size = new System.Drawing.Size(100, 61);
            this.labelIDTitle.TabIndex = 10;
            this.labelIDTitle.Text = "Sala";
            this.labelIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownClassroom
            // 
            this.numericUpDownClassroom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownClassroom.Location = new System.Drawing.Point(100, 265);
            this.numericUpDownClassroom.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.numericUpDownClassroom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownClassroom.Name = "numericUpDownClassroom";
            this.numericUpDownClassroom.Size = new System.Drawing.Size(224, 20);
            this.numericUpDownClassroom.TabIndex = 11;
            // 
            // labelStatusTitle
            // 
            this.labelStatusTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStatusTitle.Location = new System.Drawing.Point(0, 306);
            this.labelStatusTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatusTitle.Name = "labelStatusTitle";
            this.labelStatusTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelStatusTitle.Size = new System.Drawing.Size(100, 61);
            this.labelStatusTitle.TabIndex = 15;
            this.labelStatusTitle.Text = "Status";
            this.labelStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 55);
            this.panel1.TabIndex = 16;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.checkBoxStatus.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Padding = new System.Windows.Forms.Padding(10);
            this.checkBoxStatus.Size = new System.Drawing.Size(238, 55);
            this.checkBoxStatus.TabIndex = 0;
            this.checkBoxStatus.Text = "Zaliczony?";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // FormTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableContent);
            this.Name = "FormTests";
            this.Text = "Sprawdziany";
            this.tableContent.ResumeLayout(false);
            this.tableAddTest.ResumeLayout(false);
            this.tableAddTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassroom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableContent;
        private System.Windows.Forms.ListView listViewTests;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnClassroom;
        private System.Windows.Forms.ColumnHeader columnState;
        private System.Windows.Forms.TableLayoutPanel tableAddTest;
        private System.Windows.Forms.Label labelIDTitle;
        private System.Windows.Forms.Label labelDateTitle;
        private System.Windows.Forms.Label labelSubjectTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownClassroom;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.Label labelStatusTitle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Button buttonAddEditTest;
    }
}