using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormNovaMarca
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
            this.txtMarcaId = new System.Windows.Forms.TextBox();
            this.txtDescricaoMarca = new System.Windows.Forms.TextBox();
            this.btnAdicionarMarca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label(); 
            this.SuspendLayout();

            // 
            // txtMarcaId
            // 
            this.txtMarcaId.Location = new System.Drawing.Point(12, 36);
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.ReadOnly = true;
            this.txtMarcaId.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaId.TabIndex = 0;

            // 
            // txtDescricaoMarca
            // 
            this.txtDescricaoMarca.Location = new System.Drawing.Point(118, 36);
            this.txtDescricaoMarca.Name = "txtDescricaoMarca";
            this.txtDescricaoMarca.Size = new System.Drawing.Size(154, 20);
            this.txtDescricaoMarca.TabIndex = 1;

            // 
            // btnAdicionarMarca
            // 
            this.btnAdicionarMarca.Location = new System.Drawing.Point(197, 62);
            this.btnAdicionarMarca.Name = "btnAdicionarMarca";
            this.btnAdicionarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarMarca.TabIndex = 2;
            this.btnAdicionarMarca.Text = "Adicionar";
            this.btnAdicionarMarca.UseVisualStyleBackColor = true;
            this.btnAdicionarMarca.Click += new System.EventHandler(this.btnAdicionarMarca_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca ID:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição da Marca:";

            // 
            // lblTitulo - Novo Label
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(300, 20); 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 26); 
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Nova Marca";

            // 
            // FormNovaMarca
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarMarca);
            this.Controls.Add(this.txtDescricaoMarca);
            this.Controls.Add(this.txtMarcaId);
            this.Name = "FormNovaMarca";
            this.Text = "Nova Marca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNovaMarcaDLoad); 
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Função FormNovaMarcaDLoad
        private void FormNovaMarcaDLoad(object sender, EventArgs e)
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

            txtMarcaId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtMarcaId.Height + textBoxSpacing;

            label2.SetBounds(labelX, currentY, 100, 20);
            currentY += label2.Height + textBoxSpacing;

            txtDescricaoMarca.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDescricaoMarca.Height + textBoxSpacing;

            btnAdicionarMarca.Left = (this.ClientSize.Width - btnAdicionarMarca.Width) / 2;
            btnAdicionarMarca.Top = currentY + 20;
        }

        private System.Windows.Forms.TextBox txtMarcaId;
        private System.Windows.Forms.TextBox txtDescricaoMarca;
        private System.Windows.Forms.Button btnAdicionarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo; 
    }
}
