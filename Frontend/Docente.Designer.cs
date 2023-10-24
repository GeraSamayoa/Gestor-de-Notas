namespace Frontend
{
    partial class Docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docente));
            this.btnAsignarseDocente = new System.Windows.Forms.Button();
            this.btnAgregarNotas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDocente = new System.Windows.Forms.Label();
            this.btnReportesDocente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarseDocente
            // 
            this.btnAsignarseDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnAsignarseDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarseDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAsignarseDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarseDocente.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarseDocente.ForeColor = System.Drawing.Color.White;
            this.btnAsignarseDocente.Location = new System.Drawing.Point(29, 268);
            this.btnAsignarseDocente.Name = "btnAsignarseDocente";
            this.btnAsignarseDocente.Size = new System.Drawing.Size(222, 62);
            this.btnAsignarseDocente.TabIndex = 7;
            this.btnAsignarseDocente.Text = "Asignarse";
            this.btnAsignarseDocente.UseVisualStyleBackColor = false;
            // 
            // btnAgregarNotas
            // 
            this.btnAgregarNotas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarNotas.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNotas.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNotas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNotas.Location = new System.Drawing.Point(291, 268);
            this.btnAgregarNotas.Name = "btnAgregarNotas";
            this.btnAgregarNotas.Size = new System.Drawing.Size(221, 62);
            this.btnAgregarNotas.TabIndex = 6;
            this.btnAgregarNotas.Text = "Agregar Notas";
            this.btnAgregarNotas.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(651, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbDocente
            // 
            this.lbDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbDocente.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDocente.Location = new System.Drawing.Point(263, 32);
            this.lbDocente.Name = "lbDocente";
            this.lbDocente.Size = new System.Drawing.Size(270, 91);
            this.lbDocente.TabIndex = 4;
            this.lbDocente.Text = "Docente";
            // 
            // btnReportesDocente
            // 
            this.btnReportesDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnReportesDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportesDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnReportesDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportesDocente.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesDocente.ForeColor = System.Drawing.Color.White;
            this.btnReportesDocente.Location = new System.Drawing.Point(551, 268);
            this.btnReportesDocente.Name = "btnReportesDocente";
            this.btnReportesDocente.Size = new System.Drawing.Size(221, 62);
            this.btnReportesDocente.TabIndex = 8;
            this.btnReportesDocente.Text = "Reportes";
            this.btnReportesDocente.UseVisualStyleBackColor = false;
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportesDocente);
            this.Controls.Add(this.btnAsignarseDocente);
            this.Controls.Add(this.btnAgregarNotas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDocente);
            this.Name = "Docente";
            this.Text = "Docente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarseDocente;
        private System.Windows.Forms.Button btnAgregarNotas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDocente;
        private System.Windows.Forms.Button btnReportesDocente;
    }
}