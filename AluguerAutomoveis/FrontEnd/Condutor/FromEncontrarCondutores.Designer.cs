using System;

namespace AluguerAutomoveis
{
    partial class FormEncontrarCondutores
    {
        /// <summary>
        /// Variáveis necessárias para o designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão em uso.
        /// </summary>
        /// <param name="disposing">Se true, elimina os recursos gerenciados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region PlaceHolders
        // Evento quando o campo 'txtIdade' recebe foco
        private void txtIdade_Enter(object sender, EventArgs e)
        {
            if (txtIdade.Text == "Idade Mínima")
            {
                txtIdade.Text = "";
            }
        }

        // Evento quando o campo 'txtIdade' perde o foco
        private void txtIdade_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                txtIdade.Text = "Idade Mínima";
            }
        }

        // Evento quando o campo 'txtNomeOrganizacao' recebe foco
        private void txtNomeOrganizacao_Enter(object sender, EventArgs e)
        {
            if (txtNomeOrganizacao.Text == "Nome da Organização")
            {
                txtNomeOrganizacao.Text = "";
            }
        }

        // Evento quando o campo 'txtNomeOrganizacao' perde o foco
        private void txtNomeOrganizacao_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeOrganizacao.Text))
            {
                txtNomeOrganizacao.Text = "Nome da Organização";
            }
        }

        #endregion

        #region Código gerado pelo Designer

        /// <summary>
        /// Método necessário para suportar o Designer
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNomeOrganizacao = new System.Windows.Forms.TextBox();
            this.btnEncontrarCondutores = new System.Windows.Forms.Button();
            this.dgvCondutores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondutores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 20);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(250, 20);
            this.txtIdade.TabIndex = 0;
            this.txtIdade.Enter += new System.EventHandler(this.txtIdade_Enter);
            this.txtIdade.Leave += new System.EventHandler(this.txtIdade_Leave);
            this.txtIdade.Text = "Idade Mínima"; 
            // 
            // txtNomeOrganizacao
            // 
            this.txtNomeOrganizacao.Location = new System.Drawing.Point(12, 60);
            this.txtNomeOrganizacao.Name = "txtNomeOrganizacao";
            this.txtNomeOrganizacao.Size = new System.Drawing.Size(250, 20);
            this.txtNomeOrganizacao.TabIndex = 1;
            this.txtNomeOrganizacao.Enter += new System.EventHandler(this.txtNomeOrganizacao_Enter);
            this.txtNomeOrganizacao.Leave += new System.EventHandler(this.txtNomeOrganizacao_Leave);
            this.txtNomeOrganizacao.Text = "Nome da Organização"; 
            // 
            // btnBuscarCondutores
            // 
            this.btnEncontrarCondutores.Location = new System.Drawing.Point(12, 100);
            this.btnEncontrarCondutores.Name = "btnEncontrarCondutores";
            this.btnEncontrarCondutores.Size = new System.Drawing.Size(250, 30);
            this.btnEncontrarCondutores.TabIndex = 2;
            this.btnEncontrarCondutores.Text = "Encontrar Condutores";
            this.btnEncontrarCondutores.UseVisualStyleBackColor = true;
            this.btnEncontrarCondutores.Click += new System.EventHandler(this.btnEncontrarCondutores_Click);
            // 
            // dgvCondutores
            // 
            this.dgvCondutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondutores.Location = new System.Drawing.Point(12, 140);
            this.dgvCondutores.Name = "dgvCondutores";
            this.dgvCondutores.Size = new System.Drawing.Size(720, 280);
            this.dgvCondutores.TabIndex = 3;
            this.dgvCondutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // FormEncontrarCondutores
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.dgvCondutores);
            this.Controls.Add(this.btnEncontrarCondutores);
            this.Controls.Add(this.txtNomeOrganizacao);
            this.Controls.Add(this.txtIdade);
            this.Name = "FormEncontrarCondutores";
            this.Text = "Aluguer de Automóveis - Encontrar Condutores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondutores)).EndInit();
            this.Load += new System.EventHandler(this.FormEncontrarCondutoresDLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormEncontrarCondutoresDLoad(object sender, EventArgs e)
        {
            txtIdade.Left = (this.ClientSize.Width - txtIdade.Width) / 2;
            txtIdade.Top = 20;

            txtNomeOrganizacao.Left = (this.ClientSize.Width - txtNomeOrganizacao.Width) / 2;
            txtNomeOrganizacao.Top = txtIdade.Bottom + 20;

            btnEncontrarCondutores.Left = (this.ClientSize.Width - btnEncontrarCondutores.Width) / 2;
            btnEncontrarCondutores.Top = txtNomeOrganizacao.Bottom + 20;

            dgvCondutores.Width = this.ClientSize.Width - 100;
            dgvCondutores.Left = (this.ClientSize.Width - dgvCondutores.Width) / 2;
            dgvCondutores.Top = btnEncontrarCondutores.Bottom + 20;
        }


        #endregion

        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNomeOrganizacao;
        private System.Windows.Forms.Button btnEncontrarCondutores;
        private System.Windows.Forms.DataGridView dgvCondutores;
    }



}