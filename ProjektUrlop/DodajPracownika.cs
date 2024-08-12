using Microsoft.IdentityModel.Tokens;
using ProjektUrlop.Data;
using ProjektUrlop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektUrlop
{
    public partial class DodajPracownika : Form
    {
        public DodajPracownika()
        {
            InitializeComponent();
            for (int i = 0; i <= 30; i++)
            {
                comboBox1_dniUrl.Items.Add(i.ToString());
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if (textBox_imie.Text.IsNullOrEmpty() || textBox_nazwisko.Text.IsNullOrEmpty() || textBox_email.Text.IsNullOrEmpty() || textBox_haslo.Text.IsNullOrEmpty() || comboBox1_dniUrl.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Uzupełnij brakujące dane.");
            }
            else
            {
                if (textBox_haslo.Text.Length >= 8)
                {
                    if (textBox_haslo.Text == textBox1.Text)
                    {
                        bool isAdmin;
                        if (checkBox_admin.Checked)
                        {
                            isAdmin = true;
                        }
                        else
                        {
                            isAdmin = false;
                        }
                        using (var context = new AppDbContext())
                        {
                            bool emailIstnieje = context.pracownicy.Any(p => p.Email == textBox_email.Text);
                            if (emailIstnieje)
                            {
                                MessageBox.Show("Pracownik z tym adresem e-mail już istnieje.");
                            }
                            else
                            {
                                var pracownik = new Pracownik
                                {
                                    Imie = textBox_imie.Text,
                                    Nazwisko = textBox_nazwisko.Text,
                                    Email = textBox_email.Text,
                                    Haslo = HashLo(textBox_haslo.Text),
                                    IsAdmin = isAdmin,
                                    DataZatrudnienia = dateTimePicker_dataZatr.Value,
                                    DniUrlopu = int.Parse(comboBox1_dniUrl.Text),
                                    IsArch = false
                                };

                                context.pracownicy.Add(pracownik);
                                context.SaveChanges();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wpisane hasła różnią się!");
                    }
                }
                else
                {
                    MessageBox.Show("Hasło powinno zawierać co najmniej 8 znaków.");
                }
            }
        }
        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
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
