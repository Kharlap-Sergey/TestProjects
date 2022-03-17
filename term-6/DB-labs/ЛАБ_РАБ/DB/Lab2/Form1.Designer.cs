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
            this.firstName_txtBox = new System.Windows.Forms.TextBox();
            this.LastName_txtBox = new System.Windows.Forms.TextBox();
            this.fatherName_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewEmpl_btn = new System.Windows.Forms.Button();
            this.newId_txtBox = new System.Windows.Forms.TextBox();
            this.calculateCount_btn = new System.Windows.Forms.Button();
            this.count_textBox = new System.Windows.Forms.TextBox();
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
            // firstName_txtBox
            // 
            this.firstName_txtBox.Location = new System.Drawing.Point(543, 34);
            this.firstName_txtBox.Name = "firstName_txtBox";
            this.firstName_txtBox.Size = new System.Drawing.Size(100, 23);
            this.firstName_txtBox.TabIndex = 2;
            // 
            // LastName_txtBox
            // 
            this.LastName_txtBox.Location = new System.Drawing.Point(543, 75);
            this.LastName_txtBox.Name = "LastName_txtBox";
            this.LastName_txtBox.Size = new System.Drawing.Size(100, 23);
            this.LastName_txtBox.TabIndex = 3;
            // 
            // fatherName_txtBox
            // 
            this.fatherName_txtBox.Location = new System.Drawing.Point(543, 117);
            this.fatherName_txtBox.Name = "fatherName_txtBox";
            this.fatherName_txtBox.Size = new System.Drawing.Size(100, 23);
            this.fatherName_txtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "first name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "father name";
            // 
            // addNewEmpl_btn
            // 
            this.addNewEmpl_btn.Location = new System.Drawing.Point(480, 161);
            this.addNewEmpl_btn.Name = "addNewEmpl_btn";
            this.addNewEmpl_btn.Size = new System.Drawing.Size(75, 23);
            this.addNewEmpl_btn.TabIndex = 8;
            this.addNewEmpl_btn.Text = "add";
            this.addNewEmpl_btn.UseVisualStyleBackColor = true;
            this.addNewEmpl_btn.Click += new System.EventHandler(this.addNewEmpl_btn_Click);
            // 
            // newId_txtBox
            // 
            this.newId_txtBox.Location = new System.Drawing.Point(536, 202);
            this.newId_txtBox.Name = "newId_txtBox";
            this.newId_txtBox.Size = new System.Drawing.Size(100, 23);
            this.newId_txtBox.TabIndex = 9;
            // 
            // calculateCount_btn
            // 
            this.calculateCount_btn.Location = new System.Drawing.Point(216, 351);
            this.calculateCount_btn.Name = "calculateCount_btn";
            this.calculateCount_btn.Size = new System.Drawing.Size(75, 23);
            this.calculateCount_btn.TabIndex = 10;
            this.calculateCount_btn.Text = "calculate count";
            this.calculateCount_btn.UseVisualStyleBackColor = true;
            this.calculateCount_btn.Click += new System.EventHandler(this.calculateCount_btn_Click);
            // 
            // count_textBox
            // 
            this.count_textBox.Location = new System.Drawing.Point(309, 349);
            this.count_textBox.Name = "count_textBox";
            this.count_textBox.Size = new System.Drawing.Size(100, 23);
            this.count_textBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.count_textBox);
            this.Controls.Add(this.calculateCount_btn);
            this.Controls.Add(this.newId_txtBox);
            this.Controls.Add(this.addNewEmpl_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fatherName_txtBox);
            this.Controls.Add(this.LastName_txtBox);
            this.Controls.Add(this.firstName_txtBox);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.employes_listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox employes_listBox;
        private Button read_btn;
        private TextBox firstName_txtBox;
        private TextBox LastName_txtBox;
        private TextBox fatherName_txtBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addNewEmpl_btn;
        private TextBox newId_txtBox;
        private Button calculateCount_btn;
        private TextBox count_textBox;
    }
}