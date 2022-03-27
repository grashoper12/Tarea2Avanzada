
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // CmbSeleccionDeCliente
            // 
            this.CmbSeleccionDeCliente.FormattingEnabled = true;
            this.CmbSeleccionDeCliente.Items.AddRange(new object[] {
            "Seleccione"});
            this.CmbSeleccionDeCliente.Location = new System.Drawing.Point(170, 24);
            this.CmbSeleccionDeCliente.Name = "CmbSeleccionDeCliente";
            this.CmbSeleccionDeCliente.Size = new System.Drawing.Size(200, 21);
            this.CmbSeleccionDeCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Afiliacion:";
            // 
            // TxtIdAfiliacion
            // 
            this.TxtIdAfiliacion.Location = new System.Drawing.Point(170, 67);
            this.TxtIdAfiliacion.Name = "TxtIdAfiliacion";
            this.TxtIdAfiliacion.Size = new System.Drawing.Size(200, 20);
            this.TxtIdAfiliacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // BtnGuardarRegSedeDeCliente
            // 
            this.BtnGuardarRegSedeDeCliente.Location = new System.Drawing.Point(327, 247);
            this.BtnGuardarRegSedeDeCliente.Name = "BtnGuardarRegSedeDeCliente";
            this.BtnGuardarRegSedeDeCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarRegSedeDeCliente.TabIndex = 6;
            this.BtnGuardarRegSedeDeCliente.Text = "Guardar";
            this.BtnGuardarRegSedeDeCliente.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrar_Sede_de__Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGuardarRegSedeDeCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdAfiliacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbSeleccionDeCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrar_Sede_de__Clientes";
            this.Text = "FrmRegistrar_Sede_de__Clientes";
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
    }
}