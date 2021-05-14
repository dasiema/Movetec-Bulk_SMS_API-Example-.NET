Public Class API_Parameters_Model
    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(value As Integer)
            m_id = value
        End Set
    End Property
    Public Property base_url() As String
        Get
            Return m_base_url
        End Get
        Set(value As String)
            m_base_url = value
        End Set
    End Property
    Public Property username() As String
        Get
            Return m_username
        End Get
        Set(value As String)
            m_username = value
        End Set
    End Property
    Public Property key() As String
        Get
            Return m_key
        End Get
        Set(value As String)
            m_key = value
        End Set
    End Property
    Public Property sender() As String
        Get
            Return m_sender
        End Get
        Set(value As String)
            m_sender = value
        End Set
    End Property
    Public Property msgtype() As Integer
        Get
            Return m_msgtype
        End Get
        Set(value As Integer)
            m_msgtype = value
        End Set
    End Property
    Public Property dlr() As Integer
        Get
            Return m_dlr
        End Get
        Set(value As Integer)
            m_dlr = value
        End Set
    End Property

    Public Property message() As String
        Get
            Return m_message
        End Get
        Set(value As String)
            m_message = value
        End Set
    End Property
    Public Property phone() As String
        Get
            Return m_phone
        End Get
        Set(value As String)
            m_phone = value
        End Set
    End Property
    Private m_phone As String
    Private m_message As String

    Private m_id As Integer
    Private m_base_url As String
    Private m_username As String
    Private m_key As String
    Private m_sender As String
    Private m_msgtype As Integer
    Private m_dlr As Integer

End Class
