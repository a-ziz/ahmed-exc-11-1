Public Class Customer

    Private m_FirstName As String
    Private m_LastName As String
    Private m_Email As String

    Public Sub New()

    End Sub

    Public Sub New(firstName As String,
                   lastName As String,
                   email As String)
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Email = email
    End Sub
    Public Property FirstName As String
        Get
            Return m_FirstName
        End Get
        Set(value As String)
            m_FirstName = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return m_LastName
        End Get
        Set(value As String)
            m_LastName = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return m_Email
        End Get
        Set(value As String)
            m_Email = value
        End Set
    End Property

    Public Function GetDisplayText(sep As String) As String
        Dim text As String = FirstName & sep & LastName & sep & ", " & Email
        Return text
    End Function

End Class
