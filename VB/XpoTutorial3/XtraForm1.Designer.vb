Imports Microsoft.VisualBasic
Imports System
Namespace XpoTutorial3
	Partial Public Class XtraForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
			Me.session1 = New DevExpress.Xpo.Session(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpCollection1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(451, 335)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' xpCollection1
			' 
			Me.xpCollection1.ObjectType = GetType(XpoTutorial3.DataModel.Customer)
			Me.xpCollection1.Session = Me.session1
			' 
			' session1
			' 
			Me.session1.TrackPropertiesModifications = False
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colAge})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' colName
			' 
			Me.colName.ColumnEdit = Me.repositoryItemTextEdit1
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' colAge
			' 
			Me.colAge.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colAge.FieldName = "Age"
			Me.colAge.Name = "colAge"
			Me.colAge.Visible = True
			Me.colAge.VisibleIndex = 1
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(63, 351)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(135, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Criteria: Age is greater than"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(74, 379)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(124, 13)
			Me.labelControl2.TabIndex = 2
			Me.labelControl2.Text = "Filter: Age is greater than"
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(205, 348)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Size = New System.Drawing.Size(56, 20)
			Me.spinEdit1.TabIndex = 3
			' 
			' spinEdit2
			' 
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(205, 379)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Size = New System.Drawing.Size(56, 20)
			Me.spinEdit2.TabIndex = 4
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(267, 345)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 5
			Me.simpleButton1.Text = "Apply Criteria"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(267, 376)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 6
			Me.simpleButton2.Text = "Apply Filter"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(348, 345)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton3.TabIndex = 7
			Me.simpleButton3.Text = "Clear Criteria"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(348, 376)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton4.TabIndex = 8
			Me.simpleButton4.Text = "Clear Filter"
'			Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
			' 
			' XtraForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(451, 411)
			Me.Controls.Add(Me.simpleButton4)
			Me.Controls.Add(Me.simpleButton3)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.spinEdit2)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.gridControl1)
			Me.MaximizeBox = False
			Me.Name = "XtraForm1"
			Me.Text = "XtraForm1"
'			Me.Load += New System.EventHandler(Me.XtraForm1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private session1 As DevExpress.Xpo.Session
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colAge As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace