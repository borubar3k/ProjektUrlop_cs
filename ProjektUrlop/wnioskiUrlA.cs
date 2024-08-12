using ProjektUrlop.Data;
using ProjektUrlop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektUrlop
{
    public partial class wnioskiUrlA : UserControl
    {
        public wnioskiUrlA()
        {
            InitializeComponent();
        }

        private void button_zaakceptuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                using (var context = new AppDbContext())
                {
                    var url = context.urlopy.Find(id);
                    if (url != null)
                    {
                        url.IsAppr = true;
                        context.SaveChanges();
                    }
                }
                OdswiezWnioskiUrlop();
            }
        }

        private void button_odrzuc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                using (var context = new AppDbContext())
                {
                    var url = context.urlopy.Find(id);
                    if (url != null)
                    {
                        var pracownik = context.pracownicy.Find(url.Id_pracownika);
                        if (pracownik != null)
                        {
                            pracownik.DniUrlopu += url.LiczbaDni;

                            context.urlopy.Remove(url);

                            context.SaveChanges();
                        }

                    }
                }
                OdswiezWnioskiUrlop();
            }
        }
        public void OdswiezWnioskiUrlop()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.Rows.Clear();

                var urlopy = context.urlopy.Where(u => u.IsAppr == false).ToList();

                foreach (var urlop in urlopy)
                {
                    var pracownik = context.pracownicy.Where(p => p.Id == urlop.Id_pracownika && p.IsArch == false).SingleOrDefault();

                    if (pracownik != null)
                    {
                        dataGridView1.Rows.Add(
                            urlop.Id,
                            pracownik.Imie + " " + pracownik.Nazwisko,
                            pracownik.Email,
                            pracownik.DniUrlopu,
                            urlop.DataOD.ToShortDateString() + " " + urlop.DataDO.ToShortDateString(),
                            urlop.LiczbaDni
                        );
                    }
                }
            }
        }
    }
}
