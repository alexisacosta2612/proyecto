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
            SuspendLayout();
            // 
            // txtProd
            // 
            txtProd.Location = new Point(171, 234);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(75, 23);
            txtProd.TabIndex = 18;
            txtProd.TextChanged += txtProd_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(171, 263);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 20;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblfoto
            // 
            lblfoto.BackColor = Color.Transparent;
            lblfoto.ImageList = imglfotos;
            lblfoto.Location = new Point(130, 237);
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
            buttonVer.Location = new Point(12, 292);
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
            buttonAgregar.Location = new Point(151, 292);
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
            label1.Location = new Point(82, 266);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 21;
            label1.Text = "CANTIDAD ->";
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = SystemColors.ControlDarkDark;
            buttonPagar.Location = new Point(323, 292);
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
            label2.Location = new Point(73, 17);
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
            label3.Location = new Point(548, 17);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 24;
            label3.Text = "Productos añadidos";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.SlateGray;
            richTextBox1.Location = new Point(12, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(386, 166);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.LightSlateGray;
            richTextBox2.Location = new Point(440, 48);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(371, 166);
            richTextBox2.TabIndex = 26;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // Formventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(848, 363);
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
    }
}