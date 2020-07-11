Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.RibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgSkins = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SkinDropDownButtonItem = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.SkinPaletteRibbonGalleryBarItem = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem, Me.RibbonControl.SearchEditItem, Me.SkinDropDownButtonItem, Me.SkinPaletteRibbonGalleryBarItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage})
        Me.RibbonControl.Size = New System.Drawing.Size(905, 158)
        '
        'SkinRibbonGalleryBarItem
        '
        Me.SkinRibbonGalleryBarItem.Caption = "SkinRibbonGalleryBarItem"
        Me.SkinRibbonGalleryBarItem.Id = 1
        Me.SkinRibbonGalleryBarItem.Name = "SkinRibbonGalleryBarItem"
        '
        'RibbonPage
        '
        Me.RibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgSkins})
        Me.RibbonPage.Name = "RibbonPage"
        Me.RibbonPage.Text = "RibbonPage"
        '
        'rpgSkins
        '
        Me.rpgSkins.ItemLinks.Add(Me.SkinDropDownButtonItem)
        Me.rpgSkins.ItemLinks.Add(Me.SkinPaletteRibbonGalleryBarItem)
        Me.rpgSkins.Name = "rpgSkins"
        Me.rpgSkins.Text = "Skins"
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 143)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.MenuManager = Me.RibbonControl
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(905, 348)
        Me.GridControl.TabIndex = 1
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        '
        'SkinDropDownButtonItem
        '
        Me.SkinDropDownButtonItem.Id = 2
        Me.SkinDropDownButtonItem.Name = "SkinDropDownButtonItem"
        '
        'SkinPaletteRibbonGalleryBarItem
        '
        Me.SkinPaletteRibbonGalleryBarItem.Caption = "SkinPaletteRibbonGalleryBarItem"
        Me.SkinPaletteRibbonGalleryBarItem.Id = 3
        Me.SkinPaletteRibbonGalleryBarItem.Name = "SkinPaletteRibbonGalleryBarItem"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 491)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Form"
        Me.Ribbon = Me.RibbonControl
        Me.Text = "Form"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgSkins As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SkinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents SkinDropDownButtonItem As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents SkinPaletteRibbonGalleryBarItem As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
End Class
