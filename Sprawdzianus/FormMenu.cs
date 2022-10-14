using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Sprawdzianus
{
    partial class FormSprawdzianus : Form
    {
        private Button activeButton;
        private Form activeForm;
        // globalne lokalizacje plikow
        public static string[] paths = {Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\sprawdzianus",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\sprawdzianus\\sprawdziany.txt",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\sprawdzianus\\przedmioty.txt",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\sprawdzianus\\ustawienia.txt"};

        // domyślne globalne zmienne do wyglądów
        public static string[] themeColors = {"#ffffff", "#ffe5ec", "#ffc2d1", "#ffb3c6", "#ff8fab", "#fb6f92"};
        public static string[] fontColors = { "#ffffff", "#707070" };
        public static string currentFont = "Microsoft Sans Serif";
        public static Single[] fontSizes = {9F, 11F, 13F, 17F};

        private Thread trd;
        public FormSprawdzianus()
        {
            InitializeComponent();
            setTheme();
            buttonCloseChildForm.Visible = false;
            trd = new Thread(new ThreadStart(this.threadSetTheme));  // odpalenie wątku do resetowania wyglądu
            trd.Start();

            if (!Directory.Exists(paths[0]))  // sprawdzenie folderu
            {
                Directory.CreateDirectory(paths[0]);
            }
            if (!File.Exists(paths[1]))  // sprawdzenie pliku sprawdzany
            {
                FileStream file = File.Create(paths[1]);
                file.Close();
            }
            if (!File.Exists(paths[2]))  // sprawdzenie pliku przedmioty
            {
                FileStream file = File.Create(paths[2]);
                file.Close();
            }
            if (!File.Exists(paths[3]))  // sprawdzenie pliku ustawienia
            {
                FileStream file = File.Create(paths[3]);
                file.Close();
                string[] lines =
                {
                    themeColors[0]+";"+themeColors[1]+";"+themeColors[2]+";"+themeColors[3]+";"+themeColors[4]+";"+themeColors[5],
                    fontColors[0]+";"+fontColors[1],
                    currentFont
                };
                File.WriteAllLines(FormSprawdzianus.paths[3], lines);
            }
            else // jak istnieje ustawienia to je wczytuje
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(FormSprawdzianus.paths[3]).ToList();
                themeColors[0] = lines[0].Split(';')[0];
                themeColors[1] = lines[0].Split(';')[1];
                themeColors[2] = lines[0].Split(';')[2];
                themeColors[3] = lines[0].Split(';')[3];
                themeColors[4] = lines[0].Split(';')[4];
                themeColors[5] = lines[0].Split(';')[5];

                fontColors[0] = lines[1].Split(';')[0];
                fontColors[1] = lines[1].Split(';')[1];

                currentFont = lines[2];
            }
        }

        private void threadSetTheme()  //pętla wątku
        {
            while (true)
            {
                setTheme();
                Thread.Sleep(100);
            }
        }

        public void setTheme()
        {
            // Ustawianie kolorów motywów
            this.BackColor = ColorTranslator.FromHtml(themeColors[0]);
            panelDesktop.BackColor = ColorTranslator.FromHtml(themeColors[0]);
            labelSectionTitle.BackColor = ColorTranslator.FromHtml(themeColors[1]);
            panelNavigation.BackColor = ColorTranslator.FromHtml(themeColors[1]);
            buttonClose.BackColor = ColorTranslator.FromHtml(themeColors[1]);
            buttonCloseChildForm.BackColor = ColorTranslator.FromHtml(themeColors[1]);
            labelAppTitle.BackColor = ColorTranslator.FromHtml(themeColors[2]);

            // Ustawianie kolorów czcionek
            this.ForeColor = ColorTranslator.FromHtml(fontColors[1]);
            labelSectionTitle.ForeColor = ColorTranslator.FromHtml(fontColors[1]);
            buttonCloseChildForm.ForeColor = ColorTranslator.FromHtml(fontColors[1]);

            // Ustawianie czcionki i rozmiaru czcionki
            labelSectionTitle.Font = new Font(currentFont, fontSizes[3]);
            labelAppTitle.Font = new Font(currentFont, fontSizes[3]);
            buttonCloseChildForm.Font = new Font(currentFont, fontSizes[2]);

            // Robi wszstko co jest wyżej, ale tylko dla guzików nawigacji
            if (activeButton == null) { deactivateButton(); return; }
            activeButton.BackColor = ColorTranslator.FromHtml(themeColors[3]);
            activeButton.ForeColor = ColorTranslator.FromHtml(fontColors[0]);
            activeButton.Font = new Font(currentFont, fontSizes[2]);
        }

        private void activateButton(object buttonSender)  // Funkcja zmieniająca wygląd klikniętego guzika
        {
            if (buttonSender == null || activeButton == (Button)buttonSender)
                return;
            activeButton = (Button)buttonSender;
            deactivateButton();
            
            activeButton.BackColor = ColorTranslator.FromHtml(themeColors[3]);
            activeButton.ForeColor = ColorTranslator.FromHtml(fontColors[0]);
            activeButton.Font = new Font(currentFont, fontSizes[2]);
            buttonCloseChildForm.Visible = true;
        }

        private void deactivateButton()  // Funkcja resetująca wygląd guzików
        {
            foreach(Control button in panelNavigation.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    button.BackColor = ColorTranslator.FromHtml(themeColors[1]);
                    button.ForeColor = ColorTranslator.FromHtml(fontColors[1]);
                    button.Font = new Font(currentFont, fontSizes[1]);
                }
            }
        }
        private void openChildForm(Form childForm, object sender) // otwiera forma w panelDesktop
        {
            if (activeForm != null) activeForm.Close();
            activateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            labelSectionTitle.Text = childForm.Text;
        }

        // guziki z formami do odpalenia
        private void buttonTimetable_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormTimetable(), sender);
        }

        private void buttonTests_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormTests(), sender);
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSubjects(), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSettings(), sender);
        }
        // guzik do wylaczenia apki
        private void buttonClose_Click(object sender, EventArgs e)
        {
            trd.Abort();
            Close();
        }
        // zwykle wylaczenia apki
        private void FormSprawdzianus_FormClosing(object sender, EventArgs e)
        {
            trd.Abort();
        }

        // guzik od zamkniecia forma
        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            deactivateButton();
            labelSectionTitle.Text = "Menu";
            activeButton = null;
            buttonCloseChildForm.Visible = false;
        }
    }
}
