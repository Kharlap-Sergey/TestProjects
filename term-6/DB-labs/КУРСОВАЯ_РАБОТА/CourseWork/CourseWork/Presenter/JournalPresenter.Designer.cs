
namespace CourseWork.Presenter
{
    partial class JournalPresenter
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
            this.date = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(19, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(64, 25);
            this.date.TabIndex = 0;
            this.date.Text = "label1";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.Location = new System.Drawing.Point(326, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(64, 25);
            this.product.TabIndex = 1;
            this.product.Text = "label1";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(524, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(64, 25);
            this.price.TabIndex = 2;
            this.price.Text = "label1";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(644, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(64, 25);
            this.count.TabIndex = 3;
            this.count.Text = "label1";
            // 
            // JournalPresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.count);
            this.Controls.Add(this.price);
            this.Controls.Add(this.product);
            this.Controls.Add(this.date);
            this.Name = "JournalPresenter";
            this.Size = new System.Drawing.Size(739, 35);
            this.Load += new System.EventHandler(this.JournalPresenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label count;
    }
}
