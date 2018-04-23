Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors
Imports XpoTutorial3.DataModel

Namespace XpoTutorial3
	Partial Public Class XtraForm1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If xpCollection1.Count = 0 Then
				Dim customer1 = New Customer(session1)
				customer1.Name = "John"
				customer1.Age = 21
				customer1.Save()
				xpCollection1.Add(customer1)
				Dim customer2 = New Customer(session1)
				customer2.Name = "Bob"
				customer2.Age = 37
				customer2.Save()
				xpCollection1.Add(customer2)
				Dim customer3 = New Customer(session1)
				customer3.Name = "Sam"
				customer3.Age = 26
				customer3.Save()
				xpCollection1.Add(customer3)
				Dim customer4 = New Customer(session1)
				customer4.Name = "Bill"
				customer4.Age = 30
				customer4.Save()
				xpCollection1.Add(customer4)
			End If
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			xpCollection1.Criteria = New BinaryOperator("Age", spinEdit1.Value, BinaryOperatorType.Greater)
			gridControl1.RefreshDataSource()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			xpCollection1.Filter = New BinaryOperator("Age", spinEdit2.Value, BinaryOperatorType.Greater)
			gridControl1.RefreshDataSource()
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			xpCollection1.Criteria = Nothing
			gridControl1.RefreshDataSource()
		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			xpCollection1.Filter = Nothing
			gridControl1.RefreshDataSource()
		End Sub
	End Class
End Namespace