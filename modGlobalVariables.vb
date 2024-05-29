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

    ' For Data Grid View
    Public colName As String
    Public fileId As Integer
    Public locationID As Integer 'For updating location

    Public isLoggedIn As String = False
    Public currUsername As String
    Public currUserID As Integer = 1 'TODO: get user ID 
    Public currRole As String

    'Public action As String

    ' For selecting files in add transaction
    Public tempFileID As String
    Public tempFileName As String

    ' For showing specific files
    Public transactionType As String

    ' For updating user information
    Public tempRole As String

    'For Selecting purok name in view and update
    Public locationName As String

    'For adding and editing a location we use hashtable to get the id
    Public locationTable As New Hashtable()


    '=================================================='



End Module
