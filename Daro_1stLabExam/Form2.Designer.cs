namespace Daro_1stLabExam
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label labelDanielle;
        private System.Windows.Forms.Label labelEdward;
        private System.Windows.Forms.Label labelFatima;

        private void InitializeComponent()
        {
            this.labelDanielle = new System.Windows.Forms.Label();
            this.labelEdward = new System.Windows.Forms.Label();
            this.labelFatima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDanielle
            // 
            this.labelDanielle.AutoSize = true;
            this.labelDanielle.Location = new System.Drawing.Point(40, 40);
            this.labelDanielle.Name = "labelDanielle";
            this.labelDanielle.TabIndex = 0;
            this.labelDanielle.Text = "Danielle: ₱0";
            // 
            // labelEdward
            // 
            this.labelEdward.AutoSize = true;
            this.labelEdward.Location = new System.Drawing.Point(40, 80);
            this.labelEdward.Name = "labelEdward";
            this.labelEdward.TabIndex = 1;
            this.labelEdward.Text = "Edward: ₱0";
            // 
            // labelFatima
            // 
            this.labelFatima.AutoSize = true;
            this.labelFatima.Location = new System.Drawing.Point(40, 120);
            this.labelFatima.Name = "labelFatima";
            this.labelFatima.TabIndex = 2;
            this.labelFatima.Text = "Fatima: ₱0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.labelDanielle);
            this.Controls.Add(this.labelEdward);
            this.Controls.Add(this.labelFatima);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Summary";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
