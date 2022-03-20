
namespace Lab7
{
    partial class RelationsForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hISTORYTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db2DataSet = new Lab7.Db2DataSet();
            this.hISTORY_TYPESTableAdapter = new Lab7.Db2DataSetTableAdapters.HISTORY_TYPESTableAdapter();
            this.hISTORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORIESTableAdapter = new Lab7.Db2DataSetTableAdapters.HISTORIESTableAdapter();
            this.tableAdapterManager = new Lab7.Db2DataSetTableAdapters.TableAdapterManager();
            this.hISTORIESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pRODUCTCATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCT_CATEGORIESTableAdapter = new Lab7.Db2DataSetTableAdapters.PRODUCT_CATEGORIESTableAdapter();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new Lab7.Db2DataSetTableAdapters.PRODUCTSTableAdapter();
            this.pRODUCTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCATEGORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hISTORYTYPESBindingSource;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // hISTORYTYPESBindingSource
            // 
            this.hISTORYTYPESBindingSource.DataMember = "HISTORY_TYPES";
            this.hISTORYTYPESBindingSource.DataSource = this.db2DataSet;
            // 
            // db2DataSet
            // 
            this.db2DataSet.DataSetName = "Db2DataSet";
            this.db2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISTORY_TYPESTableAdapter
            // 
            this.hISTORY_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // hISTORIESBindingSource
            // 
            this.hISTORIESBindingSource.DataMember = "FK_HISTORY_HISTORY_TYPE_ID";
            this.hISTORIESBindingSource.DataSource = this.hISTORYTYPESBindingSource;
            // 
            // hISTORIESTableAdapter
            // 
            this.hISTORIESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HISTORIESTableAdapter = this.hISTORIESTableAdapter;
            this.tableAdapterManager.HISTORY_PRODUCTTableAdapter = null;
            this.tableAdapterManager.HISTORY_TYPESTableAdapter = this.hISTORY_TYPESTableAdapter;
            this.tableAdapterManager.LOCATIONSTableAdapter = null;
            this.tableAdapterManager.PRODUCT_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.PRODUCTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab7.Db2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WAREHOUSE_PRODUCTTableAdapter = null;
            this.tableAdapterManager.WAREHOUSESTableAdapter = null;
            // 
            // hISTORIESDataGridView
            // 
            this.hISTORIESDataGridView.AutoGenerateColumns = false;
            this.hISTORIESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hISTORIESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.hISTORIESDataGridView.DataSource = this.hISTORIESBindingSource;
            this.hISTORIESDataGridView.Location = new System.Drawing.Point(28, 73);
            this.hISTORIESDataGridView.Name = "hISTORIESDataGridView";
            this.hISTORIESDataGridView.Size = new System.Drawing.Size(294, 349);
            this.hISTORIESDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HISTORY_TYPE_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "HISTORY_TYPE_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IS_DELETED";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IS_DELETED";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.pRODUCTCATEGORIESBindingSource;
            this.comboBox2.DisplayMember = "NAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(443, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "ID";
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
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "FK_PRODUCT_PRODUCT_CATEGORY";
            this.pRODUCTSBindingSource.DataSource = this.pRODUCTCATEGORIESBindingSource;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTSDataGridView
            // 
            this.pRODUCTSDataGridView.AutoGenerateColumns = false;
            this.pRODUCTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn2});
            this.pRODUCTSDataGridView.DataSource = this.pRODUCTSBindingSource;
            this.pRODUCTSDataGridView.Location = new System.Drawing.Point(443, 69);
            this.pRODUCTSDataGridView.Name = "pRODUCTSDataGridView";
            this.pRODUCTSDataGridView.Size = new System.Drawing.Size(300, 353);
            this.pRODUCTSDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PRICE";
            this.dataGridViewTextBoxColumn6.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRODUCT_CATEGORY_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "PRODUCT_CATEGORY_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IS_DELETED";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IS_DELETED";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // RelationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pRODUCTSDataGridView);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.hISTORIESDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Name = "RelationsForm";
            this.Text = "RelationsForm";
            this.Load += new System.EventHandler(this.RelationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCATEGORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Db2DataSet db2DataSet;
        private System.Windows.Forms.BindingSource hISTORYTYPESBindingSource;
        private Db2DataSetTableAdapters.HISTORY_TYPESTableAdapter hISTORY_TYPESTableAdapter;
        private System.Windows.Forms.BindingSource hISTORIESBindingSource;
        private Db2DataSetTableAdapters.HISTORIESTableAdapter hISTORIESTableAdapter;
        private Db2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hISTORIESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource pRODUCTCATEGORIESBindingSource;
        private Db2DataSetTableAdapters.PRODUCT_CATEGORIESTableAdapter pRODUCT_CATEGORIESTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private Db2DataSetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridView pRODUCTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}