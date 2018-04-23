Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Text
Imports System.IO

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim names() As String = File.ReadAllLines(Server.MapPath("~/App_Data/customers.txt"), Encoding.Unicode)
		ASPxTitleIndex1.DataSource = names
		ASPxTitleIndex1.DataBind()
	End Sub
End Class
