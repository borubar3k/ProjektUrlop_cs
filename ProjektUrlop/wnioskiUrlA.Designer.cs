namespace ProjektUrlop
{
    partial class wnioskiUrlA
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
            button_odrzuc = new Button();
            button_zaakceptuj = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            imieNazwisko = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dniUrl = new DataGridViewTextBoxColumn();
            dataUrl = new DataGridViewTextBoxColumn();
            dniUrl2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_odrzuc
            // 
            button_odrzuc.Location = new Point(530, 483);
            button_odrzuc.Name = "button_odrzuc";
            button_odrzuc.Size = new Size(107, 34);
            button_odrzuc.TabIndex = 1;
            button_odrzuc.Text = "Odrzuć";
            button_odrzuc.UseVisualStyleBackColor = true;
            button_odrzuc.Click += button_odrzuc_Click;
            // 
            // button_zaakceptuj
            // 
            button_zaakceptuj.Location = new Point(417, 483);
            button_zaakceptuj.Name = "button_zaakceptuj";
            button_zaakceptuj.Size = new Size(107, 34);
            button_zaakceptuj.TabIndex = 2;
            button_zaakceptuj.Text = "Zaakceptuj";
            button_zaakceptuj.UseVisualStyleBackColor = true;
            button_zaakceptuj.Click += button_zaakceptuj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, imieNazwisko, email, dniUrl, dataUrl, dniUrl2 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 474);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // imieNazwisko
            // 
            imieNazwisko.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imieNazwisko.HeaderText = "imię i nazwisko";
            imieNazwisko.Name = "imieNazwisko";
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "e-mail";
            email.Name = "email";
            // 
            // dniUrl
            // 
            dniUrl.HeaderText = "dostępny urlop";
            dniUrl.Name = "dniUrl";
            // 
            // dataUrl
            // 
            dataUrl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataUrl.HeaderText = "data urlopu";
            dataUrl.Name = "dataUrl";
            // 
            // dniUrl2
            // 
            dniUrl2.HeaderText = "wniosk. urlop";
            dniUrl2.Name = "dniUrl2";
            // 
            // wnioskiUrlA
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(button_zaakceptuj);
            Controls.Add(button_odrzuc);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "wnioskiUrlA";
            Size = new Size(640, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_odrzuc;
        private Button button_zaakceptuj;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn imieNazwisko;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dniUrl;
        private DataGridViewTextBoxColumn dataUrl;
        private DataGridViewTextBoxColumn dniUrl2;
    }
}
