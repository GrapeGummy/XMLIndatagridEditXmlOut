<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class XMLDataGrid
    Inherits DevExpress.XtraBars.ToolbarForm.ToolbarForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TablePanel1 = New DevExpress.Utils.Layout.TablePanel()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolbarFormControl1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
        Me.ToolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BbiLoadXML = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveGridToXML = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLoadSavedXML = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRevert = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablePanel1.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolbarFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridControl1
        '
        Me.TablePanel1.SetColumn(Me.GridControl1, 1)
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(483, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.TablePanel1.SetRow(Me.GridControl1, 0)
        Me.GridControl1.Size = New System.Drawing.Size(430, 365)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'TablePanel1
        '
        Me.TablePanel1.AutoSize = True
        Me.TablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55.0!), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.0!)})
        Me.TablePanel1.Controls.Add(Me.GridControl)
        Me.TablePanel1.Controls.Add(Me.GridControl1)
        Me.TablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablePanel1.Location = New System.Drawing.Point(0, 31)
        Me.TablePanel1.Name = "TablePanel1"
        Me.TablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!)})
        Me.TablePanel1.Size = New System.Drawing.Size(916, 371)
        Me.TablePanel1.TabIndex = 7
        '
        'GridControl
        '
        Me.TablePanel1.SetColumn(Me.GridControl, 0)
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(3, 3)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.TablePanel1.SetRow(Me.GridControl, 0)
        Me.GridControl.Size = New System.Drawing.Size(474, 365)
        Me.GridControl.TabIndex = 5
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        '
        'ToolbarFormControl1
        '
        Me.ToolbarFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarFormControl1.Manager = Me.ToolbarFormManager1
        Me.ToolbarFormControl1.Name = "ToolbarFormControl1"
        Me.ToolbarFormControl1.Size = New System.Drawing.Size(916, 31)
        Me.ToolbarFormControl1.TabIndex = 8
        Me.ToolbarFormControl1.TabStop = False
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.BbiLoadXML)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.bbiSaveGridToXML)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.bbiLoadSavedXML)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.bbiRevert)
        Me.ToolbarFormControl1.ToolbarForm = Me
        '
        'ToolbarFormManager1
        '
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlTop)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlRight)
        Me.ToolbarFormManager1.Form = Me
        Me.ToolbarFormManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BbiLoadXML, Me.bbiSaveGridToXML, Me.bbiLoadSavedXML, Me.bbiRevert})
        Me.ToolbarFormManager1.MaxItemId = 4
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.ToolbarFormManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlBottom.Manager = Me.ToolbarFormManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.ToolbarFormManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlRight.Manager = Me.ToolbarFormManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
        '
        'BbiLoadXML
        '
        Me.BbiLoadXML.Caption = "LoadXML"
        Me.BbiLoadXML.Id = 0
        Me.BbiLoadXML.Name = "BbiLoadXML"
        '
        'bbiSaveGridToXML
        '
        Me.bbiSaveGridToXML.Caption = "SaveGridToXML"
        Me.bbiSaveGridToXML.Id = 1
        Me.bbiSaveGridToXML.Name = "bbiSaveGridToXML"
        '
        'bbiLoadSavedXML
        '
        Me.bbiLoadSavedXML.Caption = "LoadSavedXML"
        Me.bbiLoadSavedXML.Id = 2
        Me.bbiLoadSavedXML.Name = "bbiLoadSavedXML"
        '
        'bbiRevert
        '
        Me.bbiRevert.Caption = "Revert"
        Me.bbiRevert.Id = 3
        Me.bbiRevert.Name = "bbiRevert"
        '
        'XMLDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 402)
        Me.Controls.Add(Me.TablePanel1)
        Me.Controls.Add(Me.ToolbarFormControl1)
        Me.Name = "XMLDataGrid"
        Me.Text = "XMLDataGrid"
        Me.ToolbarFormControl = Me.ToolbarFormControl1
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablePanel1.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolbarFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TablePanel1 As DevExpress.Utils.Layout.TablePanel
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolbarFormControl1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl
    Friend WithEvents ToolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BbiLoadXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSaveGridToXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLoadSavedXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiRevert As DevExpress.XtraBars.BarButtonItem
End Class
