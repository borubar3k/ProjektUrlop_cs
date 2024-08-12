namespace ProjektUrlop
{
    partial class listaPracownikowA
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaPracownikowA));
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            imieNazwisko = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dataZatr = new DataGridViewTextBoxColumn();
            admin = new DataGridViewTextBoxColumn();
            button_zarch = new Button();
            button_usun = new Button();
            button_dodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, imieNazwisko, email, dataZatr, admin });
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            // 
            // Id
            // 
            resources.ApplyResources(Id, "Id");
            Id.Name = "Id";
            // 
            // imieNazwisko
            // 
            imieNazwisko.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(imieNazwisko, "imieNazwisko");
            imieNazwisko.Name = "imieNazwisko";
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(email, "email");
            email.Name = "email";
            // 
            // dataZatr
            // 
            dataZatr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(dataZatr, "dataZatr");
            dataZatr.Name = "dataZatr";
            // 
            // admin
            // 
            resources.ApplyResources(admin, "admin");
            admin.Name = "admin";
            // 
            // button_zarch
            // 
            resources.ApplyResources(button_zarch, "button_zarch");
            button_zarch.Name = "button_zarch";
            button_zarch.UseVisualStyleBackColor = true;
            button_zarch.Click += button_zarch_Click;
            // 
            // button_usun
            // 
            resources.ApplyResources(button_usun, "button_usun");
            button_usun.Name = "button_usun";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_dodaj
            // 
            resources.ApplyResources(button_dodaj, "button_dodaj");
            button_dodaj.Name = "button_dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // listaPracownikowA
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(button_dodaj);
            Controls.Add(button_usun);
            Controls.Add(button_zarch);
            Controls.Add(dataGridView1);
            Name = "listaPracownikowA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_zarch;
        private Button button_usun;
        private Button button_dodaj;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn imieNazwisko;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dataZatr;
        private DataGridViewTextBoxColumn admin;
    }
}
