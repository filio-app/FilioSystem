Imports MySql.Data.MySqlClient
Module ModGlobalVariable
    'global variable

    Public serverName As String     'localhost
    Public dbUserName As String     'username
    Public dbPassword As String     'password
    Public dbName As String         'schema
    Public port As String           'port
    Public conFilioSys As New MySqlConnection 'Variable that hold for the connection string
    Public command As New MySqlCommand           'instance of mysqlCommand to execute sql commands
    Public strConnectionString As String


    Public datFilio As New DataTable
    Public sqlAdapterFilio As New MySqlDataAdapter

    Public row As Integer

    Public colName As String
    Public userID As Integer

    Public currUsername As String
    Public currUserID As Integer = 1 'TODO: get user ID 

    'Public action As String

    ' For selecting files in add transaction
    Public tempFileID As String
    Public tempFileName As String




    '=================================================='

    'TODO: DONE -- Should reload the history page if there are events

End Module
