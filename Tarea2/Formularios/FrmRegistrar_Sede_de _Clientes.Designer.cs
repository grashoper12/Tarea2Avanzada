
namespace Tarea2.Formularios
{
    partial class FrmRegistrar_Sede_de__Clientes
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
            this.CmbSeleccionDeCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdAfiliacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardarRegSedeDeCliente = new System.Windows.Forms.Button();
            this.cmSedes = new System.Windows.Forms.ComboBox();
            this.Sede = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // CmbSeleccionDeCliente
            // 
            this.CmbSeleccionDeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeleccionDeCliente.FormattingEnabled = true;
            this.CmbSeleccionDeCliente.Items.AddRange(new object[] {
            "Seleccione"});
            this.CmbSeleccionDeCliente.Location = new System.Drawing.Point(80, 21);
            this.CmbSeleccionDeCliente.Name = "CmbSeleccionDeCliente";
            this.CmbSeleccionDeCliente.Size = new System.Drawing.Size(290, 21);
            this.CmbSeleccionDeCliente.TabIndex = 1;
            this.CmbSeleccionDeCliente.SelectedIndexChanged += new System.EventHandler(this.CmbSeleccionDeCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Afiliacion:";
            // 
            // TxtIdAfiliacion
            // 
            this.TxtIdAfiliacion.Location = new System.Drawing.Point(80, 48);
            this.TxtIdAfiliacion.Name = "TxtIdAfiliacion";
            this.TxtIdAfiliacion.Size = new System.Drawing.Size(290, 20);
            this.TxtIdAfiliacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // BtnGuardarRegSedeDeCliente
            // 
            this.BtnGuardarRegSedeDeCliente.Location = new System.Drawing.Point(80, 127);
            this.BtnGuardarRegSedeDeCliente.Name = "BtnGuardarRegSedeDeCliente";
            this.BtnGuardarRegSedeDeCliente.Size = new System.Drawing.Size(290, 23);
            this.BtnGuardarRegSedeDeCliente.TabIndex = 6;
            this.BtnGuardarRegSedeDeCliente.Text = "Agregar";
            this.BtnGuardarRegSedeDeCliente.UseVisualStyleBackColor = true;
            this.BtnGuardarRegSedeDeCliente.Click += new System.EventHandler(this.BtnGuardarRegSedeDeCliente_Click);
            // 
            // cmSedes
            // 
            this.cmSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSedes.FormattingEnabled = true;
            this.cmSedes.Location = new System.Drawing.Point(80, 74);
            this.cmSedes.Name = "cmSedes";
            this.cmSedes.Size = new System.Drawing.Size(290, 21);
            this.cmSedes.TabIndex = 7;
            // 
            // Sede
            // 
            this.Sede.AutoSize = true;
            this.Sede.Location = new System.Drawing.Point(35, 81);
            this.Sede.Name = "Sede";
            this.Sede.Size = new System.Drawing.Size(32, 13);
            this.Sede.TabIndex = 8;
            this.Sede.Text = "Sede";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(13, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 9;
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
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Direccion";
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistrar_Sede_de__Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sede);
            this.Controls.Add(this.cmSedes);
            this.Controls.Add(this.BtnGuardarRegSedeDeCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdAfiliacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbSeleccionDeCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrar_Sede_de__Clientes";
            this.Text = "FrmRegistrar_Sede_de__Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSeleccionDeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdAfiliacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnGuardarRegSedeDeCliente;
        private System.Windows.Forms.ComboBox cmSedes;
        private System.Windows.Forms.Label Sede;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}