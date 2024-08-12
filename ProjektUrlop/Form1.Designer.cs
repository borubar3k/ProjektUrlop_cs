namespace ProjektUrlop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_screen = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_x = new Label();
            label_zaloguj = new Label();
            label_email = new Label();
            label_haslo = new Label();
            textBox_email = new TextBox();
            textBox_haslo = new TextBox();
            button_zaloguj = new Button();
            checkBox_pokaHaslo = new CheckBox();
            panel_screen.SuspendLayout();
            SuspendLayout();
            // 
            // panel_screen
            // 
            panel_screen.BackColor = SystemColors.HotTrack;
            panel_screen.Controls.Add(label3);
            panel_screen.Controls.Add(label2);
            panel_screen.Controls.Add(label1);
            panel_screen.Dock = DockStyle.Left;
            panel_screen.ForeColor = SystemColors.ControlText;
            panel_screen.Location = new Point(0, 0);
            panel_screen.Name = "panel_screen";
            panel_screen.Size = new Size(350, 428);
            panel_screen.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(107, 115);
            label3.Name = "label3";
            label3.Size = new Size(202, 37);
            label3.TabIndex = 2;
            label3.Text = "Zarządzania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(153, 152);
            label2.Name = "label2";
            label2.Size = new Size(156, 37);
            label2.TabIndex = 1;
            label2.Text = "Urlopami";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(179, 78);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "System";
            // 
            // label_x
            // 
            label_x.AutoSize = true;
            label_x.Location = new Point(771, 9);
            label_x.Name = "label_x";
            label_x.Size = new Size(18, 19);
            label_x.TabIndex = 1;
            label_x.Text = "x";
            label_x.Click += label_x_Click;
            // 
            // label_zaloguj
            // 
            label_zaloguj.AutoSize = true;
            label_zaloguj.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_zaloguj.Location = new Point(601, 78);
            label_zaloguj.Name = "label_zaloguj";
            label_zaloguj.Size = new Size(158, 32);
            label_zaloguj.TabIndex = 2;
            label_zaloguj.Text = "Logowanie";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_email.Location = new Point(459, 166);
            label_email.Name = "label_email";
            label_email.Size = new Size(54, 19);
            label_email.TabIndex = 3;
            label_email.Text = "e-mail";
            // 
            // label_haslo
            // 
            label_haslo.AutoSize = true;
            label_haslo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_haslo.Location = new Point(459, 239);
            label_haslo.Name = "label_haslo";
            label_haslo.Size = new Size(51, 19);
            label_haslo.TabIndex = 4;
            label_haslo.Text = "hasło";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(459, 188);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(301, 26);
            textBox_email.TabIndex = 5;
            // 
            // textBox_haslo
            // 
            textBox_haslo.Location = new Point(459, 261);
            textBox_haslo.Name = "textBox_haslo";
            textBox_haslo.PasswordChar = '*';
            textBox_haslo.Size = new Size(301, 26);
            textBox_haslo.TabIndex = 6;
            // 
            // button_zaloguj
            // 
            button_zaloguj.Location = new Point(459, 318);
            button_zaloguj.Name = "button_zaloguj";
            button_zaloguj.Size = new Size(159, 46);
            button_zaloguj.TabIndex = 7;
            button_zaloguj.Text = "Zaloguj się";
            button_zaloguj.UseVisualStyleBackColor = true;
            button_zaloguj.Click += button_zaloguj_Click;
            // 
            // checkBox_pokaHaslo
            // 
            checkBox_pokaHaslo.AutoSize = true;
            checkBox_pokaHaslo.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBox_pokaHaslo.Location = new Point(658, 293);
            checkBox_pokaHaslo.Name = "checkBox_pokaHaslo";
            checkBox_pokaHaslo.Size = new Size(102, 20);
            checkBox_pokaHaslo.TabIndex = 8;
            checkBox_pokaHaslo.Text = "pokaż hasło";
            checkBox_pokaHaslo.UseVisualStyleBackColor = true;
            checkBox_pokaHaslo.CheckedChanged += checkBox_pokaHaslo_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 428);
            Controls.Add(checkBox_pokaHaslo);
            Controls.Add(button_zaloguj);
            Controls.Add(textBox_haslo);
            Controls.Add(textBox_email);
            Controls.Add(label_haslo);
            Controls.Add(label_email);
            Controls.Add(label_zaloguj);
            Controls.Add(label_x);
            Controls.Add(panel_screen);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zarządzanie urlopami - logowanie";
            panel_screen.ResumeLayout(false);
            panel_screen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_screen;
        private Label label_x;
        private Label label_zaloguj;
        private Label label_email;
        private Label label_haslo;
        private TextBox textBox_email;
        private TextBox textBox_haslo;
        private Button button_zaloguj;
        private CheckBox checkBox_pokaHaslo;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
