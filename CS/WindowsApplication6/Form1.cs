using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentsDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.departmentsDataSet.Departments);
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.

        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Column != treeList1.Columns["IMAGEINDEX"])
                return;
            string caption = "Node ID: " + e.Node.Id.ToString();
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo viewInfo = (e.EditViewInfo as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo);
            DevExpress.Utils.Drawing.BaseCheckObjectInfoArgs checkInfo = viewInfo.CheckInfo;
            checkInfo.Caption = caption;
            checkInfo.Graphics = e.Graphics;
            viewInfo.CheckPainter.CalcObjectBounds(checkInfo);
        }

        private void treeList1_ShownEditor(object sender, EventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tl = sender as DevExpress.XtraTreeList.TreeList;
            if (tl.FocusedColumn != tl.Columns["IMAGEINDEX"])
                return;
            (tl.ActiveEditor as DevExpress.XtraEditors.CheckEdit).Properties.Caption = "Node ID: " + tl.FocusedNode.Id.ToString();
        }
    }
}