namespace Frontend
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnAsignacionesAdmin = new System.Windows.Forms.Button();
            this.btnReportesAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignacionesAdmin
            // 
            this.btnAsignacionesAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.btnAsignacionesAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignacionesAdmin.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAsignacionesAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignacionesAdmin.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacionesAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAsignacionesAdmin.Location = new System.Drawing.Point(124, 265);
            this.btnAsignacionesAdmin.Name = "btnAsignacionesAdmin";
            this.btnAsignacionesAdmin.Size = new System.Drawing.Size(224, 62);
            this.btnAsignacionesAdmin.TabIndex = 7;
            this.btnAsignacionesAdmin.Text = "Asignaciones";
            this.btnAsignacionesAdmin.UseVisualStyleBackColor = false;
            // 
            // btnReportesAdmin
            // 
            this.btnReportesAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.btnReportesAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportesAdmin.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesAdmin.ForeColor = System.Drawing.Color.White;
            this.btnReportesAdmin.Location = new System.Drawing.Point(461, 265);
            this.btnReportesAdmin.Name = "btnReportesAdmin";
            this.btnReportesAdmin.Size = new System.Drawing.Size(221, 62);
            this.btnReportesAdmin.TabIndex = 6;
            this.btnReportesAdmin.Text = "Reportes";
            this.btnReportesAdmin.UseVisualStyleBackColor = false;
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
            // lbAdmin
            // 
            this.lbAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbAdmin.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAdmin.Location = new System.Drawing.Point(174, 36);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(419, 83);
            this.lbAdmin.TabIndex = 4;
            this.lbAdmin.Text = "Administrador";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignacionesAdmin);
            this.Controls.Add(this.btnReportesAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsignacionesAdmin;
        private System.Windows.Forms.Button btnReportesAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAdmin;
    }
}