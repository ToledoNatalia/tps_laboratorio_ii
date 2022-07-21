namespace FormsLibreria
{
    partial class form_menuPrincipal
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
            this.lbl_libros = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.rtb_libros = new System.Windows.Forms.RichTextBox();
            this.btn_agregarLibro = new System.Windows.Forms.Button();
            this.lbl_nombreLibreria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_modificarLibro = new System.Windows.Forms.Button();
            this.btn_eliminarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_clientes = new System.Windows.Forms.RichTextBox();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.btn_modificarCliente = new System.Windows.Forms.Button();
            this.btn_generarCompra = new System.Windows.Forms.Button();
            this.lbl_ordenando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_libros
            // 
            this.lbl_libros.AutoSize = true;
            this.lbl_libros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_libros.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_libros.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_libros.Location = new System.Drawing.Point(19, 187);
            this.lbl_libros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_libros.Name = "lbl_libros";
            this.lbl_libros.Size = new System.Drawing.Size(86, 35);
            this.lbl_libros.TabIndex = 5;
            this.lbl_libros.Text = "LIBROS";

            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Firebrick;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.CadetBlue;
            this.btn_salir.Location = new System.Drawing.Point(940, 882);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(157, 68);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // rtb_libros
            // 
            this.rtb_libros.BackColor = System.Drawing.Color.CadetBlue;
            this.rtb_libros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_libros.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_libros.Location = new System.Drawing.Point(19, 230);
            this.rtb_libros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_libros.Name = "rtb_libros";
            this.rtb_libros.ReadOnly = true;
            this.rtb_libros.Size = new System.Drawing.Size(491, 501);
            this.rtb_libros.TabIndex = 14;
            this.rtb_libros.Text = "";
            // 
            // btn_agregarLibro
            // 
            this.btn_agregarLibro.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_agregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregarLibro.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarLibro.ForeColor = System.Drawing.Color.Maroon;
            this.btn_agregarLibro.Location = new System.Drawing.Point(17, 743);
            this.btn_agregarLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_agregarLibro.Name = "btn_agregarLibro";
            this.btn_agregarLibro.Size = new System.Drawing.Size(159, 92);
            this.btn_agregarLibro.TabIndex = 15;
            this.btn_agregarLibro.Text = "Agregar";
            this.btn_agregarLibro.UseVisualStyleBackColor = false;
            this.btn_agregarLibro.Click += new System.EventHandler(this.btn_agregarLibro_Click);
            // 
            // lbl_nombreLibreria
            // 
            this.lbl_nombreLibreria.AutoSize = true;
            this.lbl_nombreLibreria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreLibreria.Font = new System.Drawing.Font("Sitka Heading", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreLibreria.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_nombreLibreria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_nombreLibreria.Location = new System.Drawing.Point(114, 57);
            this.lbl_nombreLibreria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreLibreria.Name = "lbl_nombreLibreria";
            this.lbl_nombreLibreria.Size = new System.Drawing.Size(186, 77);
            this.lbl_nombreLibreria.TabIndex = 300;
            this.lbl_nombreLibreria.Text = " ATENEO";
            this.lbl_nombreLibreria.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            //
            // btn_modificarLibro
            // 
            this.btn_modificarLibro.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_modificarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificarLibro.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_modificarLibro.ForeColor = System.Drawing.Color.Maroon;
            this.btn_modificarLibro.Location = new System.Drawing.Point(184, 743);
            this.btn_modificarLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modificarLibro.Name = "btn_modificarLibro";
            this.btn_modificarLibro.Size = new System.Drawing.Size(159, 92);
            this.btn_modificarLibro.TabIndex = 18;
            this.btn_modificarLibro.Text = "Modificar";
            this.btn_modificarLibro.UseVisualStyleBackColor = false;
            this.btn_modificarLibro.Click += new System.EventHandler(this.btn_modificarLibro_Click);
            // 
            // btn_eliminarCliente
            // 
            this.btn_eliminarCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_eliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminarCliente.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btn_eliminarCliente.Location = new System.Drawing.Point(351, 743);
            this.btn_eliminarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eliminarCliente.Name = "btn_eliminarCliente";
            this.btn_eliminarCliente.Size = new System.Drawing.Size(159, 92);
            this.btn_eliminarCliente.TabIndex = 19;
            this.btn_eliminarCliente.Text = "Eliminar";
            this.btn_eliminarCliente.UseVisualStyleBackColor = false;
            this.btn_eliminarCliente.Click += new System.EventHandler(this.btn_eliminarLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(129, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 52);
            this.label1.TabIndex = 150;
            this.label1.Text = "LIBRERIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtb_clientes
            // 
            this.rtb_clientes.BackColor = System.Drawing.Color.CadetBlue;
            this.rtb_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_clientes.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_clientes.Location = new System.Drawing.Point(604, 230);
            this.rtb_clientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_clientes.Name = "rtb_clientes";
            this.rtb_clientes.ReadOnly = true;
            this.rtb_clientes.Size = new System.Drawing.Size(491, 501);
            this.rtb_clientes.TabIndex = 30;
            this.rtb_clientes.Text = "";
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientes.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_clientes.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_clientes.Location = new System.Drawing.Point(604, 187);
            this.lbl_clientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(334, 35);
            this.lbl_clientes.TabIndex = 23;
            this.lbl_clientes.Text = "CLIENTES";
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_agregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregarCliente.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btn_agregarCliente.Location = new System.Drawing.Point(604, 743);
            this.btn_agregarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(157, 92);
            this.btn_agregarCliente.TabIndex = 24;
            this.btn_agregarCliente.Text = "Agregar";
            this.btn_agregarCliente.UseVisualStyleBackColor = false;
            this.btn_agregarCliente.Click += new System.EventHandler(this.btn_agregarCliente_Click);
            // 
            // btn_modificarCliente
            // 
            this.btn_modificarCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_modificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificarCliente.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_modificarCliente.ForeColor = System.Drawing.Color.Maroon;
            this.btn_modificarCliente.Location = new System.Drawing.Point(771, 743);
            this.btn_modificarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modificarCliente.Name = "btn_modificarCliente";
            this.btn_modificarCliente.Size = new System.Drawing.Size(159, 92);
            this.btn_modificarCliente.TabIndex = 25;
            this.btn_modificarCliente.Text = "Modificar";
            this.btn_modificarCliente.UseVisualStyleBackColor = false;
            this.btn_modificarCliente.Click += new System.EventHandler(this.btn_modificarCliente_Click);
            // 
            // btn_generarCompra
            // 
            this.btn_generarCompra.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_generarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generarCompra.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generarCompra.ForeColor = System.Drawing.Color.Maroon;
            this.btn_generarCompra.Location = new System.Drawing.Point(940, 743);
            this.btn_generarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generarCompra.Name = "btn_generarCompra";
            this.btn_generarCompra.Size = new System.Drawing.Size(157, 92);
            this.btn_generarCompra.TabIndex = 26;
            this.btn_generarCompra.Text = "Carrito";
            this.btn_generarCompra.UseVisualStyleBackColor = false;
            this.btn_generarCompra.Click += new System.EventHandler(this.btn_generarCompra_Click);
            // 
            // lbl_ordenando
            // 
            this.lbl_ordenando.AutoSize = true;
            this.lbl_ordenando.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ordenando.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ordenando.ForeColor = System.Drawing.Color.MistyRose;
            this.lbl_ordenando.Location = new System.Drawing.Point(96, 187);
            this.lbl_ordenando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ordenando.Name = "lbl_ordenando";
            this.lbl_ordenando.Size = new System.Drawing.Size(0, 35);
            this.lbl_ordenando.TabIndex = 29;
            // 
            // form_menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 990);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ordenando);
            this.Controls.Add(this.btn_generarCompra);
            this.Controls.Add(this.btn_modificarCliente);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.rtb_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminarCliente);
            this.Controls.Add(this.btn_modificarLibro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_nombreLibreria);
            this.Controls.Add(this.btn_agregarLibro);
            this.Controls.Add(this.rtb_libros);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_libros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.form_menuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_libros;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.RichTextBox rtb_libros;
        private System.Windows.Forms.Button btn_agregarLibro;
        private System.Windows.Forms.Label lbl_nombreLibreria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_modificarLibro;
        private System.Windows.Forms.Button btn_eliminarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_clientes;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.Button btn_modificarCliente;
        private System.Windows.Forms.Button btn_generarCompra;
        private System.Windows.Forms.Label lbl_ordenando;
    }
}