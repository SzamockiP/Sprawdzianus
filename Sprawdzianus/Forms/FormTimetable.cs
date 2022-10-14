using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;

namespace Sprawdzianus.Forms
{
    public partial class FormTimetable : System.Windows.Forms.Form
    {
        //dane globalne dla ich
        public int month, year;
        public DateTime now = DateTime.Now;
        public string[] monthNames = { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień" };

        public FormTimetable()
        {
            InitializeComponent();
            month = now.Month;
            year = now.Year;

            displayDays();
            setTheme();
        }

        private void setTheme()
        {
            //ustawienie tla
            this.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            flowContainer.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[0]);
            buttonNext.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);
            buttonLast.BackColor = ColorTranslator.FromHtml(FormSprawdzianus.themeColors[1]);

            //ustawienie koloru czcionki
            labelDate.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            buttonNext.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);
            buttonLast.ForeColor = ColorTranslator.FromHtml(FormSprawdzianus.fontColors[1]);

            //ustawienie czcionki
            labelDate.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[3]);
            buttonNext.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            buttonLast.Font = new Font(FormSprawdzianus.currentFont, FormSprawdzianus.fontSizes[1]);
            setDaysTheme();
        }

        private void setDaysTheme() // ustawia wygląd plakietek z dniami
        {
            foreach (Object uc in flowContainer.Controls)
            {
                if (uc.GetType() == typeof(UserControlDay))
                {
                    UserControlDay ucd = (UserControlDay)uc;
                    ucd.ucd_setTheme();
                }
            }
        }

        private void displayDays() // wyświetla dni
        {
            List<string> wiersze = File.ReadAllLines(FormSprawdzianus.paths[1]).ToList(); //pobiera dane o sprawdzianach

            DateTime startOfMonth = new DateTime(year, month, 1); // sprawdza date itp
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            labelDate.Text = monthNames[month-1] + " " + year;

            for(int i = 1; i < dayOfWeek; i++) // wypełnia pustą przestrzeń na początku miesiąca
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowContainer.Controls.Add(ucblank);
            }

            string month_str = month.ToString();
            string day_str = "01";
            if (month < 10) month_str = "0" + month.ToString();
            for (int i = 1; i <= days; i++)
            {
                if (i < 10) day_str = "0" + i.ToString();
                else day_str = i.ToString();
                UserControlDay ucday = new UserControlDay();
                ucday.days(i, searchDays(wiersze, day_str + '/' + month_str + '/' + year.ToString())); // dodaje dni z sprawdzianami
                if(i == DateTime.Today.Day && month == DateTime.Today.Month) ucday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                flowContainer.Controls.Add(ucday);
            }
        }

        private List<string> searchDays(List<string> tests, string date) // szuka sprawdzianów z określonym dniem w podanej liście z sprawdzianami
        {
            List<string> days = new List<string> {};

            foreach (string line in tests)
            {
                if (line.Split(';')[1].Contains(date)) days.Add(line);
            }
            return days;
        }

        private void buttonNext_Click(object sender, EventArgs e) // przewija kalendarz
        {
            flowContainer.Controls.Clear();
            month++;
            if (month >= 12) { month = 1; year++; }
            displayDays();
            setDaysTheme();
        }

        private void buttonLast_Click(object sender, EventArgs e) // odwija kalendarz
        {
            flowContainer.Controls.Clear();
            month--;
            if (month <= 0) { month = 12; year--; }
            displayDays();
            setDaysTheme();
        }
    }
}
