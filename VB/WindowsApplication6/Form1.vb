Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication6
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'departmentsDataSet.Departments' table. You can move, or remove it, as needed.
			Me.departmentsTableAdapter.Fill(Me.departmentsDataSet.Departments)
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.

		End Sub

		Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged

		End Sub

		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
            If Not e.Column Is treeList1.Columns("IMAGEINDEX") Then
                Return
            End If
			Dim caption As String = "Node ID: " & e.Node.Id.ToString()
			Dim viewInfo As DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo = (TryCast(e.EditViewInfo, DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo))
            Dim checkInfo As DevExpress.Utils.Drawing.BaseCheckObjectInfoArgs = viewInfo.CheckInfo
			checkInfo.Caption = caption
			checkInfo.Graphics = e.Graphics
			viewInfo.CheckPainter.CalcObjectBounds(checkInfo)
		End Sub

		Private Sub treeList1_ShownEditor(ByVal sender As Object, ByVal e As EventArgs) Handles treeList1.ShownEditor
			Dim tl As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
			If tl.FocusedColumn IsNot tl.Columns("IMAGEINDEX") Then
				Return
			End If
			TryCast(tl.ActiveEditor, DevExpress.XtraEditors.CheckEdit).Properties.Caption = "Node ID: " & tl.FocusedNode.Id.ToString()
		End Sub
	End Class
End Namespace