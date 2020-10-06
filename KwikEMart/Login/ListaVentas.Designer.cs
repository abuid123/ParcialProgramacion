namespace Login
{
    partial class ListaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVentas));
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.lbl_Empleado = new System.Windows.Forms.Label();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.AllowUserToAddRows = false;
            this.dgv_Empleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_Empleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Empleados.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Location = new System.Drawing.Point(12, 39);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            this.dgv_Empleados.RowHeadersVisible = false;
            this.dgv_Empleados.Size = new System.Drawing.Size(289, 418);
            this.dgv_Empleados.TabIndex = 2;
            this.dgv_Empleados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Empleados_MouseDoubleClick);
            // 
            // dgv_Ventas
            // 
            this.dgv_Ventas.AllowUserToAddRows = false;
            this.dgv_Ventas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_Ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ventas.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ventas.Location = new System.Drawing.Point(329, 39);
            this.dgv_Ventas.Name = "dgv_Ventas";
            this.dgv_Ventas.ReadOnly = true;
            this.dgv_Ventas.RowHeadersVisible = false;
            this.dgv_Ventas.Size = new System.Drawing.Size(559, 418);
            this.dgv_Ventas.TabIndex = 3;
            // 
            // lbl_Empleado
            // 
            this.lbl_Empleado.AutoSize = true;
            this.lbl_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empleado.Location = new System.Drawing.Point(111, 9);
            this.lbl_Empleado.Name = "lbl_Empleado";
            this.lbl_Empleado.Size = new System.Drawing.Size(106, 24);
            this.lbl_Empleado.TabIndex = 6;
            this.lbl_Empleado.Text = "Empleados";
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ventas.Location = new System.Drawing.Point(505, 12);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(68, 24);
            this.lbl_Ventas.TabIndex = 7;
            this.lbl_Ventas.Text = "Ventas";
            // 
            // ListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(900, 469);
            this.Controls.Add(this.lbl_Ventas);
            this.Controls.Add(this.lbl_Empleado);
            this.Controls.Add(this.dgv_Ventas);
            this.Controls.Add(this.dgv_Empleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaVentas";
            this.Text = "Lista de Ventas";
            this.Load += new System.EventHandler(this.ListaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Empleados;
        private System.Windows.Forms.DataGridView dgv_Ventas;
        private System.Windows.Forms.Label lbl_Empleado;
        private System.Windows.Forms.Label lbl_Ventas;
    }
}