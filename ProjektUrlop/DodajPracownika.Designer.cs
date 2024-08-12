namespace ProjektUrlop
{
    partial class DodajPracownika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_anuluj = new Button();
            button_dodaj = new Button();
            label_imie = new Label();
            textBox_imie = new TextBox();
            textBox_nazwisko = new TextBox();
            label_nazwisko = new Label();
            textBox_email = new TextBox();
            label_email = new Label();
            textBox_haslo = new TextBox();
            label_haslo = new Label();
            textBox1 = new TextBox();
            label_phaslo = new Label();
            checkBox_admin = new CheckBox();
            label_dataZatr = new Label();
            dateTimePicker_dataZatr = new DateTimePicker();
            label_dniUrl = new Label();
            comboBox1_dniUrl = new ComboBox();
            SuspendLayout();
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(219, 281);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(100, 34);
            button_anuluj.TabIndex = 0;
            button_anuluj.Text = "Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(116, 281);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(97, 34);
            button_dodaj.TabIndex = 1;
            button_dodaj.Text = "Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // label_imie
            // 
            label_imie.AutoSize = true;
            label_imie.Location = new Point(127, 29);
            label_imie.Name = "label_imie";
            label_imie.Size = new Size(40, 19);
            label_imie.TabIndex = 2;
            label_imie.Text = "imie";
            // 
            // textBox_imie
            // 
            textBox_imie.Location = new Point(175, 26);
            textBox_imie.Name = "textBox_imie";
            textBox_imie.Size = new Size(144, 26);
            textBox_imie.TabIndex = 3;
            // 
            // textBox_nazwisko
            // 
            textBox_nazwisko.Location = new Point(175, 58);
            textBox_nazwisko.Name = "textBox_nazwisko";
            textBox_nazwisko.Size = new Size(144, 26);
            textBox_nazwisko.TabIndex = 5;
            // 
            // label_nazwisko
            // 
            label_nazwisko.AutoSize = true;
            label_nazwisko.Location = new Point(85, 61);
            label_nazwisko.Name = "label_nazwisko";
            label_nazwisko.Size = new Size(82, 19);
            label_nazwisko.TabIndex = 4;
            label_nazwisko.Text = "nazwisko";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(175, 90);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(144, 26);
            textBox_email.TabIndex = 7;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(66, 93);
            label_email.Name = "label_email";
            label_email.Size = new Size(101, 19);
            label_email.TabIndex = 6;
            label_email.Text = "adres e-mail";
            // 
            // textBox_haslo
            // 
            textBox_haslo.Location = new Point(175, 122);
            textBox_haslo.Name = "textBox_haslo";
            textBox_haslo.PasswordChar = '*';
            textBox_haslo.Size = new Size(144, 26);
            textBox_haslo.TabIndex = 9;
            // 
            // label_haslo
            // 
            label_haslo.AutoSize = true;
            label_haslo.Location = new Point(116, 129);
            label_haslo.Name = "label_haslo";
            label_haslo.Size = new Size(51, 19);
            label_haslo.TabIndex = 8;
            label_haslo.Text = "hasło";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 154);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(144, 26);
            textBox1.TabIndex = 11;
            // 
            // label_phaslo
            // 
            label_phaslo.AutoSize = true;
            label_phaslo.Location = new Point(49, 157);
            label_phaslo.Name = "label_phaslo";
            label_phaslo.Size = new Size(118, 19);
            label_phaslo.TabIndex = 10;
            label_phaslo.Text = "powtórz hasło";
            // 
            // checkBox_admin
            // 
            checkBox_admin.AutoSize = true;
            checkBox_admin.Location = new Point(244, 252);
            checkBox_admin.Name = "checkBox_admin";
            checkBox_admin.Size = new Size(75, 23);
            checkBox_admin.TabIndex = 12;
            checkBox_admin.Text = "admin";
            checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // label_dataZatr
            // 
            label_dataZatr.AutoSize = true;
            label_dataZatr.Location = new Point(26, 193);
            label_dataZatr.Name = "label_dataZatr";
            label_dataZatr.Size = new Size(141, 19);
            label_dataZatr.TabIndex = 13;
            label_dataZatr.Text = "data zatrudnienia";
            // 
            // dateTimePicker_dataZatr
            // 
            dateTimePicker_dataZatr.Format = DateTimePickerFormat.Short;
            dateTimePicker_dataZatr.Location = new Point(173, 187);
            dateTimePicker_dataZatr.Name = "dateTimePicker_dataZatr";
            dateTimePicker_dataZatr.Size = new Size(146, 26);
            dateTimePicker_dataZatr.TabIndex = 14;
            // 
            // label_dniUrl
            // 
            label_dniUrl.AutoSize = true;
            label_dniUrl.Location = new Point(42, 223);
            label_dniUrl.Name = "label_dniUrl";
            label_dniUrl.Size = new Size(125, 19);
            label_dniUrl.TabIndex = 15;
            label_dniUrl.Text = "dostepny urlop";
            // 
            // comboBox1_dniUrl
            // 
            comboBox1_dniUrl.FormattingEnabled = true;
            comboBox1_dniUrl.Location = new Point(175, 220);
            comboBox1_dniUrl.Name = "comboBox1_dniUrl";
            comboBox1_dniUrl.Size = new Size(144, 27);
            comboBox1_dniUrl.TabIndex = 16;
            // 
            // DodajPracownika
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(340, 338);
            Controls.Add(comboBox1_dniUrl);
            Controls.Add(label_dniUrl);
            Controls.Add(dateTimePicker_dataZatr);
            Controls.Add(label_dataZatr);
            Controls.Add(checkBox_admin);
            Controls.Add(textBox1);
            Controls.Add(label_phaslo);
            Controls.Add(textBox_haslo);
            Controls.Add(label_haslo);
            Controls.Add(textBox_email);
            Controls.Add(label_email);
            Controls.Add(textBox_nazwisko);
            Controls.Add(label_nazwisko);
            Controls.Add(textBox_imie);
            Controls.Add(label_imie);
            Controls.Add(button_dodaj);
            Controls.Add(button_anuluj);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "DodajPracownika";
            Text = "Dodawanie pracownika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_anuluj;
        private Button button_dodaj;
        private Label label_imie;
        private TextBox textBox_imie;
        private TextBox textBox_nazwisko;
        private Label label_nazwisko;
        private TextBox textBox_email;
        private Label label_email;
        private TextBox textBox_haslo;
        private Label label_haslo;
        private TextBox textBox1;
        private Label label_phaslo;
        private CheckBox checkBox_admin;
        private Label label_dataZatr;
        private DateTimePicker dateTimePicker_dataZatr;
        private Label label_dniUrl;
        private ComboBox comboBox1_dniUrl;
    }
}