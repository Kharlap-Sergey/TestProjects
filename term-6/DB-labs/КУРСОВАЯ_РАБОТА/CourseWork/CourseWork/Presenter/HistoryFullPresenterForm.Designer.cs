
namespace CourseWork.Presenter
{
    partial class HistoryFullPresenterForm
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
            this.date_TextBox = new System.Windows.Forms.TextBox();
            this.type_TextBox = new System.Windows.Forms.TextBox();
            this.products_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.shop_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // date_TextBox
            // 
            this.date_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_TextBox.Location = new System.Drawing.Point(12, 56);
            this.date_TextBox.Name = "date_TextBox";
            this.date_TextBox.ReadOnly = true;
            this.date_TextBox.Size = new System.Drawing.Size(295, 30);
            this.date_TextBox.TabIndex = 0;
            // 
            // type_TextBox
            // 
            this.type_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_TextBox.Location = new System.Drawing.Point(493, 56);
            this.type_TextBox.Name = "type_TextBox";
            this.type_TextBox.ReadOnly = true;
            this.type_TextBox.Size = new System.Drawing.Size(295, 30);
            this.type_TextBox.TabIndex = 1;
            // 
            // products_Panel
            // 
            this.products_Panel.Location = new System.Drawing.Point(12, 92);
            this.products_Panel.Name = "products_Panel";
            this.products_Panel.Size = new System.Drawing.Size(776, 346);
            this.products_Panel.TabIndex = 2;
            // 
            // shop_TextBox
            // 
            this.shop_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shop_TextBox.Location = new System.Drawing.Point(271, 20);
            this.shop_TextBox.Name = "shop_TextBox";
            this.shop_TextBox.ReadOnly = true;
            this.shop_TextBox.Size = new System.Drawing.Size(295, 30);
            this.shop_TextBox.TabIndex = 3;
            this.shop_TextBox.DoubleClick += new System.EventHandler(this.shop_TextBox_DoubleClick);
            // 
            // HistoryFullPresenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shop_TextBox);
            this.Controls.Add(this.products_Panel);
            this.Controls.Add(this.type_TextBox);
            this.Controls.Add(this.date_TextBox);
            this.Name = "HistoryFullPresenterForm";
            this.Text = "HistoryFullPresenterForm";
            this.Load += new System.EventHandler(this.HistoryFullPresenterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox date_TextBox;
        private System.Windows.Forms.TextBox type_TextBox;
        private System.Windows.Forms.FlowLayoutPanel products_Panel;
        private System.Windows.Forms.TextBox shop_TextBox;
    }
}