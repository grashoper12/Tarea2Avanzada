
namespace Tarea2.Formularios
{
    partial class FrmClientes
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
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIng = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbGen = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPape = new System.Windows.Forms.TextBox();
            this.TxtNomb = new System.Windows.Forms.TextBox();
            this.TxtSape = new System.Windows.Forms.TextBox();
            this.BtnGuard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Location = new System.Drawing.Point(446, 97);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFecNac.TabIndex = 0;
            // 
            // dtpFecIng
            // 
            this.dtpFecIng.Location = new System.Drawing.Point(446, 146);
            this.dtpFecIng.Name = "dtpFecIng";
            this.dtpFecIng.Size = new System.Drawing.Size(200, 20);
            this.dtpFecIng.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(83, 103);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(79, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // CmbGen
            // 
            this.CmbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGen.FormattingEnabled = true;
            this.CmbGen.Items.AddRange(new object[] {
            "Seleccione",
            "Masculino",
            "Femenino"});
            this.CmbGen.Location = new System.Drawing.Point(446, 49);
            this.CmbGen.Name = "CmbGen";
            this.CmbGen.Size = new System.Drawing.Size(200, 21);
            this.CmbGen.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.PrimerA,
            this.SegundoApe,
            this.Gen,
            this.FechaNac,
            this.FechaIng});
            this.dataGridView1.Location = new System.Drawing.Point(57, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 202);
            this.dataGridView1.TabIndex = 12;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PrimerA
            // 
            this.PrimerA.HeaderText = "Primer Apellido";
            this.PrimerA.Name = "PrimerA";
            // 
            // SegundoApe
            // 
            this.SegundoApe.HeaderText = "Segundo Apellido";
            this.SegundoApe.Name = "SegundoApe";
            // 
            // Gen
            // 
            this.Gen.HeaderText = "Genero";
            this.Gen.Name = "Gen";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de Nacimiento";
            this.FechaNac.Name = "FechaNac";
            // 
            // FechaIng
            // 
            this.FechaIng.HeaderText = "Fecha de Ingreso";
            this.FechaIng.Name = "FechaIng";
            // 
            // TxtPape
            // 
            this.TxtPape.Location = new System.Drawing.Point(173, 100);
            this.TxtPape.Name = "TxtPape";
            this.TxtPape.Size = new System.Drawing.Size(100, 20);
            this.TxtPape.TabIndex = 13;
            // 
            // TxtNomb
            // 
            this.TxtNomb.Location = new System.Drawing.Point(173, 54);
            this.TxtNomb.Name = "TxtNomb";
            this.TxtNomb.Size = new System.Drawing.Size(100, 20);
            this.TxtNomb.TabIndex = 14;
            // 
            // TxtSape
            // 
            this.TxtSape.Location = new System.Drawing.Point(173, 139);
            this.TxtSape.Name = "TxtSape";
            this.TxtSape.Size = new System.Drawing.Size(100, 20);
            this.TxtSape.TabIndex = 15;
            // 
            // BtnGuard
            // 
            this.BtnGuard.Location = new System.Drawing.Point(332, 202);
            this.BtnGuard.Name = "BtnGuard";
            this.BtnGuard.Size = new System.Drawing.Size(75, 23);
            this.BtnGuard.TabIndex = 16;
            this.BtnGuard.Text = "Guardar";
            this.BtnGuard.UseVisualStyleBackColor = true;
            this.BtnGuard.Click += new System.EventHandler(this.BtnGuard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Identificacion:";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(173, 182);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdentificacion.TabIndex = 18;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuard);
            this.Controls.Add(this.TxtSape);
            this.Controls.Add(this.TxtNomb);
            this.Controls.Add(this.TxtPape);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbGen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecIng);
            this.Controls.Add(this.dtpFecNac);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.DateTimePicker dtpFecIng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbGen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtPape;
        private System.Windows.Forms.TextBox TxtNomb;
        private System.Windows.Forms.TextBox TxtSape;
        private System.Windows.Forms.Button BtnGuard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
    }
}