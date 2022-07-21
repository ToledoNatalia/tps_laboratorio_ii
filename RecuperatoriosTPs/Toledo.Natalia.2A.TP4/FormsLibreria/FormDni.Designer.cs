namespace FormsLibreria
{
    partial class form_ingresarDni
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
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_dni
            // 
            this.tb_dni.BackColor = System.Drawing.Color.Aquamarine;
            this.tb_dni.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dni.ForeColor = System.Drawing.Color.Maroon;
            this.tb_dni.Location = new System.Drawing.Point(159, 187);
            this.tb_dni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(293, 32);
            this.tb_dni.TabIndex = 0;
            this.tb_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dni_KeyPress);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dni.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dni.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_dni.Location = new System.Drawing.Point(159, 147);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(286, 33);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "Ingrese el DNI del cliente";
           
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_confirmar.Location = new System.Drawing.Point(159, 297);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(116, 73);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Location = new System.Drawing.Point(337, 297);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(116, 73);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // form_ingresarDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 493);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.tb_dni);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_ingresarDni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}