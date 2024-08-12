namespace ProjektUrlop
{
    partial class historiaUrlA
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
            textBox_szukaj = new TextBox();
            button_szukaj = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            imieNazwisko = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dataUrl = new DataGridViewTextBoxColumn();
            dniUrl = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_szukaj
            // 
            textBox_szukaj.Location = new Point(19, 3);
            textBox_szukaj.Name = "textBox_szukaj";
            textBox_szukaj.Size = new Size(530, 26);
            textBox_szukaj.TabIndex = 1;
            // 
            // button_szukaj
            // 
            button_szukaj.Location = new Point(555, 2);
            button_szukaj.Name = "button_szukaj";
            button_szukaj.Size = new Size(71, 26);
            button_szukaj.TabIndex = 2;
            button_szukaj.Text = "Szukaj";
            button_szukaj.UseVisualStyleBackColor = true;
            button_szukaj.Click += button_szukaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, imieNazwisko, email, dataUrl, dniUrl });
            dataGridView1.Location = new Point(19, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 482);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // imieNazwisko
            // 
            imieNazwisko.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imieNazwisko.HeaderText = "imie i nazwisko";
            imieNazwisko.Name = "imieNazwisko";
            // 
            // email
            // 
            email.FillWeight = 80F;
            email.HeaderText = "e-mail";
            email.Name = "email";
            email.Width = 154;
            // 
            // dataUrl
            // 
            dataUrl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataUrl.HeaderText = "data urlopu";
            dataUrl.Name = "dataUrl";
            // 
            // dniUrl
            // 
            dniUrl.HeaderText = "dni urlopu";
            dniUrl.Name = "dniUrl";
            dniUrl.Width = 50;
            // 
            // historiaUrlA
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(button_szukaj);
            Controls.Add(textBox_szukaj);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "historiaUrlA";
            Size = new Size(640, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_szukaj;
        private Button button_szukaj;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn imieNazwisko;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dataUrl;
        private DataGridViewTextBoxColumn dniUrl;
    }
}
