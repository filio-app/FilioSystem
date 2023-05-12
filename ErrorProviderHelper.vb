Imports System.IO

Public Module ErrorProviderHelper


    Public Sub SetError(ByVal control As Control, ByVal errorMessage As String)
        'Dim imagePath As String = Path.Combine(Application.StartupPath, "Assets\icons\error-provider-icon.ico")
        'Dim bmp As New Bitmap("Assets\icons\error-provider-icon.ico")
        'Dim icon As Icon = Icon.FromHandle(bmp.GetHicon())
        'errorProvider.Icon = icon

        'errorProvider.Icon = New Bitmap()

        Component.EP.SetIconAlignment(control, ErrorIconAlignment.MiddleRight)
        Component.EP.SetIconPadding(control, 4)
        Component.EP.SetError(control, errorMessage)
    End Sub

    Public Sub clearEP()
        Component.EP.Clear()
    End Sub

    Public Sub ClearError(ByVal control As Control)
        Component.EP.SetError(control, "")
    End Sub


End Module
