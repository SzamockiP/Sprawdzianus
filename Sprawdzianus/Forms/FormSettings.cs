using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprawdzianus.Forms
{
    public partial class FormSettings : System.Windows.Forms.Form
    {
        public FormSettings()
        {
            InitializeComponent();
            setTheme();

            // wpisz do guzikow dane wygladu i tyle
            textBoxK1.Text = FormSprawdzianus.themeColors[0].ToUpper();
            textBoxK2.Text = FormSprawdzianus.themeColors[1].ToUpper();
            textBoxK3.Text = FormSprawdzianus.themeColors[2].ToUpper();
            textBoxK4.Text = FormSprawdzianus.themeColors[3].ToUpper();
            textBoxK5.Text = FormSprawdzianus.themeColors[4].ToUpper();
            textBoxK6.Text = FormSprawdzianus.themeColors[5].ToUpper();

            textBoxKC1.Text = FormSprawdzianus.fontColors[0].ToUpper();
            textBoxKC2.Text = FormSprawdzianus.fontColors[1].ToUpper();
        }

        private void setTheme()
        {
            // ustawianie tla
            this.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            tableLayoutTheme.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            tableLayoutFont.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);

            labelK1.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelK2.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelK3.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelK4.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelK5.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelK6.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);

            labelKC1.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelKC2.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            labelRC.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);

            panelKC1.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[0]);
            panelKC2.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelRTC.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);

            // Ustawianie kolorów czcionek
            this.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelK1.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelK2.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelK3.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelK4.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelK5.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelK6.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            textBoxK1.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxK2.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxK3.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxK4.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxK5.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxK6.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            labelKC1.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelKC2.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelRC.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            textBoxKC1.ForeColor =  ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            textBoxKC2.ForeColor =  ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            listBoxRC.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            panelKC1.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            panelKC2.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            labelRTC.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            // Ustawianie czcionki i rozmiaru czcionki
            labelK1.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelK2.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelK3.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelK4.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelK5.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelK6.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);

            textBoxK1.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            textBoxK2.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            textBoxK3.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            textBoxK4.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            textBoxK5.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            textBoxK6.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);

            labelKC1.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelKC2.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelRC.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);

            textBoxKC1.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            textBoxKC2.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            listBoxRC.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[0]);

            panelKC1.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            panelKC2.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            labelRTC.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
        }

        private void saveFile() // zapisuje do pliku ustawienia wszystkie aktualne dane wygladu
        {
            string[] lines =
                {
                    FormSprawdzianus.themeColors[0]+";"+FormSprawdzianus.themeColors[1]+";"+FormSprawdzianus.themeColors[2]+";"+FormSprawdzianus.themeColors[3]+";"+FormSprawdzianus.themeColors[4]+";"+FormSprawdzianus.themeColors[5],
                    FormSprawdzianus.fontColors[0]+";"+FormSprawdzianus.fontColors[1],
                    FormSprawdzianus.currentFont
                };
            File.WriteAllLines(FormSprawdzianus.paths[3], lines);
        }

        // zmiana danych wygladu przez inputy w formie
        private void textBoxK1_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte) textBoxK1.SelectionStart; // tekst do wielkich liter
            textBoxK1.Text = textBoxK1.Text.ToUpper();
            textBoxK1.SelectionStart = oldSelection;

            try // proboje ustawić nowe dane wyglądu
            {
                if (textBoxK1.Text.Length != 7) return;
                panelK1.BackColor = ColorTranslator.FromHtml(textBoxK1.Text);
                FormSprawdzianus.themeColors[0] = textBoxK1.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) {return; };
        }

        private void textBoxK2_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxK2.SelectionStart;
            textBoxK2.Text = textBoxK2.Text.ToUpper();
            textBoxK2.SelectionStart = oldSelection;
            
            try {
            
                if (textBoxK2.Text.Length != 7)return;
                panelK2.BackColor = ColorTranslator.FromHtml(textBoxK2.Text);
                FormSprawdzianus.themeColors[1] = textBoxK2.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) {return;};
        }

        private void textBoxK3_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxK3.SelectionStart;
            textBoxK3.Text = textBoxK3.Text.ToUpper();
            textBoxK3.SelectionStart = oldSelection;
            
            try
            {
                if (textBoxK3.Text.Length != 7)  return;
                panelK3.BackColor = ColorTranslator.FromHtml(textBoxK3.Text);
                FormSprawdzianus.themeColors[2] = textBoxK3.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) {return;};
        }

        private void textBoxK4_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxK4.SelectionStart;
            textBoxK4.Text = textBoxK4.Text.ToUpper();
            textBoxK4.SelectionStart = oldSelection;
            
            try
            {
                if (textBoxK4.Text.Length != 7)  return;
                panelK4.BackColor = ColorTranslator.FromHtml(textBoxK4.Text);
                FormSprawdzianus.themeColors[3] = textBoxK4.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) {return;};
        }

        private void textBoxK5_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxK5.SelectionStart;
            textBoxK5.Text = textBoxK5.Text.ToUpper();
            textBoxK5.SelectionStart = oldSelection;
            
            try
            {
                if (textBoxK5.Text.Length != 7)  return;
                panelK5.BackColor = ColorTranslator.FromHtml(textBoxK5.Text);
                FormSprawdzianus.themeColors[4] = textBoxK5.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) {return;};
        }

        private void textBoxK6_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxK6.SelectionStart;
            textBoxK6.Text = textBoxK6.Text.ToUpper();
            textBoxK6.SelectionStart = oldSelection;
            
            try
            {
                if (textBoxK6.Text.Length != 7)  return;
                panelK6.BackColor = ColorTranslator.FromHtml(textBoxK6.Text);
                FormSprawdzianus.themeColors[5] = textBoxK6.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) {return;};    
        }

        private void textBoxKC1_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxKC1.SelectionStart;
            textBoxKC1.Text = textBoxKC1.Text.ToUpper();
            textBoxKC1.SelectionStart = oldSelection;

            try
            {
                if (textBoxKC1.Text.Length != 7) return;
                panelKC1.BackColor = ColorTranslator.FromHtml(textBoxKC1.Text);
                FormSprawdzianus.fontColors[0] = textBoxKC1.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) { return; };
        }

        private void textBoxKC2_TextChanged(object sender, EventArgs e)
        {
            byte oldSelection = (byte)textBoxKC2.SelectionStart;
            textBoxKC2.Text = textBoxKC2.Text.ToUpper();
            textBoxKC2.SelectionStart = oldSelection;
            try
            {
                if (textBoxKC2.Text.Length != 7) return;
                panelKC2.BackColor = ColorTranslator.FromHtml(textBoxKC2.Text);
                FormSprawdzianus.fontColors[1] = textBoxKC2.Text;
                setTheme();
                saveFile();
            }
            catch (Exception) { return; };
        }

        private void listBoxRC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try // wybierasz z listy czcionke i daje ją do wyglądu
            {
                labelRTC.Font = new Font(listBoxRC.SelectedItem.ToString(), FormSprawdzianus.fontSizes[1]);
                FormSprawdzianus.currentFont = listBoxRC.SelectedItem.ToString();
                setTheme();
                saveFile();
            }
            catch (Exception) { return; };
        }
    }
}
