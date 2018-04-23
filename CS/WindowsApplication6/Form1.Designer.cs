namespace WindowsApplication6
{
    partial class Form1
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colPARENTID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIMAGEINDEX = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDEPARTMENT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBUDGET = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsDataSet = new WindowsApplication6.DepartmentsDataSet();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.departmentsTableAdapter = new WindowsApplication6.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colPARENTID,
            this.colIMAGEINDEX,
            this.colDEPARTMENT,
            this.colBUDGET});
            this.treeList1.DataSource = this.departmentsBindingSource;
            this.treeList1.Location = new System.Drawing.Point(24, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemCheckEdit1});
            this.treeList1.Size = new System.Drawing.Size(761, 200);
            this.treeList1.TabIndex = 0;
            this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.ShownEditor += new System.EventHandler(this.treeList1_ShownEditor);
            // 
            // colPARENTID
            // 
            this.colPARENTID.Caption = "PARENTID";
            this.colPARENTID.FieldName = "PARENTID";
            this.colPARENTID.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPARENTID.Name = "colPARENTID";
            this.colPARENTID.VisibleIndex = 0;
            this.colPARENTID.Width = 54;
            // 
            // colIMAGEINDEX
            // 
            this.colIMAGEINDEX.AppearanceCell.Options.UseTextOptions = true;
            this.colIMAGEINDEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIMAGEINDEX.Caption = "Test Check";
            this.colIMAGEINDEX.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIMAGEINDEX.FieldName = "IMAGEINDEX";
            this.colIMAGEINDEX.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIMAGEINDEX.Name = "colIMAGEINDEX";
            this.colIMAGEINDEX.VisibleIndex = 1;
            this.colIMAGEINDEX.Width = 54;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // colDEPARTMENT
            // 
            this.colDEPARTMENT.Caption = "DEPARTMENT";
            this.colDEPARTMENT.FieldName = "DEPARTMENT";
            this.colDEPARTMENT.Name = "colDEPARTMENT";
            this.colDEPARTMENT.VisibleIndex = 2;
            this.colDEPARTMENT.Width = 54;
            // 
            // colBUDGET
            // 
            this.colBUDGET.Caption = "BUDGET";
            this.colBUDGET.FieldName = "BUDGET";
            this.colBUDGET.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBUDGET.Name = "colBUDGET";
            this.colBUDGET.VisibleIndex = 3;
            this.colBUDGET.Width = 54;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.departmentsDataSet;
            // 
            // departmentsDataSet
            // 
            this.departmentsDataSet.DataSetName = "DepartmentsDataSet";
            this.departmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 515);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DepartmentsDataSet departmentsDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private WindowsApplication6.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPARENTID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIMAGEINDEX;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDEPARTMENT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBUDGET;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}

