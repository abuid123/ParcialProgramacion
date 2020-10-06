namespace Login
{
    partial class Mercado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mercado));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.bbtn_Eliminar = new System.Windows.Forms.Button();
            this.btn_RealizarCompra = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_CerrarAplicacion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 21);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(157, 51);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar producto";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // bbtn_Eliminar
            // 
            this.bbtn_Eliminar.Location = new System.Drawing.Point(12, 132);
            this.bbtn_Eliminar.Name = "bbtn_Eliminar";
            this.bbtn_Eliminar.Size = new System.Drawing.Size(157, 51);
            this.bbtn_Eliminar.TabIndex = 1;
            this.bbtn_Eliminar.Text = "Eliminar producto";
            this.bbtn_Eliminar.UseVisualStyleBackColor = true;
            this.bbtn_Eliminar.Click += new System.EventHandler(this.bbtn_Eliminar_Click);
            // 
            // btn_RealizarCompra
            // 
            this.btn_RealizarCompra.Location = new System.Drawing.Point(12, 240);
            this.btn_RealizarCompra.Name = "btn_RealizarCompra";
            this.btn_RealizarCompra.Size = new System.Drawing.Size(157, 51);
            this.btn_RealizarCompra.TabIndex = 3;
            this.btn_RealizarCompra.Text = "Realizar  compra";
            this.btn_RealizarCompra.UseVisualStyleBackColor = true;
            this.btn_RealizarCompra.Click += new System.EventHandler(this.btn_RealizarCompra_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.Location = new System.Drawing.Point(12, 355);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(157, 51);
            this.btn_Stock.TabIndex = 4;
            this.btn_Stock.Text = "Stock";
            this.btn_Stock.UseVisualStyleBackColor = true;
            this.btn_Stock.Click += new System.EventHandler(this.btn_Stock_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(597, 355);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(157, 51);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Cerrar sesion";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Location = new System.Drawing.Point(626, 21);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 6;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btn_CerrarAplicacion
            // 
            this.btn_CerrarAplicacion.Location = new System.Drawing.Point(597, 278);
            this.btn_CerrarAplicacion.Name = "btn_CerrarAplicacion";
            this.btn_CerrarAplicacion.Size = new System.Drawing.Size(157, 51);
            this.btn_CerrarAplicacion.TabIndex = 8;
            this.btn_CerrarAplicacion.Text = "Cerrar Aplicacion";
            this.btn_CerrarAplicacion.UseVisualStyleBackColor = true;
            this.btn_CerrarAplicacion.Click += new System.EventHandler(this.btn_CerrarAplicacion_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Lista
            // 
            this.btn_Lista.Location = new System.Drawing.Point(597, 58);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(157, 51);
            this.btn_Lista.TabIndex = 9;
            this.btn_Lista.Text = "Obtener Lista";
            this.btn_Lista.UseVisualStyleBackColor = true;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.simpsons_1_1280x720;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Lista);
            this.Controls.Add(this.btn_CerrarAplicacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Stock);
            this.Controls.Add(this.btn_RealizarCompra);
            this.Controls.Add(this.bbtn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mercado";
            this.Text = "Mercado";
            this.Load += new System.EventHandler(this.Mercado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button bbtn_Eliminar;
        private System.Windows.Forms.Button btn_RealizarCompra;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_CerrarAplicacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Lista;
    }
}