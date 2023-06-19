namespace CRUD
{
    partial class Consulta
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
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.panelSalida = new System.Windows.Forms.Panel();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            this.panelEntrada.SuspendLayout();
            this.panelSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.AllowUserToResizeColumns = false;
            this.dgvEntrada.AllowUserToResizeRows = false;
            this.dgvEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvEntrada.Location = new System.Drawing.Point(31, 38);
            this.dgvEntrada.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvEntrada.MultiSelect = false;
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.ReadOnly = true;
            this.dgvEntrada.RowHeadersVisible = false;
            this.dgvEntrada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrada.Size = new System.Drawing.Size(498, 207);
            this.dgvEntrada.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registros de Entrada:";
            // 
            // panelEntrada
            // 
            this.panelEntrada.Controls.Add(this.dgvEntrada);
            this.panelEntrada.Controls.Add(this.label1);
            this.panelEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntrada.Location = new System.Drawing.Point(0, 0);
            this.panelEntrada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(560, 280);
            this.panelEntrada.TabIndex = 21;
            // 
            // panelSalida
            // 
            this.panelSalida.Controls.Add(this.dgvSalida);
            this.panelSalida.Controls.Add(this.label2);
            this.panelSalida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSalida.Location = new System.Drawing.Point(0, 287);
            this.panelSalida.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSalida.Name = "panelSalida";
            this.panelSalida.Size = new System.Drawing.Size(560, 274);
            this.panelSalida.TabIndex = 22;
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToResizeColumns = false;
            this.dgvSalida.AllowUserToResizeRows = false;
            this.dgvSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvSalida.Location = new System.Drawing.Point(31, 36);
            this.dgvSalida.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvSalida.MultiSelect = false;
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.ReadOnly = true;
            this.dgvSalida.RowHeadersVisible = false;
            this.dgvSalida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalida.Size = new System.Drawing.Size(498, 207);
            this.dgvSalida.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Registros de Salida:";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(560, 561);
            this.Controls.Add(this.panelSalida);
            this.Controls.Add(this.panelEntrada);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            this.panelEntrada.ResumeLayout(false);
            this.panelEntrada.PerformLayout();
            this.panelSalida.ResumeLayout(false);
            this.panelSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Panel panelSalida;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.Label label2;
    }
}