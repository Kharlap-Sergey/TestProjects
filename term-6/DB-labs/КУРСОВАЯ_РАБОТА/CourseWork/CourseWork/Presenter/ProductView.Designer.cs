
namespace CourseWork.Presenter
{
    partial class ProductView
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.categoryName_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(3, 6);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(151, 20);
            this.name_textBox.TabIndex = 0;
            // 
            // categoryName_textBox
            // 
            this.categoryName_textBox.Location = new System.Drawing.Point(160, 6);
            this.categoryName_textBox.Name = "categoryName_textBox";
            this.categoryName_textBox.ReadOnly = true;
            this.categoryName_textBox.Size = new System.Drawing.Size(223, 20);
            this.categoryName_textBox.TabIndex = 1;
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(389, 6);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.ReadOnly = true;
            this.price_textBox.Size = new System.Drawing.Size(72, 20);
            this.price_textBox.TabIndex = 2;
            // 
            // edit_btn
            // 
            this.edit_btn.Image = global::CourseWork.Properties.Resources.edit2;
            this.edit_btn.Location = new System.Drawing.Point(581, 5);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(27, 20);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.categoryName_textBox);
            this.Controls.Add(this.name_textBox);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(611, 29);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox categoryName_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Button edit_btn;
    }
}
