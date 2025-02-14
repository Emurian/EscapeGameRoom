Public Class Program
    <STAThread()>
    Public Shared Sub Main()
        ' 
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainMenu())
    End Sub
End Class
