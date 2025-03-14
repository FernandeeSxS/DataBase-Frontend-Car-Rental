using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormDadosVeiculo
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

        private void FormDadosVeiculo_Load(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;

            btnInserirVeiculo.Left = (this.ClientSize.Width - btnInserirVeiculo.Width) / 2;
            btnInserirVeiculo.Top = 150;

            btnEditarVeiculo.Left = (this.ClientSize.Width - btnEditarVeiculo.Width) / 2;
            btnEditarVeiculo.Top = 250;

            btnEliminarVeiculo.Left = (this.ClientSize.Width - btnEliminarVeiculo.Width) / 2;
            btnEliminarVeiculo.Top = 350;
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInserirVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnEliminarVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(700, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dados Veículo";
            // 
            // btnInserirVeiculo
            // 
            this.btnInserirVeiculo.Location = new System.Drawing.Point(700, 150);
            this.btnInserirVeiculo.Name = "btnInserirVeiculo";
            this.btnInserirVeiculo.Size = new System.Drawing.Size(310, 67);
            this.btnInserirVeiculo.TabIndex = 1;
            this.btnInserirVeiculo.Text = "Inserir Veículo";
            this.btnInserirVeiculo.UseVisualStyleBackColor = true;
            this.btnInserirVeiculo.Click += new System.EventHandler(this.btnInserirVeiculo_Click);
            // 
            // btnEditarVeiculo
            // 
            this.btnEditarVeiculo.Location = new System.Drawing.Point(700, 250);
            this.btnEditarVeiculo.Name = "btnEditarVeiculo";
            this.btnEditarVeiculo.Size = new System.Drawing.Size(310, 72);
            this.btnEditarVeiculo.TabIndex = 2;
            this.btnEditarVeiculo.Text = "Editar Veículo";
            this.btnEditarVeiculo.UseVisualStyleBackColor = true;
            this.btnEditarVeiculo.Click += new System.EventHandler(this.btnEditarVeiculo_Click);
            // 
            // btnEliminarVeiculo
            // 
            this.btnEliminarVeiculo.Location = new System.Drawing.Point(700, 350);
            this.btnEliminarVeiculo.Name = "btnEliminarVeiculo";
            this.btnEliminarVeiculo.Size = new System.Drawing.Size(310, 72);
            this.btnEliminarVeiculo.TabIndex = 3;
            this.btnEliminarVeiculo.Text = "Eliminar Veículo";
            this.btnEliminarVeiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVeiculo.Click += new System.EventHandler(this.btnEliminarVeiculo_Click);
            // 
            // FormDadosVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminarVeiculo);
            this.Controls.Add(this.btnEditarVeiculo);
            this.Controls.Add(this.btnInserirVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormDadosVeiculo";
            this.Text = "Dados Veículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDadosVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInserirVeiculo;
        private System.Windows.Forms.Button btnEditarVeiculo;
        private System.Windows.Forms.Button btnEliminarVeiculo;
    }
}
