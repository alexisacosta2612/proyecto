﻿namespace proyecto
{
    partial class Formadmin
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
            components = new System.ComponentModel.Container();
            buttonRefrescar = new Button();
            textBoxiddelete = new TextBox();
            buttondelete = new Button();
            richTextBox1 = new RichTextBox();
            buttonAGREGAR = new Button();
            buttonMODIFICAR = new Button();
            richTextBox2 = new RichTextBox();
            button1morestock = new Button();
            panel1 = new Panel();
            labeladmin = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            textBoxtotalvntas = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelhora = new Label();
            labelfecha = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.FlatStyle = FlatStyle.Popup;
            buttonRefrescar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRefrescar.ForeColor = SystemColors.ControlDark;
            buttonRefrescar.Location = new Point(206, 24);
            buttonRefrescar.Margin = new Padding(3, 2, 3, 2);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(230, 34);
            buttonRefrescar.TabIndex = 11;
            buttonRefrescar.Text = "REFRESCAR";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // textBoxiddelete
            // 
            textBoxiddelete.AccessibleName = "";
            textBoxiddelete.BackColor = Color.FromArgb(37, 42, 74);
            textBoxiddelete.BorderStyle = BorderStyle.None;
            textBoxiddelete.ForeColor = Color.Cyan;
            textBoxiddelete.Location = new Point(26, 261);
            textBoxiddelete.Multiline = true;
            textBoxiddelete.Name = "textBoxiddelete";
            textBoxiddelete.PlaceholderText = "ID A ELIMINAR:";
            textBoxiddelete.Size = new Size(147, 43);
            textBoxiddelete.TabIndex = 31;
            textBoxiddelete.TextChanged += textBoxiddelete_TextChanged;
            // 
            // buttondelete
            // 
            buttondelete.FlatStyle = FlatStyle.Flat;
            buttondelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttondelete.ForeColor = Color.Red;
            buttondelete.Location = new Point(26, 310);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(147, 47);
            buttondelete.TabIndex = 32;
            buttondelete.Text = "ELIMINAR";
            buttondelete.UseVisualStyleBackColor = true;
            buttondelete.Click += buttondelete_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(37, 42, 74);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Cyan;
            richTextBox1.Location = new Point(206, 86);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(420, 230);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // buttonAGREGAR
            // 
            buttonAGREGAR.FlatStyle = FlatStyle.Popup;
            buttonAGREGAR.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAGREGAR.ForeColor = Color.Cyan;
            buttonAGREGAR.Location = new Point(26, 208);
            buttonAGREGAR.Name = "buttonAGREGAR";
            buttonAGREGAR.Size = new Size(147, 47);
            buttonAGREGAR.TabIndex = 33;
            buttonAGREGAR.Text = "AGREGAR REGISTRO";
            buttonAGREGAR.UseVisualStyleBackColor = true;
            buttonAGREGAR.Click += button1_Click;
            // 
            // buttonMODIFICAR
            // 
            buttonMODIFICAR.FlatStyle = FlatStyle.Popup;
            buttonMODIFICAR.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMODIFICAR.ForeColor = Color.Cyan;
            buttonMODIFICAR.Location = new Point(26, 155);
            buttonMODIFICAR.Name = "buttonMODIFICAR";
            buttonMODIFICAR.Size = new Size(147, 47);
            buttonMODIFICAR.TabIndex = 34;
            buttonMODIFICAR.Text = "MODIFICAR REGISTRO";
            buttonMODIFICAR.UseVisualStyleBackColor = true;
            buttonMODIFICAR.Click += buttonMODIFICAR_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(37, 42, 74);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = Color.Cyan;
            richTextBox2.Location = new Point(665, 86);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(482, 230);
            richTextBox2.TabIndex = 35;
            richTextBox2.Text = "";
            // 
            // button1morestock
            // 
            button1morestock.FlatStyle = FlatStyle.Popup;
            button1morestock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1morestock.ForeColor = SystemColors.ControlDark;
            button1morestock.Location = new Point(665, 24);
            button1morestock.Name = "button1morestock";
            button1morestock.Size = new Size(381, 34);
            button1morestock.TabIndex = 36;
            button1morestock.Text = "EXISTENCIAS DE MAYOR A MENOR";
            button1morestock.UseVisualStyleBackColor = true;
            button1morestock.Click += button1morestock_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(labeladmin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonMODIFICAR);
            panel1.Controls.Add(textBoxiddelete);
            panel1.Controls.Add(buttondelete);
            panel1.Controls.Add(buttonAGREGAR);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 516);
            panel1.TabIndex = 37;
            // 
            // labeladmin
            // 
            labeladmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeladmin.ForeColor = Color.Cyan;
            labeladmin.Location = new Point(3, 95);
            labeladmin.Name = "labeladmin";
            labeladmin.Size = new Size(191, 54);
            labeladmin.TabIndex = 38;
            labeladmin.Text = "label1";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(3, 429);
            button1.Name = "button1";
            button1.Size = new Size(191, 53);
            button1.TabIndex = 36;
            button1.Text = "REGRESAR A LA PANTALLA PRINCIPAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(3, 459);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 100);
            panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.LOGO_CHIQUITO;
            pictureBox2.Location = new Point(243, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cyan;
            button3.Location = new Point(665, 348);
            button3.Name = "button3";
            button3.Size = new Size(202, 47);
            button3.TabIndex = 38;
            button3.Text = "TOTAL DE VENTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxtotalvntas
            // 
            textBoxtotalvntas.AccessibleName = "";
            textBoxtotalvntas.BackColor = Color.FromArgb(37, 42, 74);
            textBoxtotalvntas.BorderStyle = BorderStyle.None;
            textBoxtotalvntas.ForeColor = Color.Cyan;
            textBoxtotalvntas.Location = new Point(888, 348);
            textBoxtotalvntas.Multiline = true;
            textBoxtotalvntas.Name = "textBoxtotalvntas";
            textBoxtotalvntas.PlaceholderText = "TOTAL DE VENTAS:";
            textBoxtotalvntas.Size = new Size(147, 43);
            textBoxtotalvntas.TabIndex = 39;
            textBoxtotalvntas.TextChanged += textBoxtotalvntas_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelhora
            // 
            labelhora.AutoSize = true;
            labelhora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelhora.ForeColor = Color.Cyan;
            labelhora.Location = new Point(872, 394);
            labelhora.Name = "labelhora";
            labelhora.Size = new Size(52, 21);
            labelhora.TabIndex = 40;
            labelhora.Text = "label1";
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfecha.ForeColor = Color.Cyan;
            labelfecha.Location = new Point(872, 429);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(52, 21);
            labelfecha.TabIndex = 41;
            labelfecha.Text = "label2";
            // 
            // Formadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1256, 560);
            Controls.Add(labelfecha);
            Controls.Add(labelhora);
            Controls.Add(textBoxtotalvntas);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button1morestock);
            Controls.Add(richTextBox2);
            Controls.Add(buttonRefrescar);
            Controls.Add(richTextBox1);
            Controls.Add(panel3);
            Name = "Formadmin";
            Text = "Formadmin";
            Load += Formadmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRefrescar;
        private TextBox textBoxiddelete;
        private Button buttondelete;
        private RichTextBox richTextBox1;
        private Button buttonAGREGAR;
        private Button buttonMODIFICAR;
        private RichTextBox richTextBox2;
        private Button button1morestock;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button button3;
        private TextBox textBoxtotalvntas;
        private System.Windows.Forms.Timer timer1;
        private Label labelhora;
        private Label labelfecha;
        private Label labeladmin;
    }
}