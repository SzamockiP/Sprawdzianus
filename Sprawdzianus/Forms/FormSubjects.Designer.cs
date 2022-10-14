namespace Sprawdzianus.Forms
{
    partial class FormSubjects
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
            this.listViewSubjects = new System.Windows.Forms.ListView();
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableContent = new System.Windows.Forms.TableLayoutPanel();
            this.tableAddSubject = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurnameTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonAddEditSubject = new System.Windows.Forms.Button();
            this.labelSubjectTitle = new System.Windows.Forms.Label();
            this.tableContent.SuspendLayout();
            this.tableAddSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSubjects
            // 
            this.listViewSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnSurname,
            this.columnName});
            this.listViewSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSubjects.FullRowSelect = true;
            this.listViewSubjects.GridLines = true;
            this.listViewSubjects.HideSelection = false;
            this.listViewSubjects.Location = new System.Drawing.Point(10, 10);
            this.listViewSubjects.Margin = new System.Windows.Forms.Padding(10);
            this.listViewSubjects.Name = "listViewSubjects";
            this.listViewSubjects.Size = new System.Drawing.Size(345, 430);
            this.listViewSubjects.TabIndex = 0;
            this.listViewSubjects.UseCompatibleStateImageBehavior = false;
            this.listViewSubjects.View = System.Windows.Forms.View.Details;
            this.listViewSubjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSubjects_MouseDoubleClick);
            // 
            // columnSubject
            // 
            this.columnSubject.Text = "Przedmiot";
            this.columnSubject.Width = 93;
            // 
            // columnSurname
            // 
            this.columnSurname.DisplayIndex = 2;
            this.columnSurname.Text = "Nazwisko";
            this.columnSurname.Width = 103;
            // 
            // columnName
            // 
            this.columnName.DisplayIndex = 1;
            this.columnName.Text = "Imie";
            this.columnName.Width = 102;
            // 
            // tableContent
            // 
            this.tableContent.ColumnCount = 2;
            this.tableContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.625F));
            this.tableContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.375F));
            this.tableContent.Controls.Add(this.listViewSubjects, 0, 0);
            this.tableContent.Controls.Add(this.tableAddSubject, 1, 0);
            this.tableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContent.Location = new System.Drawing.Point(0, 0);
            this.tableContent.Name = "tableContent";
            this.tableContent.RowCount = 1;
            this.tableContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContent.Size = new System.Drawing.Size(800, 450);
            this.tableContent.TabIndex = 1;
            // 
            // tableAddSubject
            // 
            this.tableAddSubject.ColumnCount = 2;
            this.tableAddSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.06977F));
            this.tableAddSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.93023F));
            this.tableAddSubject.Controls.Add(this.textBoxSurname, 1, 2);
            this.tableAddSubject.Controls.Add(this.labelSurnameTitle, 0, 2);
            this.tableAddSubject.Controls.Add(this.textBoxName, 1, 1);
            this.tableAddSubject.Controls.Add(this.labelNameTitle, 0, 1);
            this.tableAddSubject.Controls.Add(this.textBoxSubject, 1, 0);
            this.tableAddSubject.Controls.Add(this.buttonAddEditSubject, 1, 4);
            this.tableAddSubject.Controls.Add(this.labelSubjectTitle, 0, 0);
            this.tableAddSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAddSubject.Location = new System.Drawing.Point(395, 10);
            this.tableAddSubject.Margin = new System.Windows.Forms.Padding(30, 10, 50, 10);
            this.tableAddSubject.Name = "tableAddSubject";
            this.tableAddSubject.RowCount = 5;
            this.tableAddSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableAddSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableAddSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableAddSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableAddSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableAddSubject.Size = new System.Drawing.Size(355, 430);
            this.tableAddSubject.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Location = new System.Drawing.Point(103, 205);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(232, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // labelSurnameTitle
            // 
            this.labelSurnameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSurnameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSurnameTitle.Location = new System.Drawing.Point(0, 172);
            this.labelSurnameTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelSurnameTitle.Name = "labelSurnameTitle";
            this.labelSurnameTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelSurnameTitle.Size = new System.Drawing.Size(103, 86);
            this.labelSurnameTitle.TabIndex = 8;
            this.labelSurnameTitle.Text = "Nazwisko";
            this.labelSurnameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(103, 119);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNameTitle.Location = new System.Drawing.Point(0, 86);
            this.labelNameTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelNameTitle.Size = new System.Drawing.Size(103, 86);
            this.labelNameTitle.TabIndex = 6;
            this.labelNameTitle.Text = "Imie";
            this.labelNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSubject.Location = new System.Drawing.Point(103, 33);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(232, 20);
            this.textBoxSubject.TabIndex = 0;
            // 
            // buttonAddEditSubject
            // 
            this.buttonAddEditSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddEditSubject.FlatAppearance.BorderSize = 0;
            this.buttonAddEditSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEditSubject.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonAddEditSubject.Location = new System.Drawing.Point(143, 364);
            this.buttonAddEditSubject.Margin = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.buttonAddEditSubject.Name = "buttonAddEditSubject";
            this.buttonAddEditSubject.Size = new System.Drawing.Size(172, 46);
            this.buttonAddEditSubject.TabIndex = 4;
            this.buttonAddEditSubject.Text = "Dodaj / Edytuj";
            this.buttonAddEditSubject.UseVisualStyleBackColor = true;
            this.buttonAddEditSubject.Click += new System.EventHandler(this.buttonAddEditSubject_Click);
            // 
            // labelSubjectTitle
            // 
            this.labelSubjectTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSubjectTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSubjectTitle.Location = new System.Drawing.Point(0, 0);
            this.labelSubjectTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelSubjectTitle.Name = "labelSubjectTitle";
            this.labelSubjectTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelSubjectTitle.Size = new System.Drawing.Size(103, 86);
            this.labelSubjectTitle.TabIndex = 5;
            this.labelSubjectTitle.Text = "Przedmiot";
            this.labelSubjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableContent);
            this.Name = "FormSubjects";
            this.Text = "Przedmioty";
            this.tableContent.ResumeLayout(false);
            this.tableAddSubject.ResumeLayout(false);
            this.tableAddSubject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSubjects;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.TableLayoutPanel tableContent;
        private System.Windows.Forms.TableLayoutPanel tableAddSubject;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurnameTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNameTitle;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonAddEditSubject;
        private System.Windows.Forms.Label labelSubjectTitle;
    }
}