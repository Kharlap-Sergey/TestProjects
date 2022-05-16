
namespace CourseWork.Filters
{
    partial class HistoryFiltersForm
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
            this.from_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.types_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.stores_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.orderBy_comboBox = new System.Windows.Forms.ComboBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from_dateTimePicker
            // 
            this.from_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from_dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.from_dateTimePicker.Name = "from_dateTimePicker";
            this.from_dateTimePicker.Size = new System.Drawing.Size(346, 30);
            this.from_dateTimePicker.TabIndex = 0;
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_dateTimePicker.Location = new System.Drawing.Point(12, 57);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(346, 30);
            this.to_dateTimePicker.TabIndex = 1;
            // 
            // types_checkedListBox
            // 
            this.types_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.types_checkedListBox.FormattingEnabled = true;
            this.types_checkedListBox.Location = new System.Drawing.Point(12, 99);
            this.types_checkedListBox.Name = "types_checkedListBox";
            this.types_checkedListBox.Size = new System.Drawing.Size(425, 54);
            this.types_checkedListBox.TabIndex = 3;
            // 
            // stores_checkedListBox
            // 
            this.stores_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stores_checkedListBox.FormattingEnabled = true;
            this.stores_checkedListBox.Location = new System.Drawing.Point(12, 167);
            this.stores_checkedListBox.Name = "stores_checkedListBox";
            this.stores_checkedListBox.Size = new System.Drawing.Size(425, 54);
            this.stores_checkedListBox.TabIndex = 4;
            // 
            // orderBy_comboBox
            // 
            this.orderBy_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderBy_comboBox.FormattingEnabled = true;
            this.orderBy_comboBox.Items.AddRange(new object[] {
            "newest",
            "latest"});
            this.orderBy_comboBox.Location = new System.Drawing.Point(12, 240);
            this.orderBy_comboBox.Name = "orderBy_comboBox";
            this.orderBy_comboBox.Size = new System.Drawing.Size(346, 33);
            this.orderBy_comboBox.TabIndex = 5;
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.apply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apply_btn.Location = new System.Drawing.Point(12, 279);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(84, 32);
            this.apply_btn.TabIndex = 6;
            this.apply_btn.Text = "apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Yellow;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_btn.Location = new System.Drawing.Point(257, 279);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(84, 32);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_btn.Location = new System.Drawing.Point(138, 279);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(84, 32);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // HistoryFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 319);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.orderBy_comboBox);
            this.Controls.Add(this.stores_checkedListBox);
            this.Controls.Add(this.types_checkedListBox);
            this.Controls.Add(this.to_dateTimePicker);
            this.Controls.Add(this.from_dateTimePicker);
            this.Name = "HistoryFiltersForm";
            this.Text = "HistoryFilters";
            this.Load += new System.EventHandler(this.HistoryFilters_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from_dateTimePicker;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        private System.Windows.Forms.CheckedListBox types_checkedListBox;
        private System.Windows.Forms.CheckedListBox stores_checkedListBox;
        private System.Windows.Forms.ComboBox orderBy_comboBox;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}