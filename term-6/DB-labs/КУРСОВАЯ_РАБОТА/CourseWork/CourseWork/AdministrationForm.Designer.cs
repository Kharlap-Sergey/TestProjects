
namespace CourseWork
{
    partial class AdministrationForm
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
            this.pages_tabControl = new System.Windows.Forms.TabControl();
            this.productCategories_tabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.productCategories_panal = new System.Windows.Forms.FlowLayoutPanel();
            this.products_tabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.products_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.shops_tabPage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel_menuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.save_menuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.add_menuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.shops_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pages_tabControl.SuspendLayout();
            this.productCategories_tabPage.SuspendLayout();
            this.products_tabPage.SuspendLayout();
            this.shops_tabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pages_tabControl
            // 
            this.pages_tabControl.Controls.Add(this.productCategories_tabPage);
            this.pages_tabControl.Controls.Add(this.products_tabPage);
            this.pages_tabControl.Controls.Add(this.shops_tabPage);
            this.pages_tabControl.Location = new System.Drawing.Point(12, 37);
            this.pages_tabControl.Name = "pages_tabControl";
            this.pages_tabControl.SelectedIndex = 0;
            this.pages_tabControl.Size = new System.Drawing.Size(776, 401);
            this.pages_tabControl.TabIndex = 0;
            // 
            // productCategories_tabPage
            // 
            this.productCategories_tabPage.Controls.Add(this.label3);
            this.productCategories_tabPage.Controls.Add(this.productCategories_panal);
            this.productCategories_tabPage.Location = new System.Drawing.Point(4, 22);
            this.productCategories_tabPage.Name = "productCategories_tabPage";
            this.productCategories_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productCategories_tabPage.Size = new System.Drawing.Size(768, 375);
            this.productCategories_tabPage.TabIndex = 0;
            this.productCategories_tabPage.Text = "Product Categories";
            this.productCategories_tabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // productCategories_panal
            // 
            this.productCategories_panal.AutoScroll = true;
            this.productCategories_panal.Location = new System.Drawing.Point(18, 35);
            this.productCategories_panal.Name = "productCategories_panal";
            this.productCategories_panal.Size = new System.Drawing.Size(722, 334);
            this.productCategories_panal.TabIndex = 0;
            // 
            // products_tabPage
            // 
            this.products_tabPage.Controls.Add(this.label4);
            this.products_tabPage.Controls.Add(this.label2);
            this.products_tabPage.Controls.Add(this.label1);
            this.products_tabPage.Controls.Add(this.products_panel);
            this.products_tabPage.Location = new System.Drawing.Point(4, 22);
            this.products_tabPage.Name = "products_tabPage";
            this.products_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.products_tabPage.Size = new System.Drawing.Size(768, 375);
            this.products_tabPage.TabIndex = 1;
            this.products_tabPage.Text = "Products";
            this.products_tabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(413, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // products_panel
            // 
            this.products_panel.AutoScroll = true;
            this.products_panel.Location = new System.Drawing.Point(22, 33);
            this.products_panel.Name = "products_panel";
            this.products_panel.Size = new System.Drawing.Size(722, 329);
            this.products_panel.TabIndex = 1;
            // 
            // shops_tabPage
            // 
            this.shops_tabPage.Controls.Add(this.shops_panel);
            this.shops_tabPage.Location = new System.Drawing.Point(4, 22);
            this.shops_tabPage.Name = "shops_tabPage";
            this.shops_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shops_tabPage.Size = new System.Drawing.Size(768, 375);
            this.shops_tabPage.TabIndex = 2;
            this.shops_tabPage.Text = "Shops";
            this.shops_tabPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.cancel_menuBtn,
            this.save_menuBtn,
            this.add_menuBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.toolsToolStripMenuItem.Text = "tools";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.undoToolStripMenuItem.Text = "undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // cancel_menuBtn
            // 
            this.cancel_menuBtn.Image = global::CourseWork.Properties.Resources.cancel;
            this.cancel_menuBtn.Name = "cancel_menuBtn";
            this.cancel_menuBtn.Size = new System.Drawing.Size(28, 20);
            this.cancel_menuBtn.Click += new System.EventHandler(this.cancel_menuBtn_Click);
            // 
            // save_menuBtn
            // 
            this.save_menuBtn.Image = global::CourseWork.Properties.Resources.save;
            this.save_menuBtn.Name = "save_menuBtn";
            this.save_menuBtn.Size = new System.Drawing.Size(28, 20);
            this.save_menuBtn.Click += new System.EventHandler(this.save_menuBtn_Click);
            // 
            // add_menuBtn
            // 
            this.add_menuBtn.Image = global::CourseWork.Properties.Resources.add;
            this.add_menuBtn.Name = "add_menuBtn";
            this.add_menuBtn.Size = new System.Drawing.Size(28, 20);
            this.add_menuBtn.Click += new System.EventHandler(this.add_menuBtn_Click);
            // 
            // shops_panel
            // 
            this.shops_panel.AutoScroll = true;
            this.shops_panel.Location = new System.Drawing.Point(23, 20);
            this.shops_panel.Name = "shops_panel";
            this.shops_panel.Size = new System.Drawing.Size(722, 334);
            this.shops_panel.TabIndex = 1;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pages_tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrationForm";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.pages_tabControl.ResumeLayout(false);
            this.productCategories_tabPage.ResumeLayout(false);
            this.productCategories_tabPage.PerformLayout();
            this.products_tabPage.ResumeLayout(false);
            this.products_tabPage.PerformLayout();
            this.shops_tabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl pages_tabControl;
        private System.Windows.Forms.TabPage productCategories_tabPage;
        private System.Windows.Forms.TabPage products_tabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancel_menuBtn;
        private System.Windows.Forms.ToolStripMenuItem save_menuBtn;
        private System.Windows.Forms.ToolStripMenuItem add_menuBtn;
        private System.Windows.Forms.FlowLayoutPanel productCategories_panal;
        private System.Windows.Forms.FlowLayoutPanel products_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage shops_tabPage;
        private System.Windows.Forms.FlowLayoutPanel shops_panel;
    }
}