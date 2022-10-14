using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sprawdzianus.Forms
{
    public partial class UserControlDay : UserControl
    {
        List<string> tests;
        public UserControlDay()
        {
            InitializeComponent();
        }

        public void days(int numday,List<string> passedTests) // ustawia numer dnia i dodaje sprawdziany do listy
        {
            tests = passedTests;
            labelDay.Text = numday.ToString();
            foreach(string line in tests)
            {
                listBoxTests.Items.Add(line.Split(';')[0]);
            }
        }

        public void ucd_setTheme()  // ustawia wygląd 
        {
            this.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            listBoxTests.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            listBoxTests.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelDay.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            listBoxTests.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
            labelDay.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);
        }

        private void listBoxTests_MouseDoubleClick(object sender, EventArgs e) // odpala dodatkowe informacje o teście
        {
            if (listBoxTests.SelectedItems.Count != 1) return;
            foreach (string test in tests)
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(FormSprawdzianus.paths[2]).ToList(); // otwiera plik z nauczycielami
                string[] entries = {"","",""};
                foreach(string line in lines) // szuka przedmiotu z pliku po nazwie przedmiotu z sprawdziany
                {
                    if(line.Split(';')[0] == test.Split(';')[0])
                    {
                        entries = line.Split(';');
                        break;
                    }
                }
                string check;
                if (test.Split(';')[3] == "1") check = "Zaliczony";
                else check = "Niezaliczony"; // pokazuje wszystkie dane w msgBoxie
                if (listBoxTests.SelectedItems[0].ToString() == test.Split(';')[0]) MessageBox.Show($"Przedmiot: {test.Split(';')[0]}\nTermin: {test.Split(';')[1]}\nSala: {test.Split(';')[2]}\nStatus: {check}\nImie naucz.: {entries[1]}\nNazwisko naucz.: {entries[2]}", "Sprawdzian");
            }
        }
    }
}
