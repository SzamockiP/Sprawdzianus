using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Sprawdzianus.Forms
{
    public partial class FormSubjects : System.Windows.Forms.Form
    {
        public FormSubjects()
        {
            InitializeComponent();
            setTheme();
            
            // załadowuje dane z pliku do tabelki
            List<string> lines = File.ReadAllLines(FormSprawdzianus.paths[2]).ToList();
            listViewSubjects.Items.Clear();
            foreach (var line in lines)
            {
                string[] entries = line.Split(';');
                ListViewItem item;
                item = listViewSubjects.Items.Add(entries[0]);
                item.SubItems.Add(entries[1]);
                item.SubItems.Add(entries[2]);
            }
        }

        private void setTheme()
        {
            // Ustawianie kolorów motywów
            this.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            tableContent.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            listViewSubjects.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);

            buttonAddEditSubject.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelNameTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelSubjectTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelSurnameTitle.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            tableAddSubject.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);


            // Ustawianie kolorów czcionek
            this.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelSurnameTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelNameTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelSubjectTitle.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            buttonAddEditSubject.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            textBoxName.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxSurname.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxSubject.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);


            // Ustawianie czcionki i rozmiaru czcionki
            labelSurnameTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelNameTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelSubjectTitle.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            buttonAddEditSubject.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);

            textBoxName.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
            textBoxSurname.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
            textBoxSubject.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
        }
        // Dodanie do "bazy" / do pliku
        private void buttonAddEditSubject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSubject.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))  // sprawdzenie czy wszystkie pola są pełne
            {
                MessageBox.Show("Uzupełnij wszystkie pola", "Błąd");
                return;
            }
            List<string> lines = new List<string>(); // pobranie danych z pliku
            lines = File.ReadAllLines(FormSprawdzianus.paths[2]).ToList();
            ListViewItem item;

            for (int i = 0; i < lines.Count; i++)
            {
                if(lines[i].Split(';')[0] == textBoxSubject.Text) // kod do edycji jednego przedmiotu
                {
                    lines[i] = textBoxSubject.Text + ";" + textBoxName.Text + ";" + textBoxSurname.Text;

                    listViewSubjects.Items.Clear();
                    foreach (var line in lines)
                    {
                        string[] entries = line.Split(';');
                        item = listViewSubjects.Items.Add(entries[0]);
                        item.SubItems.Add(entries[1]);
                        item.SubItems.Add(entries[2]);
                    }
                    File.WriteAllLines(FormSprawdzianus.paths[2], lines);
                    textBoxSubject.Text = "";
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";

                    return;
                }
            }

            lines.Add(textBoxSubject.Text + ";" + textBoxName.Text + ";" + textBoxSurname.Text);
            File.WriteAllLines(FormSprawdzianus.paths[2], lines);

            item = listViewSubjects.Items.Add(textBoxSubject.Text);
            item.SubItems.Add(textBoxName.Text);
            item.SubItems.Add(textBoxSurname.Text);

            textBoxSubject.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
        }

        private void listViewSubjects_MouseDoubleClick(object sender, EventArgs e)  // usuwa z listy rekord
        {
            if (listViewSubjects.SelectedItems.Count != 1) return;
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć element?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            List<string> lines = new List<string>();
            listViewSubjects.SelectedItems[0].Remove(); // usuwa

            foreach (ListViewItem item in listViewSubjects.Items) // zapisuje reszte danych do pliku
                lines.Add(item.SubItems[0].Text + ";" + item.SubItems[1].Text + ";" + item.SubItems[2].Text);

            File.WriteAllLines(FormSprawdzianus.paths[2], lines);
        }
    }
}
