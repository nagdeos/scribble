﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="ScribbleDB")>  _
Partial Public Class SiteFunctionsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertAspNetKeywordMaster(instance As AspNetKeywordMaster)
    End Sub
  Partial Private Sub UpdateAspNetKeywordMaster(instance As AspNetKeywordMaster)
    End Sub
  Partial Private Sub DeleteAspNetKeywordMaster(instance As AspNetKeywordMaster)
    End Sub
  Partial Private Sub InsertAspNetUser(instance As AspNetUser)
    End Sub
  Partial Private Sub UpdateAspNetUser(instance As AspNetUser)
    End Sub
  Partial Private Sub DeleteAspNetUser(instance As AspNetUser)
    End Sub
  Partial Private Sub InsertAspNetStory(instance As AspNetStory)
    End Sub
  Partial Private Sub UpdateAspNetStory(instance As AspNetStory)
    End Sub
  Partial Private Sub DeleteAspNetStory(instance As AspNetStory)
    End Sub
  Partial Private Sub InsertAspNetComment(instance As AspNetComment)
    End Sub
  Partial Private Sub UpdateAspNetComment(instance As AspNetComment)
    End Sub
  Partial Private Sub DeleteAspNetComment(instance As AspNetComment)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("ScribbleDBConnectionString2").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property AspNetKeywordMasters() As System.Data.Linq.Table(Of AspNetKeywordMaster)
		Get
			Return Me.GetTable(Of AspNetKeywordMaster)
		End Get
	End Property
	
	Public ReadOnly Property AspNetUsers() As System.Data.Linq.Table(Of AspNetUser)
		Get
			Return Me.GetTable(Of AspNetUser)
		End Get
	End Property
	
	Public ReadOnly Property AspNetStories() As System.Data.Linq.Table(Of AspNetStory)
		Get
			Return Me.GetTable(Of AspNetStory)
		End Get
	End Property
	
	Public ReadOnly Property AspNetComments() As System.Data.Linq.Table(Of AspNetComment)
		Get
			Return Me.GetTable(Of AspNetComment)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.AddKeyword")>  _
	Public Function AddKeyword(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="KeywordName", DbType:="NVarChar(50)")> ByVal keywordName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Rating", DbType:="Int")> ByVal rating As System.Nullable(Of Integer)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), keywordName, rating)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.UpdateProfileDetails")>  _
	Public Function UpdateProfileDetails(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="UserName", DbType:="NVarChar(256)")> ByVal userName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Name", DbType:="NVarChar(50)")> ByVal name As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Email", DbType:="NVarChar(256)")> ByVal email As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="PhoneNumber", DbType:="NVarChar(MAX)")> ByVal phoneNumber As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Gender", DbType:="NVarChar(50)")> ByVal gender As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Education", DbType:="NVarChar(50)")> ByVal education As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="WorkProfile", DbType:="NVarChar(50)")> ByVal workProfile As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Interest", DbType:="NVarChar(50)")> ByVal interest As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Dob", DbType:="Date")> ByVal dob As System.Nullable(Of Date), <Global.System.Data.Linq.Mapping.ParameterAttribute(DbType:="NVarChar(256)")> ByVal status As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), userName, name, email, phoneNumber, gender, education, workProfile, interest, dob, status)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.UpdateKeyword")>  _
	Public Function UpdateKeyword(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="KeywordID", DbType:="Int")> ByVal keywordID As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="KeywordName", DbType:="NVarChar(50)")> ByVal keywordName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Rating", DbType:="Int")> ByVal rating As System.Nullable(Of Integer)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), keywordID, keywordName, rating)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.UploadImage")>  _
	Public Function UploadImage(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ProfileImage", DbType:="VarBinary(MAX)")> ByVal profileImage As System.Data.Linq.Binary, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ImgSize", DbType:="Int")> ByVal imgSize As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="UserName", DbType:="NVarChar(256)")> ByVal userName As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), profileImage, imgSize, userName)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.GetImageByUserName")>  _
	Public Function GetImageByUserName(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="UserName", DbType:="NVarChar(256)")> ByVal userName As String) As ISingleResult(Of GetImageByUserNameResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), userName)
		Return CType(result.ReturnValue,ISingleResult(Of GetImageByUserNameResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.AddStory")>  _
	Public Function AddStory(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="UserName", DbType:="NVarChar(256)")> ByVal userName As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Story", DbType:="VarBinary(MAX)")> ByVal story As System.Data.Linq.Binary, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Caption", DbType:="NVarChar(256)")> ByVal caption As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Date", DbType:="Date")> ByVal [date] As System.Nullable(Of Date)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), userName, story, caption, [date])
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.AddComment")>  _
	Public Function AddComment(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Comment", DbType:="NVarChar(256)")> ByVal comment As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="CommentedBy", DbType:="NVarChar(50)")> ByVal commentedBy As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="StoryID", DbType:="Int")> ByVal storyID As System.Nullable(Of Integer)) As ISingleResult(Of AddCommentResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), comment, commentedBy, storyID)
		Return CType(result.ReturnValue,ISingleResult(Of AddCommentResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.SetOpinion")>  _
	Public Function SetOpinion(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="StoryID", DbType:="Int")> ByVal storyID As System.Nullable(Of Integer)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), storyID)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.SetDefaultImage")>  _
	Public Function SetDefaultImage(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="UserName", DbType:="NVarChar(256)")> ByVal userName As String) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), userName)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.UpdateStory")>  _
	Public Function UpdateStory(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="StoryID", DbType:="Int")> ByVal storyID As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Story", DbType:="VarBinary(MAX)")> ByVal story As System.Data.Linq.Binary, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Caption", DbType:="NVarChar(256)")> ByVal caption As String, <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Date", DbType:="Date")> ByVal [date] As System.Nullable(Of Date)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), storyID, story, caption, [date])
		Return CType(result.ReturnValue,Integer)
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AspNetKeywordMaster")>  _
Partial Public Class AspNetKeywordMaster
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _KeywordID As Integer
	
	Private _KeywordName As String
	
	Private _Rating As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnKeywordIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnKeywordIDChanged()
    End Sub
    Partial Private Sub OnKeywordNameChanging(value As String)
    End Sub
    Partial Private Sub OnKeywordNameChanged()
    End Sub
    Partial Private Sub OnRatingChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnRatingChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_KeywordID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property KeywordID() As Integer
		Get
			Return Me._KeywordID
		End Get
		Set
			If ((Me._KeywordID = value)  _
						= false) Then
				Me.OnKeywordIDChanging(value)
				Me.SendPropertyChanging
				Me._KeywordID = value
				Me.SendPropertyChanged("KeywordID")
				Me.OnKeywordIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_KeywordName", DbType:="NVarChar(50)")>  _
	Public Property KeywordName() As String
		Get
			Return Me._KeywordName
		End Get
		Set
			If (String.Equals(Me._KeywordName, value) = false) Then
				Me.OnKeywordNameChanging(value)
				Me.SendPropertyChanging
				Me._KeywordName = value
				Me.SendPropertyChanged("KeywordName")
				Me.OnKeywordNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Rating", DbType:="Int")>  _
	Public Property Rating() As System.Nullable(Of Integer)
		Get
			Return Me._Rating
		End Get
		Set
			If (Me._Rating.Equals(value) = false) Then
				Me.OnRatingChanging(value)
				Me.SendPropertyChanging
				Me._Rating = value
				Me.SendPropertyChanged("Rating")
				Me.OnRatingChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AspNetUsers")>  _
Partial Public Class AspNetUser
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As String
	
	Private _Email As String
	
	Private _EmailConfirmed As Boolean
	
	Private _PasswordHash As String
	
	Private _SecurityStamp As String
	
	Private _PhoneNumber As String
	
	Private _PhoneNumberConfirmed As Boolean
	
	Private _TwoFactorEnabled As Boolean
	
	Private _LockoutEndDateUtc As System.Nullable(Of Date)
	
	Private _LockoutEnabled As Boolean
	
	Private _AccessFailedCount As Integer
	
	Private _UserName As String
	
	Private _isAdmin As Boolean
	
	Private _Name As String
	
	Private _Gender As String
	
	Private _Dob As System.Nullable(Of Date)
	
	Private _status As String
	
	Private _WorkProfile As String
	
	Private _Education As String
	
	Private _Interest As String
	
	Private _ProfileImage As System.Data.Linq.Binary
	
	Private _ImgSize As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As String)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnEmailConfirmedChanging(value As Boolean)
    End Sub
    Partial Private Sub OnEmailConfirmedChanged()
    End Sub
    Partial Private Sub OnPasswordHashChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordHashChanged()
    End Sub
    Partial Private Sub OnSecurityStampChanging(value As String)
    End Sub
    Partial Private Sub OnSecurityStampChanged()
    End Sub
    Partial Private Sub OnPhoneNumberChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneNumberChanged()
    End Sub
    Partial Private Sub OnPhoneNumberConfirmedChanging(value As Boolean)
    End Sub
    Partial Private Sub OnPhoneNumberConfirmedChanged()
    End Sub
    Partial Private Sub OnTwoFactorEnabledChanging(value As Boolean)
    End Sub
    Partial Private Sub OnTwoFactorEnabledChanged()
    End Sub
    Partial Private Sub OnLockoutEndDateUtcChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnLockoutEndDateUtcChanged()
    End Sub
    Partial Private Sub OnLockoutEnabledChanging(value As Boolean)
    End Sub
    Partial Private Sub OnLockoutEnabledChanged()
    End Sub
    Partial Private Sub OnAccessFailedCountChanging(value As Integer)
    End Sub
    Partial Private Sub OnAccessFailedCountChanged()
    End Sub
    Partial Private Sub OnUserNameChanging(value As String)
    End Sub
    Partial Private Sub OnUserNameChanged()
    End Sub
    Partial Private Sub OnisAdminChanging(value As Boolean)
    End Sub
    Partial Private Sub OnisAdminChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnDobChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDobChanged()
    End Sub
    Partial Private Sub OnstatusChanging(value As String)
    End Sub
    Partial Private Sub OnstatusChanged()
    End Sub
    Partial Private Sub OnWorkProfileChanging(value As String)
    End Sub
    Partial Private Sub OnWorkProfileChanged()
    End Sub
    Partial Private Sub OnEducationChanging(value As String)
    End Sub
    Partial Private Sub OnEducationChanged()
    End Sub
    Partial Private Sub OnInterestChanging(value As String)
    End Sub
    Partial Private Sub OnInterestChanged()
    End Sub
    Partial Private Sub OnProfileImageChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnProfileImageChanged()
    End Sub
    Partial Private Sub OnImgSizeChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnImgSizeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="NVarChar(128) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Id() As String
		Get
			Return Me._Id
		End Get
		Set
			If (String.Equals(Me._Id, value) = false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="NVarChar(256)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailConfirmed", DbType:="Bit NOT NULL")>  _
	Public Property EmailConfirmed() As Boolean
		Get
			Return Me._EmailConfirmed
		End Get
		Set
			If ((Me._EmailConfirmed = value)  _
						= false) Then
				Me.OnEmailConfirmedChanging(value)
				Me.SendPropertyChanging
				Me._EmailConfirmed = value
				Me.SendPropertyChanged("EmailConfirmed")
				Me.OnEmailConfirmedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PasswordHash", DbType:="NVarChar(MAX)")>  _
	Public Property PasswordHash() As String
		Get
			Return Me._PasswordHash
		End Get
		Set
			If (String.Equals(Me._PasswordHash, value) = false) Then
				Me.OnPasswordHashChanging(value)
				Me.SendPropertyChanging
				Me._PasswordHash = value
				Me.SendPropertyChanged("PasswordHash")
				Me.OnPasswordHashChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SecurityStamp", DbType:="NVarChar(MAX)")>  _
	Public Property SecurityStamp() As String
		Get
			Return Me._SecurityStamp
		End Get
		Set
			If (String.Equals(Me._SecurityStamp, value) = false) Then
				Me.OnSecurityStampChanging(value)
				Me.SendPropertyChanging
				Me._SecurityStamp = value
				Me.SendPropertyChanged("SecurityStamp")
				Me.OnSecurityStampChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PhoneNumber", DbType:="NVarChar(MAX)")>  _
	Public Property PhoneNumber() As String
		Get
			Return Me._PhoneNumber
		End Get
		Set
			If (String.Equals(Me._PhoneNumber, value) = false) Then
				Me.OnPhoneNumberChanging(value)
				Me.SendPropertyChanging
				Me._PhoneNumber = value
				Me.SendPropertyChanged("PhoneNumber")
				Me.OnPhoneNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PhoneNumberConfirmed", DbType:="Bit NOT NULL")>  _
	Public Property PhoneNumberConfirmed() As Boolean
		Get
			Return Me._PhoneNumberConfirmed
		End Get
		Set
			If ((Me._PhoneNumberConfirmed = value)  _
						= false) Then
				Me.OnPhoneNumberConfirmedChanging(value)
				Me.SendPropertyChanging
				Me._PhoneNumberConfirmed = value
				Me.SendPropertyChanged("PhoneNumberConfirmed")
				Me.OnPhoneNumberConfirmedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TwoFactorEnabled", DbType:="Bit NOT NULL")>  _
	Public Property TwoFactorEnabled() As Boolean
		Get
			Return Me._TwoFactorEnabled
		End Get
		Set
			If ((Me._TwoFactorEnabled = value)  _
						= false) Then
				Me.OnTwoFactorEnabledChanging(value)
				Me.SendPropertyChanging
				Me._TwoFactorEnabled = value
				Me.SendPropertyChanged("TwoFactorEnabled")
				Me.OnTwoFactorEnabledChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LockoutEndDateUtc", DbType:="DateTime")>  _
	Public Property LockoutEndDateUtc() As System.Nullable(Of Date)
		Get
			Return Me._LockoutEndDateUtc
		End Get
		Set
			If (Me._LockoutEndDateUtc.Equals(value) = false) Then
				Me.OnLockoutEndDateUtcChanging(value)
				Me.SendPropertyChanging
				Me._LockoutEndDateUtc = value
				Me.SendPropertyChanged("LockoutEndDateUtc")
				Me.OnLockoutEndDateUtcChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LockoutEnabled", DbType:="Bit NOT NULL")>  _
	Public Property LockoutEnabled() As Boolean
		Get
			Return Me._LockoutEnabled
		End Get
		Set
			If ((Me._LockoutEnabled = value)  _
						= false) Then
				Me.OnLockoutEnabledChanging(value)
				Me.SendPropertyChanging
				Me._LockoutEnabled = value
				Me.SendPropertyChanged("LockoutEnabled")
				Me.OnLockoutEnabledChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AccessFailedCount", DbType:="Int NOT NULL")>  _
	Public Property AccessFailedCount() As Integer
		Get
			Return Me._AccessFailedCount
		End Get
		Set
			If ((Me._AccessFailedCount = value)  _
						= false) Then
				Me.OnAccessFailedCountChanging(value)
				Me.SendPropertyChanging
				Me._AccessFailedCount = value
				Me.SendPropertyChanged("AccessFailedCount")
				Me.OnAccessFailedCountChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserName", DbType:="NVarChar(256) NOT NULL", CanBeNull:=false)>  _
	Public Property UserName() As String
		Get
			Return Me._UserName
		End Get
		Set
			If (String.Equals(Me._UserName, value) = false) Then
				Me.OnUserNameChanging(value)
				Me.SendPropertyChanging
				Me._UserName = value
				Me.SendPropertyChanged("UserName")
				Me.OnUserNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_isAdmin", DbType:="Bit NOT NULL")>  _
	Public Property isAdmin() As Boolean
		Get
			Return Me._isAdmin
		End Get
		Set
			If ((Me._isAdmin = value)  _
						= false) Then
				Me.OnisAdminChanging(value)
				Me.SendPropertyChanging
				Me._isAdmin = value
				Me.SendPropertyChanged("isAdmin")
				Me.OnisAdminChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(50)")>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="NVarChar(50)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Dob", DbType:="Date")>  _
	Public Property Dob() As System.Nullable(Of Date)
		Get
			Return Me._Dob
		End Get
		Set
			If (Me._Dob.Equals(value) = false) Then
				Me.OnDobChanging(value)
				Me.SendPropertyChanging
				Me._Dob = value
				Me.SendPropertyChanged("Dob")
				Me.OnDobChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_status", DbType:="NVarChar(256)")>  _
	Public Property status() As String
		Get
			Return Me._status
		End Get
		Set
			If (String.Equals(Me._status, value) = false) Then
				Me.OnstatusChanging(value)
				Me.SendPropertyChanging
				Me._status = value
				Me.SendPropertyChanged("status")
				Me.OnstatusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_WorkProfile", DbType:="NVarChar(50)")>  _
	Public Property WorkProfile() As String
		Get
			Return Me._WorkProfile
		End Get
		Set
			If (String.Equals(Me._WorkProfile, value) = false) Then
				Me.OnWorkProfileChanging(value)
				Me.SendPropertyChanging
				Me._WorkProfile = value
				Me.SendPropertyChanged("WorkProfile")
				Me.OnWorkProfileChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Education", DbType:="NVarChar(50)")>  _
	Public Property Education() As String
		Get
			Return Me._Education
		End Get
		Set
			If (String.Equals(Me._Education, value) = false) Then
				Me.OnEducationChanging(value)
				Me.SendPropertyChanging
				Me._Education = value
				Me.SendPropertyChanged("Education")
				Me.OnEducationChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Interest", DbType:="NVarChar(50)")>  _
	Public Property Interest() As String
		Get
			Return Me._Interest
		End Get
		Set
			If (String.Equals(Me._Interest, value) = false) Then
				Me.OnInterestChanging(value)
				Me.SendPropertyChanging
				Me._Interest = value
				Me.SendPropertyChanged("Interest")
				Me.OnInterestChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProfileImage", DbType:="VarBinary(MAX)", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property ProfileImage() As System.Data.Linq.Binary
		Get
			Return Me._ProfileImage
		End Get
		Set
			If (Object.Equals(Me._ProfileImage, value) = false) Then
				Me.OnProfileImageChanging(value)
				Me.SendPropertyChanging
				Me._ProfileImage = value
				Me.SendPropertyChanged("ProfileImage")
				Me.OnProfileImageChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ImgSize", DbType:="Int")>  _
	Public Property ImgSize() As System.Nullable(Of Integer)
		Get
			Return Me._ImgSize
		End Get
		Set
			If (Me._ImgSize.Equals(value) = false) Then
				Me.OnImgSizeChanging(value)
				Me.SendPropertyChanging
				Me._ImgSize = value
				Me.SendPropertyChanged("ImgSize")
				Me.OnImgSizeChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AspNetStory")>  _
Partial Public Class AspNetStory
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _StoryID As Integer
	
	Private _UserName As String
	
	Private _Story As System.Data.Linq.Binary
	
	Private _Caption As String
	
	Private _Date As System.Nullable(Of Date)
	
	Private _Opinion As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnStoryIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnStoryIDChanged()
    End Sub
    Partial Private Sub OnUserNameChanging(value As String)
    End Sub
    Partial Private Sub OnUserNameChanged()
    End Sub
    Partial Private Sub OnStoryChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnStoryChanged()
    End Sub
    Partial Private Sub OnCaptionChanging(value As String)
    End Sub
    Partial Private Sub OnCaptionChanged()
    End Sub
    Partial Private Sub OnDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDateChanged()
    End Sub
    Partial Private Sub OnOpinionChanging(value As String)
    End Sub
    Partial Private Sub OnOpinionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StoryID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property StoryID() As Integer
		Get
			Return Me._StoryID
		End Get
		Set
			If ((Me._StoryID = value)  _
						= false) Then
				Me.OnStoryIDChanging(value)
				Me.SendPropertyChanging
				Me._StoryID = value
				Me.SendPropertyChanged("StoryID")
				Me.OnStoryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UserName", DbType:="NVarChar(256) NOT NULL", CanBeNull:=false)>  _
	Public Property UserName() As String
		Get
			Return Me._UserName
		End Get
		Set
			If (String.Equals(Me._UserName, value) = false) Then
				Me.OnUserNameChanging(value)
				Me.SendPropertyChanging
				Me._UserName = value
				Me.SendPropertyChanged("UserName")
				Me.OnUserNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Story", DbType:="VarBinary(MAX)", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Story() As System.Data.Linq.Binary
		Get
			Return Me._Story
		End Get
		Set
			If (Object.Equals(Me._Story, value) = false) Then
				Me.OnStoryChanging(value)
				Me.SendPropertyChanging
				Me._Story = value
				Me.SendPropertyChanged("Story")
				Me.OnStoryChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Caption", DbType:="NVarChar(256)")>  _
	Public Property Caption() As String
		Get
			Return Me._Caption
		End Get
		Set
			If (String.Equals(Me._Caption, value) = false) Then
				Me.OnCaptionChanging(value)
				Me.SendPropertyChanging
				Me._Caption = value
				Me.SendPropertyChanged("Caption")
				Me.OnCaptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Date", Storage:="_Date", DbType:="Date")>  _
	Public Property [Date]() As System.Nullable(Of Date)
		Get
			Return Me._Date
		End Get
		Set
			If (Me._Date.Equals(value) = false) Then
				Me.OnDateChanging(value)
				Me.SendPropertyChanging
				Me._Date = value
				Me.SendPropertyChanged("[Date]")
				Me.OnDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Opinion", DbType:="NVarChar(50)")>  _
	Public Property Opinion() As String
		Get
			Return Me._Opinion
		End Get
		Set
			If (String.Equals(Me._Opinion, value) = false) Then
				Me.OnOpinionChanging(value)
				Me.SendPropertyChanging
				Me._Opinion = value
				Me.SendPropertyChanged("Opinion")
				Me.OnOpinionChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AspNetComment")>  _
Partial Public Class AspNetComment
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CommentID As Integer
	
	Private _StoryID As System.Nullable(Of Integer)
	
	Private _Comment As String
	
	Private _Rating As System.Nullable(Of Integer)
	
	Private _CommentedBy As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCommentIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCommentIDChanged()
    End Sub
    Partial Private Sub OnStoryIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnStoryIDChanged()
    End Sub
    Partial Private Sub OnCommentChanging(value As String)
    End Sub
    Partial Private Sub OnCommentChanged()
    End Sub
    Partial Private Sub OnRatingChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnRatingChanged()
    End Sub
    Partial Private Sub OnCommentedByChanging(value As String)
    End Sub
    Partial Private Sub OnCommentedByChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CommentID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property CommentID() As Integer
		Get
			Return Me._CommentID
		End Get
		Set
			If ((Me._CommentID = value)  _
						= false) Then
				Me.OnCommentIDChanging(value)
				Me.SendPropertyChanging
				Me._CommentID = value
				Me.SendPropertyChanged("CommentID")
				Me.OnCommentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StoryID", DbType:="Int")>  _
	Public Property StoryID() As System.Nullable(Of Integer)
		Get
			Return Me._StoryID
		End Get
		Set
			If (Me._StoryID.Equals(value) = false) Then
				Me.OnStoryIDChanging(value)
				Me.SendPropertyChanging
				Me._StoryID = value
				Me.SendPropertyChanged("StoryID")
				Me.OnStoryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Comment", DbType:="NVarChar(256)")>  _
	Public Property Comment() As String
		Get
			Return Me._Comment
		End Get
		Set
			If (String.Equals(Me._Comment, value) = false) Then
				Me.OnCommentChanging(value)
				Me.SendPropertyChanging
				Me._Comment = value
				Me.SendPropertyChanged("Comment")
				Me.OnCommentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Rating", DbType:="Int")>  _
	Public Property Rating() As System.Nullable(Of Integer)
		Get
			Return Me._Rating
		End Get
		Set
			If (Me._Rating.Equals(value) = false) Then
				Me.OnRatingChanging(value)
				Me.SendPropertyChanging
				Me._Rating = value
				Me.SendPropertyChanged("Rating")
				Me.OnRatingChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CommentedBy", DbType:="NVarChar(50)")>  _
	Public Property CommentedBy() As String
		Get
			Return Me._CommentedBy
		End Get
		Set
			If (String.Equals(Me._CommentedBy, value) = false) Then
				Me.OnCommentedByChanging(value)
				Me.SendPropertyChanging
				Me._CommentedBy = value
				Me.SendPropertyChanged("CommentedBy")
				Me.OnCommentedByChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class GetImageByUserNameResult
	
	Private _ProfileImage As System.Data.Linq.Binary
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProfileImage", DbType:="VarBinary(MAX)")>  _
	Public Property ProfileImage() As System.Data.Linq.Binary
		Get
			Return Me._ProfileImage
		End Get
		Set
			If (Object.Equals(Me._ProfileImage, value) = false) Then
				Me._ProfileImage = value
			End If
		End Set
	End Property
End Class

Partial Public Class AddCommentResult
	
	Private _Column1 As System.Nullable(Of Integer)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="", Storage:="_Column1", DbType:="Int")>  _
	Public Property Column1() As System.Nullable(Of Integer)
		Get
			Return Me._Column1
		End Get
		Set
			If (Me._Column1.Equals(value) = false) Then
				Me._Column1 = value
			End If
		End Set
	End Property
End Class