using System;

namespace AluguerAutomoveis
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos em uso.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;

            btnManipulacaoDados.Left = (this.ClientSize.Width - btnManipulacaoDados.Width) / 2;
            btnManipulacaoDados.Top = 150;

            btnStoredProcedure.Left = (this.ClientSize.Width - btnStoredProcedure.Width) / 2;
            btnStoredProcedure.Top = 250;

            btnQuery.Left = (this.ClientSize.Width - btnQuery.Width) / 2;
            btnQuery.Top = 350;
        }


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer.
        /// Não modifique o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnManipulacaoDados = new System.Windows.Forms.Button();
            this.btnStoredProcedure = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(660, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Principal";
            // 
            // btnManipulacaoDados
            // 
            this.btnManipulacaoDados.Location = new System.Drawing.Point(573, 130);
            this.btnManipulacaoDados.Name = "btnManipulacaoDados";
            this.btnManipulacaoDados.Size = new System.Drawing.Size(310, 67);
            this.btnManipulacaoDados.TabIndex = 1;
            this.btnManipulacaoDados.Text = "Manipulação de Dados";
            this.btnManipulacaoDados.UseVisualStyleBackColor = true;
            this.btnManipulacaoDados.Click += new System.EventHandler(this.btnManipulacaoDados_Click);
            // 
            // btnStoredProcedure
            // 
            this.btnStoredProcedure.Location = new System.Drawing.Point(573, 249);
            this.btnStoredProcedure.Name = "btnStoredProcedure";
            this.btnStoredProcedure.Size = new System.Drawing.Size(310, 72);
            this.btnStoredProcedure.TabIndex = 2;
            this.btnStoredProcedure.Text = "Encontrar Condutor Stored Procedure";
            this.btnStoredProcedure.UseVisualStyleBackColor = true;
            this.btnStoredProcedure.Click += new System.EventHandler(this.btnStoredProcedure_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(573, 376);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(310, 72);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Encontrar Condutor Idade Mínima Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 713); 
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnStoredProcedure);
            this.Controls.Add(this.btnManipulacaoDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable; 
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnManipulacaoDados;
        private System.Windows.Forms.Button btnStoredProcedure;
        private System.Windows.Forms.Button btnQuery;
    }
}



