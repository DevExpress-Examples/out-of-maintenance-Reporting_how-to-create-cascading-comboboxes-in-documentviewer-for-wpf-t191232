Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Editors

Namespace WpfApplication1
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private report As XtraReport1

        Private Sub documentPreview1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            report = New XtraReport1() With {.RequestParameters = True}
            Dim model As New XtraReportPreviewModel()
            model.Report = report
            report.CreateDocument()
            documentPreview1.Model = model
        End Sub
    End Class
End Namespace
