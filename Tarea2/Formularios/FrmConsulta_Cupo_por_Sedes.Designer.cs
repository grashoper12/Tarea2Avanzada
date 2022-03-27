
namespace Tarea2.Formularios
{
    partial class FrmConsulta_Cupo_por_Sedes
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
            this.CmbSedesConsultaCupoSedes = new System.Windows.Forms.ComboBox();
            this.BtnConsultaCupoPorSedes = new System.Windows.Forms.Button();
            this.DtgConsultaCupoPorSedes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultaCupoPorSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sedes:";
            // 
            // CmbSedesConsultaCupoSedes
            // 
            this.CmbSedesConsultaCupoSedes.FormattingEnabled = true;
            this.CmbSedesConsultaCupoSedes.Location = new System.Drawing.Point(335, 37);
            this.CmbSedesConsultaCupoSedes.Name = "CmbSedesConsultaCupoSedes";
            this.CmbSedesConsultaCupoSedes.Size = new System.Drawing.Size(121, 21);
            this.CmbSedesConsultaCupoSedes.TabIndex = 1;
            // 
            // BtnConsultaCupoPorSedes
            // 
            this.BtnConsultaCupoPorSedes.Location = new System.Drawing.Point(351, 88);
            this.BtnConsultaCupoPorSedes.Name = "BtnConsultaCupoPorSedes";
            this.BtnConsultaCupoPorSedes.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultaCupoPorSedes.TabIndex = 2;
            this.BtnConsultaCupoPorSedes.Text = "Consultar";
            this.BtnConsultaCupoPorSedes.UseVisualStyleBackColor = true;
            // 
            // DtgConsultaCupoPorSedes
            // 
            this.DtgConsultaCupoPorSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultaCupoPorSedes.Location = new System.Drawing.Point(280, 141);
            this.DtgConsultaCupoPorSedes.Name = "DtgConsultaCupoPorSedes";
            this.DtgConsultaCupoPorSedes.Size = new System.Drawing.Size(240, 150);
            this.DtgConsultaCupoPorSedes.TabIndex = 3;
            // 
            // FrmConsulta_Cupo_por_Sedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgConsultaCupoPorSedes);
            this.Controls.Add(this.BtnConsultaCupoPorSedes);
            this.Controls.Add(this.CmbSedesConsultaCupoSedes);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulta_Cupo_por_Sedes";
            this.Text = "FrmConsulta_Cupo_por_Sedes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultaCupoPorSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSedesConsultaCupoSedes;
        private System.Windows.Forms.Button BtnConsultaCupoPorSedes;
        private System.Windows.Forms.DataGridView DtgConsultaCupoPorSedes;
    }
}