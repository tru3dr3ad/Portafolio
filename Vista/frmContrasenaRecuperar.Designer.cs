namespace Vista
{
    partial class frmContrasenaRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrasenaRecuperar));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtRunUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificarUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMostrarCorreo = new System.Windows.Forms.Label();
            this.txtVerificarCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerificarCorreo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCorreo = new System.Windows.Forms.GroupBox();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCorreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
            this.panel4.Controls.Add(this.btnMinimizar);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 46);
            this.panel4.TabIndex = 12;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(421, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(457, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtRunUsuario
            // 
            this.txtRunUsuario.Location = new System.Drawing.Point(58, 50);
            this.txtRunUsuario.MaxLength = 8;
            this.txtRunUsuario.Name = "txtRunUsuario";
            this.txtRunUsuario.Size = new System.Drawing.Size(141, 20);
            this.txtRunUsuario.TabIndex = 13;
            this.txtRunUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRunUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "INGRESE RUN";
            // 
            // btnVerificarUsuario
            // 
            this.btnVerificarUsuario.Location = new System.Drawing.Point(253, 50);
            this.btnVerificarUsuario.Name = "btnVerificarUsuario";
            this.btnVerificarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarUsuario.TabIndex = 15;
            this.btnVerificarUsuario.Text = "INGRESAR";
            this.btnVerificarUsuario.UseVisualStyleBackColor = true;
            this.btnVerificarUsuario.Click += new System.EventHandler(this.btnVerificarUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(59, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buenas tardes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vemos que haz olvidado tu contraseña a continuacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = " mostraremos parte del correo que tenemos asociado a su cuenta.";
            // 
            // lblMostrarCorreo
            // 
            this.lblMostrarCorreo.AutoSize = true;
            this.lblMostrarCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarCorreo.Location = new System.Drawing.Point(127, 118);
            this.lblMostrarCorreo.Name = "lblMostrarCorreo";
            this.lblMostrarCorreo.Size = new System.Drawing.Size(205, 21);
            this.lblMostrarCorreo.TabIndex = 19;
            this.lblMostrarCorreo.Text = "cor***********o@gmail.com";
            // 
            // txtVerificarCorreo
            // 
            this.txtVerificarCorreo.Location = new System.Drawing.Point(102, 182);
            this.txtVerificarCorreo.Name = "txtVerificarCorreo";
            this.txtVerificarCorreo.Size = new System.Drawing.Size(266, 20);
            this.txtVerificarCorreo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ingresa el correo electronico que mostramos arriba";
            // 
            // btnVerificarCorreo
            // 
            this.btnVerificarCorreo.Location = new System.Drawing.Point(196, 208);
            this.btnVerificarCorreo.Name = "btnVerificarCorreo";
            this.btnVerificarCorreo.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarCorreo.TabIndex = 22;
            this.btnVerificarCorreo.Text = "VERIFICAR";
            this.btnVerificarCorreo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDv);
            this.groupBox1.Controls.Add(this.btnVerificarUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRunUsuario);
            this.groupBox1.Location = new System.Drawing.Point(75, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 103);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Run";
            // 
            // grpCorreo
            // 
            this.grpCorreo.Controls.Add(this.lblNombreUsuario);
            this.grpCorreo.Controls.Add(this.btnVerificarCorreo);
            this.grpCorreo.Controls.Add(this.label6);
            this.grpCorreo.Controls.Add(this.txtVerificarCorreo);
            this.grpCorreo.Controls.Add(this.lblMostrarCorreo);
            this.grpCorreo.Controls.Add(this.label4);
            this.grpCorreo.Controls.Add(this.label3);
            this.grpCorreo.Controls.Add(this.label2);
            this.grpCorreo.Location = new System.Drawing.Point(12, 194);
            this.grpCorreo.Name = "grpCorreo";
            this.grpCorreo.Size = new System.Drawing.Size(476, 244);
            this.grpCorreo.TabIndex = 24;
            this.grpCorreo.TabStop = false;
            this.grpCorreo.Text = "Verificacion Correo";
            // 
            // txtDv
            // 
            this.txtDv.Location = new System.Drawing.Point(221, 50);
            this.txtDv.MaxLength = 1;
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(26, 20);
            this.txtDv.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(205, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "-";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombreUsuario.Location = new System.Drawing.Point(172, 35);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(146, 21);
            this.lblNombreUsuario.TabIndex = 23;
            this.lblNombreUsuario.Text = "NOMBRE USUARIO";
            // 
            // frmContrasenaRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.grpCorreo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContrasenaRecuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContrasenaRecuperar";
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCorreo.ResumeLayout(false);
            this.grpCorreo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtRunUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMostrarCorreo;
        private System.Windows.Forms.TextBox txtVerificarCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerificarCorreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Label lblNombreUsuario;
    }
}