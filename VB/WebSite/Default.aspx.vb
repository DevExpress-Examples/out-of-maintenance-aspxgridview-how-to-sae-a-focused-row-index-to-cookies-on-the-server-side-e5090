Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		Response.Cookies(grid.ID)("FocudedIndex") = grid.FocusedRowIndex.ToString()
		Response.Cookies(grid.ID).Expires = DateTime.Now.AddDays(1R)
	End Sub
	Protected Sub gridView_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
		If (Not IsPostBack) Then
		If Request.Cookies(grid.ID) IsNot Nothing Then
			grid.FocusedRowIndex =Convert.ToInt32(Request.Cookies(grid.ID)("FocudedIndex"))
		End If
		End If
	End Sub
End Class