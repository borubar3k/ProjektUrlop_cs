using Microsoft.IdentityModel.Tokens;
using ProjektUrlop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektUrlop
{
    public partial class historiaUrlA : UserControl
    {
        public historiaUrlA()
        {
            InitializeComponent();
        }

        private void button_szukaj_Click(object sender, EventArgs e)
        {
            string szukane = textBox_szukaj.Text;
            using (var context = new AppDbContext())
            {
                dataGridView1.Rows.Clear();

                var urlopy = context.urlopy.Where(u => u.IsAppr == true).ToList();

                foreach (var urlop in urlopy)
                {
                    var pracownik = context.pracownicy.Where(p => p.Id == urlop.Id_pracownika && (string.IsNullOrEmpty(szukane) || p.Imie.Contains(szukane) || p.Nazwisko.Contains(szukane) || (p.Imie + " " + p.Nazwisko).Contains(szukane))).SingleOrDefault();

                    if (pracownik != null)
                    {
                        dataGridView1.Rows.Add(
                            urlop.Id,
                            pracownik.Imie + " " + pracownik.Nazwisko,
                            pracownik.Email,
                            urlop.DataOD.ToShortDateString() + " " + urlop.DataDO.ToShortDateString(),
                            urlop.LiczbaDni
                        );
                    }
                }
            }

        }
        public void OdswiezUrlop()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.Rows.Clear();

                var urlopy = context.urlopy.Where(u => u.IsAppr == true).ToList();

                foreach (var urlop in urlopy)
                {
                    var pracownik = context.pracownicy.Where(p => p.Id == urlop.Id_pracownika).SingleOrDefault();

                    if (pracownik != null)
                    {
                        dataGridView1.Rows.Add(
                            urlop.Id,
                            pracownik.Imie + " " + pracownik.Nazwisko,
                            pracownik.Email,
                            urlop.DataOD.ToShortDateString() + " " + urlop.DataDO.ToShortDateString(),
                            urlop.LiczbaDni
                        );
                    }
                }
            }
        }
    }
}
