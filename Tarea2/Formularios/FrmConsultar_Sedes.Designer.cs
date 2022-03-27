
namespace Tarea2.Formularios
{
    partial class FrmConsultar_Sedes
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
            this.CmbConsultarSedes = new System.Windows.Forms.ComboBox();
            this.BtnConsultarSedes = new System.Windows.Forms.Button();
            this.DtgConsultarSedes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sedes:";
            // 
            // CmbConsultarSedes
            // 
            this.CmbConsultarSedes.FormattingEnabled = true;
            this.CmbConsultarSedes.Items.AddRange(new object[] {
            "Seleccione"});
            this.CmbConsultarSedes.Location = new System.Drawing.Point(297, 28);
            this.CmbConsultarSedes.Name = "CmbConsultarSedes";
            this.CmbConsultarSedes.Size = new System.Drawing.Size(121, 21);
            this.CmbConsultarSedes.TabIndex = 1;
            // 
            // BtnConsultarSedes
            // 
            this.BtnConsultarSedes.Location = new System.Drawing.Point(323, 81);
            this.BtnConsultarSedes.Name = "BtnConsultarSedes";
            this.BtnConsultarSedes.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarSedes.TabIndex = 2;
            this.BtnConsultarSedes.Text = "Consultar";
            this.BtnConsultarSedes.UseVisualStyleBackColor = true;
            // 
            // DtgConsultarSedes
            // 
            this.DtgConsultarSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultarSedes.Location = new System.Drawing.Point(240, 135);
            this.DtgConsultarSedes.Name = "DtgConsultarSedes";
            this.DtgConsultarSedes.Size = new System.Drawing.Size(240, 150);
            this.DtgConsultarSedes.TabIndex = 3;
            // 
            // FrmConsultar_Sedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgConsultarSedes);
            this.Controls.Add(this.BtnConsultarSedes);
            this.Controls.Add(this.CmbConsultarSedes);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultar_Sedes";
            this.Text = "FrmConsultar_Sedes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbConsultarSedes;
        private System.Windows.Forms.Button BtnConsultarSedes;
        private System.Windows.Forms.DataGridView DtgConsultarSedes;
    }
}