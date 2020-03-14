Imports CommonSnappableTypes

<CompanyInfo(CompanyName:="Chucky's Software", CompanyUrl:="www.ChuckySoft.com")>
Public Class VbSnapIn
    Implements IAppFunctionality

    Public Sub Doit() Implements IAppFunctionality.Doit
        Console.WriteLine("\nYou have just used VB snap-in!")
    End Sub
End Class
