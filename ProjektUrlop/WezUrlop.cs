using ProjektUrlop.Data;
using ProjektUrlop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjektUrlop
{
    public partial class WezUrlop : UserControl
    {
        public int Id_pracownika {  get; set; }
        public WezUrlop()
        {
            InitializeComponent();
        }

        private void button_zalozWniosek_Click(object sender, EventArgs e)
        {
            DateTime dataOD = dateTimePicker_dataOD.Value.Date;
            DateTime dataDO = dateTimePicker_dataDO.Value.Date;
            if (dataDO >= dataOD)
            {
                TimeSpan timeSpan = dataDO - dataOD;
                int roznica = (int)timeSpan.TotalDays + 1;
                using (var context = new AppDbContext())
                {
                    var uzytkownik = context.pracownicy.Where(u => u.Id == Id_pracownika).SingleOrDefault();
                    if (uzytkownik != null)
                    {
                        int dostepneDni = uzytkownik.DniUrlopu;
                        if (roznica <= dostepneDni)
                        {
                            uzytkownik.DniUrlopu = dostepneDni - roznica;

                            var nowyUrlop = new Urlop
                            {
                                Id_pracownika = uzytkownik.Id,
                                DataOD = dataOD,
                                DataDO = dataDO,
                                LiczbaDni = roznica,
                                IsAppr = false
                            };
                            context.urlopy.Add(nowyUrlop);
                            context.SaveChanges();
                            MessageBox.Show("Wysłano wniosek");
                            UstawIloscDni();

                        }
                        else
                        {
                            MessageBox.Show("Brak wystarczającej ilości dni wolnych.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak wystarczającej ilości dni wolnych.");
            }
            
        }
        public void UstawIloscDni()
        {
            using (var context = new AppDbContext())
            {
                var uzytkownik = context.pracownicy.Where(u => u.Id == Id_pracownika).SingleOrDefault(); ;
                if (uzytkownik != null)
                {
                    label_dniUrl.Text = uzytkownik.DniUrlopu.ToString();
                }
                else
                {
                    label_dniUrl.Text = "0";
                }
            }
        }
    }
}
