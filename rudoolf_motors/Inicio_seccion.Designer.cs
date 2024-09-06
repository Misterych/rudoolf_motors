namespace rudoolf_motors
{
    partial class Inicio_seccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Ingresar = new System.Windows.Forms.Button();
            this.mostrar_ocultar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio sección de panel admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Correo de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(32, 86);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(349, 22);
            this.correo.TabIndex = 3;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(32, 144);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(221, 22);
            this.contraseña.TabIndex = 4;
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(219, 181);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(162, 32);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(32, 181);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(162, 32);
            this.Ingresar.TabIndex = 7;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // mostrar_ocultar
            // 
            this.mostrar_ocultar.AutoSize = true;
            this.mostrar_ocultar.Location = new System.Drawing.Point(259, 148);
            this.mostrar_ocultar.Name = "mostrar_ocultar";
            this.mostrar_ocultar.Size = new System.Drawing.Size(18, 17);
            this.mostrar_ocultar.TabIndex = 8;
            this.mostrar_ocultar.UseVisualStyleBackColor = true;
            this.mostrar_ocultar.CheckedChanged += new System.EventHandler(this.mostrar_ocultar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mostrar/Ocultar";
            // 
            // Inicio_seccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostrar_ocultar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Inicio_seccion";
            this.Text = "Inicio_seccion";
            this.Load += new System.EventHandler(this.Inicio_seccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.CheckBox mostrar_ocultar;
        private System.Windows.Forms.Label label4;
    }
}