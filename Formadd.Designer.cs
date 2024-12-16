namespace proyecto
{
    partial class Formadd
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
            textBoxstockadd = new TextBox();
            textBoxpriceadd = new TextBox();
            textBoxpdadd = new TextBox();
            textBoxnamepictureadd = new TextBox();
            textBoxidadd = new TextBox();
            buttonadd = new Button();
            SuspendLayout();
            // 
            // textBoxstockadd
            // 
            textBoxstockadd.BackColor = Color.FromArgb(37, 42, 74);
            textBoxstockadd.ForeColor = Color.Cyan;
            textBoxstockadd.Location = new Point(130, 329);
            textBoxstockadd.Multiline = true;
            textBoxstockadd.Name = "textBoxstockadd";
            textBoxstockadd.PlaceholderText = "stock";
            textBoxstockadd.Size = new Size(248, 49);
            textBoxstockadd.TabIndex = 50;
            // 
            // textBoxpriceadd
            // 
            textBoxpriceadd.BackColor = Color.FromArgb(37, 42, 74);
            textBoxpriceadd.ForeColor = Color.Cyan;
            textBoxpriceadd.Location = new Point(130, 255);
            textBoxpriceadd.Multiline = true;
            textBoxpriceadd.Name = "textBoxpriceadd";
            textBoxpriceadd.PlaceholderText = "price";
            textBoxpriceadd.Size = new Size(248, 49);
            textBoxpriceadd.TabIndex = 49;
            // 
            // textBoxpdadd
            // 
            textBoxpdadd.BackColor = Color.FromArgb(37, 42, 74);
            textBoxpdadd.ForeColor = Color.Cyan;
            textBoxpdadd.Location = new Point(130, 183);
            textBoxpdadd.Multiline = true;
            textBoxpdadd.Name = "textBoxpdadd";
            textBoxpdadd.PlaceholderText = "product description";
            textBoxpdadd.Size = new Size(248, 49);
            textBoxpdadd.TabIndex = 48;
            // 
            // textBoxnamepictureadd
            // 
            textBoxnamepictureadd.BackColor = Color.FromArgb(37, 42, 74);
            textBoxnamepictureadd.ForeColor = Color.Cyan;
            textBoxnamepictureadd.Location = new Point(130, 110);
            textBoxnamepictureadd.Multiline = true;
            textBoxnamepictureadd.Name = "textBoxnamepictureadd";
            textBoxnamepictureadd.PlaceholderText = "name product";
            textBoxnamepictureadd.Size = new Size(248, 49);
            textBoxnamepictureadd.TabIndex = 47;
            // 
            // textBoxidadd
            // 
            textBoxidadd.BackColor = Color.FromArgb(37, 42, 74);
            textBoxidadd.ForeColor = Color.Cyan;
            textBoxidadd.Location = new Point(130, 36);
            textBoxidadd.Multiline = true;
            textBoxidadd.Name = "textBoxidadd";
            textBoxidadd.PlaceholderText = "id";
            textBoxidadd.Size = new Size(248, 49);
            textBoxidadd.TabIndex = 46;
            // 
            // buttonadd
            // 
            buttonadd.FlatStyle = FlatStyle.Popup;
            buttonadd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonadd.Location = new Point(130, 383);
            buttonadd.Margin = new Padding(3, 2, 3, 2);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(248, 67);
            buttonadd.TabIndex = 51;
            buttonadd.Text = "AGREGAR";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += buttonadd_Click;
            // 
            // Formadd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(521, 461);
            Controls.Add(buttonadd);
            Controls.Add(textBoxstockadd);
            Controls.Add(textBoxpriceadd);
            Controls.Add(textBoxpdadd);
            Controls.Add(textBoxnamepictureadd);
            Controls.Add(textBoxidadd);
            ForeColor = Color.Cyan;
            Name = "Formadd";
            Text = "Formadd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxstockadd;
        private TextBox textBoxpriceadd;
        private TextBox textBoxpdadd;
        private TextBox textBoxnamepictureadd;
        private TextBox textBoxidadd;
        private Button buttonadd;
    }
}