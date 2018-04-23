Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports XpoTutorial3.DataModel

Namespace XpoTutorial3
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			ConnectionHelper.Connect(AutoCreateOption.DatabaseAndSchema)
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.Run(New XtraForm1())
		End Sub
	End Class
End Namespace
