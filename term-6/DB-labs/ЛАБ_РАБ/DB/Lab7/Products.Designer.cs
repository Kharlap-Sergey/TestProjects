
namespace Lab7
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label pRICELabel;
            System.Windows.Forms.Label pRODUCT_CATEGORY_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.db2DataSet = new Lab7.Db2DataSet();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new Lab7.Db2DataSetTableAdapters.PRODUCTSTableAdapter();
            this.tableAdapterManager = new Lab7.Db2DataSetTableAdapters.TableAdapterManager();
            this.pRODUCTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pRODUCTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.pRODUCT_CATEGORY_IDTextBox = new System.Windows.Forms.TextBox();
            this.productCat_combo = new System.Windows.Forms.ComboBox();
            this.pRODUCTCATEGORIESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTCATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCT_CATEGORIESTableAdapter = new Lab7.Db2DataSetTableAdapters.PRODUCT_CATEGORIESTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            nAMELabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            pRODUCT_CATEGORY_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingNavigator)).BeginInit();
            this.pRODUCTSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCATEGORIESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCATEGORIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(65, 90);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(41, 13);
            nAMELabel.TabIndex = 2;
            nAMELabel.Text = "NAME:";
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Location = new System.Drawing.Point(64, 116);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(42, 13);
            pRICELabel.TabIndex = 3;
            pRICELabel.Text = "PRICE:";
            // 
            // pRODUCT_CATEGORY_IDLabel
            // 
            pRODUCT_CATEGORY_IDLabel.AutoSize = true;
            pRODUCT_CATEGORY_IDLabel.Location = new System.Drawing.Point(73, 148);
            pRODUCT_CATEGORY_IDLabel.Name = "pRODUCT_CATEGORY_IDLabel";
            pRODUCT_CATEGORY_IDLabel.Size = new System.Drawing.Size(139, 13);
            pRODUCT_CATEGORY_IDLabel.TabIndex = 5;
            pRODUCT_CATEGORY_IDLabel.Text = "PRODUCT CATEGORY ID:";
            // 
            // db2DataSet
            // 
            this.db2DataSet.DataSetName = "Db2DataSet";
            this.db2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.db2DataSet;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HISTORIESTableAdapter = null;
            this.tableAdapterManager.HISTORY_PRODUCTTableAdapter = null;
            this.tableAdapterManager.HISTORY_TYPESTableAdapter = null;
            this.tableAdapterManager.LOCATIONSTableAdapter = null;
            this.tableAdapterManager.PRODUCT_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.PRODUCTSTableAdapter = this.pRODUCTSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab7.Db2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WAREHOUSE_PRODUCTTableAdapter = null;
            this.tableAdapterManager.WAREHOUSESTableAdapter = null;
            // 
            // pRODUCTSBindingNavigator
            // 
            this.pRODUCTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUCTSBindingNavigator.BindingSource = this.pRODUCTSBindingSource;
            this.pRODUCTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUCTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUCTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pRODUCTSBindingNavigatorSaveItem});
            this.pRODUCTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRODUCTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUCTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUCTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUCTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUCTSBindingNavigator.Name = "pRODUCTSBindingNavigator";
            this.pRODUCTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUCTSBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pRODUCTSBindingNavigator.TabIndex = 0;
            this.pRODUCTSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pRODUCTSBindingNavigatorSaveItem
            // 
            this.pRODUCTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCTSBindingNavigatorSaveItem.Image")));
            this.pRODUCTSBindingNavigatorSaveItem.Name = "pRODUCTSBindingNavigatorSaveItem";
            this.pRODUCTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pRODUCTSBindingNavigatorSaveItem.Text = "Save Data";
            this.pRODUCTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUCTSBindingNavigatorSaveItem_Click);
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(112, 87);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMETextBox.TabIndex = 3;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(112, 113);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(100, 20);
            this.pRICETextBox.TabIndex = 4;
            // 
            // pRODUCT_CATEGORY_IDTextBox
            // 
            this.pRODUCT_CATEGORY_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "PRODUCT_CATEGORY_ID", true));
            this.pRODUCT_CATEGORY_IDTextBox.Location = new System.Drawing.Point(6, 298);
            this.pRODUCT_CATEGORY_IDTextBox.Name = "pRODUCT_CATEGORY_IDTextBox";
            this.pRODUCT_CATEGORY_IDTextBox.Size = new System.Drawing.Size(10, 20);
            this.pRODUCT_CATEGORY_IDTextBox.TabIndex = 6;
            this.pRODUCT_CATEGORY_IDTextBox.TextChanged += new System.EventHandler(this.pRODUCT_CATEGORY_IDTextBox_TextChanged);
            // 
            // productCat_combo
            // 
            this.productCat_combo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUCTSBindingSource, "PRODUCT_CATEGORY_ID", true));
            this.productCat_combo.DataSource = this.pRODUCTCATEGORIESBindingSource1;
            this.productCat_combo.DisplayMember = "NAME";
            this.productCat_combo.FormattingEnabled = true;
            this.productCat_combo.Location = new System.Drawing.Point(231, 145);
            this.productCat_combo.Name = "productCat_combo";
            this.productCat_combo.Size = new System.Drawing.Size(121, 21);
            this.productCat_combo.TabIndex = 7;
            this.productCat_combo.ValueMember = "ID";
            this.productCat_combo.SelectedIndexChanged += new System.EventHandler(this.productCat_combo_SelectedIndexChanged);
            // 
            // pRODUCTCATEGORIESBindingSource1
            // 
            this.pRODUCTCATEGORIESBindingSource1.DataMember = "PRODUCT_CATEGORIES";
            this.pRODUCTCATEGORIESBindingSource1.DataSource = this.db2DataSet;
            // 
            // pRODUCTCATEGORIESBindingSource
            // 
            this.pRODUCTCATEGORIESBindingSource.DataMember = "PRODUCT_CATEGORIES";
            this.pRODUCTCATEGORIESBindingSource.DataSource = this.db2DataSet;
            // 
            // pRODUCT_CATEGORIESTableAdapter
            // 
            this.pRODUCT_CATEGORIESTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // report_btn
            // 
            this.report_btn.Location = new System.Drawing.Point(501, 145);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(75, 23);
            this.report_btn.TabIndex = 9;
            this.report_btn.Text = "report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productCat_combo);
            this.Controls.Add(pRODUCT_CATEGORY_IDLabel);
            this.Controls.Add(this.pRODUCT_CATEGORY_IDTextBox);
            this.Controls.Add(pRICELabel);
            this.Controls.Add(this.pRICETextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(this.pRODUCTSBindingNavigator);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingNavigator)).EndInit();
            this.pRODUCTSBindingNavigator.ResumeLayout(false);
            this.pRODUCTSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCATEGORIESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCATEGORIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Db2DataSet db2DataSet;
        public System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private Db2DataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private Db2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRODUCTSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pRODUCTSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.TextBox pRODUCT_CATEGORY_IDTextBox;
        private System.Windows.Forms.ComboBox productCat_combo;
        private System.Windows.Forms.BindingSource pRODUCTCATEGORIESBindingSource;
        private Db2DataSetTableAdapters.PRODUCT_CATEGORIESTableAdapter pRODUCT_CATEGORIESTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pRODUCTCATEGORIESBindingSource1;
        private System.Windows.Forms.Button report_btn;
    }
}