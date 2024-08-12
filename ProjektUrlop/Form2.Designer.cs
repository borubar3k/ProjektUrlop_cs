namespace ProjektUrlop
{
    partial class Form2
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
            panel1 = new Panel();
            button_wyloguj = new Button();
            button_AhistoriaUrl = new Button();
            button_AlistaPracownikow = new Button();
            button_AwnioskiUrl = new Button();
            button_twojaHistoria = new Button();
            button_urlop = new Button();
            label_name = new Label();
            label_witaj = new Label();
            label_zamknij = new Label();
            wezUrlop1 = new WezUrlop();
            twojaHistoria1 = new TwojaHistoria();
            wnioskiUrla1 = new wnioskiUrlA();
            historiaUrla1 = new historiaUrlA();
            listaPracownikowa1 = new listaPracownikowA();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button_wyloguj);
            panel1.Controls.Add(button_AhistoriaUrl);
            panel1.Controls.Add(button_AlistaPracownikow);
            panel1.Controls.Add(button_AwnioskiUrl);
            panel1.Controls.Add(button_twojaHistoria);
            panel1.Controls.Add(button_urlop);
            panel1.Controls.Add(label_name);
            panel1.Controls.Add(label_witaj);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 563);
            panel1.TabIndex = 0;
            // 
            // button_wyloguj
            // 
            button_wyloguj.BackColor = SystemColors.GradientInactiveCaption;
            button_wyloguj.Location = new Point(12, 518);
            button_wyloguj.Name = "button_wyloguj";
            button_wyloguj.Size = new Size(110, 33);
            button_wyloguj.TabIndex = 7;
            button_wyloguj.Text = "Wyloguj się";
            button_wyloguj.UseVisualStyleBackColor = false;
            button_wyloguj.Click += button_wyloguj_Click;
            // 
            // button_AhistoriaUrl
            // 
            button_AhistoriaUrl.BackColor = SystemColors.GradientInactiveCaption;
            button_AhistoriaUrl.Location = new Point(12, 365);
            button_AhistoriaUrl.Name = "button_AhistoriaUrl";
            button_AhistoriaUrl.Size = new Size(313, 33);
            button_AhistoriaUrl.TabIndex = 6;
            button_AhistoriaUrl.Text = "Historia urlopów";
            button_AhistoriaUrl.UseVisualStyleBackColor = false;
            button_AhistoriaUrl.Click += button_AhistoriaUrl_Click;
            // 
            // button_AlistaPracownikow
            // 
            button_AlistaPracownikow.BackColor = SystemColors.GradientInactiveCaption;
            button_AlistaPracownikow.Location = new Point(12, 404);
            button_AlistaPracownikow.Name = "button_AlistaPracownikow";
            button_AlistaPracownikow.Size = new Size(313, 33);
            button_AlistaPracownikow.TabIndex = 5;
            button_AlistaPracownikow.Text = "Lista pracowników";
            button_AlistaPracownikow.UseVisualStyleBackColor = false;
            button_AlistaPracownikow.Click += button_AlistaPracownikow_Click;
            // 
            // button_AwnioskiUrl
            // 
            button_AwnioskiUrl.BackColor = SystemColors.GradientInactiveCaption;
            button_AwnioskiUrl.Location = new Point(12, 326);
            button_AwnioskiUrl.Name = "button_AwnioskiUrl";
            button_AwnioskiUrl.Size = new Size(313, 33);
            button_AwnioskiUrl.TabIndex = 4;
            button_AwnioskiUrl.Text = "Wnioski o urlop";
            button_AwnioskiUrl.UseVisualStyleBackColor = false;
            button_AwnioskiUrl.Click += button_AwnioskiUrl_Click;
            // 
            // button_twojaHistoria
            // 
            button_twojaHistoria.BackColor = SystemColors.GradientInactiveCaption;
            button_twojaHistoria.Location = new Point(12, 248);
            button_twojaHistoria.Name = "button_twojaHistoria";
            button_twojaHistoria.Size = new Size(313, 33);
            button_twojaHistoria.TabIndex = 3;
            button_twojaHistoria.Text = "Twoja historia";
            button_twojaHistoria.UseVisualStyleBackColor = false;
            button_twojaHistoria.Click += button_twojaHistoria_Click;
            // 
            // button_urlop
            // 
            button_urlop.BackColor = SystemColors.GradientInactiveCaption;
            button_urlop.Location = new Point(12, 209);
            button_urlop.Name = "button_urlop";
            button_urlop.Size = new Size(313, 33);
            button_urlop.TabIndex = 2;
            button_urlop.Text = "Weź urlop";
            button_urlop.UseVisualStyleBackColor = false;
            button_urlop.Click += button_urlop_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.BackColor = SystemColors.HotTrack;
            label_name.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_name.ForeColor = SystemColors.ButtonFace;
            label_name.Location = new Point(12, 97);
            label_name.Name = "label_name";
            label_name.Size = new Size(328, 56);
            label_name.TabIndex = 1;
            label_name.Text = "użytkowniku!";
            // 
            // label_witaj
            // 
            label_witaj.AutoSize = true;
            label_witaj.BackColor = SystemColors.HotTrack;
            label_witaj.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_witaj.ForeColor = SystemColors.ButtonFace;
            label_witaj.Location = new Point(12, 30);
            label_witaj.Name = "label_witaj";
            label_witaj.Size = new Size(151, 56);
            label_witaj.TabIndex = 0;
            label_witaj.Text = "Witaj,";
            // 
            // label_zamknij
            // 
            label_zamknij.AutoSize = true;
            label_zamknij.Location = new Point(970, 9);
            label_zamknij.Name = "label_zamknij";
            label_zamknij.Size = new Size(18, 19);
            label_zamknij.TabIndex = 1;
            label_zamknij.Text = "x";
            label_zamknij.Click += label_zamknij_Click;
            // 
            // wezUrlop1
            // 
            wezUrlop1.BackColor = SystemColors.GradientInactiveCaption;
            wezUrlop1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            wezUrlop1.Id_pracownika = 0;
            wezUrlop1.Location = new Point(347, 32);
            wezUrlop1.Margin = new Padding(4);
            wezUrlop1.Name = "wezUrlop1";
            wezUrlop1.Size = new Size(640, 520);
            wezUrlop1.TabIndex = 2;
            // 
            // twojaHistoria1
            // 
            twojaHistoria1.BackColor = SystemColors.GradientInactiveCaption;
            twojaHistoria1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            twojaHistoria1.Id_pracownika = 0;
            twojaHistoria1.Location = new Point(348, 32);
            twojaHistoria1.Margin = new Padding(4);
            twojaHistoria1.Name = "twojaHistoria1";
            twojaHistoria1.Size = new Size(640, 520);
            twojaHistoria1.TabIndex = 3;
            // 
            // wnioskiUrla1
            // 
            wnioskiUrla1.BackColor = SystemColors.GradientInactiveCaption;
            wnioskiUrla1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            wnioskiUrla1.Location = new Point(348, 32);
            wnioskiUrla1.Margin = new Padding(4);
            wnioskiUrla1.Name = "wnioskiUrla1";
            wnioskiUrla1.Size = new Size(640, 520);
            wnioskiUrla1.TabIndex = 4;
            // 
            // historiaUrla1
            // 
            historiaUrla1.BackColor = SystemColors.GradientInactiveCaption;
            historiaUrla1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            historiaUrla1.Location = new Point(348, 32);
            historiaUrla1.Margin = new Padding(4);
            historiaUrla1.Name = "historiaUrla1";
            historiaUrla1.Size = new Size(640, 520);
            historiaUrla1.TabIndex = 5;
            // 
            // listaPracownikowa1
            // 
            listaPracownikowa1.BackColor = SystemColors.GradientInactiveCaption;
            listaPracownikowa1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listaPracownikowa1.Location = new Point(347, 32);
            listaPracownikowa1.Margin = new Padding(4);
            listaPracownikowa1.Name = "listaPracownikowa1";
            listaPracownikowa1.Size = new Size(640, 520);
            listaPracownikowa1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1000, 563);
            Controls.Add(listaPracownikowa1);
            Controls.Add(historiaUrla1);
            Controls.Add(wnioskiUrla1);
            Controls.Add(twojaHistoria1);
            Controls.Add(wezUrlop1);
            Controls.Add(label_zamknij);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_zamknij;
        private Button button_urlop;
        private Label label_name;
        private Label label_witaj;
        private Button button_wyloguj;
        private Button button_AhistoriaUrl;
        private Button button_AlistaPracownikow;
        private Button button_AwnioskiUrl;
        private Button button_twojaHistoria;
        private WezUrlop wezUrlop1;
        private TwojaHistoria twojaHistoria1;
        private wnioskiUrlA wnioskiUrla1;
        private historiaUrlA historiaUrla1;
        private listaPracownikowA listaPracownikowa1;
    }
}