
namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.histories_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.warehouses_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // histories_btn
            // 
            this.histories_btn.Location = new System.Drawing.Point(217, 48);
            this.histories_btn.Name = "histories_btn";
            this.histories_btn.Size = new System.Drawing.Size(344, 48);
            this.histories_btn.TabIndex = 0;
            this.histories_btn.Text = "Histories";
            this.histories_btn.UseVisualStyleBackColor = true;
            this.histories_btn.Click += new System.EventHandler(this.histories_btn_Click);
            // 
            // products_btn
            // 
            this.products_btn.Location = new System.Drawing.Point(217, 124);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(344, 48);
            this.products_btn.TabIndex = 1;
            this.products_btn.Text = "Products";
            this.products_btn.UseVisualStyleBackColor = true;
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // warehouses_btn
            // 
            this.warehouses_btn.Location = new System.Drawing.Point(217, 209);
            this.warehouses_btn.Name = "warehouses_btn";
            this.warehouses_btn.Size = new System.Drawing.Size(344, 48);
            this.warehouses_btn.TabIndex = 2;
            this.warehouses_btn.Text = "Warehouses";
            this.warehouses_btn.UseVisualStyleBackColor = true;
            this.warehouses_btn.Click += new System.EventHandler(this.warehouses_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warehouses_btn);
            this.Controls.Add(this.products_btn);
            this.Controls.Add(this.histories_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button histories_btn;
        private System.Windows.Forms.Button products_btn;
        private System.Windows.Forms.Button warehouses_btn;
    }
}

