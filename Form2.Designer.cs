namespace proyecto
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
            buttonlogin = new Button();
            textBoxcontraseña = new TextBox();
            textBoxcuenta = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonloggout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = SystemColors.ActiveCaptionText;
            buttonlogin.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonlogin.ForeColor = Color.Snow;
            buttonlogin.Location = new Point(280, 330);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(240, 47);
            buttonlogin.TabIndex = 14;
            buttonlogin.Text = "LOGIN";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // textBoxcontraseña
            // 
            textBoxcontraseña.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcontraseña.Location = new Point(280, 297);
            textBoxcontraseña.Name = "textBoxcontraseña";
            textBoxcontraseña.PlaceholderText = "Contraseña";
            textBoxcontraseña.Size = new Size(240, 27);
            textBoxcontraseña.TabIndex = 13;
            // 
            // textBoxcuenta
            // 
            textBoxcuenta.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxcuenta.Location = new Point(280, 255);
            textBoxcuenta.Name = "textBoxcuenta";
            textBoxcuenta.PlaceholderText = "Someone@gmail.com";
            textBoxcuenta.Size = new Size(240, 27);
            textBoxcuenta.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 195);
            label2.Name = "label2";
            label2.Size = new Size(282, 32);
            label2.TabIndex = 10;
            label2.Text = "“SWIFT. SMART. RELIABLE”";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.LOGO_CHIQUITO;
            pictureBox1.Location = new Point(280, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 12);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 8;
            label1.Text = "MERCURIO";
            // 
            // buttonloggout
            // 
            buttonloggout.BackColor = SystemColors.ActiveCaptionText;
            buttonloggout.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonloggout.ForeColor = Color.Red;
            buttonloggout.Location = new Point(280, 383);
            buttonloggout.Name = "buttonloggout";
            buttonloggout.Size = new Size(240, 47);
            buttonloggout.TabIndex = 15;
            buttonloggout.Text = "LOGGOUT";
            buttonloggout.UseVisualStyleBackColor = false;
            buttonloggout.Click += buttonloggout_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonloggout);
            Controls.Add(buttonlogin);
            Controls.Add(textBoxcontraseña);
            Controls.Add(textBoxcuenta);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonlogin;
        private TextBox textBoxcontraseña;
        private TextBox textBoxcuenta;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonloggout;
    }
}