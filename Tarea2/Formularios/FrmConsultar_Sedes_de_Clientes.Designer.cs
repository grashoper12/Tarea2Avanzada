
namespace Tarea2.Formularios
{
    partial class FrmConsultar_Sedes_de_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdAfiliacionConsulSedClientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClienteConsulSedClientes = new System.Windows.Forms.TextBox();
            this.DtgConsulSedClientes = new System.Windows.Forms.DataGridView();
            this.BtnConsultarSedClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsulSedClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Afiliacion:";
            // 
            // TxtIdAfiliacionConsulSedClientes
            // 
            this.TxtIdAfiliacionConsulSedClientes.Location = new System.Drawing.Point(325, 26);
            this.TxtIdAfiliacionConsulSedClientes.Name = "TxtIdAfiliacionConsulSedClientes";
            this.TxtIdAfiliacionConsulSedClientes.Size = new System.Drawing.Size(100, 20);
            this.TxtIdAfiliacionConsulSedClientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // TxtClienteConsulSedClientes
            // 
            this.TxtClienteConsulSedClientes.Location = new System.Drawing.Point(325, 71);
            this.TxtClienteConsulSedClientes.Name = "TxtClienteConsulSedClientes";
            this.TxtClienteConsulSedClientes.Size = new System.Drawing.Size(100, 20);
            this.TxtClienteConsulSedClientes.TabIndex = 3;
            // 
            // DtgConsulSedClientes
            // 
            this.DtgConsulSedClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsulSedClientes.Location = new System.Drawing.Point(233, 173);
            this.DtgConsulSedClientes.Name = "DtgConsulSedClientes";
            this.DtgConsulSedClientes.Size = new System.Drawing.Size(240, 150);
            this.DtgConsulSedClientes.TabIndex = 4;
            // 
            // BtnConsultarSedClientes
            // 
            this.BtnConsultarSedClientes.Location = new System.Drawing.Point(325, 125);
            this.BtnConsultarSedClientes.Name = "BtnConsultarSedClientes";
            this.BtnConsultarSedClientes.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarSedClientes.TabIndex = 5;
            this.BtnConsultarSedClientes.Text = "Consultar";
            this.BtnConsultarSedClientes.UseVisualStyleBackColor = true;
            // 
            // FrmConsultar_Sedes_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConsultarSedClientes);
            this.Controls.Add(this.DtgConsulSedClientes);
            this.Controls.Add(this.TxtClienteConsulSedClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdAfiliacionConsulSedClientes);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultar_Sedes_de_Clientes";
            this.Text = "FrmConsultar_Sedes_de_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsulSedClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdAfiliacionConsulSedClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClienteConsulSedClientes;
        private System.Windows.Forms.DataGridView DtgConsulSedClientes;
        private System.Windows.Forms.Button BtnConsultarSedClientes;
    }
}