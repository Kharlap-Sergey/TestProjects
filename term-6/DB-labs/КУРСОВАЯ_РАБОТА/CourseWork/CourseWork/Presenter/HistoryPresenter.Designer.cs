
namespace CourseWork.Presenter
{
    partial class HistoryPresenter
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
            this.more_btn = new System.Windows.Forms.Button();
            this.categoryName_Text = new System.Windows.Forms.TextBox();
            this.date_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // more_btn
            // 
            this.more_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.more_btn.Location = new System.Drawing.Point(541, 3);
            this.more_btn.Name = "more_btn";
            this.more_btn.Size = new System.Drawing.Size(140, 30);
            this.more_btn.TabIndex = 2;
            this.more_btn.Text = "more";
            this.more_btn.UseVisualStyleBackColor = true;
            this.more_btn.Click += new System.EventHandler(this.more_btn_Click);
            // 
            // categoryName_Text
            // 
            this.categoryName_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryName_Text.Location = new System.Drawing.Point(336, 3);
            this.categoryName_Text.Name = "categoryName_Text";
            this.categoryName_Text.ReadOnly = true;
            this.categoryName_Text.Size = new System.Drawing.Size(168, 30);
            this.categoryName_Text.TabIndex = 3;
            this.categoryName_Text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // date_Text
            // 
            this.date_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_Text.Location = new System.Drawing.Point(22, 3);
            this.date_Text.Name = "date_Text";
            this.date_Text.ReadOnly = true;
            this.date_Text.Size = new System.Drawing.Size(298, 30);
            this.date_Text.TabIndex = 4;
            // 
            // HistoryPresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_Text);
            this.Controls.Add(this.categoryName_Text);
            this.Controls.Add(this.more_btn);
            this.Name = "HistoryPresenter";
            this.Size = new System.Drawing.Size(688, 41);
            this.Load += new System.EventHandler(this.HistoryPresenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button more_btn;
        private System.Windows.Forms.TextBox categoryName_Text;
        private System.Windows.Forms.TextBox date_Text;
    }
}
