namespace app12
{
    partial class Form1
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

        
        private void InitializeComponent()
        {
            this.timeLbl = new System.Windows.Forms.Label();
            this.londonBtn = new System.Windows.Forms.Button();
            this.bakuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Transparent;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Brown;
            this.timeLbl.Location = new System.Drawing.Point(95, 7);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(164, 55);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "ⓉⒾⓂⒺ";
            this.timeLbl.Click += new System.EventHandler(this.timeLbl_Click);
            // 
            // londonBtn
            // 
            this.londonBtn.BackColor = System.Drawing.Color.Transparent;
            this.londonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonBtn.ForeColor = System.Drawing.Color.Chocolate;
            this.londonBtn.Location = new System.Drawing.Point(525, 453);
            this.londonBtn.Margin = new System.Windows.Forms.Padding(2);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(249, 53);
            this.londonBtn.TabIndex = 1;
            this.londonBtn.Text = "𝓛𝓞𝓝𝓓𝓞𝓝";
            this.londonBtn.UseVisualStyleBackColor = false;
            this.londonBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonBtn_MouseClick);
            // 
            // bakuBtn
            // 
            this.bakuBtn.BackColor = System.Drawing.Color.Transparent;
            this.bakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuBtn.ForeColor = System.Drawing.Color.Red;
            this.bakuBtn.Location = new System.Drawing.Point(61, 453);
            this.bakuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(249, 53);
            this.bakuBtn.TabIndex = 2;
            this.bakuBtn.Text = "ẞ𝓐Ⲕ𝓤";
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app12.Properties.Resources.Panorama_of_Baku_2022;
            this.ClientSize = new System.Drawing.Size(886, 591);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.londonBtn);
            this.Controls.Add(this.timeLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(7504, 820);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Button bakuBtn;
    }
}

