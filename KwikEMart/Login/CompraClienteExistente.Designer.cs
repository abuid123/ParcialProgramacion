namespace Login
{
    partial class CompraClienteExistente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraClienteExistente));
            this.dgv_Mercado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Compra = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Carrito = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Empleados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Mercado
            // 
            this.dgv_Mercado.AllowUserToAddRows = false;
            this.dgv_Mercado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_Mercado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Mercado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Mercado.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Mercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mercado.Location = new System.Drawing.Point(12, 248);
            this.dgv_Mercado.Name = "dgv_Mercado";
            this.dgv_Mercado.ReadOnly = true;
            this.dgv_Mercado.RowHeadersVisible = false;
            this.dgv_Mercado.Size = new System.Drawing.Size(539, 190);
            this.dgv_Mercado.TabIndex = 0;
            this.dgv_Mercado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(737, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carrito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mercado";
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.AllowUserToAddRows = false;
            this.dgv_Cliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_Cliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cliente.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(12, 35);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.ReadOnly = true;
            this.dgv_Cliente.RowHeadersVisible = false;
            this.dgv_Cliente.Size = new System.Drawing.Size(539, 105);
            this.dgv_Cliente.TabIndex = 4;
            this.dgv_Cliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione un cliente(doble click) y luego los productos";
            // 
            // btn_Compra
            // 
            this.btn_Compra.Location = new System.Drawing.Point(663, 389);
            this.btn_Compra.Name = "btn_Compra";
            this.btn_Compra.Size = new System.Drawing.Size(213, 49);
            this.btn_Compra.TabIndex = 7;
            this.btn_Compra.Text = "Confirmar Compra!";
            this.btn_Compra.UseVisualStyleBackColor = true;
            this.btn_Compra.Click += new System.EventHandler(this.btn_Compra_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(384, 225);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // dgv_Carrito
            // 
            this.dgv_Carrito.AllowUserToAddRows = false;
            this.dgv_Carrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_Carrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Carrito.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Carrito.Location = new System.Drawing.Point(605, 35);
            this.dgv_Carrito.Name = "dgv_Carrito";
            this.dgv_Carrito.ReadOnly = true;
            this.dgv_Carrito.RowHeadersVisible = false;
            this.dgv_Carrito.Size = new System.Drawing.Size(321, 217);
            this.dgv_Carrito.TabIndex = 10;
            this.dgv_Carrito.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doble click a los productos para eliminarlos";
            // 
            // cmb_Empleados
            // 
            this.cmb_Empleados.FormattingEnabled = true;
            this.cmb_Empleados.Location = new System.Drawing.Point(707, 324);
            this.cmb_Empleados.Name = "cmb_Empleados";
            this.cmb_Empleados.Size = new System.Drawing.Size(121, 21);
            this.cmb_Empleados.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(695, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seleccione el empleado";
            // 
            // CompraClienteExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Empleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Carrito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.btn_Compra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Mercado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompraClienteExistente";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.CompraClienteExistente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mercado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Mercado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Compra;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Carrito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Empleados;
        private System.Windows.Forms.Label label7;
    }
}