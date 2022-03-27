
namespace Tarea2.Formularios
{
    partial class FrmConsultar_Clentes
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
            this.CmbConsultaClientes = new System.Windows.Forms.ComboBox();
            this.BtnConsultaClientes = new System.Windows.Forms.Button();
            this.DtgConsultarClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SqgundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes:";
            // 
            // CmbConsultaClientes
            // 
            this.CmbConsultaClientes.FormattingEnabled = true;
            this.CmbConsultaClientes.Items.AddRange(new object[] {
            "Seleccione"});
            this.CmbConsultaClientes.Location = new System.Drawing.Point(65, 44);
            this.CmbConsultaClientes.Name = "CmbConsultaClientes";
            this.CmbConsultaClientes.Size = new System.Drawing.Size(267, 21);
            this.CmbConsultaClientes.TabIndex = 1;
            // 
            // BtnConsultaClientes
            // 
            this.BtnConsultaClientes.Location = new System.Drawing.Point(348, 44);
            this.BtnConsultaClientes.Name = "BtnConsultaClientes";
            this.BtnConsultaClientes.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultaClientes.TabIndex = 2;
            this.BtnConsultaClientes.Text = "Consultar";
            this.BtnConsultaClientes.UseVisualStyleBackColor = true;
            this.BtnConsultaClientes.Click += new System.EventHandler(this.BtnConsultaClientes_Click);
            // 
            // DtgConsultarClientes
            // 
            this.DtgConsultarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsultarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrimerApellido,
            this.SqgundoApellido,
            this.Identificacion,
            this.Genero,
            this.FechaNacimiento,
            this.FechaIngreso});
            this.DtgConsultarClientes.Location = new System.Drawing.Point(12, 84);
            this.DtgConsultarClientes.Name = "DtgConsultarClientes";
            this.DtgConsultarClientes.Size = new System.Drawing.Size(727, 150);
            this.DtgConsultarClientes.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            // 
            // SqgundoApellido
            // 
            this.SqgundoApellido.HeaderText = "Segundo Apellido";
            this.SqgundoApellido.Name = "SqgundoApellido";
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            // 
            // FrmConsultar_Clentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.DtgConsultarClientes);
            this.Controls.Add(this.BtnConsultaClientes);
            this.Controls.Add(this.CmbConsultaClientes);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultar_Clentes";
            this.Text = "FrmConsultar_Clentes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsultarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbConsultaClientes;
        private System.Windows.Forms.Button BtnConsultaClientes;
        private System.Windows.Forms.DataGridView DtgConsultarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SqgundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
    }
}