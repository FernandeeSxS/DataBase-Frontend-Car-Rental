using System;

namespace AluguerAutomoveis
{
    partial class FormNovoContacto
    {
        /// <summary>
        /// Variáveis de designer necessárias.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpeza de todos os recursos em uso.
        /// </summary>
        /// <param name="disposing">Se os recursos gerenciados devem ser descartados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para a criação do Designer. Não modifique o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtTipoContactoId = new System.Windows.Forms.TextBox();
            this.txtCondutorId = new System.Windows.Forms.TextBox();
            this.txtOrganizacaoId = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTipoContacto = new System.Windows.Forms.Label();
            this.lblCondutorId = new System.Windows.Forms.Label();
            this.lblOrganizacaoId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();  
            this.SuspendLayout();
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(125, 50);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 20);
            this.txtContact.TabIndex = 0;
            // 
            // txtTipoContactoId
            // 
            this.txtTipoContactoId.Location = new System.Drawing.Point(125, 90);
            this.txtTipoContactoId.Name = "txtTipoContactoId";
            this.txtTipoContactoId.Size = new System.Drawing.Size(200, 20);
            this.txtTipoContactoId.TabIndex = 1;
            // 
            // txtCondutorId
            // 
            this.txtCondutorId.Location = new System.Drawing.Point(125, 130);
            this.txtCondutorId.Name = "txtCondutorId";
            this.txtCondutorId.Size = new System.Drawing.Size(200, 20);
            this.txtCondutorId.TabIndex = 2;
            // 
            // txtOrganizacaoId
            // 
            this.txtOrganizacaoId.Location = new System.Drawing.Point(125, 170);
            this.txtOrganizacaoId.Name = "txtOrganizacaoId";
            this.txtOrganizacaoId.Size = new System.Drawing.Size(200, 20);
            this.txtOrganizacaoId.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(125, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(60, 53);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(50, 13);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contacto";
            // 
            // lblTipoContacto
            // 
            this.lblTipoContacto.AutoSize = true;
            this.lblTipoContacto.Location = new System.Drawing.Point(13, 93);
            this.lblTipoContacto.Name = "lblTipoContacto";
            this.lblTipoContacto.Size = new System.Drawing.Size(109, 13);
            this.lblTipoContacto.TabIndex = 6;
            this.lblTipoContacto.Text = "Tipo de Contacto (ID)";
            this.lblTipoContacto.Click += new System.EventHandler(this.lblTipoContacto_Click);
            // 
            // lblCondutorId
            // 
            this.lblCondutorId.AutoSize = true;
            this.lblCondutorId.Location = new System.Drawing.Point(60, 133);
            this.lblCondutorId.Name = "lblCondutorId";
            this.lblCondutorId.Size = new System.Drawing.Size(62, 13);
            this.lblCondutorId.TabIndex = 7;
            this.lblCondutorId.Text = "Condutor Id";
            // 
            // lblOrganizacaoId
            // 
            this.lblOrganizacaoId.AutoSize = true;
            this.lblOrganizacaoId.Location = new System.Drawing.Point(43, 173);
            this.lblOrganizacaoId.Name = "lblOrganizacaoId";
            this.lblOrganizacaoId.Size = new System.Drawing.Size(79, 13);
            this.lblOrganizacaoId.TabIndex = 8;
            this.lblOrganizacaoId.Text = "Organização Id";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(125, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 24);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Adicionar Contacto";
            // 
            // FormNovoContacto
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.lblOrganizacaoId);
            this.Controls.Add(this.lblCondutorId);
            this.Controls.Add(this.lblTipoContacto);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtOrganizacaoId);
            this.Controls.Add(this.txtCondutorId);
            this.Controls.Add(this.txtTipoContactoId);
            this.Controls.Add(this.txtContact);
            this.Name = "FormNovoContacto";
            this.Text = "Adicionar Contacto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNovoContactoDLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void FormNovoContactoDLoad(object sender, EventArgs e)
        {
            // Centraliza o título
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 20;

            // Centraliza os campos de texto
            int textBoxWidth = 300;
            int textBoxSpacing = 10;
            int startX = (this.ClientSize.Width - textBoxWidth) / 2;
            int currentY = lblTitulo.Bottom + 20;

            txtContact.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtContact.Height + textBoxSpacing;

            txtTipoContactoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtTipoContactoId.Height + textBoxSpacing;

            txtCondutorId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCondutorId.Height + textBoxSpacing;

            txtOrganizacaoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtOrganizacaoId.Height + textBoxSpacing;

            // Centraliza o botão Salvar
            btnGuardar.Left = (this.ClientSize.Width - btnGuardar.Width) / 2;
            btnGuardar.Top = currentY + 20;
        }


        #endregion

        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtTipoContactoId;
        private System.Windows.Forms.TextBox txtCondutorId;
        private System.Windows.Forms.TextBox txtOrganizacaoId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTipoContacto;
        private System.Windows.Forms.Label lblCondutorId;
        private System.Windows.Forms.Label lblOrganizacaoId;
        private System.Windows.Forms.Label lblTitulo;
    }

}
