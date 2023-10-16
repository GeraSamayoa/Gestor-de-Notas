namespace Frontend
{
    partial class FormPruebasSR
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
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.cbxDocente = new System.Windows.Forms.ComboBox();
            this.dvgNotas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCiclo = new System.Windows.Forms.ComboBox();
            this.cbxJornada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEleccionIngresoNota = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNotas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(308, 189);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(124, 42);
            this.btnAgregarNota.TabIndex = 0;
            this.btnAgregarNota.Text = "Agregar Nota";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Docente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(115, 273);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(121, 24);
            this.cbxEstudiante.TabIndex = 3;
            // 
            // cbxDocente
            // 
            this.cbxDocente.FormattingEnabled = true;
            this.cbxDocente.Location = new System.Drawing.Point(116, 11);
            this.cbxDocente.Name = "cbxDocente";
            this.cbxDocente.Size = new System.Drawing.Size(121, 24);
            this.cbxDocente.TabIndex = 4;
            // 
            // dvgNotas
            // 
            this.dvgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgNotas.Location = new System.Drawing.Point(460, 82);
            this.dvgNotas.Name = "dvgNotas";
            this.dvgNotas.RowHeadersWidth = 51;
            this.dvgNotas.RowTemplate.Height = 24;
            this.dvgNotas.Size = new System.Drawing.Size(323, 275);
            this.dvgNotas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(345, 14);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 22);
            this.txtNota.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Curso";
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(115, 230);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(121, 24);
            this.cbxCurso.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 456);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbxEleccionIngresoNota);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbxJornada);
            this.tabPage1.Controls.Add(this.cbxCiclo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnAgregarNota);
            this.tabPage1.Controls.Add(this.cbxEstudiante);
            this.tabPage1.Controls.Add(this.cbxDocente);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbxCurso);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dvgNotas);
            this.tabPage1.Controls.Add(this.txtNota);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RegistroNotas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Carrera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ciclo";
            // 
            // cbxCiclo
            // 
            this.cbxCiclo.FormattingEnabled = true;
            this.cbxCiclo.Location = new System.Drawing.Point(115, 143);
            this.cbxCiclo.Name = "cbxCiclo";
            this.cbxCiclo.Size = new System.Drawing.Size(121, 24);
            this.cbxCiclo.TabIndex = 13;
            // 
            // cbxJornada
            // 
            this.cbxJornada.FormattingEnabled = true;
            this.cbxJornada.Location = new System.Drawing.Point(115, 101);
            this.cbxJornada.Name = "cbxJornada";
            this.cbxJornada.Size = new System.Drawing.Size(121, 24);
            this.cbxJornada.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jornada";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 67);
            this.label8.TabIndex = 16;
            this.label8.Text = "Selecione en donde desea ingresar la nota";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbxEleccionIngresoNota
            // 
            this.cbxEleccionIngresoNota.FormattingEnabled = true;
            this.cbxEleccionIngresoNota.Location = new System.Drawing.Point(115, 327);
            this.cbxEleccionIngresoNota.Name = "cbxEleccionIngresoNota";
            this.cbxEleccionIngresoNota.Size = new System.Drawing.Size(121, 24);
            this.cbxEleccionIngresoNota.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Seccion";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(115, 188);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boleta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // FormPruebasSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPruebasSR";
            this.Text = "FormPruebasSR";
            ((System.ComponentModel.ISupportInitialize)(this.dvgNotas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.ComboBox cbxDocente;
        private System.Windows.Forms.DataGridView dvgNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxCiclo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxJornada;
        private System.Windows.Forms.ComboBox cbxEleccionIngresoNota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
    }
}