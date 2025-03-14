using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormInserirCondutor
    {
        /// <summary>
        /// Variáveis necessárias para suporte - não modifique
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpeza de recursos
        /// </summary>
        /// <param name="disposing">Indica se os recursos gerenciados devem ser descartados</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region PlaceHolders
        // Evento quando o campo 'NomeCondutor' recebe foco
        private void txtNomeCondutor_Enter(object sender, EventArgs e)
        {
            if (txtNomeCondutor.Text == "Nome do Condutor")
            {
                txtNomeCondutor.Text = "";
            }
        }

        // Evento quando o campo 'NomeCondutor' perde o foco
        private void txtNomeCondutor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCondutor.Text))
            {
                txtNomeCondutor.Text = "Nome do Condutor";
            }
        }

        // Evento quando o campo 'Rua' recebe foco
        private void txtRua_Enter(object sender, EventArgs e)
        {
            if (txtRua.Text == "Rua do Condutor")
            {
                txtRua.Text = "";
            }
        }

        // Evento quando o campo 'Rua' perde o foco
        private void txtRua_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                txtRua.Text = "Rua do Condutor";
            }
        }

        // Evento quando o campo 'DocIdentificacao' recebe foco
        private void txtDocIdentificacao_Enter(object sender, EventArgs e)
        {
            if (txtDocIdentificacao.Text == "Documento de Identificação")
            {
                txtDocIdentificacao.Text = "";
            }
        }

        // Evento quando o campo 'DocIdentificacao' perde o foco
        private void txtDocIdentificacao_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocIdentificacao.Text))
            {
                txtDocIdentificacao.Text = "Documento de Identificação";
            }
        }

        // Evento quando o campo 'TipoClienteId' recebe foco
        private void txtTipoClienteId_Enter(object sender, EventArgs e)
        {
            if (txtTipoClienteId.Text == "Tipo de Cliente")
            {
                txtTipoClienteId.Text = "";
            }
        }

        // Evento quando o campo 'TipoClienteId' perde o foco
        private void txtTipoClienteId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoClienteId.Text))
            {
                txtTipoClienteId.Text = "Tipo de Cliente";
            }
        }

        // Evento quando o campo 'DataNasc' recebe foco
        private void txtDataNasc_Enter(object sender, EventArgs e)
        {
            if (txtDataNasc.Text == "Data de Nascimento")
            {
                txtDataNasc.Text = "";
            }
        }

        // Evento quando o campo 'DataNasc' perde o foco
        private void txtDataNasc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDataNasc.Text))
            {
                txtDataNasc.Text = "Data de Nascimento";
            }
        }

        // Evento quando o campo 'TituloCondutor' recebe foco
        private void txtTituloCondutor_Enter(object sender, EventArgs e)
        {
            if (txtTituloCondutor.Text == "Título do Condutor")
            {
                txtTituloCondutor.Text = "";
            }
        }

        // Evento quando o campo 'TituloCondutor' perde o foco
        private void txtTituloCondutor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloCondutor.Text))
            {
                txtTituloCondutor.Text = "Título do Condutor";
            }
        }

        // Evento quando o campo 'CartaoMB' recebe foco
        private void txtCartaoMB_Enter(object sender, EventArgs e)
        {
            if (txtCartaoMB.Text == "Cartão MB")
            {
                txtCartaoMB.Text = "";
            }
        }

        // Evento quando o campo 'CartaoMB' perde o foco
        private void txtCartaoMB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCartaoMB.Text))
            {
                txtCartaoMB.Text = "Cartão MB";
            }
        }

        // Evento quando o campo 'CP' recebe foco
        private void txtCP_Enter(object sender, EventArgs e)
        {
            if (txtCP.Text == "Código Postal")
            {
                txtCP.Text = "";
            }
        }

        // Evento quando o campo 'CP' perde o foco
        private void txtCP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCP.Text))
            {
                txtCP.Text = "Código Postal";
            }
        }

        // Evento quando o campo 'OrganizacaoId' recebe foco
        private void txtOrganizacaoId_Enter(object sender, EventArgs e)
        {
            if (txtOrganizacaoId.Text == "ID Organização")
            {
                txtOrganizacaoId.Text = "";
            }
        }

        // Evento quando o campo 'OrganizacaoId' perde o foco
        private void txtOrganizacaoId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrganizacaoId.Text))
            {
                txtOrganizacaoId.Text = "ID Organização";
            }
        }
        #endregion


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer. Não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCondutor = new System.Windows.Forms.DataGridView();
            this.txtCondutorId = new System.Windows.Forms.TextBox();
            this.txtNomeCondutor = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtDocIdentificacao = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.txtTituloCondutor = new System.Windows.Forms.TextBox();
            this.txtCartaoMB = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtOrganizacaoId = new System.Windows.Forms.TextBox();
            this.txtTipoClienteId = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondutor)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewCondutor
            // 
            this.dataGridViewCondutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCondutor.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCondutor.Name = "dataGridViewCondutor";
            this.dataGridViewCondutor.Size = new System.Drawing.Size(560, 150);
            this.dataGridViewCondutor.TabIndex = 0;
            this.dataGridViewCondutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 180); 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 26);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Gestão de Condutores"; 

            // 
            // txtCondutorId
            // 
            this.txtCondutorId.Location = new System.Drawing.Point(12, 200);
            this.txtCondutorId.Name = "txtCondutorId";
            this.txtCondutorId.Size = new System.Drawing.Size(100, 20);
            this.txtCondutorId.TabIndex = 1;
            this.txtCondutorId.Visible = false;

            // 
            // txtNomeCondutor
            // 
            this.txtNomeCondutor.Location = new System.Drawing.Point(12, 230);
            this.txtNomeCondutor.Name = "txtNomeCondutor";
            this.txtNomeCondutor.Size = new System.Drawing.Size(200, 20);
            this.txtNomeCondutor.TabIndex = 2;
            this.txtNomeCondutor.Enter += new System.EventHandler(this.txtNomeCondutor_Enter);
            this.txtNomeCondutor.Leave += new System.EventHandler(this.txtNomeCondutor_Leave);
            this.txtNomeCondutor.Text = "Nome do Condutor";

            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(12, 260);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(200, 20);
            this.txtRua.TabIndex = 3;
            this.txtRua.Enter += new System.EventHandler(this.txtRua_Enter);
            this.txtRua.Leave += new System.EventHandler(this.txtRua_Leave);
            this.txtRua.Text = "Rua do Condutor";

            // 
            // txtDocIdentificacao
            // 
            this.txtDocIdentificacao.Location = new System.Drawing.Point(12, 290);
            this.txtDocIdentificacao.Name = "txtDocIdentificacao";
            this.txtDocIdentificacao.Size = new System.Drawing.Size(200, 20);
            this.txtDocIdentificacao.TabIndex = 4;
            this.txtDocIdentificacao.Enter += new System.EventHandler(this.txtDocIdentificacao_Enter);
            this.txtDocIdentificacao.Leave += new System.EventHandler(this.txtDocIdentificacao_Leave);
            this.txtDocIdentificacao.Text = "Documento de Identificação";

            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(220, 230);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(100, 20);
            this.txtDataNasc.TabIndex = 5;
            this.txtDataNasc.Enter += new System.EventHandler(this.txtDataNasc_Enter);
            this.txtDataNasc.Leave += new System.EventHandler(this.txtDataNasc_Leave);
            this.txtDataNasc.Text = "Data de Nascimento";

            // 
            // txtTituloCondutor
            // 
            this.txtTituloCondutor.Location = new System.Drawing.Point(220, 260);
            this.txtTituloCondutor.Name = "txtTituloCondutor";
            this.txtTituloCondutor.Size = new System.Drawing.Size(100, 20);
            this.txtTituloCondutor.TabIndex = 6;
            this.txtTituloCondutor.Enter += new System.EventHandler(this.txtTituloCondutor_Enter);
            this.txtTituloCondutor.Leave += new System.EventHandler(this.txtTituloCondutor_Leave);
            this.txtTituloCondutor.Text = "Título do Condutor";

            // 
            // txtCartaoMB
            // 
            this.txtCartaoMB.Location = new System.Drawing.Point(220, 290);
            this.txtCartaoMB.Name = "txtCartaoMB";
            this.txtCartaoMB.Size = new System.Drawing.Size(100, 20);
            this.txtCartaoMB.TabIndex = 7;
            this.txtCartaoMB.Enter += new System.EventHandler(this.txtCartaoMB_Enter);
            this.txtCartaoMB.Leave += new System.EventHandler(this.txtCartaoMB_Leave);
            this.txtCartaoMB.Text = "Cartão MB";

            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(330, 230);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 8;
            this.txtCP.Enter += new System.EventHandler(this.txtCP_Enter);
            this.txtCP.Leave += new System.EventHandler(this.txtCP_Leave);
            this.txtCP.Text = "Código Postal";

            // 
            // txtOrganizacaoId
            // 
            this.txtOrganizacaoId.Location = new System.Drawing.Point(330, 260);
            this.txtOrganizacaoId.Name = "txtOrganizacaoId";
            this.txtOrganizacaoId.Size = new System.Drawing.Size(100, 20);
            this.txtOrganizacaoId.TabIndex = 9;
            this.txtOrganizacaoId.Enter += new System.EventHandler(this.txtOrganizacaoId_Enter);
            this.txtOrganizacaoId.Leave += new System.EventHandler(this.txtOrganizacaoId_Leave);
            this.txtOrganizacaoId.Text = "ID Organização";

            // 
            // txtTipoClienteId
            // 
            this.txtTipoClienteId.Location = new System.Drawing.Point(330, 290);
            this.txtTipoClienteId.Name = "txtTipoClienteId";
            this.txtTipoClienteId.Size = new System.Drawing.Size(100, 20);
            this.txtTipoClienteId.TabIndex = 10;
            this.txtTipoClienteId.Text = "Tipo de Cliente";
            this.txtTipoClienteId.Enter += new System.EventHandler(this.txtTipoClienteId_Enter);
            this.txtTipoClienteId.Leave += new System.EventHandler(this.txtTipoClienteId_Leave);

            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 320);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtTipoClienteId);
            this.Controls.Add(this.txtOrganizacaoId);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtCartaoMB);
            this.Controls.Add(this.txtTituloCondutor);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtDocIdentificacao);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNomeCondutor);
            this.Controls.Add(this.txtCondutorId);
            this.Controls.Add(this.dataGridViewCondutor);
            this.Name = "Form2";
            this.Text = "Gestão de Condutor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Load += new System.EventHandler(this.FormNovoCondutorDLoad);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void FormNovoCondutorDLoad(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 20;

            dataGridViewCondutor.Width = this.ClientSize.Width - 100;
            dataGridViewCondutor.Left = (this.ClientSize.Width - dataGridViewCondutor.Width) / 2;
            dataGridViewCondutor.Top = lblTitulo.Bottom + 20;

            int textBoxWidth = 300;
            int textBoxSpacing = 10;
            int startX = (this.ClientSize.Width - textBoxWidth) / 2;
            int currentY = dataGridViewCondutor.Bottom + 20;

            txtCondutorId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCondutorId.Height + textBoxSpacing;

            txtNomeCondutor.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtNomeCondutor.Height + textBoxSpacing;

            txtRua.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtRua.Height + textBoxSpacing;

            txtDocIdentificacao.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDocIdentificacao.Height + textBoxSpacing;

            txtDataNasc.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDataNasc.Height + textBoxSpacing;

            txtTituloCondutor.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtTituloCondutor.Height + textBoxSpacing;

            txtCartaoMB.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCartaoMB.Height + textBoxSpacing;

            txtCP.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCP.Height + textBoxSpacing;

            txtOrganizacaoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtOrganizacaoId.Height + textBoxSpacing;

            txtTipoClienteId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtTipoClienteId.Height + textBoxSpacing;

            btnAdicionar.Left = (this.ClientSize.Width - btnAdicionar.Width) / 2;
            btnAdicionar.Top = currentY + 20;
        }



        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCondutor;
        private System.Windows.Forms.TextBox txtCondutorId;
        private System.Windows.Forms.TextBox txtNomeCondutor;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtDocIdentificacao;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.TextBox txtTituloCondutor;
        private System.Windows.Forms.TextBox txtCartaoMB;
        private System.Windows.Forms.TextBox txtTipoClienteId;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtOrganizacaoId;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblTitulo;
    }

}

