namespace ProjektUrlop
{
    partial class TwojaHistoria
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
            dataGridView1 = new DataGridView();
            dataOd = new DataGridViewTextBoxColumn();
            dataDo = new DataGridViewTextBoxColumn();
            liczbaDni = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataOd, dataDo, liczbaDni });
            dataGridView1.Location = new Point(15, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(609, 485);
            dataGridView1.TabIndex = 0;
            // 
            // dataOd
            // 
            dataOd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataOd.HeaderText = "data rozpoczecia";
            dataOd.Name = "dataOd";
            // 
            // dataDo
            // 
            dataDo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataDo.HeaderText = "data zakończenia";
            dataDo.Name = "dataDo";
            // 
            // liczbaDni
            // 
            liczbaDni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            liczbaDni.HeaderText = "liczba dni";
            liczbaDni.Name = "liczbaDni";
            // 
            // TwojaHistoria
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "TwojaHistoria";
            Size = new Size(640, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataOd;
        private DataGridViewTextBoxColumn dataDo;
        private DataGridViewTextBoxColumn liczbaDni;
    }
}
