
namespace Tarea2.Formularios
{
    partial class FrmSedes
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
            this.TxtIdSede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombreSede = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNumTelefono = new System.Windows.Forms.TextBox();
            this.CmbEstadoSede = new System.Windows.Forms.ComboBox();
            this.BtnGuardarSede = new System.Windows.Forms.Button();
            this.dgvSedes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Sede:";
            // 
            // TxtIdSede
            // 
            this.TxtIdSede.Location = new System.Drawing.Point(151, 26);
            this.TxtIdSede.Name = "TxtIdSede";
            this.TxtIdSede.Size = new System.Drawing.Size(292, 20);
            this.TxtIdSede.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono:";
            // 
            // TxtNombreSede
            // 
            this.TxtNombreSede.Location = new System.Drawing.Point(151, 51);
            this.TxtNombreSede.Name = "TxtNombreSede";
            this.TxtNombreSede.Size = new System.Drawing.Size(292, 20);
            this.TxtNombreSede.TabIndex = 6;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(151, 77);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(292, 20);
            this.TxtDireccion.TabIndex = 7;
            // 
            // TxtNumTelefono
            // 
            this.TxtNumTelefono.Location = new System.Drawing.Point(151, 127);
            this.TxtNumTelefono.Name = "TxtNumTelefono";
            this.TxtNumTelefono.Size = new System.Drawing.Size(292, 20);
            this.TxtNumTelefono.TabIndex = 8;
            // 
            // CmbEstadoSede
            // 
            this.CmbEstadoSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstadoSede.FormattingEnabled = true;
            this.CmbEstadoSede.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Inactivo"});
            this.CmbEstadoSede.Location = new System.Drawing.Point(151, 103);
            this.CmbEstadoSede.Name = "CmbEstadoSede";
            this.CmbEstadoSede.Size = new System.Drawing.Size(292, 21);
            this.CmbEstadoSede.TabIndex = 9;
            // 
            // BtnGuardarSede
            // 
            this.BtnGuardarSede.Location = new System.Drawing.Point(151, 163);
            this.BtnGuardarSede.Name = "BtnGuardarSede";
            this.BtnGuardarSede.Size = new System.Drawing.Size(292, 23);
            this.BtnGuardarSede.TabIndex = 10;
            this.BtnGuardarSede.Text = "Guardar";
            this.BtnGuardarSede.UseVisualStyleBackColor = true;
            this.BtnGuardarSede.Click += new System.EventHandler(this.BtnGuardarSede_Click);
            // 
            // dgvSedes
            // 
            this.dgvSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSedes.Location = new System.Drawing.Point(12, 207);
            this.dgvSedes.Name = "dgvSedes";
            this.dgvSedes.Size = new System.Drawing.Size(529, 164);
            this.dgvSedes.TabIndex = 11;
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
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Teléfono";
            this.Column5.Name = "Column5";
            // 
            // FrmSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 393);
            this.Controls.Add(this.dgvSedes);
            this.Controls.Add(this.BtnGuardarSede);
            this.Controls.Add(this.CmbEstadoSede);
            this.Controls.Add(this.TxtNumTelefono);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNombreSede);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdSede);
            this.Controls.Add(this.label1);
            this.Name = "FrmSedes";
            this.Text = "FrmSedes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdSede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombreSede;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNumTelefono;
        private System.Windows.Forms.ComboBox CmbEstadoSede;
        private System.Windows.Forms.Button BtnGuardarSede;
        private System.Windows.Forms.DataGridView dgvSedes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}