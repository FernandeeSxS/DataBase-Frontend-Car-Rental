using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormNovoTipoExtra
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
            this.txtTipoExtraId = new System.Windows.Forms.TextBox();
            this.txtDescricaoTipoExtra = new System.Windows.Forms.TextBox();
            this.btnAdicionarTipoExtra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label(); 
            this.SuspendLayout();

            // 
            // txtTipoExtraId
            // 
            this.txtTipoExtraId.Location = new System.Drawing.Point(12, 36);
            this.txtTipoExtraId.Name = "txtTipoExtraId";
            this.txtTipoExtraId.ReadOnly = true;
            this.txtTipoExtraId.Size = new System.Drawing.Size(100, 20);
            this.txtTipoExtraId.TabIndex = 0;

            // 
            // txtDescricaoTipoExtra
            // 
            this.txtDescricaoTipoExtra.Location = new System.Drawing.Point(118, 36);
            this.txtDescricaoTipoExtra.Name = "txtDescricaoTipoExtra";
            this.txtDescricaoTipoExtra.Size = new System.Drawing.Size(154, 20);
            this.txtDescricaoTipoExtra.TabIndex = 1;

            // 
            // btnAdicionarTipoExtra
            // 
            this.btnAdicionarTipoExtra.Location = new System.Drawing.Point(197, 72);
            this.btnAdicionarTipoExtra.Name = "btnAdicionarTipoExtra";
            this.btnAdicionarTipoExtra.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarTipoExtra.TabIndex = 2;
            this.btnAdicionarTipoExtra.Text = "Adicionar";
            this.btnAdicionarTipoExtra.UseVisualStyleBackColor = true;
            this.btnAdicionarTipoExtra.Click += new System.EventHandler(this.btnAdicionarTipoExtra_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo Extra ID:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição Tipo Extra:";

            // 
            // lblTitulo - Novo Label
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(300, 20); 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 26); 
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Novo Tipo Extra"; 

            // 
            // FormNovoTipoExtra
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarTipoExtra);
            this.Controls.Add(this.txtDescricaoTipoExtra);
            this.Controls.Add(this.txtTipoExtraId);
            this.Name = "FormNovoTipoExtra";
            this.Text = "Novo Tipo Extra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNovoTipoExtraDLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void FormNovoTipoExtraDLoad(object sender, EventArgs e)
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

            txtTipoExtraId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtTipoExtraId.Height + textBoxSpacing;

            label2.SetBounds(labelX, currentY, 100, 20);
            currentY += label2.Height + textBoxSpacing;

            txtDescricaoTipoExtra.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDescricaoTipoExtra.Height + textBoxSpacing;

            btnAdicionarTipoExtra.Left = (this.ClientSize.Width - btnAdicionarTipoExtra.Width) / 2;
            btnAdicionarTipoExtra.Top = currentY + 20;
        }





        private System.Windows.Forms.TextBox txtTipoExtraId;
        private System.Windows.Forms.TextBox txtDescricaoTipoExtra;
        private System.Windows.Forms.Button btnAdicionarTipoExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
    }
}
