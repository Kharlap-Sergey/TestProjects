
namespace CourseWork.Creators
{
    partial class ProductWithCountEditor
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
            this.products_comboBox = new System.Windows.Forms.ComboBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.count_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // products_comboBox
            // 
            this.products_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.products_comboBox.FormattingEnabled = true;
            this.products_comboBox.Location = new System.Drawing.Point(33, 33);
            this.products_comboBox.Name = "products_comboBox";
            this.products_comboBox.Size = new System.Drawing.Size(512, 39);
            this.products_comboBox.TabIndex = 0;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_btn.Location = new System.Drawing.Point(237, 193);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(124, 44);
            this.cancel_btn.TabIndex = 10;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.Location = new System.Drawing.Point(421, 193);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(124, 44);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "Remove";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(43, 193);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(124, 44);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Submit";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // price_TB
            // 
            this.count_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_TB.Location = new System.Drawing.Point(337, 107);
            this.count_TB.Name = "count_TB";
            this.count_TB.Size = new System.Drawing.Size(208, 38);
            this.count_TB.TabIndex = 11;
            this.count_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Count";
            // 
            // ProductWithCountEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_TB);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.products_comboBox);
            this.Name = "ProductWithCountEditor";
            this.Text = "ProductWithCountEditor";
            this.Load += new System.EventHandler(this.ProductWithCountEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox products_comboBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox count_TB;
        private System.Windows.Forms.Label label1;
    }
}