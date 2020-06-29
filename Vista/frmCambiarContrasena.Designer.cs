namespace Vista
{
    partial class frmCambiarContrasena
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
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.txtRepertirContrasenaNueva = new System.Windows.Forms.TextBox();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaActual.Location = new System.Drawing.Point(55, 115);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.PasswordChar = '*';
            this.txtContrasenaActual.Size = new System.Drawing.Size(275, 29);
            this.txtContrasenaActual.TabIndex = 0;
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaNueva.Location = new System.Drawing.Point(55, 223);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.PasswordChar = '*';
            this.txtContrasenaNueva.Size = new System.Drawing.Size(275, 29);
            this.txtContrasenaNueva.TabIndex = 1;
            // 
            // txtRepertirContrasenaNueva
            // 
            this.txtRepertirContrasenaNueva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepertirContrasenaNueva.Location = new System.Drawing.Point(55, 298);
            this.txtRepertirContrasenaNueva.Name = "txtRepertirContrasenaNueva";
            this.txtRepertirContrasenaNueva.PasswordChar = '*';
            this.txtRepertirContrasenaNueva.Size = new System.Drawing.Size(275, 29);
            this.txtRepertirContrasenaNueva.TabIndex = 2;
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCambiarContrasena.Location = new System.Drawing.Point(55, 363);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(274, 46);
            this.btnCambiarContrasena.TabIndex = 3;
            this.btnCambiarContrasena.Text = "Cambiar Contraseña";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(51, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(51, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese Contraseña Nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(51, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repetir Contraseña Nueva";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCambiarContrasena);
            this.groupBox1.Controls.Add(this.txtRepertirContrasenaNueva);
            this.groupBox1.Controls.Add(this.txtContrasenaNueva);
            this.groupBox1.Controls.Add(this.txtContrasenaActual);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(291, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 480);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña";
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCambiarContrasena";
            this.Text = "frmCambiarContrasena";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContrasenaActual;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.TextBox txtRepertirContrasenaNueva;
        private System.Windows.Forms.Button btnCambiarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}