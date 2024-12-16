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
            panel1 = new Panel();
            lblfoto = new Label();
            imglfotos = new ImageList(components);
            dataGridView1 = new DataGridView();
            dataGridViewCarrito = new DataGridView();
            btnAgregarCarrito = new Button();
            btnQuitarDelCarrito = new Button();
            lblTotal = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(lblfoto);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 483);
            panel1.TabIndex = 10;
            // 
            // lblfoto
            // 
            lblfoto.ImageList = imglfotos;
            lblfoto.Location = new Point(76, 10);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(100, 96);
            lblfoto.TabIndex = 12;
            lblfoto.Text = "label1";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(244, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(360, 182);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Location = new Point(655, 46);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.Size = new Size(373, 182);
            dataGridViewCarrito.TabIndex = 12;
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(655, 283);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(75, 23);
            btnAgregarCarrito.TabIndex = 13;
            btnAgregarCarrito.Text = "button1";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // btnQuitarDelCarrito
            // 
            btnQuitarDelCarrito.Location = new Point(795, 282);
            btnQuitarDelCarrito.Name = "btnQuitarDelCarrito";
            btnQuitarDelCarrito.Size = new Size(75, 23);
            btnQuitarDelCarrito.TabIndex = 14;
            btnQuitarDelCarrito.Text = "button2";
            btnQuitarDelCarrito.UseVisualStyleBackColor = true;
            btnQuitarDelCarrito.Click += btnQuitarDelCarrito_Click;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(876, 283);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(50, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 135);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 20;
            // 
            // Formventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 481);
            Controls.Add(lblTotal);
            Controls.Add(btnQuitarDelCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(dataGridViewCarrito);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Formventa";
            Text = "Formventa";
            Load += Formventa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private ImageList imglfotos;
        private Label lblfoto;
        private DataGridView dataGridViewCarrito;
        private Button btnAgregarCarrito;
        private Button btnQuitarDelCarrito;
        private TextBox lblTotal;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}