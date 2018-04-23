using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication218
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");
            gridControl1.DataSource = dt;
        }

        private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column && e.HitInfo.InGroupColumn && e.HitInfo.Column.FieldName == "A")
            {
                foreach (DevExpress.Utils.Menu.DXMenuItem item in e.Menu.Items)
                {
                    if (item.Caption == DevExpress.XtraGrid.Localization.GridLocalizer.Active.GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId.MenuColumnUnGroup))
                    {
                        item.Enabled = false;
                    }
                }
            }
        }
    }
}