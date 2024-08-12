using ProjektUrlop.Data;
using ProjektUrlop.Models;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace ProjektUrlop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_pokaHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pokaHaslo.Checked)
            {
                textBox_haslo.PasswordChar = '\0';
            }
            else
            {
                textBox_haslo.PasswordChar = '*';
            }
        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string pass = textBox_haslo.Text;
            using (var context = new AppDbContext())
            {
                var uzytkownik = context.pracownicy.Where(w => w.Email == email && w.Haslo == HashLo(pass) && w.IsArch == false).FirstOrDefault();
                if (uzytkownik != null)
                {
                    var noweLogowanie = new Logowania
                    {
                        Id_pracownika = uzytkownik.Id,
                        DataLogowania = DateTime.Now
                    };
                    context.logowania.Add(noweLogowanie);
                    context.SaveChanges();
                    Form2 form2 = new Form2(uzytkownik);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nieprawid³owe dane.");
                }
            }
            DodajDniUrlopu();
        }
        private void DodajDniUrlopu()
        {
            using (var context = new AppDbContext())
            {
                var prac = context.pracownicy.ToList();
                var log = context.logowania.Last
                var currentDate = DateTime.Now;

                foreach (var p in prac)
                {
                    int monthsEmployed = ((currentDate.Year - p.DataZatrudnienia.Year) * 12) + currentDate.Month - p.DataZatrudnienia.Month;
                    if (monthsEmployed > 0 && monthsEmployed % 6 == 0)
                    {
                        p.DniUrlopu += 10;
                    }
                }

                context.SaveChanges();
            }
        }
        private string HashLo(string haslo)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(haslo));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
