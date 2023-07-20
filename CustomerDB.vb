Imports System.Xml

Public Class CustomerDB
    Private Const Path As String = "../../Customers.xml"

    Public Shared Function GetCustomers() As List(Of Customer)
        Dim customers As New List(Of Customer)

        Dim settings As New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        Dim xmlIn As XmlReader = XmlReader.Create(Path, settings)

        If xmlIn.ReadToDescendant("Customer") Then
            Do While xmlIn.Name = "Customer"
                Dim customer As Customer = New Customer
                xmlIn.ReadStartElement("Customer")
                customer.FirstName = xmlIn.ReadElementString("FirstName")
                customer.LastName = xmlIn.ReadElementString("LastName")
                customer.Email = xmlIn.ReadElementString("Email")
                xmlIn.ReadEndElement()

                customers.Add(customer)
            Loop
        End If

        xmlIn.Close()
        Return customers
    End Function

    Public Shared Sub SaveCustomers(customers As List(Of Customer))

        Dim settings As New XmlWriterSettings
        settings.Indent = True
        settings.IndentChars = ("    ")

        Dim xmlOut As XmlWriter = XmlWriter.Create(Path, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("Customers")

        For Each customer As Customer In customers
            xmlOut.WriteStartElement("Customer")
            xmlOut.WriteElementString("FirstName", customer.FirstName)
            xmlOut.WriteElementString("LastName", customer.LastName)
            xmlOut.WriteElementString("Email", customer.Email)
            xmlOut.WriteEndElement()
        Next

        xmlOut.WriteEndElement()

        xmlOut.Close()
    End Sub

End Class
