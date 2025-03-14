using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormNovoModelo
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

        private void InitializeComponent()
        {
            this.txtModeloId = new System.Windows.Forms.TextBox();
            this.txtDescricaoModelo = new System.Windows.Forms.TextBox();
            this.txtMarcaId = new System.Windows.Forms.TextBox();
            this.btnAdicionarModelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label(); 
            this.SuspendLayout();

            // 
            // txtModeloId
            // 
            this.txtModeloId.Location = new System.Drawing.Point(12, 36);
            this.txtModeloId.Name = "txtModeloId";
            this.txtModeloId.ReadOnly = true;
            this.txtModeloId.Size = new System.Drawing.Size(100, 20);
            this.txtModeloId.TabIndex = 0;

            // 
            // txtDescricaoModelo
            // 
            this.txtDescricaoModelo.Location = new System.Drawing.Point(118, 36);
            this.txtDescricaoModelo.Name = "txtDescricaoModelo";
            this.txtDescricaoModelo.Size = new System.Drawing.Size(154, 20);
            this.txtDescricaoModelo.TabIndex = 1;

            // 
            // txtMarcaId
            // 
            this.txtMarcaId.Location = new System.Drawing.Point(12, 86);
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaId.TabIndex = 2;

            // 
            // btnAdicionarModelo
            // 
            this.btnAdicionarModelo.Location = new System.Drawing.Point(197, 112);
            this.btnAdicionarModelo.Name = "btnAdicionarModelo";
            this.btnAdicionarModelo.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarModelo.TabIndex = 3;
            this.btnAdicionarModelo.Text = "Adicionar";
            this.btnAdicionarModelo.UseVisualStyleBackColor = true;
            this.btnAdicionarModelo.Click += new System.EventHandler(this.btnAdicionarModelo_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo ID:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição do Modelo:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca ID:";

            // 
            // lblTitulo - Novo Label
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(300, 20); 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 26); 
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Novo Modelo";

            // 
            // FormNovoModelo
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarModelo);
            this.Controls.Add(this.txtMarcaId);
            this.Controls.Add(this.txtDescricaoModelo);
            this.Controls.Add(this.txtModeloId);
            this.Name = "FormNovoModelo";
            this.Text = "Novo Modelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNovoModeloDLoad); 
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Função FormNovoModeloDLoad
        private void FormNovoModeloDLoad(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 20;

            int textBoxWidth = 300;
            int textBoxSpacing = 10;

            int startX = (this.ClientSize.Width - textBoxWidth) / 2;

            int currentY = lblTitulo.Bottom + 20;

            int labelX = startX - 110; 

            label1.SetBounds(labelX, currentY, 100, 20);
            currentY += label1.Height + textBoxSpacing;

            txtModeloId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtModeloId.Height + textBoxSpacing;

            label2.SetBounds(labelX, currentY, 100, 20);
            currentY += label2.Height + textBoxSpacing;

            txtDescricaoModelo.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDescricaoModelo.Height + textBoxSpacing;

            label3.SetBounds(labelX, currentY, 100, 20);
            currentY += label3.Height + textBoxSpacing;

            txtMarcaId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtMarcaId.Height + textBoxSpacing;

            btnAdicionarModelo.Left = (this.ClientSize.Width - btnAdicionarModelo.Width) / 2;
            btnAdicionarModelo.Top = currentY + 20;
        }

        private System.Windows.Forms.TextBox txtModeloId;
        private System.Windows.Forms.TextBox txtDescricaoModelo;
        private System.Windows.Forms.TextBox txtMarcaId;
        private System.Windows.Forms.Button btnAdicionarModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo; 
    }
}
