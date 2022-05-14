
namespace CourseWork
{
    partial class SuppliesForm
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
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            this.supplies_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shop_comboBox = new System.Windows.Forms.ComboBox();
            this.products_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // type_comboBox
            // 
            this.type_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Location = new System.Drawing.Point(642, 26);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(146, 33);
            this.type_comboBox.TabIndex = 0;
            // 
            // supplies_dateTimePicker
            // 
            this.supplies_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplies_dateTimePicker.Location = new System.Drawing.Point(238, 29);
            this.supplies_dateTimePicker.Name = "supplies_dateTimePicker";
            this.supplies_dateTimePicker.Size = new System.Drawing.Size(398, 30);
            this.supplies_dateTimePicker.TabIndex = 1;
            // 
            // shop_comboBox
            // 
            this.shop_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shop_comboBox.FormattingEnabled = true;
            this.shop_comboBox.Location = new System.Drawing.Point(24, 26);
            this.shop_comboBox.Name = "shop_comboBox";
            this.shop_comboBox.Size = new System.Drawing.Size(208, 33);
            this.shop_comboBox.TabIndex = 2;
            // 
            // products_panel
            // 
            this.products_panel.Location = new System.Drawing.Point(24, 107);
            this.products_panel.Name = "products_panel";
            this.products_panel.Size = new System.Drawing.Size(764, 279);
            this.products_panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(764, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SuppliesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.products_panel);
            this.Controls.Add(this.shop_comboBox);
            this.Controls.Add(this.supplies_dateTimePicker);
            this.Controls.Add(this.type_comboBox);
            this.Name = "SuppliesForm";
            this.Text = "SuppliesForm";
            this.Load += new System.EventHandler(this.SuppliesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type_comboBox;
        private System.Windows.Forms.DateTimePicker supplies_dateTimePicker;
        private System.Windows.Forms.ComboBox shop_comboBox;
        private System.Windows.Forms.FlowLayoutPanel products_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}