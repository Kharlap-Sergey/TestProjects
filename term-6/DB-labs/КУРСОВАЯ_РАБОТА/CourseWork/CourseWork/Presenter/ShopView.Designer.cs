
namespace CourseWork.Presenter
{
    partial class ShopView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_TB = new System.Windows.Forms.TextBox();
            this.cureCode_TB = new System.Windows.Forms.TextBox();
            this.location1_TB = new System.Windows.Forms.TextBox();
            this.location2_TB = new System.Windows.Forms.TextBox();
            this.location3_TB = new System.Windows.Forms.TextBox();
            this.location4_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_TB
            // 
            this.name_TB.Location = new System.Drawing.Point(41, 3);
            this.name_TB.Name = "name_TB";
            this.name_TB.ReadOnly = true;
            this.name_TB.Size = new System.Drawing.Size(568, 20);
            this.name_TB.TabIndex = 0;
            // 
            // cureCode_TB
            // 
            this.cureCode_TB.Location = new System.Drawing.Point(3, 51);
            this.cureCode_TB.Name = "cureCode_TB";
            this.cureCode_TB.ReadOnly = true;
            this.cureCode_TB.Size = new System.Drawing.Size(61, 20);
            this.cureCode_TB.TabIndex = 1;
            // 
            // location1_TB
            // 
            this.location1_TB.Location = new System.Drawing.Point(84, 51);
            this.location1_TB.Name = "location1_TB";
            this.location1_TB.ReadOnly = true;
            this.location1_TB.Size = new System.Drawing.Size(124, 20);
            this.location1_TB.TabIndex = 2;
            // 
            // location2_TB
            // 
            this.location2_TB.Location = new System.Drawing.Point(223, 51);
            this.location2_TB.Name = "location2_TB";
            this.location2_TB.ReadOnly = true;
            this.location2_TB.Size = new System.Drawing.Size(124, 20);
            this.location2_TB.TabIndex = 3;
            // 
            // location3_TB
            // 
            this.location3_TB.Location = new System.Drawing.Point(362, 51);
            this.location3_TB.Name = "location3_TB";
            this.location3_TB.ReadOnly = true;
            this.location3_TB.Size = new System.Drawing.Size(124, 20);
            this.location3_TB.TabIndex = 4;
            // 
            // location4_TB
            // 
            this.location4_TB.Location = new System.Drawing.Point(511, 51);
            this.location4_TB.Name = "location4_TB";
            this.location4_TB.ReadOnly = true;
            this.location4_TB.Size = new System.Drawing.Size(124, 20);
            this.location4_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "cur code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Streat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "house hold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "District";
            // 
            // edit_btn
            // 
            this.edit_btn.Image = global::CourseWork.Properties.Resources.edit2;
            this.edit_btn.Location = new System.Drawing.Point(608, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(27, 20);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // ShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location4_TB);
            this.Controls.Add(this.location3_TB);
            this.Controls.Add(this.location2_TB);
            this.Controls.Add(this.location1_TB);
            this.Controls.Add(this.cureCode_TB);
            this.Controls.Add(this.name_TB);
            this.Name = "ShopView";
            this.Size = new System.Drawing.Size(647, 74);
            this.Load += new System.EventHandler(this.ShopView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_TB;
        private System.Windows.Forms.TextBox cureCode_TB;
        private System.Windows.Forms.TextBox location1_TB;
        private System.Windows.Forms.TextBox location2_TB;
        private System.Windows.Forms.TextBox location3_TB;
        private System.Windows.Forms.TextBox location4_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_btn;
    }
}
