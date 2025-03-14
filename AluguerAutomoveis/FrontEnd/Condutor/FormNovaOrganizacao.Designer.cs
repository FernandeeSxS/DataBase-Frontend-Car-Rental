using System;

namespace AluguerAutomoveis
{
    partial class FormNovaOrganizacao
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOrganizacaoId = new System.Windows.Forms.Label();
            this.txtOrganizacaoId = new System.Windows.Forms.TextBox();
            this.lblNomeOrg = new System.Windows.Forms.Label();
            this.txtNomeOrg = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblRepresentanteOrg = new System.Windows.Forms.Label();
            this.txtRepresentanteOrg = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Título do Formulário
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Criar Organização";

            // Label OrganizacaoId
            this.lblOrganizacaoId.AutoSize = true;
            this.lblOrganizacaoId.Location = new System.Drawing.Point(12, 60);
            this.lblOrganizacaoId.Name = "lblOrganizacaoId";
            this.lblOrganizacaoId.Size = new System.Drawing.Size(84, 15);
            this.lblOrganizacaoId.TabIndex = 1;
            this.lblOrganizacaoId.Text = "Organização ID";

            // TextBox OrganizacaoId
            this.txtOrganizacaoId.Location = new System.Drawing.Point(130, 57);
            this.txtOrganizacaoId.Name = "txtOrganizacaoId";
            this.txtOrganizacaoId.ReadOnly = true;
            this.txtOrganizacaoId.Size = new System.Drawing.Size(200, 23);
            this.txtOrganizacaoId.TabIndex = 2;

            // Label NomeOrg
            this.lblNomeOrg.AutoSize = true;
            this.lblNomeOrg.Location = new System.Drawing.Point(12, 100);
            this.lblNomeOrg.Name = "lblNomeOrg";
            this.lblNomeOrg.Size = new System.Drawing.Size(99, 15);
            this.lblNomeOrg.TabIndex = 3;
            this.lblNomeOrg.Text = "Nome Organização";

            // TextBox NomeOrg
            this.txtNomeOrg.Location = new System.Drawing.Point(130, 97);
            this.txtNomeOrg.Name = "txtNomeOrg";
            this.txtNomeOrg.Size = new System.Drawing.Size(200, 23);
            this.txtNomeOrg.TabIndex = 4;

            // Label Rua
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(12, 140);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 15);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Rua";

            // TextBox Rua
            this.txtRua.Location = new System.Drawing.Point(130, 137);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(200, 23);
            this.txtRua.TabIndex = 6;

            // Label NIF
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(12, 180);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(25, 15);
            this.lblNIF.TabIndex = 7;
            this.lblNIF.Text = "NIF";

            // TextBox NIF
            this.txtNIF.Location = new System.Drawing.Point(130, 177);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(200, 23);
            this.txtNIF.TabIndex = 8;

            // Label RepresentanteOrg
            this.lblRepresentanteOrg.AutoSize = true;
            this.lblRepresentanteOrg.Location = new System.Drawing.Point(12, 220);
            this.lblRepresentanteOrg.Name = "lblRepresentanteOrg";
            this.lblRepresentanteOrg.Size = new System.Drawing.Size(112, 15);
            this.lblRepresentanteOrg.TabIndex = 9;
            this.lblRepresentanteOrg.Text = "Representante Org";

            // TextBox RepresentanteOrg
            this.txtRepresentanteOrg.Location = new System.Drawing.Point(130, 217);
            this.txtRepresentanteOrg.Name = "txtRepresentanteOrg";
            this.txtRepresentanteOrg.Size = new System.Drawing.Size(200, 23);
            this.txtRepresentanteOrg.TabIndex = 10;

            // Label CP
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(12, 260);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(21, 15);
            this.lblCP.TabIndex = 11;
            this.lblCP.Text = "CP";

            // TextBox CP
            this.txtCP.Location = new System.Drawing.Point(130, 257);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(200, 23);
            this.txtCP.TabIndex = 12;

            // Button Salvar
            this.btnSalvar.Location = new System.Drawing.Point(130, 300);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FormNovaOrganizacao
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblRepresentanteOrg);
            this.Controls.Add(this.txtRepresentanteOrg);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblNomeOrg);
            this.Controls.Add(this.txtNomeOrg);
            this.Controls.Add(this.lblOrganizacaoId);
            this.Controls.Add(this.txtOrganizacaoId);
            this.Load += new System.EventHandler(this.FormNovaOrganizacaoDLoad);
            this.Name = "FormNovaOrganizacao";
            this.Text = "Nova Organização";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void FormNovaOrganizacaoDLoad(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 20;

            int textBoxWidth = 300;
            int textBoxSpacing = 10;
            int startX = (this.ClientSize.Width - textBoxWidth) / 2;
            int currentY = lblTitulo.Bottom + 20;

            txtOrganizacaoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtOrganizacaoId.Height + textBoxSpacing;

            txtNomeOrg.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtNomeOrg.Height + textBoxSpacing;

            txtRua.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtRua.Height + textBoxSpacing;

            txtNIF.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtNIF.Height + textBoxSpacing;

            txtRepresentanteOrg.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtRepresentanteOrg.Height + textBoxSpacing;

            txtCP.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCP.Height + textBoxSpacing;

            btnSalvar.Left = (this.ClientSize.Width - btnSalvar.Width) / 2;
            btnSalvar.Top = currentY + 20;

            btnCancelar.Left = (this.ClientSize.Width - btnCancelar.Width) / 2;
            btnCancelar.Top = btnSalvar.Bottom + 10;
        }


        private System.Windows.Forms.Label lblOrganizacaoId;
        private System.Windows.Forms.TextBox txtOrganizacaoId;
        private System.Windows.Forms.Label lblNomeOrg;
        private System.Windows.Forms.TextBox txtNomeOrg;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblRepresentanteOrg;
        private System.Windows.Forms.TextBox txtRepresentanteOrg;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
    }
}