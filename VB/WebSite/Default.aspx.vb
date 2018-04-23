Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports DevExpress.Web.ASPxDataView
Imports System.Text
Imports DevExpress.Web.ASPxCallback
Imports System.Xml
Imports DevExpress.Web.ASPxTabControl


Partial Public Class ASPxperience_LoadOnCallback
	Inherits System.Web.UI.Page
	Protected Sub LoadActiveTabPageContent()
		Dim activePage As TabPage = ASPxPageControl1.ActiveTabPage
		If activePage.Controls.Count = 0 Then
			Dim contentControl As Control = CreateTabPageContentControl(activePage.Name)
			If Not contentControl Is Nothing Then
				activePage.Controls.Add(contentControl)
			End If
		End If
	End Sub
	Protected Function CreateTabPageContentControl(ByVal name As String) As Control
		Select Case name
			Case "UserControl"
				Return LoadControl("UserControl.ascx")
			Case "ExternalPage"
				Return LoadControl("ExternalPageUserControl.ascx")
			Case Else
				Return Nothing
		End Select
	End Function

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		LoadActiveTabPageContent()
	End Sub
	Protected Sub ASPxPageControl1_ActiveTabChanged(ByVal source As Object, ByVal e As DevExpress.Web.ASPxTabControl.TabControlEventArgs)
		LoadActiveTabPageContent()
	End Sub
End Class