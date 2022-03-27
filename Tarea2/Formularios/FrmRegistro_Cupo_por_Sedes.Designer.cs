
namespace Tarea2.Formularios
{
    partial class FrmRegistro_Cupo_por_Sedes
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
            this.CmbSedeRegCupoSedes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCuposDisponibles = new System.Windows.Forms.TextBox();
            this.BtnGuardarRegCupoPorSedes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sede:";
            // 
            // CmbSedeRegCupoSedes
            // 
            this.CmbSedeRegCupoSedes.FormattingEnabled = true;
            this.CmbSedeRegCupoSedes.Location = new System.Drawing.Point(342, 34);
            this.CmbSedeRegCupoSedes.Name = "CmbSedeRegCupoSedes";
            this.CmbSedeRegCupoSedes.Size = new System.Drawing.Size(200, 21);
            this.CmbSedeRegCupoSedes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cupos disponibles:";
            // 
            // TxtCuposDisponibles
            // 
            this.TxtCuposDisponibles.Location = new System.Drawing.Point(340, 122);
            this.TxtCuposDisponibles.Name = "TxtCuposDisponibles";
            this.TxtCuposDisponibles.Size = new System.Drawing.Size(202, 20);
            this.TxtCuposDisponibles.TabIndex = 5;
            // 
            // BtnGuardarRegCupoPorSedes
            // 
            this.BtnGuardarRegCupoPorSedes.Location = new System.Drawing.Point(365, 175);
            this.BtnGuardarRegCupoPorSedes.Name = "BtnGuardarRegCupoPorSedes";
            this.BtnGuardarRegCupoPorSedes.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarRegCupoPorSedes.TabIndex = 6;
            this.BtnGuardarRegCupoPorSedes.Text = "Guardar";
            this.BtnGuardarRegCupoPorSedes.UseVisualStyleBackColor = true;
            // 
            // FrmRegistro_Cupo_por_Sedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGuardarRegCupoPorSedes);
            this.Controls.Add(this.TxtCuposDisponibles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbSedeRegCupoSedes);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro_Cupo_por_Sedes";
            this.Text = "FrmRegistro_Cupo_por_Sedes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSedeRegCupoSedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCuposDisponibles;
        private System.Windows.Forms.Button BtnGuardarRegCupoPorSedes;
    }
}