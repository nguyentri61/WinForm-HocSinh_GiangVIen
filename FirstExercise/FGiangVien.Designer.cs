namespace FirstExercise
{
    partial class FGiangVien
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
            this.ucThongTin1 = new FirstExercise.UCThongTin();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucThongTin1
            // 
            this.ucThongTin1.Location = new System.Drawing.Point(12, 68);
            this.ucThongTin1.Name = "ucThongTin1";
            this.ucThongTin1.Size = new System.Drawing.Size(1441, 552);
            this.ucThongTin1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(576, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 39);
            this.label5.TabIndex = 26;
            this.label5.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // FGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1457, 679);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ucThongTin1);
            this.Name = "FGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiangVien";
            this.Load += new System.EventHandler(this.FGiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCThongTin ucThongTin1;
        private System.Windows.Forms.Label label5;
    }
}