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
    public partial class listaPracownikowA : UserControl
    {
        public listaPracownikowA()
        {
            InitializeComponent();
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            DodajPracownika dodaj = new DodajPracownika();
            if(dodaj.ShowDialog() == DialogResult.OK)
            {
                odswiezPracownikow();
            }
            
        }

        private void button_zarch_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                using (var context = new AppDbContext())
                {
                    var uzytkownik = context.pracownicy.Where(u => u.Id == id).SingleOrDefault();
                    if (uzytkownik != null)
                    {
                        uzytkownik.IsArch = true;
                        context.SaveChanges();
                    }
                    odswiezPracownikow();
                }
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                using (var context = new AppDbContext())
                {
                    var pracownik = context.pracownicy.Find(id);
                    if (pracownik != null)
                    {
                        context.pracownicy.Remove(pracownik);
                        context.SaveChanges();
                    }
                }
                odswiezPracownikow();
            }
        }
        public void odswiezPracownikow()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.Rows.Clear();

                var pracownicy = context.pracownicy.Where(p => p.IsArch == false).ToList();

                foreach (var pracownik in pracownicy)
                {
                    if (pracownik != null)
                    {
                        dataGridView1.Rows.Add(
                            pracownik.Id,
                            pracownik.Imie + " " + pracownik.Nazwisko,
                            pracownik.Email,
                            pracownik.DataZatrudnienia.ToShortDateString(),
                            pracownik.IsAdmin
                        );
                    }
                }
            }
        }
    }
}
