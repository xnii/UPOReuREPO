namespace Система_учета_пожарного_оборудования
{
    partial class SpsOTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpsOTV));
            this.uPOReuV1DataSet = new Система_учета_пожарного_оборудования.UPOReuV1DataSet();
            this.oBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oBETableAdapter = new Система_учета_пожарного_оборудования.UPOReuV1DataSetTableAdapters.OBETableAdapter();
            this.tableAdapterManager = new Система_учета_пожарного_оборудования.UPOReuV1DataSetTableAdapters.TableAdapterManager();
            this.oBEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oBEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oBEDataGridView = new System.Windows.Forms.DataGridView();
            this.iDOBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMOBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aROBRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sROKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTHREGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kVARREGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eARREGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAROBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZNACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOBRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTSBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTYPEOBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSTATUSOBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uPOReuV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBEBindingNavigator)).BeginInit();
            this.oBEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oBEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uPOReuV1DataSet
            // 
            this.uPOReuV1DataSet.DataSetName = "UPOReuV1DataSet";
            this.uPOReuV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oBEBindingSource
            // 
            this.oBEBindingSource.DataMember = "OBE";
            this.oBEBindingSource.DataSource = this.uPOReuV1DataSet;
            // 
            // oBETableAdapter
            // 
            this.oBETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOLJTableAdapter = null;
            this.tableAdapterManager.OBETableAdapter = this.oBETableAdapter;
            this.tableAdapterManager.OBRTableAdapter = null;
            this.tableAdapterManager.OTVTableAdapter = null;
            this.tableAdapterManager.POMTableAdapter = null;
            this.tableAdapterManager.STATUSOBETableAdapter = null;
            this.tableAdapterManager.TEHQTableAdapter = null;
            this.tableAdapterManager.TSBTableAdapter = null;
            this.tableAdapterManager.TYPEOBETableAdapter = null;
            this.tableAdapterManager.TYPEOBRTableAdapter = null;
            this.tableAdapterManager.TYPEPOMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Система_учета_пожарного_оборудования.UPOReuV1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oBEBindingNavigator
            // 
            this.oBEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oBEBindingNavigator.BindingSource = this.oBEBindingSource;
            this.oBEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oBEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oBEBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.oBEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oBEBindingNavigatorSaveItem});
            this.oBEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oBEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oBEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oBEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oBEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oBEBindingNavigator.Name = "oBEBindingNavigator";
            this.oBEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oBEBindingNavigator.Size = new System.Drawing.Size(1652, 31);
            this.oBEBindingNavigator.TabIndex = 0;
            this.oBEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // oBEBindingNavigatorSaveItem
            // 
            this.oBEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oBEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oBEBindingNavigatorSaveItem.Image")));
            this.oBEBindingNavigatorSaveItem.Name = "oBEBindingNavigatorSaveItem";
            this.oBEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.oBEBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.oBEBindingNavigatorSaveItem.Click += new System.EventHandler(this.oBEBindingNavigatorSaveItem_Click);
            // 
            // oBEDataGridView
            // 
            this.oBEDataGridView.AutoGenerateColumns = false;
            this.oBEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oBEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOBEDataGridViewTextBoxColumn,
            this.nAMOBEDataGridViewTextBoxColumn,
            this.aROBRDataGridViewTextBoxColumn,
            this.dATEINDataGridViewTextBoxColumn,
            this.dATEOUTDataGridViewTextBoxColumn,
            this.sROKDataGridViewTextBoxColumn,
            this.mOTHREGDataGridViewTextBoxColumn,
            this.kVARREGDataGridViewTextBoxColumn,
            this.eARREGDataGridViewTextBoxColumn,
            this.xAROBEDataGridViewTextBoxColumn,
            this.nAZNACHDataGridViewTextBoxColumn,
            this.iDOBRDataGridViewTextBoxColumn,
            this.iDPOMDataGridViewTextBoxColumn,
            this.iDTSBDataGridViewTextBoxColumn,
            this.iDTYPEOBEDataGridViewTextBoxColumn,
            this.iDSTATUSOBEDataGridViewTextBoxColumn});
            this.oBEDataGridView.DataSource = this.oBEBindingSource;
            this.oBEDataGridView.Location = new System.Drawing.Point(0, 34);
            this.oBEDataGridView.Name = "oBEDataGridView";
            this.oBEDataGridView.RowTemplate.Height = 28;
            this.oBEDataGridView.Size = new System.Drawing.Size(1652, 403);
            this.oBEDataGridView.TabIndex = 1;
            // 
            // iDOBEDataGridViewTextBoxColumn
            // 
            this.iDOBEDataGridViewTextBoxColumn.DataPropertyName = "ID_OBE";
            this.iDOBEDataGridViewTextBoxColumn.HeaderText = "ID_OBE";
            this.iDOBEDataGridViewTextBoxColumn.Name = "iDOBEDataGridViewTextBoxColumn";
            // 
            // nAMOBEDataGridViewTextBoxColumn
            // 
            this.nAMOBEDataGridViewTextBoxColumn.DataPropertyName = "NAMOBE";
            this.nAMOBEDataGridViewTextBoxColumn.HeaderText = "NAMOBE";
            this.nAMOBEDataGridViewTextBoxColumn.Name = "nAMOBEDataGridViewTextBoxColumn";
            // 
            // aROBRDataGridViewTextBoxColumn
            // 
            this.aROBRDataGridViewTextBoxColumn.DataPropertyName = "AROBR";
            this.aROBRDataGridViewTextBoxColumn.HeaderText = "AROBR";
            this.aROBRDataGridViewTextBoxColumn.Name = "aROBRDataGridViewTextBoxColumn";
            // 
            // dATEINDataGridViewTextBoxColumn
            // 
            this.dATEINDataGridViewTextBoxColumn.DataPropertyName = "DATEIN";
            this.dATEINDataGridViewTextBoxColumn.HeaderText = "DATEIN";
            this.dATEINDataGridViewTextBoxColumn.Name = "dATEINDataGridViewTextBoxColumn";
            // 
            // dATEOUTDataGridViewTextBoxColumn
            // 
            this.dATEOUTDataGridViewTextBoxColumn.DataPropertyName = "DATEOUT";
            this.dATEOUTDataGridViewTextBoxColumn.HeaderText = "DATEOUT";
            this.dATEOUTDataGridViewTextBoxColumn.Name = "dATEOUTDataGridViewTextBoxColumn";
            // 
            // sROKDataGridViewTextBoxColumn
            // 
            this.sROKDataGridViewTextBoxColumn.DataPropertyName = "SROK";
            this.sROKDataGridViewTextBoxColumn.HeaderText = "SROK";
            this.sROKDataGridViewTextBoxColumn.Name = "sROKDataGridViewTextBoxColumn";
            // 
            // mOTHREGDataGridViewTextBoxColumn
            // 
            this.mOTHREGDataGridViewTextBoxColumn.DataPropertyName = "MOTHREG";
            this.mOTHREGDataGridViewTextBoxColumn.HeaderText = "MOTHREG";
            this.mOTHREGDataGridViewTextBoxColumn.Name = "mOTHREGDataGridViewTextBoxColumn";
            // 
            // kVARREGDataGridViewTextBoxColumn
            // 
            this.kVARREGDataGridViewTextBoxColumn.DataPropertyName = "KVARREG";
            this.kVARREGDataGridViewTextBoxColumn.HeaderText = "KVARREG";
            this.kVARREGDataGridViewTextBoxColumn.Name = "kVARREGDataGridViewTextBoxColumn";
            // 
            // eARREGDataGridViewTextBoxColumn
            // 
            this.eARREGDataGridViewTextBoxColumn.DataPropertyName = "EARREG";
            this.eARREGDataGridViewTextBoxColumn.HeaderText = "EARREG";
            this.eARREGDataGridViewTextBoxColumn.Name = "eARREGDataGridViewTextBoxColumn";
            // 
            // xAROBEDataGridViewTextBoxColumn
            // 
            this.xAROBEDataGridViewTextBoxColumn.DataPropertyName = "XAROBE";
            this.xAROBEDataGridViewTextBoxColumn.HeaderText = "XAROBE";
            this.xAROBEDataGridViewTextBoxColumn.Name = "xAROBEDataGridViewTextBoxColumn";
            // 
            // nAZNACHDataGridViewTextBoxColumn
            // 
            this.nAZNACHDataGridViewTextBoxColumn.DataPropertyName = "NAZNACH";
            this.nAZNACHDataGridViewTextBoxColumn.HeaderText = "NAZNACH";
            this.nAZNACHDataGridViewTextBoxColumn.Name = "nAZNACHDataGridViewTextBoxColumn";
            // 
            // iDOBRDataGridViewTextBoxColumn
            // 
            this.iDOBRDataGridViewTextBoxColumn.DataPropertyName = "ID_OBR";
            this.iDOBRDataGridViewTextBoxColumn.HeaderText = "ID_OBR";
            this.iDOBRDataGridViewTextBoxColumn.Name = "iDOBRDataGridViewTextBoxColumn";
            // 
            // iDPOMDataGridViewTextBoxColumn
            // 
            this.iDPOMDataGridViewTextBoxColumn.DataPropertyName = "ID_POM";
            this.iDPOMDataGridViewTextBoxColumn.HeaderText = "ID_POM";
            this.iDPOMDataGridViewTextBoxColumn.Name = "iDPOMDataGridViewTextBoxColumn";
            // 
            // iDTSBDataGridViewTextBoxColumn
            // 
            this.iDTSBDataGridViewTextBoxColumn.DataPropertyName = "ID_TSB";
            this.iDTSBDataGridViewTextBoxColumn.HeaderText = "ID_TSB";
            this.iDTSBDataGridViewTextBoxColumn.Name = "iDTSBDataGridViewTextBoxColumn";
            // 
            // iDTYPEOBEDataGridViewTextBoxColumn
            // 
            this.iDTYPEOBEDataGridViewTextBoxColumn.DataPropertyName = "ID_TYPEOBE";
            this.iDTYPEOBEDataGridViewTextBoxColumn.HeaderText = "ID_TYPEOBE";
            this.iDTYPEOBEDataGridViewTextBoxColumn.Name = "iDTYPEOBEDataGridViewTextBoxColumn";
            // 
            // iDSTATUSOBEDataGridViewTextBoxColumn
            // 
            this.iDSTATUSOBEDataGridViewTextBoxColumn.DataPropertyName = "ID_STATUSOBE";
            this.iDSTATUSOBEDataGridViewTextBoxColumn.HeaderText = "ID_STATUSOBE";
            this.iDSTATUSOBEDataGridViewTextBoxColumn.Name = "iDSTATUSOBEDataGridViewTextBoxColumn";
            // 
            // SpsOTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 566);
            this.Controls.Add(this.oBEDataGridView);
            this.Controls.Add(this.oBEBindingNavigator);
            this.Name = "SpsOTV";
            this.Text = "SpsOTV";
            this.Load += new System.EventHandler(this.SpsOTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uPOReuV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oBEBindingNavigator)).EndInit();
            this.oBEBindingNavigator.ResumeLayout(false);
            this.oBEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oBEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UPOReuV1DataSet uPOReuV1DataSet;
        private System.Windows.Forms.BindingSource oBEBindingSource;
        private UPOReuV1DataSetTableAdapters.OBETableAdapter oBETableAdapter;
        private UPOReuV1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oBEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oBEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView oBEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOBEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMOBEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aROBRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sROKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTHREGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kVARREGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eARREGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAROBEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZNACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOBRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTSBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTYPEOBEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSTATUSOBEDataGridViewTextBoxColumn;
    }
}