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

namespace ProjektUrlop
{
    public partial class Form2 : Form
    {
        private readonly Pracownik User;
        public Form2(Pracownik User)
        {
            InitializeComponent();
            this.User = User;
            label_name.Text = User.Imie;
            if (User.IsAdmin == false)
            {
                button_AhistoriaUrl.Visible = false;
                button_AwnioskiUrl.Visible = false;
                button_AlistaPracownikow.Visible = false;
            }
            wezUrlop1.Visible = true;
            twojaHistoria1.Visible = false;
            wnioskiUrla1.Visible = false;
            historiaUrla1.Visible = false;
            listaPracownikowa1.Visible = false;

            wezUrlop1.Id_pracownika = User.Id;
            wezUrlop1.UstawIloscDni();

            twojaHistoria1.Id_pracownika = User.Id;
        }

        private void label_zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_wyloguj_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button_urlop_Click(object sender, EventArgs e)
        {
            wezUrlop1.Visible = true;
            twojaHistoria1.Visible = false;
            wnioskiUrla1.Visible = false;
            historiaUrla1.Visible = false;
            listaPracownikowa1.Visible = false;
            wezUrlop1.UstawIloscDni();
        }

        private void button_twojaHistoria_Click(object sender, EventArgs e)
        {
            wezUrlop1.Visible = false;
            twojaHistoria1.Visible = true;
            wnioskiUrla1.Visible = false;
            historiaUrla1.Visible = false;
            listaPracownikowa1.Visible = false;
            twojaHistoria1.OdswiezTwojaHistorie();
        }

        private void button_AwnioskiUrl_Click(object sender, EventArgs e)
        {
            wezUrlop1.Visible = false;
            twojaHistoria1.Visible = false;
            wnioskiUrla1.Visible = true;
            historiaUrla1.Visible = false;
            listaPracownikowa1.Visible = false;
            wnioskiUrla1.OdswiezWnioskiUrlop();
        }

        private void button_AhistoriaUrl_Click(object sender, EventArgs e)
        {
            wezUrlop1.Visible = false;
            twojaHistoria1.Visible = false;
            wnioskiUrla1.Visible = false;
            historiaUrla1.Visible = true;
            listaPracownikowa1.Visible = false;
            historiaUrla1.OdswiezUrlop();
        }

        private void button_AlistaPracownikow_Click(object sender, EventArgs e)
        {
            wezUrlop1.Visible = false;
            twojaHistoria1.Visible = false;
            wnioskiUrla1.Visible = false;
            historiaUrla1.Visible = false;
            listaPracownikowa1.Visible = true;
            listaPracownikowa1.odswiezPracownikow();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
