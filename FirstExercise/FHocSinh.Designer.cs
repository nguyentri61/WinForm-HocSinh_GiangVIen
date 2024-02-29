namespace FirstExercise
{
    partial class FHocSinh
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnGV = new System.Windows.Forms.Button();
            this.ucThongTin1 = new FirstExercise.UCThongTin();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-A Love Of Thunder", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 39);
            this.label5.TabIndex = 27;
            this.label5.Text = "QUẢN LÝ HỌC SINH";
            // 
            // btnGV
            // 
            this.btnGV.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGV.Font = new System.Drawing.Font("SVN-Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnGV.Location = new System.Drawing.Point(1319, 624);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(186, 62);
            this.btnGV.TabIndex = 28;
            this.btnGV.Text = "Giảng Viên";
            this.btnGV.UseVisualStyleBackColor = false;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // ucThongTin1
            // 
            this.ucThongTin1.Location = new System.Drawing.Point(12, 67);
            this.ucThongTin1.Name = "ucThongTin1";
            this.ucThongTin1.Size = new System.Drawing.Size(1441, 552);
            this.ucThongTin1.TabIndex = 29;
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1517, 698);
            this.Controls.Add(this.ucThongTin1);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.label5);
            this.Name = "FHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGV;
        private UCThongTin ucThongTin1;
    }
}

