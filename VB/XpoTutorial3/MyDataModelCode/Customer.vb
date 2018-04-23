Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Namespace XpoTutorial3.DataModel

	Partial Public Class Customer
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

End Namespace
