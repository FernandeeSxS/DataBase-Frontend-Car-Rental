using System;

namespace AluguerAutomoveis
{
    partial class FormManipulacaoDados
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos em uso.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormManipulacaoDados_Load(object sender, EventArgs e)
        {
            // Centraliza o título
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;

            // Centraliza os botões
            btnCondutor.Left = (this.ClientSize.Width - btnCondutor.Width) / 2;
            btnCondutor.Top = 150;

            btnReserva.Left = (this.ClientSize.Width - btnReserva.Width) / 2;
            btnReserva.Top = 250;

            btnVeiculo.Left = (this.ClientSize.Width - btnVeiculo.Width) / 2;
            btnVeiculo.Top = 350;
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer.
        /// Não modifique o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCondutor = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
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
            this.lblTitulo.Text = "Manipulação de Dados";
            // 
            // btnCondutor
            // 
            this.btnCondutor.Location = new System.Drawing.Point(700, 150);
            this.btnCondutor.Name = "btnCondutor";
            this.btnCondutor.Size = new System.Drawing.Size(310, 67);
            this.btnCondutor.TabIndex = 1;
            this.btnCondutor.Text = "Condutor";
            this.btnCondutor.UseVisualStyleBackColor = true;
            this.btnCondutor.Click += new System.EventHandler(this.btnCondutor_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(700, 250);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(310, 72);
            this.btnReserva.TabIndex = 2;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Location = new System.Drawing.Point(700, 350);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(310, 72);
            this.btnVeiculo.TabIndex = 3;
            this.btnVeiculo.Text = "Veículo";
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // FormManipulacaoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVeiculo);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.btnCondutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormManipulacaoDados";
            this.Text = "Manipulação de Dados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormManipulacaoDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCondutor;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnVeiculo;
    }
}
