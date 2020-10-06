namespace Login
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ClienteExistente = new System.Windows.Forms.Button();
            this.btn_ClienteNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_ClienteExistente
            // 
            this.btn_ClienteExistente.Location = new System.Drawing.Point(90, 139);
            this.btn_ClienteExistente.Name = "btn_ClienteExistente";
            this.btn_ClienteExistente.Size = new System.Drawing.Size(238, 179);
            this.btn_ClienteExistente.TabIndex = 2;
            this.btn_ClienteExistente.Text = "Cliente Existente";
            this.btn_ClienteExistente.UseVisualStyleBackColor = true;
            this.btn_ClienteExistente.Click += new System.EventHandler(this.btn_ClienteExistente_Click);
            // 
            // btn_ClienteNuevo
            // 
            this.btn_ClienteNuevo.Location = new System.Drawing.Point(500, 139);
            this.btn_ClienteNuevo.Name = "btn_ClienteNuevo";
            this.btn_ClienteNuevo.Size = new System.Drawing.Size(238, 179);
            this.btn_ClienteNuevo.TabIndex = 3;
            this.btn_ClienteNuevo.Text = "Cliente Nuevo";
            this.btn_ClienteNuevo.UseVisualStyleBackColor = true;
            this.btn_ClienteNuevo.Click += new System.EventHandler(this.btn_ClienteNuevo_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ClienteNuevo);
            this.Controls.Add(this.btn_ClienteExistente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ClienteExistente;
        private System.Windows.Forms.Button btn_ClienteNuevo;
    }
}