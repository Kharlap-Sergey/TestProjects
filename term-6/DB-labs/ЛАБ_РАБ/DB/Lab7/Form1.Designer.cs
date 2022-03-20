
namespace Lab7
{
    partial class Form1
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
            this.openRelations_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openRelations_btn
            // 
            this.openRelations_btn.Location = new System.Drawing.Point(48, 371);
            this.openRelations_btn.Name = "openRelations_btn";
            this.openRelations_btn.Size = new System.Drawing.Size(710, 52);
            this.openRelations_btn.TabIndex = 0;
            this.openRelations_btn.Text = "Open Relations";
            this.openRelations_btn.UseVisualStyleBackColor = true;
            this.openRelations_btn.Click += new System.EventHandler(this.openRelations_btn_Click);
            // 
            // products_btn
            // 
            this.products_btn.Location = new System.Drawing.Point(167, 32);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(459, 34);
            this.products_btn.TabIndex = 1;
            this.products_btn.Text = "Products";
            this.products_btn.UseVisualStyleBackColor = true;
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.products_btn);
            this.Controls.Add(this.openRelations_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openRelations_btn;
        private System.Windows.Forms.Button products_btn;
    }
}

