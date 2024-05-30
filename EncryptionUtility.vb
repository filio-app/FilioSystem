Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class EncryptionUtility
    Private Shared ReadOnly Key As Byte()
    Private Shared ReadOnly IV As Byte()


    Shared Sub New()
        ' Load environment variables from .env file
        DotNetEnv.Env.TraversePath().Load()

        ' Get encryption key and IV from environment variables
        Dim encryptionKey As String = Environment.GetEnvironmentVariable("ENCRYPTION_KEY")
        Dim encryptionIV As String = Environment.GetEnvironmentVariable("ENCRYPTION_IV")

        ' Convert encryption key and IV to byte arrays
        Key = Encoding.UTF8.GetBytes(encryptionKey)
        IV = Encoding.UTF8.GetBytes(encryptionIV)

        ' Ensure the encryption key is 16, 24, or 32 bytes long
        If Key.Length <> 16 AndAlso Key.Length <> 24 AndAlso Key.Length <> 32 Then
            Throw New Exception("Encryption key must be 16, 24, or 32 bytes long.")
        End If

        ' Ensure the IV is exactly 16 bytes long
        If IV.Length <> 16 Then
            Throw New Exception("Encryption IV must be exactly 16 bytes long.")
        End If
    End Sub

    Public Shared Sub EncryptFile(inputFile As String, outputFile As String)
        Using aes As Aes = aes.Create()
            aes.Key = Key
            aes.IV = IV
            aes.Padding = PaddingMode.PKCS7

            Using fsInput As New FileStream(inputFile, FileMode.Open, FileAccess.Read)
                Using fsOutput As New FileStream(outputFile, FileMode.Create, FileAccess.Write)
                    Using cs As New CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write)
                        fsInput.CopyTo(cs)
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Shared Sub DecryptFile(inputFile As String, outputFile As String)
        Using aes As Aes = aes.Create()
            aes.Key = Key
            aes.IV = IV
            aes.Padding = PaddingMode.PKCS7

            Using fsInput As New FileStream(inputFile, FileMode.Open, FileAccess.Read)
                Using fsOutput As New FileStream(outputFile, FileMode.Create, FileAccess.Write)
                    Using cs As New CryptoStream(fsInput, aes.CreateDecryptor(), CryptoStreamMode.Read)
                        cs.CopyTo(fsOutput)
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
