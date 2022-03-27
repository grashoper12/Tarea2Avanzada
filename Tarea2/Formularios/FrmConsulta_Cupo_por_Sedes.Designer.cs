
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultaCupoPorSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sedes:";
            // 
            // CmbSedesConsultaCupoSedes
            // 
            this.CmbSedesConsultaCupoSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSedesConsultaCupoSedes.FormattingEnabled = true;
            this.CmbSedesConsultaCupoSedes.Location = new System.Drawing.Point(67, 40);
            this.CmbSedesConsultaCupoSedes.Name = "CmbSedesConsultaCupoSedes";
            this.CmbSedesConsultaCupoSedes.Size = new System.Drawing.Size(409, 21);
            this.CmbSedesConsultaCupoSedes.TabIndex = 1;
            // 
            // BtnConsultaCupoPorSedes
            // 
            this.BtnConsultaCupoPorSedes.Location = new System.Drawing.Point(493, 40);
            this.BtnConsultaCupoPorSedes.Name = "BtnConsultaCupoPorSedes";
            this.BtnConsultaCupoPorSedes.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultaCupoPorSedes.TabIndex = 2;
            this.BtnConsultaCupoPorSedes.Text = "Consultar";
            this.BtnConsultaCupoPorSedes.UseVisualStyleBackColor = true;
            this.BtnConsultaCupoPorSedes.Click += new System.EventHandler(this.BtnConsultaCupoPorSedes_Click);
            // 
            // DtgConsultaCupoPorSedes
            // 
            this.DtgConsultaCupoPorSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultaCupoPorSedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DtgConsultaCupoPorSedes.Location = new System.Drawing.Point(24, 77);
            this.DtgConsultaCupoPorSedes.Name = "DtgConsultaCupoPorSedes";
            this.DtgConsultaCupoPorSedes.Size = new System.Drawing.Size(544, 150);
            this.DtgConsultaCupoPorSedes.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sede";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dirección";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cupos por fecha";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            // 
            // FrmConsulta_Cupo_por_Sedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 261);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}