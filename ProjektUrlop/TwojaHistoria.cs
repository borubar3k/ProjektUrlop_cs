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
    public partial class TwojaHistoria : UserControl
    {
        public int Id_pracownika { get; set; }
        public TwojaHistoria()
        {
            InitializeComponent();
        }
        public void OdswiezTwojaHistorie()
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.Rows.Clear();

                var urlopy = context.urlopy.Where(u => u.Id_pracownika == Id_pracownika).ToList();

                foreach (var urlop in urlopy)
                {
                    var pracownik = context.pracownicy.Where(p => p.Id == urlop.Id_pracownika).SingleOrDefault();

                    if (pracownik != null)
                    {
                        dataGridView1.Rows.Add(
                            urlop.DataOD.ToShortDateString(),
                            urlop.DataDO.ToShortDateString(),
                            urlop.LiczbaDni
                        );
                    }
                }
            }
        }  
    }
}
