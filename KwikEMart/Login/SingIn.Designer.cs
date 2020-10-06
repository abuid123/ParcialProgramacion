namespace Login
{
    partial class SingIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingIn));
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_ConfirmContraseña = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_ConfirmeContraseña = new System.Windows.Forms.Label();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(138, 34);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(138, 77);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_Contraseña.TabIndex = 1;
            this.txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // txt_ConfirmContraseña
            // 
            this.txt_ConfirmContraseña.Location = new System.Drawing.Point(138, 119);
            this.txt_ConfirmContraseña.Name = "txt_ConfirmContraseña";
            this.txt_ConfirmContraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_ConfirmContraseña.TabIndex = 2;
            this.txt_ConfirmContraseña.UseSystemPasswordChar = true;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(73, 37);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(55, 80);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(64, 13);
            this.lbl_Contraseña.TabIndex = 4;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // lbl_ConfirmeContraseña
            // 
            this.lbl_ConfirmeContraseña.AutoSize = true;
            this.lbl_ConfirmeContraseña.Location = new System.Drawing.Point(12, 122);
            this.lbl_ConfirmeContraseña.Name = "lbl_ConfirmeContraseña";
            this.lbl_ConfirmeContraseña.Size = new System.Drawing.Size(107, 13);
            this.lbl_ConfirmeContraseña.TabIndex = 5;
            this.lbl_ConfirmeContraseña.Text = "Confirme contraseña:";
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.Location = new System.Drawing.Point(100, 181);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrarse.TabIndex = 6;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click);
            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(314, 241);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.lbl_ConfirmeContraseña);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.txt_ConfirmContraseña);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingIn";
            this.Text = "SingIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_ConfirmContraseña;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_ConfirmeContraseña;
        private System.Windows.Forms.Button btn_Registrarse;
    }
}