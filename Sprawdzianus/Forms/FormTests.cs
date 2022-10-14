using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Sprawdzianus.Forms
{
    public partial class FormTests : System.Windows.Forms.Form
    {

        public FormTests()
        {
            InitializeComponent();
            setTheme();

            listBoxSubjects.Items.Clear();
            List<string> lines = File.ReadAllLines(FormSprawdzianus.paths[1]).ToList();
            foreach (string line in lines)
            {
                string[] entries = line.Split(';');
                ListViewItem item;
                item = listViewTests.Items.Add(entries[0]);
                item.SubItems.Add(entries[1]);
                item.SubItems.Add(entries[2]);
                if (entries[3] == "1")
                    item.SubItems.Add("Tak");
                else
                    item.SubItems.Add("Nie");
            }

            lines = File.ReadAllLines(FormSprawdzianus.paths[2]).ToList();
            foreach (string line in lines)
            {
                string[] entries = line.Split(';');
                listBoxSubjects.Items.Add(entries[0]);
            }

        }

        private void setTheme()
        {
            // Ustawianie kolorów motywów
            this.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            tableContent.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            listViewTests.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);

            buttonAddEditTest.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelIDTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelDateTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelSubjectTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelStatusTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            tableAddTest.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);

            // Ustawianie kolorów czcionek
            this.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelIDTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelDateTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelSubjectTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelStatusTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            buttonAddEditTest.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            maskedTextBoxDate.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            listViewTests.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            numericUpDownClassroom.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            checkBoxStatus.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            // Ustawianie czcionki i rozmiaru czcionki
            labelIDTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelDateTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelSubjectTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelStatusTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            buttonAddEditTest.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);

            maskedTextBoxDate.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
            listViewTests.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
            numericUpDownClassroom.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
            checkBoxStatus.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
        }

        private void buttonAddEditTest_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy pola są puste
            if (string.IsNullOrEmpty(listBoxSubjects.Text) || maskedTextBoxDate.Text == "  /  /       :" || numericUpDownClassroom.Text == "0")
            {
                MessageBox.Show("Uzupełnij wszystkie pola", "Błąd");
                return;
            }
            // pobranie danych z pliku
            ListViewItem item;
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(FormSprawdzianus.paths[1]).ToList();
            string check = "1";
            if (checkBoxStatus.Checked == true)
                check = "1";
            else
                check = "0";

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Split(';')[1] == maskedTextBoxDate.Text)  // kod do edycji jednego testu
                {
                    lines[i] = listBoxSubjects.SelectedItem.ToString() + ";" + maskedTextBoxDate.Text + ";" + numericUpDownClassroom.Text + ";" + check;
                    listViewTests.Items.Clear();
                    foreach (var line in lines)
                    {
                        string[] entries = line.Split(';');
                        item = listViewTests.Items.Add(entries[0]);
                        item.SubItems.Add(entries[1]);
                        item.SubItems.Add(entries[2]);
                        item.SubItems.Add(entries[3]);
                    }
                    File.WriteAllLines(FormSprawdzianus.paths[1], lines);  // zapisuje dane do pliku
                    maskedTextBoxDate.Text = "";
                    maskedTextBoxDate.Text = "1";
                    checkBoxStatus.Checked = false;

                    return;
                }
            }

            lines.Add(listBoxSubjects.Text + ";" + maskedTextBoxDate.Text + ";" + numericUpDownClassroom.Text + ";" + check);
            File.WriteAllLines(FormSprawdzianus.paths[1], lines); // zapisuje dane do pliku

            item = listViewTests.Items.Add(listBoxSubjects.Text.ToString());
            item.SubItems.Add(maskedTextBoxDate.Text.ToString());
            item.SubItems.Add(numericUpDownClassroom.Text.ToString());

            if (check == "1")
                item.SubItems.Add("Tak");
            else
                item.SubItems.Add("Nie");


            maskedTextBoxDate.Text = " ";
            numericUpDownClassroom.Text = " ";
        }

        private void listViewTests_MouseDoubleClick(object sender, EventArgs e)  // usuwa z listy test
        {
            if (listViewTests.SelectedItems.Count != 1) return;

            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć element?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            List<string> lines = new List<string>();
            listViewTests.SelectedItems[0].Remove();

            foreach (ListViewItem item in listViewTests.Items)
                lines.Add(item.SubItems[0].Text + ";" + item.SubItems[1].Text + ";" + item.SubItems[2].Text + ";" + item.SubItems[3].Text);

            File.WriteAllLines(FormSprawdzianus.paths[1], lines);
        }
    }
}




