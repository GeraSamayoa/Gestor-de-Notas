namespace Frontend
{
    partial class Estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudiante));
            this.lbEstudiante = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBoletaEstudiante = new System.Windows.Forms.Button();
            this.btnAsignarseEstudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstudiante
            // 
            this.lbEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEstudiante.Location = new System.Drawing.Point(233, 30);
            this.lbEstudiante.Name = "lbEstudiante";
            this.lbEstudiante.Size = new System.Drawing.Size(329, 91);
            this.lbEstudiante.TabIndex = 0;
            this.lbEstudiante.Text = "Estudiante";
            this.lbEstudiante.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(651, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnBoletaEstudiante
            // 
            this.btnBoletaEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.btnBoletaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoletaEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletaEstudiante.Location = new System.Drawing.Point(128, 262);
            this.btnBoletaEstudiante.Name = "btnBoletaEstudiante";
            this.btnBoletaEstudiante.Size = new System.Drawing.Size(221, 62);
            this.btnBoletaEstudiante.TabIndex = 2;
            this.btnBoletaEstudiante.Text = "Boleta";
            this.btnBoletaEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnAsignarseEstudiante
            // 
            this.btnAsignarseEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.btnAsignarseEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarseEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAsignarseEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignarseEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarseEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnAsignarseEstudiante.Location = new System.Drawing.Point(457, 262);
            this.btnAsignarseEstudiante.Name = "btnAsignarseEstudiante";
            this.btnAsignarseEstudiante.Size = new System.Drawing.Size(221, 62);
            this.btnAsignarseEstudiante.TabIndex = 3;
            this.btnAsignarseEstudiante.Text = "Asignarse";
            this.btnAsignarseEstudiante.UseVisualStyleBackColor = false;
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignarseEstudiante);
            this.Controls.Add(this.btnBoletaEstudiante);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbEstudiante);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Estudiante";
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEstudiante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBoletaEstudiante;
        private System.Windows.Forms.Button btnAsignarseEstudiante;
    }
}