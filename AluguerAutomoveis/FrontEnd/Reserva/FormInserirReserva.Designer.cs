using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormInserirReserva
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

        // Evento quando o campo 'DataReserva' recebe foco
        private void txtDataRes_Enter(object sender, EventArgs e)
        {
            if (txtDataRes.Text == "Data Reserva")
            {
                txtDataRes.Text = "";
            }
        }

        // Evento quando o campo 'DataReserva' perde o foco
        private void txtDataRes_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDataRes.Text))
            {
                txtDataRes.Text = "Data Reserva";
            }
        }

        // Evento quando o campo 'DataIniAluguer' recebe foco
        private void txtDataIniAluguer_Enter(object sender, EventArgs e)
        {
            if (txtDataIniAluguer.Text == "Data Início Aluguer")
            {
                txtDataIniAluguer.Text = "";
            }
        }

        // Evento quando o campo 'DataIniAluguer' perde o foco
        private void txtDataIniAluguer_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDataIniAluguer.Text))
            {
                txtDataIniAluguer.Text = "Data Início Aluguer";
            }
        }

        // Evento quando o campo 'DataFimAluguer' recebe foco
        private void txtDataFimAluguer_Enter(object sender, EventArgs e)
        {
            if (txtDataFimAluguer.Text == "Data Fim Aluguer")
            {
                txtDataFimAluguer.Text = "";
            }
        }

        // Evento quando o campo 'DataFimAluguer' perde o foco
        private void txtDataFimAluguer_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDataFimAluguer.Text))
            {
                txtDataFimAluguer.Text = "Data Fim Aluguer";
            }
        }

        // Evento quando o campo 'LocalLev' recebe foco
        private void txtLocalLev_Enter(object sender, EventArgs e)
        {
            if (txtLocalLev.Text == "Local Levantamento")
            {
                txtLocalLev.Text = "";
            }
        }

        // Evento quando o campo 'LocalLev' perde o foco
        private void txtLocalLev_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocalLev.Text))
            {
                txtLocalLev.Text = "Local Levantamento";
            }
        }

        // Evento quando o campo 'LocalDev' recebe foco
        private void txtLocalDev_Enter(object sender, EventArgs e)
        {
            if (txtLocalDev.Text == "Local Devolução")
            {
                txtLocalDev.Text = "";
            }
        }

        // Evento quando o campo 'LocalDev' perde o foco
        private void txtLocalDev_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocalDev.Text))
            {
                txtLocalDev.Text = "Local Devolução";
            }
        }

        // Evento quando o campo 'PrecoDiario' recebe foco
        private void txtPrecoDiario_Enter(object sender, EventArgs e)
        {
            if (txtPrecoDiario.Text == "Preço Diário")
            {
                txtPrecoDiario.Text = "";
            }
        }

        // Evento quando o campo 'PrecoDiario' perde o foco
        private void txtPrecoDiario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecoDiario.Text))
            {
                txtPrecoDiario.Text = "Preço Diário";
            }
        }

        // Evento quando o campo 'KmPerm' recebe foco
        private void txtKmPerm_Enter(object sender, EventArgs e)
        {
            if (txtKmPerm.Text == "KM Permitido")
            {
                txtKmPerm.Text = "";
            }
        }

        // Evento quando o campo 'KmPerm' perde o foco
        private void txtKmPerm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKmPerm.Text))
            {
                txtKmPerm.Text = "KM Permitido";
            }
        }

        // Evento quando o campo 'Caucao' recebe foco
        private void txtCaucao_Enter(object sender, EventArgs e)
        {
            if (txtCaucao.Text == "Caução")
            {
                txtCaucao.Text = "";
            }
        }

        // Evento quando o campo 'Caucao' perde o foco
        private void txtCaucao_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaucao.Text))
            {
                txtCaucao.Text = "Caução";
            }
        }

        // Evento quando o campo 'CondutorId' recebe foco
        private void txtCondutorId_Enter(object sender, EventArgs e)
        {
            if (txtCondutorId.Text == "ID Condutor")
            {
                txtCondutorId.Text = "";
            }
        }

        // Evento quando o campo 'CondutorId' perde o foco
        private void txtCondutorId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCondutorId.Text))
            {
                txtCondutorId.Text = "ID Condutor";
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

        // Evento quando o campo 'TipoExtraId' recebe foco
        private void txtTipoExtraId_Enter(object sender, EventArgs e)
        {
            if (txtTipoExtraId.Text == "ID Tipo Extra")
            {
                txtTipoExtraId.Text = "";
            }
        }

        // Evento quando o campo 'TipoExtraId' perde o foco
        private void txtTipoExtraId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoExtraId.Text))
            {
                txtTipoExtraId.Text = "ID Tipo Extra";
            }
        }

        // Evento quando o campo 'VeiculoId' recebe foco
        private void txtVeiculoId_Enter(object sender, EventArgs e)
        {
            if (txtVeiculoId.Text == "ID Veículo")
            {
                txtVeiculoId.Text = "";
            }
        }

        // Evento quando o campo 'VeiculoId' perde o foco
        private void txtVeiculoId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVeiculoId.Text))
            {
                txtVeiculoId.Text = "ID Veículo";
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
            this.dataGridViewReserva = new System.Windows.Forms.DataGridView();
            this.txtReservaId = new System.Windows.Forms.TextBox();
            this.txtDataRes = new System.Windows.Forms.TextBox();
            this.txtDataIniAluguer = new System.Windows.Forms.TextBox();
            this.txtDataFimAluguer = new System.Windows.Forms.TextBox();
            this.txtLocalLev = new System.Windows.Forms.TextBox();
            this.txtLocalDev = new System.Windows.Forms.TextBox();
            this.txtPrecoDiario = new System.Windows.Forms.TextBox();
            this.txtKmPerm = new System.Windows.Forms.TextBox();
            this.txtCaucao = new System.Windows.Forms.TextBox();
            this.txtCondutorId = new System.Windows.Forms.TextBox();
            this.txtOrganizacaoId = new System.Windows.Forms.TextBox();
            this.txtTipoExtraId = new System.Windows.Forms.TextBox();
            this.txtVeiculoId = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label(); 

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(600, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 26);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Gestão de Reservas"; 
            // 
            // dataGridViewReserva
            // 
            this.dataGridViewReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserva.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReserva.Name = "dataGridViewReserva";
            this.dataGridViewReserva.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewReserva.TabIndex = 0;
            this.dataGridViewReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // txtReservaId
            // 
            this.txtReservaId.Location = new System.Drawing.Point(12, 180);
            this.txtReservaId.Name = "txtReservaId";
            this.txtReservaId.Size = new System.Drawing.Size(100, 20);
            this.txtReservaId.TabIndex = 1;
            this.txtReservaId.Visible = false;
            // 
            // txtDataRes
            // 
            this.txtDataRes.Location = new System.Drawing.Point(12, 210);
            this.txtDataRes.Name = "txtDataRes";
            this.txtDataRes.Size = new System.Drawing.Size(100, 20);
            this.txtDataRes.TabIndex = 2;
            this.txtDataRes.Enter += new System.EventHandler(this.txtDataRes_Enter);
            this.txtDataRes.Leave += new System.EventHandler(this.txtDataRes_Leave);
            this.txtDataRes.Text = "Data Reserva";
            // 
            // txtDataIniAluguer
            // 
            this.txtDataIniAluguer.Location = new System.Drawing.Point(12, 240);
            this.txtDataIniAluguer.Name = "txtDataIniAluguer";
            this.txtDataIniAluguer.Size = new System.Drawing.Size(100, 20);
            this.txtDataIniAluguer.TabIndex = 3;
            this.txtDataIniAluguer.Enter += new System.EventHandler(this.txtDataIniAluguer_Enter);
            this.txtDataIniAluguer.Leave += new System.EventHandler(this.txtDataIniAluguer_Leave);
            this.txtDataIniAluguer.Text = "Data Início Aluguer";
            // 
            // txtDataFimAluguer
            // 
            this.txtDataFimAluguer.Location = new System.Drawing.Point(12, 270);
            this.txtDataFimAluguer.Name = "txtDataFimAluguer";
            this.txtDataFimAluguer.Size = new System.Drawing.Size(100, 20);
            this.txtDataFimAluguer.TabIndex = 4;
            this.txtDataFimAluguer.Enter += new System.EventHandler(this.txtDataFimAluguer_Enter);
            this.txtDataFimAluguer.Leave += new System.EventHandler(this.txtDataFimAluguer_Leave);
            this.txtDataFimAluguer.Text = "Data Fim Aluguer";
            // 
            // txtLocalLev
            // 
            this.txtLocalLev.Location = new System.Drawing.Point(130, 210);
            this.txtLocalLev.Name = "txtLocalLev";
            this.txtLocalLev.Size = new System.Drawing.Size(100, 20);
            this.txtLocalLev.TabIndex = 5;
            this.txtLocalLev.Enter += new System.EventHandler(this.txtLocalLev_Enter);
            this.txtLocalLev.Leave += new System.EventHandler(this.txtLocalLev_Leave);
            this.txtLocalLev.Text = "Local Levantamento";
            // 
            // txtLocalDev
            // 
            this.txtLocalDev.Location = new System.Drawing.Point(130, 240);
            this.txtLocalDev.Name = "txtLocalDev";
            this.txtLocalDev.Size = new System.Drawing.Size(100, 20);
            this.txtLocalDev.TabIndex = 6;
            this.txtLocalDev.Enter += new System.EventHandler(this.txtLocalDev_Enter);
            this.txtLocalDev.Leave += new System.EventHandler(this.txtLocalDev_Leave);
            this.txtLocalDev.Text = "Local Devolução";
            // 
            // txtPrecoDiario
            // 
            this.txtPrecoDiario.Location = new System.Drawing.Point(130, 270);
            this.txtPrecoDiario.Name = "txtPrecoDiario";
            this.txtPrecoDiario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoDiario.TabIndex = 7;
            this.txtPrecoDiario.Enter += new System.EventHandler(this.txtPrecoDiario_Enter);
            this.txtPrecoDiario.Leave += new System.EventHandler(this.txtPrecoDiario_Leave);
            this.txtPrecoDiario.Text = "Preço Diário";
            // 
            // txtKmPerm
            // 
            this.txtKmPerm.Location = new System.Drawing.Point(130, 300);
            this.txtKmPerm.Name = "txtKmPerm";
            this.txtKmPerm.Size = new System.Drawing.Size(100, 20);
            this.txtKmPerm.TabIndex = 8;
            this.txtKmPerm.Enter += new System.EventHandler(this.txtKmPerm_Enter);
            this.txtKmPerm.Leave += new System.EventHandler(this.txtKmPerm_Leave);
            this.txtKmPerm.Text = "KM Permitido";
            // 
            // txtCaucao
            // 
            this.txtCaucao.Location = new System.Drawing.Point(12, 300);
            this.txtCaucao.Name = "txtCaucao";
            this.txtCaucao.Size = new System.Drawing.Size(100, 20);
            this.txtCaucao.TabIndex = 9;
            this.txtCaucao.Enter += new System.EventHandler(this.txtCaucao_Enter);
            this.txtCaucao.Leave += new System.EventHandler(this.txtCaucao_Leave);
            this.txtCaucao.Text = "Caução";
            // 
            // txtCondutorId
            // 
            this.txtCondutorId.Location = new System.Drawing.Point(250, 210);
            this.txtCondutorId.Name = "txtCondutorId";
            this.txtCondutorId.Size = new System.Drawing.Size(100, 20);
            this.txtCondutorId.TabIndex = 10;
            this.txtCondutorId.Enter += new System.EventHandler(this.txtCondutorId_Enter);
            this.txtCondutorId.Leave += new System.EventHandler(this.txtCondutorId_Leave);
            this.txtCondutorId.Text = "ID Condutor";
            // 
            // txtOrganizacaoId
            // 
            this.txtOrganizacaoId.Location = new System.Drawing.Point(250, 240);
            this.txtOrganizacaoId.Name = "txtOrganizacaoId";
            this.txtOrganizacaoId.Size = new System.Drawing.Size(100, 20);
            this.txtOrganizacaoId.TabIndex = 11;
            this.txtOrganizacaoId.Enter += new System.EventHandler(this.txtOrganizacaoId_Enter);
            this.txtOrganizacaoId.Leave += new System.EventHandler(this.txtOrganizacaoId_Leave);
            this.txtOrganizacaoId.Text = "ID Organização";
            // 
            // txtTipoExtraId
            // 
            this.txtTipoExtraId.Location = new System.Drawing.Point(250, 270);
            this.txtTipoExtraId.Name = "txtTipoExtraId";
            this.txtTipoExtraId.Size = new System.Drawing.Size(100, 20);
            this.txtTipoExtraId.TabIndex = 12;
            this.txtTipoExtraId.Enter += new System.EventHandler(this.txtTipoExtraId_Enter);
            this.txtTipoExtraId.Leave += new System.EventHandler(this.txtTipoExtraId_Leave);
            this.txtTipoExtraId.Text = "ID Tipo Extra";
            // 
            // txtVeiculoId
            // 
            this.txtVeiculoId.Location = new System.Drawing.Point(250, 300);
            this.txtVeiculoId.Name = "txtVeiculoId";
            this.txtVeiculoId.Size = new System.Drawing.Size(100, 20);
            this.txtVeiculoId.TabIndex = 13;
            this.txtVeiculoId.Enter += new System.EventHandler(this.txtVeiculoId_Enter);
            this.txtVeiculoId.Leave += new System.EventHandler(this.txtVeiculoId_Leave);
            this.txtVeiculoId.Text = "ID Veículo";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 360);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FormInserirReserva
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo); 
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtVeiculoId);
            this.Controls.Add(this.txtTipoExtraId);
            this.Controls.Add(this.txtOrganizacaoId);
            this.Controls.Add(this.txtCondutorId);
            this.Controls.Add(this.txtCaucao);
            this.Controls.Add(this.txtKmPerm);
            this.Controls.Add(this.txtPrecoDiario);
            this.Controls.Add(this.txtLocalDev);
            this.Controls.Add(this.txtLocalLev);
            this.Controls.Add(this.txtDataFimAluguer);
            this.Controls.Add(this.txtDataIniAluguer);
            this.Controls.Add(this.txtDataRes);
            this.Controls.Add(this.txtReservaId);
            this.Controls.Add(this.dataGridViewReserva);
            this.Name = "FormInserirReserva";
            this.Text = "Gestão de Reservas";
            this.Load += new System.EventHandler(this.FormInserirReserva_Load);
            this.Load += new System.EventHandler(this.FormInserirReservaDLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).EndInit();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormInserirReservaDLoad(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 20;

            dataGridViewReserva.Width = this.ClientSize.Width - 100;
            dataGridViewReserva.Left = (this.ClientSize.Width - dataGridViewReserva.Width) / 2;
            dataGridViewReserva.Top = lblTitulo.Bottom + 20;

            int textBoxWidth = 300;
            int textBoxSpacing = 10;
            int startX = (this.ClientSize.Width - textBoxWidth) / 2;
            int currentY = dataGridViewReserva.Bottom + 20;

            txtReservaId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtReservaId.Height + textBoxSpacing;

            txtDataRes.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDataRes.Height + textBoxSpacing;

            txtDataIniAluguer.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDataIniAluguer.Height + textBoxSpacing;

            txtDataFimAluguer.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtDataFimAluguer.Height + textBoxSpacing;

            txtLocalLev.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtLocalLev.Height + textBoxSpacing;

            txtLocalDev.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtLocalDev.Height + textBoxSpacing;

            txtPrecoDiario.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtPrecoDiario.Height + textBoxSpacing;

            txtKmPerm.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtKmPerm.Height + textBoxSpacing;

            txtCaucao.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCaucao.Height + textBoxSpacing;

            txtCondutorId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCondutorId.Height + textBoxSpacing;

            txtOrganizacaoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtOrganizacaoId.Height + textBoxSpacing;

            txtTipoExtraId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtTipoExtraId.Height + textBoxSpacing;

            txtVeiculoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtVeiculoId.Height + textBoxSpacing;

            btnAdicionar.Left = (this.ClientSize.Width - btnAdicionar.Width) / 2;
            btnAdicionar.Top = currentY + 20;
        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReserva;
        private System.Windows.Forms.TextBox txtReservaId;
        private System.Windows.Forms.TextBox txtDataRes;
        private System.Windows.Forms.TextBox txtDataIniAluguer;
        private System.Windows.Forms.TextBox txtDataFimAluguer;
        private System.Windows.Forms.TextBox txtLocalLev;
        private System.Windows.Forms.TextBox txtLocalDev;
        private System.Windows.Forms.TextBox txtPrecoDiario;
        private System.Windows.Forms.TextBox txtKmPerm;
        private System.Windows.Forms.TextBox txtCaucao;
        private System.Windows.Forms.TextBox txtCondutorId;
        private System.Windows.Forms.TextBox txtOrganizacaoId;
        private System.Windows.Forms.TextBox txtTipoExtraId;
        private System.Windows.Forms.TextBox txtVeiculoId;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblTitulo;
    }
}
