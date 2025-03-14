using System;

namespace AluguerAutomoveis.FrontEnd
{
    partial class FormInserirVeiculo
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

        #region PlaceHolders
        private void txtCapacidade_Enter(object sender, EventArgs e)
        {
            if (txtCapacidade.Text == "Capacidade")
            {
                txtCapacidade.Text = "";
            }
        }

        private void txtCapacidade_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapacidade.Text))
            {
                txtCapacidade.Text = "Capacidade";
            }
        }

        private void txtKM_Enter(object sender, EventArgs e)
        {
            if (txtKM.Text == "Quilometragem")
            {
                txtKM.Text = "";
            }
        }

        private void txtKM_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKM.Text))
            {
                txtKM.Text = "Quilometragem";
            }
        }

        private void txtNivComb_Enter(object sender, EventArgs e)
        {
            if (txtNivComb.Text == "Nível de Combustível")
            {
                txtNivComb.Text = "";
            }
        }

        private void txtNivComb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNivComb.Text))
            {
                txtNivComb.Text = "Nível de Combustível";
            }
        }

        private void txtTipoVeiculoId_Enter(object sender, EventArgs e)
        {
            if (txtTipoVeiculoId.Text == "Tipo de Veículo")
            {
                txtTipoVeiculoId.Text = "";
            }
        }

        private void txtTipoVeiculoId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoVeiculoId.Text))
            {
                txtTipoVeiculoId.Text = "Tipo de Veículo";
            }
        }

        private void txtModeloId_Enter(object sender, EventArgs e)
        {
            if (txtModeloId.Text == "Modelo")
            {
                txtModeloId.Text = "";
            }
        }

        private void txtModeloId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModeloId.Text))
            {
                txtModeloId.Text = "Modelo";
            }
        }

        private void txtCondicoesEntregaId_Enter(object sender, EventArgs e)
        {
            if (txtCondicoesEntregaId.Text == "Condições de Entrega")
            {
                txtCondicoesEntregaId.Text = "";
            }
        }

        private void txtCondicoesEntregaId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCondicoesEntregaId.Text))
            {
                txtCondicoesEntregaId.Text = "Condições de Entrega";
            }
        }
        #endregion

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.dataGridViewVeiculo = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtVeiculoId = new System.Windows.Forms.TextBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtNivComb = new System.Windows.Forms.TextBox();
            this.txtTipoVeiculoId = new System.Windows.Forms.TextBox();
            this.txtModeloId = new System.Windows.Forms.TextBox();
            this.txtCondicoesEntregaId = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculo)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Inserir Veículo";

            // 
            // dataGridViewVeiculo
            // 
            this.dataGridViewVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeiculo.Name = "dataGridViewVeiculo";
            this.dataGridViewVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // txtVeiculoId
            // 
            this.txtVeiculoId.Visible = false;

            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Text = "Capacidade";
            this.txtCapacidade.Enter += new System.EventHandler(this.txtCapacidade_Enter);
            this.txtCapacidade.Leave += new System.EventHandler(this.txtCapacidade_Leave);

            // 
            // txtKM
            // 
            this.txtKM.Name = "txtKM";
            this.txtKM.Text = "Quilometragem";
            this.txtKM.Enter += new System.EventHandler(this.txtKM_Enter);
            this.txtKM.Leave += new System.EventHandler(this.txtKM_Leave);

            // 
            // txtNivComb
            // 
            this.txtNivComb.Name = "txtNivComb";
            this.txtNivComb.Text = "Nível de Combustível";
            this.txtNivComb.Enter += new System.EventHandler(this.txtNivComb_Enter);
            this.txtNivComb.Leave += new System.EventHandler(this.txtNivComb_Leave);

            // 
            // txtTipoVeiculoId
            // 
            this.txtTipoVeiculoId.Name = "txtTipoVeiculoId";
            this.txtTipoVeiculoId.Text = "Tipo de Veículo";
            this.txtTipoVeiculoId.Enter += new System.EventHandler(this.txtTipoVeiculoId_Enter);
            this.txtTipoVeiculoId.Leave += new System.EventHandler(this.txtTipoVeiculoId_Leave);

            // 
            // txtModeloId
            // 
            this.txtModeloId.Name = "txtModeloId";
            this.txtModeloId.Text = "Modelo";
            this.txtModeloId.Enter += new System.EventHandler(this.txtModeloId_Enter);
            this.txtModeloId.Leave += new System.EventHandler(this.txtModeloId_Leave);

            // 
            // txtCondicoesEntregaId
            // 
            this.txtCondicoesEntregaId.Name = "txtCondicoesEntregaId";
            this.txtCondicoesEntregaId.Text = "Condições de Entrega";
            this.txtCondicoesEntregaId.Enter += new System.EventHandler(this.txtCondicoesEntregaId_Enter);
            this.txtCondicoesEntregaId.Leave += new System.EventHandler(this.txtCondicoesEntregaId_Leave);

            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // 
            // FormInserirVeiculo
            // 
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewVeiculo);
            this.Controls.Add(this.txtCondicoesEntregaId);
            this.Controls.Add(this.txtModeloId);
            this.Controls.Add(this.txtTipoVeiculoId);
            this.Controls.Add(this.txtNivComb);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.txtVeiculoId);
            this.Controls.Add(this.btnAdicionar);
            this.Load += new System.EventHandler(this.FormInserirVeiculo_Load);
            this.Load += new System.EventHandler(this.FormInserirVeiculoDLoad);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private void FormInserirVeiculoDLoad(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 20;

            dataGridViewVeiculo.Width = this.ClientSize.Width - 100;
            dataGridViewVeiculo.Left = (this.ClientSize.Width - dataGridViewVeiculo.Width) / 2;
            dataGridViewVeiculo.Top = lblTitulo.Bottom + 20;

            int textBoxWidth = 300;
            int textBoxSpacing = 10;
            int startX = (this.ClientSize.Width - textBoxWidth) / 2;
            int currentY = dataGridViewVeiculo.Bottom + 20;

            txtCapacidade.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCapacidade.Height + textBoxSpacing;

            txtKM.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtKM.Height + textBoxSpacing;

            txtNivComb.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtNivComb.Height + textBoxSpacing;

            txtTipoVeiculoId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtTipoVeiculoId.Height + textBoxSpacing;

            txtModeloId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtModeloId.Height + textBoxSpacing;

            txtCondicoesEntregaId.SetBounds(startX, currentY, textBoxWidth, 20);
            currentY += txtCondicoesEntregaId.Height + textBoxSpacing;

            // Centraliza o botão
            btnAdicionar.Left = (this.ClientSize.Width - btnAdicionar.Width) / 2;
            btnAdicionar.Top = currentY + 20;
        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVeiculo;
        private System.Windows.Forms.TextBox txtVeiculoId;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtNivComb;
        private System.Windows.Forms.TextBox txtTipoVeiculoId;
        private System.Windows.Forms.TextBox txtModeloId;
        private System.Windows.Forms.TextBox txtCondicoesEntregaId;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblTitulo;
    }
}
