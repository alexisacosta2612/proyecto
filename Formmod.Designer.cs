namespace proyecto
{
    partial class Formmod
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
            textBoxmodid = new TextBox();
            textBoxidmod = new TextBox();
            textBoxpdmod = new TextBox();
            textBoxnamepicturemod = new TextBox();
            textBoxpricemod = new TextBox();
            textBoxstockmod = new TextBox();
            buttonseedatamod = new Button();
            buttonmod = new Button();
            SuspendLayout();
            // 
            // textBoxmodid
            // 
            textBoxmodid.BackColor = Color.FromArgb(37, 42, 74);
            textBoxmodid.ForeColor = Color.Cyan;
            textBoxmodid.Location = new Point(185, 38);
            textBoxmodid.Multiline = true;
            textBoxmodid.Name = "textBoxmodid";
            textBoxmodid.PlaceholderText = "Id ";
            textBoxmodid.Size = new Size(139, 43);
            textBoxmodid.TabIndex = 0;
            // 
            // textBoxidmod
            // 
            textBoxidmod.BackColor = Color.FromArgb(37, 42, 74);
            textBoxidmod.ForeColor = Color.Cyan;
            textBoxidmod.Location = new Point(185, 88);
            textBoxidmod.Multiline = true;
            textBoxidmod.Name = "textBoxidmod";
            textBoxidmod.PlaceholderText = "nuevo id";
            textBoxidmod.Size = new Size(139, 43);
            textBoxidmod.TabIndex = 1;
            // 
            // textBoxpdmod
            // 
            textBoxpdmod.BackColor = Color.FromArgb(37, 42, 74);
            textBoxpdmod.ForeColor = Color.Cyan;
            textBoxpdmod.Location = new Point(185, 188);
            textBoxpdmod.Multiline = true;
            textBoxpdmod.Name = "textBoxpdmod";
            textBoxpdmod.PlaceholderText = "new product description";
            textBoxpdmod.Size = new Size(139, 43);
            textBoxpdmod.TabIndex = 2;
            // 
            // textBoxnamepicturemod
            // 
            textBoxnamepicturemod.BackColor = Color.FromArgb(37, 42, 74);
            textBoxnamepicturemod.ForeColor = Color.Cyan;
            textBoxnamepicturemod.Location = new Point(185, 137);
            textBoxnamepicturemod.Multiline = true;
            textBoxnamepicturemod.Name = "textBoxnamepicturemod";
            textBoxnamepicturemod.PlaceholderText = "new name product";
            textBoxnamepicturemod.Size = new Size(139, 43);
            textBoxnamepicturemod.TabIndex = 3;
            // 
            // textBoxpricemod
            // 
            textBoxpricemod.BackColor = Color.FromArgb(37, 42, 74);
            textBoxpricemod.ForeColor = Color.Cyan;
            textBoxpricemod.Location = new Point(185, 237);
            textBoxpricemod.Multiline = true;
            textBoxpricemod.Name = "textBoxpricemod";
            textBoxpricemod.PlaceholderText = "new price";
            textBoxpricemod.Size = new Size(139, 43);
            textBoxpricemod.TabIndex = 4;
            // 
            // textBoxstockmod
            // 
            textBoxstockmod.BackColor = Color.FromArgb(37, 42, 74);
            textBoxstockmod.ForeColor = Color.Cyan;
            textBoxstockmod.Location = new Point(185, 286);
            textBoxstockmod.Multiline = true;
            textBoxstockmod.Name = "textBoxstockmod";
            textBoxstockmod.PlaceholderText = "new stock";
            textBoxstockmod.Size = new Size(139, 43);
            textBoxstockmod.TabIndex = 5;
            // 
            // buttonseedatamod
            // 
            buttonseedatamod.FlatStyle = FlatStyle.Popup;
            buttonseedatamod.ForeColor = Color.FromArgb(255, 255, 128);
            buttonseedatamod.Location = new Point(330, 38);
            buttonseedatamod.Name = "buttonseedatamod";
            buttonseedatamod.Size = new Size(156, 43);
            buttonseedatamod.TabIndex = 6;
            buttonseedatamod.Text = "MOSTRAR DATOS";
            buttonseedatamod.UseVisualStyleBackColor = true;
            buttonseedatamod.Click += buttonseedatamod_Click;
            // 
            // buttonmod
            // 
            buttonmod.FlatStyle = FlatStyle.Popup;
            buttonmod.ForeColor = Color.Cyan;
            buttonmod.Location = new Point(185, 335);
            buttonmod.Name = "buttonmod";
            buttonmod.Size = new Size(139, 48);
            buttonmod.TabIndex = 7;
            buttonmod.Text = "MODIFICAR";
            buttonmod.UseVisualStyleBackColor = true;
            buttonmod.Click += buttonmod_Click;
            // 
            // Formmod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(590, 506);
            Controls.Add(buttonmod);
            Controls.Add(buttonseedatamod);
            Controls.Add(textBoxstockmod);
            Controls.Add(textBoxpricemod);
            Controls.Add(textBoxnamepicturemod);
            Controls.Add(textBoxpdmod);
            Controls.Add(textBoxidmod);
            Controls.Add(textBoxmodid);
            Name = "Formmod";
            Text = "Formmod";
            Load += Formmod_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxmodid;
        private TextBox textBoxidmod;
        private TextBox textBoxpdmod;
        private TextBox textBoxnamepicturemod;
        private TextBox textBoxpricemod;
        private TextBox textBoxstockmod;
        private Button buttonseedatamod;
        private Button buttonmod;
    }
}