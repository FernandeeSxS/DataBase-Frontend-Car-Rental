using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormNovasCondicoes
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
            this.txtCondicoesEntregaId = new System.Windows.Forms.TextBox();
            this.txtDescricaoCondicoesEntrega = new System.Windows.Forms.TextBox();
            this.btnAdicionarCondicoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label(); 
            this.SuspendLayout();

            // 
            // txtCondicoesEntregaId
            // 
            this.txtCondicoesEntregaId.Location = new System.Drawing.Point(38, 36);
            this.txtCondicoesEntregaId.Name = "txtCondicoesEntregaId";
            this.txtCondicoesEntregaId.ReadOnly = true;
            this.txtCondicoesEntregaId.Size = new System.Drawing.Size(157, 20);
            this.txtCondicoesEntregaId.TabIndex = 0;

            // 
            // txtDescricaoCondicoesEntrega
            // 
            this.txtDescricaoCondicoesEntrega.Location = new System.Drawing.Point(250, 36);
            this.txtDescricaoCondicoesEntrega.Name = "txtDescricaoCondicoesEntrega";
            this.txtDescricaoCondicoesEntrega.Size = new System.Drawing.Size(154, 20);
            this.txtDescricaoCondicoesEntrega.TabIndex = 1;

            // 
            // btnAdicionarCondicoes
            // 
            this.btnAdicionarCondicoes.Location = new System.Drawing.Point(162, 78);
            this.btnAdicionarCondicoes.Name = "btnAdicionarCondicoes";
            this.btnAdicionarCondicoes.Size = new System.Drawing.Size(92, 33);
            this.btnAdicionarCondicoes.TabIndex = 2;
            this.btnAdicionarCondicoes.Text = "Adicionar";
            this.btnAdicionarCondicoes.UseVisualStyleBackColor = true;
            this.btnAdicionarCondicoes.Click += new System.EventHandler(this.btnAdicionarCondicoes_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Condições de Entrega ID:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição das Condições de Entrega:";

            // 
            // lblTitulo - Novo Label
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(300, 20); 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 26); 
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Novas Condições de Entrega"; 

            // 
            // FormNovasCondicoes
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarCondicoes);
            this.Controls.Add(this.txtDescricaoCondicoesEntrega);
            this.Controls.Add(this.txtCondicoesEntregaId);
            this.Name = "FormNovasCondicoes";
            this.Text = "Novas Condições de Entrega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNovasCondicoesDLoad); 
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Função FormNovasCondicoesDLoad
        private void FormNovasCondicoesDLoad(object sender, EventArgs e)
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

            txtCondicoesEntregaId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCondicoesEntregaId.Height + textBoxSpacing;

            label2.SetBounds(labelX, currentY, 100, 20);
            currentY += label2.Height + textBoxSpacing;

            txtDescricaoCondicoesEntrega.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDescricaoCondicoesEntrega.Height + textBoxSpacing;

            btnAdicionarCondicoes.Left = (this.ClientSize.Width - btnAdicionarCondicoes.Width) / 2;
            btnAdicionarCondicoes.Top = currentY + 20;
        }

        private System.Windows.Forms.TextBox txtCondicoesEntregaId;
        private System.Windows.Forms.TextBox txtDescricaoCondicoesEntrega;
        private System.Windows.Forms.Button btnAdicionarCondicoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo; 
    }
}
