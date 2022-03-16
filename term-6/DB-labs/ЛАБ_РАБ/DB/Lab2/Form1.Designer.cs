namespace Lab2
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
            this.employes_listBox = new System.Windows.Forms.ListBox();
            this.read_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employes_listBox
            // 
            this.employes_listBox.FormattingEnabled = true;
            this.employes_listBox.ItemHeight = 15;
            this.employes_listBox.Location = new System.Drawing.Point(36, 36);
            this.employes_listBox.Name = "employes_listBox";
            this.employes_listBox.Size = new System.Drawing.Size(211, 229);
            this.employes_listBox.TabIndex = 0;
            // 
            // read_btn
            // 
            this.read_btn.Location = new System.Drawing.Point(35, 12);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(75, 23);
            this.read_btn.TabIndex = 1;
            this.read_btn.Text = "get";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.employes_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox employes_listBox;
        private Button read_btn;
    }
}