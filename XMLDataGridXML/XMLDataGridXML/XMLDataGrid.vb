Imports DevExpress.XtraEditors
Imports XMLDataGridXML.XMLDataGridXML
Public Class XMLDataGrid
    Private ReadOnly jobconfigFileIn As String = "..\..\JobConfig.xml"
    Private ReadOnly jobconfigFileOut As String = "..\..\JobConfigSaved.xml"
    Public JobConfigXML As JobConfig
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JobConfigXML = JobConfig.LoadFromFile(jobconfigFileIn)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BbiLoadXML.ItemClick
        JobConfigXML = JobConfig.LoadFromFile(jobconfigFileIn)
        SetGridDataSources()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSaveGridToXML.ItemClick
        JobConfigXML.SaveToFile(jobconfigFileOut)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLoadSavedXML.ItemClick
        If IO.File.Exists(jobconfigFileOut) Then
            JobConfigXML = JobConfig.LoadFromFile(jobconfigFileOut)
            SetGridDataSources()
        Else
            MessageBox.Show("Aborting Load: Saved XML file does not exist.")
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRevert.ItemClick
        JobConfigXML = JobConfig.LoadFromFile(jobconfigFileIn)
        SetGridDataSources()
        IO.File.Delete(jobconfigFileOut)
    End Sub

    Private Sub SetGridDataSources()
        GridControl.DataSource = JobConfigXML.JobInfo.JobProperties.JobProperty
        GridControl1.DataSource = JobConfigXML.JobInfo.JobProperties.CustomJobProperty
    End Sub
End Class