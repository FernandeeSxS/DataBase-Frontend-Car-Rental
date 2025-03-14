using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormDadosCondutor
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

        private void FormDadosCondutor_Load(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;

            btnInserirCondutor.Left = (this.ClientSize.Width - btnInserirCondutor.Width) / 2;
            btnInserirCondutor.Top = 150;

            btnEditarCondutor.Left = (this.ClientSize.Width - btnEditarCondutor.Width) / 2;
            btnEditarCondutor.Top = 250;

            btnEliminarCondutor.Left = (this.ClientSize.Width - btnEliminarCondutor.Width) / 2;
            btnEliminarCondutor.Top = 350;
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInserirCondutor = new System.Windows.Forms.Button();
            this.btnEditarCondutor = new System.Windows.Forms.Button();
            this.btnEliminarCondutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(710, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dados do Condutor";
            // 
            // btnInserirCondutor
            // 
            this.btnInserirCondutor.Location = new System.Drawing.Point(700, 150);
            this.btnInserirCondutor.Name = "btnInserirCondutor";
            this.btnInserirCondutor.Size = new System.Drawing.Size(310, 67);
            this.btnInserirCondutor.TabIndex = 1;
            this.btnInserirCondutor.Text = "Inserir Condutor";
            this.btnInserirCondutor.UseVisualStyleBackColor = true;
            this.btnInserirCondutor.Click += new System.EventHandler(this.btnInserirCondutor_Click);
            // 
            // btnEditarCondutor
            // 
            this.btnEditarCondutor.Location = new System.Drawing.Point(700, 250);
            this.btnEditarCondutor.Name = "btnEditarCondutor";
            this.btnEditarCondutor.Size = new System.Drawing.Size(310, 72);
            this.btnEditarCondutor.TabIndex = 2;
            this.btnEditarCondutor.Text = "Editar Condutor";
            this.btnEditarCondutor.UseVisualStyleBackColor = true;
            this.btnEditarCondutor.Click += new System.EventHandler(this.btnEditarCondutor_Click);
            // 
            // btnEliminarCondutor
            // 
            this.btnEliminarCondutor.Location = new System.Drawing.Point(700, 350);
            this.btnEliminarCondutor.Name = "btnEliminarCondutor";
            this.btnEliminarCondutor.Size = new System.Drawing.Size(310, 72);
            this.btnEliminarCondutor.TabIndex = 3;
            this.btnEliminarCondutor.Text = "Eliminar Condutor";
            this.btnEliminarCondutor.UseVisualStyleBackColor = true;
            this.btnEliminarCondutor.Click += new System.EventHandler(this.btnEliminarCondutor_Click);
            // 
            // FormDadosCondutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 713); 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminarCondutor);
            this.Controls.Add(this.btnEditarCondutor);
            this.Controls.Add(this.btnInserirCondutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormDadosCondutor";
            this.Text = "Dados Condutor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDadosCondutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInserirCondutor;
        private System.Windows.Forms.Button btnEditarCondutor;
        private System.Windows.Forms.Button btnEliminarCondutor;
    }
}
