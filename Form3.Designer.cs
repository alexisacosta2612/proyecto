namespace proyecto
{
    partial class Form3
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
            button1 = new Button();
            txtCuenta = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(236, 197);
            button1.Name = "button1";
            button1.Size = new Size(110, 43);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(236, 81);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(110, 23);
            txtCuenta.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(236, 127);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(110, 23);
            txtContrasena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 31);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 3;
            label1.Text = "AUTENTIFICACION DE USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Cuenta ->";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 135);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña ->";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 274);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtCuenta);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtCuenta;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}