namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldos = new System.Windows.Forms.Label();
            this.lblTransacciones = new System.Windows.Forms.Label();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.inicioToolStripMenuItem.Text = "🏠 Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.clientesToolStripMenuItem.Text = "👥 Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.cuentasToolStripMenuItem.Text = "🗃️ Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblSaldos);
            this.panel1.Controls.Add(this.lblTransacciones);
            this.panel1.Controls.Add(this.lblCuentas);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 478);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 264);
            this.dataGridView1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "📊 Transacciones Recientes 🔃";
            // 
            // lblSaldos
            // 
            this.lblSaldos.AutoSize = true;
            this.lblSaldos.Location = new System.Drawing.Point(391, 94);
            this.lblSaldos.Name = "lblSaldos";
            this.lblSaldos.Size = new System.Drawing.Size(276, 20);
            this.lblSaldos.TabIndex = 3;
            this.lblSaldos.Text = "✅ Saldo total de todas las cuentas 💵";
            // 
            // lblTransacciones
            // 
            this.lblTransacciones.AutoSize = true;
            this.lblTransacciones.Location = new System.Drawing.Point(391, 37);
            this.lblTransacciones.Name = "lblTransacciones";
            this.lblTransacciones.Size = new System.Drawing.Size(266, 20);
            this.lblTransacciones.TabIndex = 2;
            this.lblTransacciones.Text = "✅ Total de Transacciones del Día 📊";
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Location = new System.Drawing.Point(35, 94);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(245, 20);
            this.lblCuentas.TabIndex = 1;
            this.lblCuentas.Text = "✅ Total de Cuentas Bancarias 🗃️";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(35, 37);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(222, 20);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "✅ Total de Clientes Activos 📊";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco XYZ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaldos;
        private System.Windows.Forms.Label lblTransacciones;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}

