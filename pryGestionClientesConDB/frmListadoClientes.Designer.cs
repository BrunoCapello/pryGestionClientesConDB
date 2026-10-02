namespace pryGestionClientesConDB
{
    partial class frmListadoClientes
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblMuestraTotalDeuda = new System.Windows.Forms.Label();
            this.lblMuestraCantClientes = new System.Windows.Forms.Label();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 12);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(564, 269);
            this.dgvListado.TabIndex = 0;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(12, 299);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(77, 15);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total Deuda:";
            // 
            // lblMuestraTotalDeuda
            // 
            this.lblMuestraTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraTotalDeuda.Location = new System.Drawing.Point(95, 299);
            this.lblMuestraTotalDeuda.Name = "lblMuestraTotalDeuda";
            this.lblMuestraTotalDeuda.Size = new System.Drawing.Size(117, 15);
            this.lblMuestraTotalDeuda.TabIndex = 2;
            // 
            // lblMuestraCantClientes
            // 
            this.lblMuestraCantClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuestraCantClientes.Location = new System.Drawing.Point(306, 299);
            this.lblMuestraCantClientes.Name = "lblMuestraCantClientes";
            this.lblMuestraCantClientes.Size = new System.Drawing.Size(55, 15);
            this.lblMuestraCantClientes.TabIndex = 4;
            this.lblMuestraCantClientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.Location = new System.Drawing.Point(218, 299);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(82, 15);
            this.lblCantClientes.TabIndex = 3;
            this.lblCantClientes.Text = "Cant Clientes:";
            this.lblCantClientes.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(376, 299);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 15);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Total Deuda:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(221, 326);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(133, 19);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 357);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblMuestraCantClientes);
            this.Controls.Add(this.lblCantClientes);
            this.Controls.Add(this.lblMuestraTotalDeuda);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmListadoClientes";
            this.Text = "Listado de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblMuestraTotalDeuda;
        private System.Windows.Forms.Label lblMuestraCantClientes;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnListar;
    }
}