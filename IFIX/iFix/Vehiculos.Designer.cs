namespace iFix
{
    partial class Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SeleccionOrden = new System.Windows.Forms.MenuStrip();
            this.oRDENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgVehiculos = new System.Windows.Forms.DataGridView();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ayu = new System.Windows.Forms.ToolTip(this.components);
            this.fin = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SeleccionOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(256, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(509, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.AutoToolTip = true;
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.ToolTipText = "F1";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.VentaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.ToolTipText = "F2";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.vehiculosToolStripMenuItem.Text = "Vehículos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.ToolTipText = "F4";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.ToolTipText = "F5";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(167)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(12, 489);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(53, 44);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(713, 511);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(62, 23);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "AYUDA";
            this.ayu.SetToolTip(this.btnAyuda, "Shift + A");
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // SeleccionOrden
            // 
            this.SeleccionOrden.BackColor = System.Drawing.Color.Transparent;
            this.SeleccionOrden.Dock = System.Windows.Forms.DockStyle.None;
            this.SeleccionOrden.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionOrden.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SeleccionOrden.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDENToolStripMenuItem});
            this.SeleccionOrden.Location = new System.Drawing.Point(0, 101);
            this.SeleccionOrden.Name = "SeleccionOrden";
            this.SeleccionOrden.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SeleccionOrden.Size = new System.Drawing.Size(139, 28);
            this.SeleccionOrden.TabIndex = 25;
            this.SeleccionOrden.Text = "menuStrip2";
            // 
            // oRDENToolStripMenuItem
            // 
            this.oRDENToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.oRDENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminadosToolStripMenuItem,
            this.pendientesToolStripMenuItem});
            this.oRDENToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oRDENToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.oRDENToolStripMenuItem.Name = "oRDENToolStripMenuItem";
            this.oRDENToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.oRDENToolStripMenuItem.Text = "ORDENAR POR";
            this.oRDENToolStripMenuItem.Click += new System.EventHandler(this.ORDENToolStripMenuItem_Click);
            // 
            // terminadosToolStripMenuItem
            // 
            this.terminadosToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminadosToolStripMenuItem.Name = "terminadosToolStripMenuItem";
            this.terminadosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.terminadosToolStripMenuItem.Text = "Terminados";
            this.terminadosToolStripMenuItem.Click += new System.EventHandler(this.TerminadosToolStripMenuItem_Click);
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pendientesToolStripMenuItem.Text = "Pendientes";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.PendientesToolStripMenuItem_Click);
            // 
            // dgVehiculos
            // 
            this.dgVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vehiculo,
            this.NumSerie,
            this.Dueno,
            this.Salida});
            this.dgVehiculos.Location = new System.Drawing.Point(69, 132);
            this.dgVehiculos.Name = "dgVehiculos";
            this.dgVehiculos.Size = new System.Drawing.Size(664, 304);
            this.dgVehiculos.TabIndex = 3;
            this.dgVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVehiculos_CellContentClick);
            // 
            // Vehiculo
            // 
            this.Vehiculo.HeaderText = "Vehículo";
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            this.Vehiculo.Width = 120;
            // 
            // NumSerie
            // 
            this.NumSerie.HeaderText = "Número de serie";
            this.NumSerie.Name = "NumSerie";
            this.NumSerie.ReadOnly = true;
            this.NumSerie.Width = 180;
            // 
            // Dueno
            // 
            this.Dueno.HeaderText = "Dueño";
            this.Dueno.Name = "Dueno";
            this.Dueno.ReadOnly = true;
            this.Dueno.Width = 120;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Fecha de salida";
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            this.Salida.Width = 200;
            // 
            // btnSal
            // 
            this.btnSal.BackColor = System.Drawing.Color.Transparent;
            this.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSal.Location = new System.Drawing.Point(342, 442);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(103, 41);
            this.btnSal.TabIndex = 0;
            this.btnSal.Text = "Añadir fecha de salida";
            this.fin.SetToolTip(this.btnSal, "Shift + T");
            this.btnSal.UseVisualStyleBackColor = false;
            this.btnSal.Click += new System.EventHandler(this.BtnSal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Lista de vehículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "\"Podemos repararlo.\"";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(703, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Ayuda";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.dgVehiculos);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SeleccionOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.SeleccionOrden;
            this.Name = "Vehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Vehiculos_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SeleccionOrden.ResumeLayout(false);
            this.SeleccionOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.MenuStrip SeleccionOrden;
        private System.Windows.Forms.ToolStripMenuItem oRDENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgVehiculos;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.ToolTip ayu;
        private System.Windows.Forms.ToolTip fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}