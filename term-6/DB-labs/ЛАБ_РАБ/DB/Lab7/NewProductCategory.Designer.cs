
namespace Lab7
{
    partial class NewProductCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductCategory));
            this.db2DataSet = new Lab7.Db2DataSet();
            this.pRODUCT_CATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCT_CATEGORIESTableAdapter = new Lab7.Db2DataSetTableAdapters.PRODUCT_CATEGORIESTableAdapter();
            this.tableAdapterManager = new Lab7.Db2DataSetTableAdapters.TableAdapterManager();
            this.pRODUCT_CATEGORIESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUCT_CATEGORIESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_CATEGORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_CATEGORIESBindingNavigator)).BeginInit();
            this.pRODUCT_CATEGORIESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_CATEGORIESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // db2DataSet
            // 
            this.db2DataSet.DataSetName = "Db2DataSet";
            this.db2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCT_CATEGORIESBindingSource
            // 
            this.pRODUCT_CATEGORIESBindingSource.DataMember = "PRODUCT_CATEGORIES";
            this.pRODUCT_CATEGORIESBindingSource.DataSource = this.db2DataSet;
            // 
            // pRODUCT_CATEGORIESTableAdapter
            // 
            this.pRODUCT_CATEGORIESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HISTORIESTableAdapter = null;
            this.tableAdapterManager.HISTORY_PRODUCTTableAdapter = null;
            this.tableAdapterManager.HISTORY_TYPESTableAdapter = null;
            this.tableAdapterManager.LOCATIONSTableAdapter = null;
            this.tableAdapterManager.PRODUCT_CATEGORIESTableAdapter = this.pRODUCT_CATEGORIESTableAdapter;
            this.tableAdapterManager.PRODUCTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab7.Db2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WAREHOUSE_PRODUCTTableAdapter = null;
            this.tableAdapterManager.WAREHOUSESTableAdapter = null;
            // 
            // pRODUCT_CATEGORIESBindingNavigator
            // 
            this.pRODUCT_CATEGORIESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUCT_CATEGORIESBindingNavigator.BindingSource = this.pRODUCT_CATEGORIESBindingSource;
            this.pRODUCT_CATEGORIESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUCT_CATEGORIESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUCT_CATEGORIESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem});
            this.pRODUCT_CATEGORIESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRODUCT_CATEGORIESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUCT_CATEGORIESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUCT_CATEGORIESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUCT_CATEGORIESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUCT_CATEGORIESBindingNavigator.Name = "pRODUCT_CATEGORIESBindingNavigator";
            this.pRODUCT_CATEGORIESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUCT_CATEGORIESBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pRODUCT_CATEGORIESBindingNavigator.TabIndex = 0;
            this.pRODUCT_CATEGORIESBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pRODUCT_CATEGORIESBindingNavigatorSaveItem
            // 
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCT_CATEGORIESBindingNavigatorSaveItem.Image")));
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem.Name = "pRODUCT_CATEGORIESBindingNavigatorSaveItem";
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem.Text = "Save Data";
            this.pRODUCT_CATEGORIESBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUCT_CATEGORIESBindingNavigatorSaveItem_Click);
            // 
            // pRODUCT_CATEGORIESDataGridView
            // 
            this.pRODUCT_CATEGORIESDataGridView.AutoGenerateColumns = false;
            this.pRODUCT_CATEGORIESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCT_CATEGORIESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pRODUCT_CATEGORIESDataGridView.DataSource = this.pRODUCT_CATEGORIESBindingSource;
            this.pRODUCT_CATEGORIESDataGridView.Location = new System.Drawing.Point(283, 132);
            this.pRODUCT_CATEGORIESDataGridView.Name = "pRODUCT_CATEGORIESDataGridView";
            this.pRODUCT_CATEGORIESDataGridView.Size = new System.Drawing.Size(300, 220);
            this.pRODUCT_CATEGORIESDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NewProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pRODUCT_CATEGORIESDataGridView);
            this.Controls.Add(this.pRODUCT_CATEGORIESBindingNavigator);
            this.Name = "NewProductCategory";
            this.Text = "NewProducts";
            this.Load += new System.EventHandler(this.NewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_CATEGORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_CATEGORIESBindingNavigator)).EndInit();
            this.pRODUCT_CATEGORIESBindingNavigator.ResumeLayout(false);
            this.pRODUCT_CATEGORIESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_CATEGORIESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Db2DataSet db2DataSet;
        private System.Windows.Forms.BindingSource pRODUCT_CATEGORIESBindingSource;
        private Db2DataSetTableAdapters.PRODUCT_CATEGORIESTableAdapter pRODUCT_CATEGORIESTableAdapter;
        private Db2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRODUCT_CATEGORIESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRODUCT_CATEGORIESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pRODUCT_CATEGORIESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}