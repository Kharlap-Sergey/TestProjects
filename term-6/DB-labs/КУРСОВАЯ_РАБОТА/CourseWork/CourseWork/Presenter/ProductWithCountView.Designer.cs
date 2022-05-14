
namespace CourseWork.Presenter
{
    partial class ProductWithCountView
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.categoryName_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.count_textBox = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(7, 43);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(151, 20);
            this.name_textBox.TabIndex = 4;
            // 
            // categoryName_textBox
            // 
            this.categoryName_textBox.Location = new System.Drawing.Point(164, 43);
            this.categoryName_textBox.Name = "categoryName_textBox";
            this.categoryName_textBox.ReadOnly = true;
            this.categoryName_textBox.Size = new System.Drawing.Size(223, 20);
            this.categoryName_textBox.TabIndex = 5;
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(393, 43);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.ReadOnly = true;
            this.price_textBox.Size = new System.Drawing.Size(116, 20);
            this.price_textBox.TabIndex = 6;
            // 
            // count_textBox
            // 
            this.count_textBox.Location = new System.Drawing.Point(515, 43);
            this.count_textBox.Name = "count_textBox";
            this.count_textBox.ReadOnly = true;
            this.count_textBox.Size = new System.Drawing.Size(72, 20);
            this.count_textBox.TabIndex = 7;
            // 
            // edit_btn
            // 
            this.edit_btn.Image = global::CourseWork.Properties.Resources.edit2;
            this.edit_btn.Location = new System.Drawing.Point(613, 12);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(58, 51);
            this.edit_btn.TabIndex = 11;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(277, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(510, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Count";
            // 
            // ProductWithCountView
            // 
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.count_textBox);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.categoryName_textBox);
            this.Controls.Add(this.name_textBox);
            this.Name = "ProductWithCountView";
            this.Size = new System.Drawing.Size(685, 75);
            this.Load += new System.EventHandler(this.ProductWithCountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox categoryName_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox count_textBox;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}