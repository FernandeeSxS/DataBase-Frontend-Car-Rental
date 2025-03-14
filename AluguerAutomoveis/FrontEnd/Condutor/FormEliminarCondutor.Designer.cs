using System;

namespace AluguerAutomoveis
{
    partial class FormEliminarCondutor
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

        private void FormEliminarCondutor_Load(object sender, EventArgs e)
        {

            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;

            btnEliminar.Left = (this.ClientSize.Width - btnEliminar.Width) / 2;
            btnEliminar.Top = 150;
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(710, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminar Condutor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(700, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(310, 67);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Condutor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormEliminarCondutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 713);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormEliminarCondutor";
            this.Text = "Eliminar Condutor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEliminarCondutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminar;
    }
}

