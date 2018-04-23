Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication6
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colPARENTID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colIMAGEINDEX = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.colDEPARTMENT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colBUDGET = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.departmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.departmentsDataSet = New WindowsApplication6.DepartmentsDataSet()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.departmentsTableAdapter = New WindowsApplication6.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.departmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colPARENTID, Me.colIMAGEINDEX, Me.colDEPARTMENT, Me.colBUDGET})
			Me.treeList1.DataSource = Me.departmentsBindingSource
			Me.treeList1.Location = New System.Drawing.Point(24, 12)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemCheckEdit1})
			Me.treeList1.Size = New System.Drawing.Size(761, 200)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.CustomDrawNodeCell += New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(Me.treeList1_CustomDrawNodeCell);
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged);
'			Me.treeList1.ShownEditor += New System.EventHandler(Me.treeList1_ShownEditor);
			' 
			' colPARENTID
			' 
			Me.colPARENTID.Caption = "PARENTID"
			Me.colPARENTID.FieldName = "PARENTID"
			Me.colPARENTID.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPARENTID.Name = "colPARENTID"
			Me.colPARENTID.VisibleIndex = 0
			Me.colPARENTID.Width = 54
			' 
			' colIMAGEINDEX
			' 
			Me.colIMAGEINDEX.AppearanceCell.Options.UseTextOptions = True
			Me.colIMAGEINDEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.colIMAGEINDEX.Caption = "Test Check"
			Me.colIMAGEINDEX.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.colIMAGEINDEX.FieldName = "IMAGEINDEX"
			Me.colIMAGEINDEX.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colIMAGEINDEX.Name = "colIMAGEINDEX"
			Me.colIMAGEINDEX.VisibleIndex = 1
			Me.colIMAGEINDEX.Width = 54
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			Me.repositoryItemCheckEdit1.ValueChecked = 1
			Me.repositoryItemCheckEdit1.ValueUnchecked = 0
			' 
			' colDEPARTMENT
			' 
			Me.colDEPARTMENT.Caption = "DEPARTMENT"
			Me.colDEPARTMENT.FieldName = "DEPARTMENT"
			Me.colDEPARTMENT.Name = "colDEPARTMENT"
			Me.colDEPARTMENT.VisibleIndex = 2
			Me.colDEPARTMENT.Width = 54
			' 
			' colBUDGET
			' 
			Me.colBUDGET.Caption = "BUDGET"
			Me.colBUDGET.FieldName = "BUDGET"
			Me.colBUDGET.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colBUDGET.Name = "colBUDGET"
			Me.colBUDGET.VisibleIndex = 3
			Me.colBUDGET.Width = 54
			' 
			' departmentsBindingSource
			' 
			Me.departmentsBindingSource.DataMember = "Departments"
			Me.departmentsBindingSource.DataSource = Me.departmentsDataSet
			' 
			' departmentsDataSet
			' 
			Me.departmentsDataSet.DataSetName = "DepartmentsDataSet"
			Me.departmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' departmentsTableAdapter
			' 
			Me.departmentsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(797, 515)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.departmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.departmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private departmentsDataSet As DepartmentsDataSet
		Private departmentsBindingSource As System.Windows.Forms.BindingSource
		Private departmentsTableAdapter As WindowsApplication6.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter
		Private colPARENTID As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colIMAGEINDEX As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colDEPARTMENT As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colBUDGET As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
	End Class
End Namespace

