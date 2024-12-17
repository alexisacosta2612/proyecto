namespace proyecto
{
    partial class Formventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formventa));
            txtProd = new TextBox();
            txtCantidad = new TextBox();
            lblfoto = new Label();
            imglfotos = new ImageList(components);
            buttonVer = new Button();
            buttonAgregar = new Button();
            label1 = new Label();
            buttonPagar = new Button();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            panel1 = new Panel();
            buttonfm2 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            labelfecha = new Label();
            labelhora = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtProd
            // 
            txtProd.Location = new Point(375, 312);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(75, 23);
            txtProd.TabIndex = 18;
            txtProd.TextChanged += txtProd_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(375, 341);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 20;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblfoto
            // 
            lblfoto.BackColor = Color.Transparent;
            lblfoto.ImageList = imglfotos;
            lblfoto.Location = new Point(334, 315);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(35, 21);
            lblfoto.TabIndex = 12;
            lblfoto.Text = "ID ->";
            // 
            // imglfotos
            // 
            imglfotos.ColorDepth = ColorDepth.Depth32Bit;
            imglfotos.ImageStream = (ImageListStreamer)resources.GetObject("imglfotos.ImageStream");
            imglfotos.TransparentColor = Color.Transparent;
            imglfotos.Images.SetKeyName(0, "teniis.jpg");
            imglfotos.Images.SetKeyName(1, "chachucha.jpg");
            imglfotos.Images.SetKeyName(2, "chamarra.jpg");
            imglfotos.Images.SetKeyName(3, "pantalon.jpg");
            imglfotos.Images.SetKeyName(4, "pants.jpg");
            imglfotos.Images.SetKeyName(5, "playera.jpg");
            // 
            // buttonVer
            // 
            buttonVer.BackColor = SystemColors.ControlDarkDark;
            buttonVer.Location = new Point(216, 370);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(105, 23);
            buttonVer.TabIndex = 13;
            buttonVer.Text = "Ver Productos";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += btnAgregarCarrito_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = SystemColors.ControlDarkDark;
            buttonAgregar.Location = new Point(355, 370);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(109, 23);
            buttonAgregar.TabIndex = 14;
            buttonAgregar.Text = "Agregar Producto";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += btnQuitarDelCarrito_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(286, 344);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 21;
            label1.Text = "CANTIDAD ->";
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = SystemColors.ControlDarkDark;
            buttonPagar.Location = new Point(525, 372);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(75, 23);
            buttonPagar.TabIndex = 22;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(214, 88);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 23;
            label2.Text = "Productos de la base de datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(547, 88);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 24;
            label3.Text = "Productos añadidos";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ButtonHighlight;
            richTextBox1.Location = new Point(214, 119);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(386, 166);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ButtonHighlight;
            richTextBox2.Location = new Point(651, 119);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(371, 166);
            richTextBox2.TabIndex = 26;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaptionText;
            panel1.Controls.Add(buttonfm2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 473);
            panel1.TabIndex = 27;
            // 
            // buttonfm2
            // 
            buttonfm2.BackColor = SystemColors.GrayText;
            buttonfm2.FlatStyle = FlatStyle.Popup;
            buttonfm2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonfm2.ForeColor = Color.LightGreen;
            buttonfm2.Location = new Point(3, 321);
            buttonfm2.Name = "buttonfm2";
            buttonfm2.Size = new Size(191, 53);
            buttonfm2.TabIndex = 39;
            buttonfm2.Text = "VOLVER A PANTALLA DE ACCESO";
            buttonfm2.UseVisualStyleBackColor = false;
            buttonfm2.Click += buttonfm2_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.PaleGoldenrod;
            button4.Location = new Point(6, 235);
            button4.Name = "button4";
            button4.Size = new Size(191, 53);
            button4.TabIndex = 38;
            button4.Text = "PANTALLA DE AMINISTRADOR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelfecha);
            panel2.Controls.Add(labelhora);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 237);
            panel2.TabIndex = 28;
            // 
            // labelfecha
            // 
            labelfecha.AutoSize = true;
            labelfecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfecha.ForeColor = Color.Cyan;
            labelfecha.Location = new Point(74, 163);
            labelfecha.Name = "labelfecha";
            labelfecha.Size = new Size(52, 21);
            labelfecha.TabIndex = 28;
            labelfecha.Text = "label4";
            // 
            // labelhora
            // 
            labelhora.AutoSize = true;
            labelhora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelhora.ForeColor = Color.Cyan;
            labelhora.Location = new Point(74, 129);
            labelhora.Name = "labelhora";
            labelhora.Size = new Size(52, 21);
            labelhora.TabIndex = 29;
            labelhora.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.LOGO_CHIQUITO;
            pictureBox1.Image = Properties.Resources.LLOGO_CHIQUITO1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(203, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 57);
            panel3.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Unicode MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(380, 9);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 29;
            label4.Text = "clothesport";
            // 
            // Formventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1053, 523);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonPagar);
            Controls.Add(label1);
            Controls.Add(buttonAgregar);
            Controls.Add(txtProd);
            Controls.Add(buttonVer);
            Controls.Add(txtCantidad);
            Controls.Add(lblfoto);
            Name = "Formventa";
            Text = "Formventa";
            Load += Formventa_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imglfotos;
        private Label lblfoto;
        private Button buttonVer;
        private Button buttonAgregar;
        private TextBox txtProd;
        private TextBox txtCantidad;
        private Label label1;
        private Button buttonPagar;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Label labelfecha;
        private Label labelhora;
        private Button button4;
        private Button buttonfm2;
        private Panel panel3;
        private Label label4;
    }
}