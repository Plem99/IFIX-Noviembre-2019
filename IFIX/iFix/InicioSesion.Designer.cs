namespace iFix
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.inicia = new System.Windows.Forms.ToolTip(this.components);
            this.contr = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.Location = new System.Drawing.Point(109, 214);
            this.txtUsuario.MaxLength = 8;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 31);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtContrasena.Location = new System.Drawing.Point(109, 258);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(144, 31);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 2;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(128, 341);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(103, 42);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar\r\nsesión";
            this.inicia.SetToolTip(this.btnIniciarSesion, "ALT + Enter");
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.lblIniciarSesion_Click);
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambiarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnCambiarContrasena.FlatAppearance.BorderSize = 0;
            this.btnCambiarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContrasena.ForeColor = System.Drawing.Color.Blue;
            this.btnCambiarContrasena.Location = new System.Drawing.Point(121, 295);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(122, 23);
            this.btnCambiarContrasena.TabIndex = 2;
            this.btnCambiarContrasena.Text = "Olvide mi contraseña";
            this.contr.SetToolTip(this.btnCambiarContrasena, "Shift + O");
            this.btnCambiarContrasena.UseVisualStyleBackColor = false;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(128, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "\"Podemos repararlo.\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCambiarContrasena);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InicioSesion_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnCambiarContrasena;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolTip contr;
        private System.Windows.Forms.ToolTip inicia;
        private System.Windows.Forms.Label label2;
    }
}