
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
            this.label2 = new System.Windows.Forms.Label();
            this.DtgConsulSedClientes = new System.Windows.Forms.DataGridView();
            this.BtnConsultarSedClientes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsulSedClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // DtgConsulSedClientes
            // 
            this.DtgConsulSedClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsulSedClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DtgConsulSedClientes.Location = new System.Drawing.Point(29, 91);
            this.DtgConsulSedClientes.Name = "DtgConsulSedClientes";
            this.DtgConsulSedClientes.Size = new System.Drawing.Size(442, 150);
            this.DtgConsulSedClientes.TabIndex = 4;
            // 
            // BtnConsultarSedClientes
            // 
            this.BtnConsultarSedClientes.Location = new System.Drawing.Point(396, 46);
            this.BtnConsultarSedClientes.Name = "BtnConsultarSedClientes";
            this.BtnConsultarSedClientes.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarSedClientes.TabIndex = 5;
            this.BtnConsultarSedClientes.Text = "Consultar";
            this.BtnConsultarSedClientes.UseVisualStyleBackColor = true;
            this.BtnConsultarSedClientes.Click += new System.EventHandler(this.BtnConsultarSedClientes_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Sede";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            // 
            // FrmConsultar_Sedes_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnConsultarSedClientes);
            this.Controls.Add(this.DtgConsulSedClientes);
            this.Controls.Add(this.label2);
            this.Name = "FrmConsultar_Sedes_de_Clientes";
            this.Text = "FrmConsultar_Sedes_de_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsulSedClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtgConsulSedClientes;
        private System.Windows.Forms.Button BtnConsultarSedClientes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}