
namespace CourseWork
{
    partial class SweetShop
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
            this.supplies_btn = new System.Windows.Forms.Button();
            this.administration_btn = new System.Windows.Forms.Button();
            this.statistic_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supplies_btn
            // 
            this.supplies_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplies_btn.Location = new System.Drawing.Point(66, 216);
            this.supplies_btn.Name = "supplies_btn";
            this.supplies_btn.Size = new System.Drawing.Size(766, 74);
            this.supplies_btn.TabIndex = 0;
            this.supplies_btn.Text = "supplies";
            this.supplies_btn.UseVisualStyleBackColor = true;
            this.supplies_btn.Click += new System.EventHandler(this.supplies_btn_Click);
            // 
            // administration_btn
            // 
            this.administration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.administration_btn.Location = new System.Drawing.Point(66, 114);
            this.administration_btn.Name = "administration_btn";
            this.administration_btn.Size = new System.Drawing.Size(766, 74);
            this.administration_btn.TabIndex = 1;
            this.administration_btn.Text = "administration";
            this.administration_btn.UseVisualStyleBackColor = true;
            this.administration_btn.Click += new System.EventHandler(this.administration_btn_Click);
            // 
            // statistic_btn
            // 
            this.statistic_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistic_btn.Location = new System.Drawing.Point(66, 325);
            this.statistic_btn.Name = "statistic_btn";
            this.statistic_btn.Size = new System.Drawing.Size(766, 74);
            this.statistic_btn.TabIndex = 2;
            this.statistic_btn.Text = "statistic";
            this.statistic_btn.UseVisualStyleBackColor = true;
            this.statistic_btn.Click += new System.EventHandler(this.statistic_btn_Click);
            // 
            // SweetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 478);
            this.Controls.Add(this.statistic_btn);
            this.Controls.Add(this.administration_btn);
            this.Controls.Add(this.supplies_btn);
            this.Name = "SweetShop";
            this.Text = "Candy shop sppliement system Kharlap Sergey";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button supplies_btn;
        private System.Windows.Forms.Button administration_btn;
        private System.Windows.Forms.Button statistic_btn;
    }
}

