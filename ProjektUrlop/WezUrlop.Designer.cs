namespace ProjektUrlop
{
    partial class WezUrlop
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
            label_dostwolne = new Label();
            label_dniUrl = new Label();
            label_dataOD = new Label();
            label_dataDO = new Label();
            dateTimePicker_dataOD = new DateTimePicker();
            dateTimePicker_dataDO = new DateTimePicker();
            button_zalozWniosek = new Button();
            SuspendLayout();
            // 
            // label_dostwolne
            // 
            label_dostwolne.AutoSize = true;
            label_dostwolne.Location = new Point(200, 132);
            label_dostwolne.Name = "label_dostwolne";
            label_dostwolne.Size = new Size(171, 19);
            label_dostwolne.TabIndex = 0;
            label_dostwolne.Text = "Dostępne dni urlopu:";
            // 
            // label_dniUrl
            // 
            label_dniUrl.AutoSize = true;
            label_dniUrl.Font = new Font("Arial", 72F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_dniUrl.ForeColor = Color.ForestGreen;
            label_dniUrl.Location = new Point(377, 83);
            label_dniUrl.Name = "label_dniUrl";
            label_dniUrl.Size = new Size(98, 107);
            label_dniUrl.TabIndex = 1;
            label_dniUrl.Text = "0";
            // 
            // label_dataOD
            // 
            label_dataOD.AutoSize = true;
            label_dataOD.Location = new Point(94, 282);
            label_dataOD.Name = "label_dataOD";
            label_dataOD.Size = new Size(202, 19);
            label_dataOD.TabIndex = 2;
            label_dataOD.Text = "Data rozpoczecia urlopu:";
            // 
            // label_dataDO
            // 
            label_dataDO.AutoSize = true;
            label_dataDO.Location = new Point(94, 325);
            label_dataDO.Name = "label_dataDO";
            label_dataDO.Size = new Size(205, 19);
            label_dataDO.TabIndex = 3;
            label_dataDO.Text = "Data zakończenia urlopu:";
            // 
            // dateTimePicker_dataOD
            // 
            dateTimePicker_dataOD.Format = DateTimePickerFormat.Short;
            dateTimePicker_dataOD.Location = new Point(338, 276);
            dateTimePicker_dataOD.Name = "dateTimePicker_dataOD";
            dateTimePicker_dataOD.Size = new Size(200, 26);
            dateTimePicker_dataOD.TabIndex = 4;
            // 
            // dateTimePicker_dataDO
            // 
            dateTimePicker_dataDO.Format = DateTimePickerFormat.Short;
            dateTimePicker_dataDO.Location = new Point(338, 319);
            dateTimePicker_dataDO.Name = "dateTimePicker_dataDO";
            dateTimePicker_dataDO.Size = new Size(200, 26);
            dateTimePicker_dataDO.TabIndex = 5;
            // 
            // button_zalozWniosek
            // 
            button_zalozWniosek.Location = new Point(338, 363);
            button_zalozWniosek.Name = "button_zalozWniosek";
            button_zalozWniosek.Size = new Size(200, 39);
            button_zalozWniosek.TabIndex = 6;
            button_zalozWniosek.Text = "Złóż wniosek";
            button_zalozWniosek.UseVisualStyleBackColor = true;
            button_zalozWniosek.Click += button_zalozWniosek_Click;
            // 
            // WezUrlop
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(button_zalozWniosek);
            Controls.Add(dateTimePicker_dataDO);
            Controls.Add(dateTimePicker_dataOD);
            Controls.Add(label_dataDO);
            Controls.Add(label_dataOD);
            Controls.Add(label_dniUrl);
            Controls.Add(label_dostwolne);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "WezUrlop";
            Size = new Size(640, 520);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_dostwolne;
        private Label label_dniUrl;
        private Label label_dataOD;
        private Label label_dataDO;
        private DateTimePicker dateTimePicker_dataOD;
        private DateTimePicker dateTimePicker_dataDO;
        private Button button_zalozWniosek;
    }
}
