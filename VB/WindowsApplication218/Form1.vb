Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication218
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim dt As New DataTable()
			dt.Columns.Add("A")
			dt.Columns.Add("B")
			dt.Columns.Add("C")
			dt.Columns.Add("D")
			gridControl1.DataSource = dt
		End Sub

		Private Sub gridView1_ShowGridMenu(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs) Handles gridView1.ShowGridMenu
			If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column AndAlso e.HitInfo.InGroupColumn AndAlso e.HitInfo.Column.FieldName = "A" Then
				For Each item As DevExpress.Utils.Menu.DXMenuItem In e.Menu.Items
					If item.Caption = DevExpress.XtraGrid.Localization.GridLocalizer.Active.GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId.MenuColumnUnGroup) Then
						item.Enabled = False
					End If
				Next item
			End If
		End Sub
	End Class
End Namespace