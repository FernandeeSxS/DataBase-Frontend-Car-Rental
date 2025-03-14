using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormDadosReserva
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormDadosReserva_Load(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;

            btnInserirReserva.Left = (this.ClientSize.Width - btnInserirReserva.Width) / 2;
            btnInserirReserva.Top = 150;

            btnEditarReserva.Left = (this.ClientSize.Width - btnEditarReserva.Width) / 2;
            btnEditarReserva.Top = 250;

            btnEliminarReserva.Left = (this.ClientSize.Width - btnEliminarReserva.Width) / 2;
            btnEliminarReserva.Top = 350;
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInserirReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(700, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestão de Reservas";
            // 
            // btnInserirReserva
            // 
            this.btnInserirReserva.Location = new System.Drawing.Point(700, 150);
            this.btnInserirReserva.Name = "btnInserirReserva";
            this.btnInserirReserva.Size = new System.Drawing.Size(310, 67);
            this.btnInserirReserva.TabIndex = 1;
            this.btnInserirReserva.Text = "Inserir Reserva";
            this.btnInserirReserva.UseVisualStyleBackColor = true;
            this.btnInserirReserva.Click += new System.EventHandler(this.btnInserirReserva_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(700, 250);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(310, 72);
            this.btnEditarReserva.TabIndex = 2;
            this.btnEditarReserva.Text = "Editar Reserva";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(700, 350);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(310, 72);
            this.btnEliminarReserva.TabIndex = 3;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // FormDadosReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnInserirReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormDadosReserva";
            this.Text = "Gestão de Reservas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDadosReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInserirReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
    }
}
