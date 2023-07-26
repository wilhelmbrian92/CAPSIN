namespace CRUD
{
    partial class Inicio
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.picLogoBrown = new System.Windows.Forms.PictureBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFrm = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBrown)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panelSideMenu.Controls.Add(this.btnConsultas);
            this.panelSideMenu.Controls.Add(this.picLogoBrown);
            this.panelSideMenu.Controls.Add(this.btnCalendario);
            this.panelSideMenu.Controls.Add(this.btnSalidas);
            this.panelSideMenu.Controls.Add(this.btnEntrada);
            this.panelSideMenu.Controls.Add(this.btnAlta);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(224, 561);
            this.panelSideMenu.TabIndex = 4;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsultas.Location = new System.Drawing.Point(0, 280);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultas.Size = new System.Drawing.Size(224, 45);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Historial de registros";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // picLogoBrown
            // 
            this.picLogoBrown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picLogoBrown.Location = new System.Drawing.Point(0, 461);
            this.picLogoBrown.Name = "picLogoBrown";
            this.picLogoBrown.Padding = new System.Windows.Forms.Padding(25, 30, 55, 30);
            this.picLogoBrown.Size = new System.Drawing.Size(224, 100);
            this.picLogoBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoBrown.TabIndex = 0;
            this.picLogoBrown.TabStop = false;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalendario.Location = new System.Drawing.Point(0, 235);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalendario.Size = new System.Drawing.Size(224, 45);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "Vencimientos";
            this.btnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalidas.FlatAppearance.BorderSize = 0;
            this.btnSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalidas.Location = new System.Drawing.Point(0, 190);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalidas.Size = new System.Drawing.Size(224, 45);
            this.btnSalidas.TabIndex = 3;
            this.btnSalidas.Text = "Salida de productos";
            this.btnSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEntrada.Location = new System.Drawing.Point(0, 145);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEntrada.Size = new System.Drawing.Size(224, 45);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Ingreso de productos";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAlta.Location = new System.Drawing.Point(0, 100);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAlta.Size = new System.Drawing.Size(224, 45);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta de nuevo artículo";
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(224, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelFrm
            // 
            this.panelFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrm.Location = new System.Drawing.Point(224, 0);
            this.panelFrm.Name = "panelFrm";
            this.panelFrm.Size = new System.Drawing.Size(560, 561);
            this.panelFrm.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(33, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(155, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelFrm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPSin";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBrown)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelFrm;
        private System.Windows.Forms.PictureBox picLogoBrown;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

