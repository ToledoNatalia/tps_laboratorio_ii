namespace FormsLibreria
{
    partial class form_agregarModificarLibro
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
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.tb_cantidadPaginas = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_cantidadPaginas = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_titulo
            // 
            this.tb_titulo.BackColor = System.Drawing.Color.MistyRose;
            this.tb_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_titulo.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_titulo.ForeColor = System.Drawing.Color.Maroon;
            this.tb_titulo.Location = new System.Drawing.Point(49, 88);
            this.tb_titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(496, 32);
            this.tb_titulo.TabIndex = 0;
            // 
            // tb_autor
            // 
            this.tb_autor.BackColor = System.Drawing.Color.MistyRose;
            this.tb_autor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_autor.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_autor.ForeColor = System.Drawing.Color.Maroon;
            this.tb_autor.Location = new System.Drawing.Point(50, 175);
            this.tb_autor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(495, 32);
            this.tb_autor.TabIndex = 1;
            this.tb_autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_autor_KeyPress);
            // 
            // cb_genero
            // 
            this.cb_genero.BackColor = System.Drawing.Color.MistyRose;
            this.cb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_genero.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_genero.ForeColor = System.Drawing.Color.Maroon;
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Ficcion",
            "No-ficcion"});
            this.cb_genero.Location = new System.Drawing.Point(50, 263);
            this.cb_genero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(215, 36);
            this.cb_genero.TabIndex = 2;
            // 
            // tb_cantidadPaginas
            // 
            this.tb_cantidadPaginas.BackColor = System.Drawing.Color.MistyRose;
            this.tb_cantidadPaginas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cantidadPaginas.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_cantidadPaginas.ForeColor = System.Drawing.Color.Maroon;
            this.tb_cantidadPaginas.Location = new System.Drawing.Point(49, 357);
            this.tb_cantidadPaginas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_cantidadPaginas.Name = "tb_cantidadPaginas";
            this.tb_cantidadPaginas.Size = new System.Drawing.Size(218, 32);
            this.tb_cantidadPaginas.TabIndex = 3;
            this.tb_cantidadPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cantidadPaginas_KeyPress);
            // 
            // tb_codigo
            // 
            this.tb_codigo.BackColor = System.Drawing.Color.MistyRose;
            this.tb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_codigo.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_codigo.ForeColor = System.Drawing.Color.Maroon;
            this.tb_codigo.Location = new System.Drawing.Point(50, 443);
            this.tb_codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(216, 32);
            this.tb_codigo.TabIndex = 4;
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codigo_KeyPress);
            // 
            // tb_precio
            // 
            this.tb_precio.BackColor = System.Drawing.Color.MistyRose;
            this.tb_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precio.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_precio.ForeColor = System.Drawing.Color.Maroon;
            this.tb_precio.Location = new System.Drawing.Point(49, 532);
            this.tb_precio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(218, 32);
            this.tb_precio.TabIndex = 5;
            this.tb_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precio_KeyPress);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_titulo.Location = new System.Drawing.Point(49, 48);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(70, 29);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Título";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_autor.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_autor.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_autor.Location = new System.Drawing.Point(50, 142);
            this.lbl_autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(66, 29);
            this.lbl_autor.TabIndex = 8;
            this.lbl_autor.Text = "Autor";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genero.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_genero.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_genero.Location = new System.Drawing.Point(49, 227);
            this.lbl_genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(79, 29);
            this.lbl_genero.TabIndex = 9;
            this.lbl_genero.Text = "Género";
            // 
            // lbl_cantidadPaginas
            // 
            this.lbl_cantidadPaginas.AutoSize = true;
            this.lbl_cantidadPaginas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidadPaginas.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidadPaginas.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_cantidadPaginas.Location = new System.Drawing.Point(49, 320);
            this.lbl_cantidadPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidadPaginas.Name = "lbl_cantidadPaginas";
            this.lbl_cantidadPaginas.Size = new System.Drawing.Size(203, 29);
            this.lbl_cantidadPaginas.TabIndex = 10;
            this.lbl_cantidadPaginas.Text = "Cantidad de páginas";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_codigo.Location = new System.Drawing.Point(49, 407);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(182, 29);
            this.lbl_codigo.TabIndex = 11;
            this.lbl_codigo.Text = "Código (4 dígitos)";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_precio.Location = new System.Drawing.Point(49, 495);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(71, 29);
            this.lbl_precio.TabIndex = 12;
            this.lbl_precio.Text = "Precio";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_aceptar.Location = new System.Drawing.Point(304, 498);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(107, 73);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Location = new System.Drawing.Point(439, 498);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(107, 73);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // form_agregarModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_cantidadPaginas);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.tb_cantidadPaginas);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.tb_titulo);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_agregarModificarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Modificar libro";
            this.Load += new System.EventHandler(this.FormAgregarModificarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.TextBox tb_cantidadPaginas;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_cantidadPaginas;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}