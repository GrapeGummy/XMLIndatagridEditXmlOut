'' -----------------------------------------------------------------------------
''    <NameSpace>XMLDataGridXML</NameSpace><Collection>List</Collection><codeType>VisualBasic</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net45</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>False</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>False</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>None</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>False</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><ClassLevel>Public</ClassLevel><PartialClass>True</PartialClass><ClassesInSeparateFiles>False</ClassesInSeparateFiles><ClassesInSeparateFilesDir></ClassesInSeparateFilesDir><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><EnableAppInfoSettings>False</EnableAppInfoSettings><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>False</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>False</CleanupCode><EnableXmlSerialization>True</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><IndentChar>Indent2Space</IndentChar><NewLineAttr>False</NewLineAttr><OmitXML>False</OmitXML><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><sspNullable>False</sspNullable><sspString>False</sspString><sspCollection>False</sspCollection><sspComplexType>False</sspComplexType><sspSimpleType>False</sspSimpleType><sspEnumType>False</sspEnumType><XmlSerializerEvent>False</XmlSerializerEvent><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings><AttributesToExlude></AttributesToExlude>
'' ------------------------------------------------------------------------------
#Disable Warning
Imports System
Imports System.Diagnostics
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Collections.Generic

Namespace XMLDataGridXML

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class JobConfig

#Region "Private fields"
        Private _jobInfo As JobConfigJobInfo

        Private Shared sSerializer As XmlSerializer
#End Region

        Public Sub New()
            MyBase.New
            Me._jobInfo = New JobConfigJobInfo()
        End Sub

        Public Property JobInfo() As JobConfigJobInfo
            Get
                Return Me._jobInfo
            End Get
            Set
                Me._jobInfo = Value
            End Set
        End Property

        Private Shared ReadOnly Property Serializer() As XmlSerializer
            Get
                If (sSerializer Is Nothing) Then
                    sSerializer = New XmlSerializerFactory().CreateSerializer(GetType(JobConfig))
                End If
                Return sSerializer
            End Get
        End Property

#Region "Serialize/Deserialize"
        ''' <summary>
        ''' Serializes current JobConfig object into an XML string
        ''' </summary>
        ''' <returns>string XML value</returns>
        Public Overridable Function Serialize() As String
            Dim streamReader As System.IO.StreamReader = Nothing
            Dim memoryStream As System.IO.MemoryStream = Nothing
            Try
                memoryStream = New System.IO.MemoryStream()
                Dim xmlWriterSettings As System.Xml.XmlWriterSettings = New System.Xml.XmlWriterSettings()
                Dim xmlWriter As System.Xml.XmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings)
                Serializer.Serialize(xmlWriter, Me)
                memoryStream.Seek(0, SeekOrigin.Begin)
                streamReader = New System.IO.StreamReader(memoryStream)
                Return streamReader.ReadToEnd
            Finally
                If (Not (streamReader) Is Nothing) Then
                    streamReader.Dispose()
                End If
                If (Not (memoryStream) Is Nothing) Then
                    memoryStream.Dispose()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Deserializes workflow markup into an JobConfig object
        ''' </summary>
        ''' <param name="input">string workflow markup to deserialize</param>
        ''' <param name="obj">Output JobConfig object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfig, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfig)
            Try
                obj = Deserialize(input)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfig) As Boolean
            Dim exception As System.Exception = Nothing
            Return Deserialize(input, obj, exception)
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String) As JobConfig
            Dim stringReader As System.IO.StringReader = Nothing
            Try
                stringReader = New System.IO.StringReader(input)
                Return CType(Serializer.Deserialize(XmlReader.Create(stringReader)), JobConfig)
            Finally
                If (Not (stringReader) Is Nothing) Then
                    stringReader.Dispose()
                End If
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal s As System.IO.Stream) As JobConfig
            Return CType(Serializer.Deserialize(s), JobConfig)
        End Function
#End Region

        ''' <summary>
        ''' Serializes current JobConfig object into file
        ''' </summary>
        ''' <param name="fileName">full path of outupt xml file</param>
        ''' <param name="exception">output Exception value if failed</param>
        ''' <returns>true if can serialize and save into file; otherwise, false</returns>
        Public Overridable Overloads Function SaveToFile(ByVal fileName As String, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            Try
                SaveToFile(fileName)
                Return True
            Catch e As System.Exception
                exception = e
                Return False
            End Try
        End Function

        Public Overridable Overloads Sub SaveToFile(ByVal fileName As String)
            Dim streamWriter As System.IO.StreamWriter = Nothing
            Try
                Dim xmlString As String = Serialize()
                Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString)
                streamWriter.Close()
            Finally
                If (Not (streamWriter) Is Nothing) Then
                    streamWriter.Dispose()
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Deserializes xml markup from file into an JobConfig object
        ''' </summary>
        ''' <param name="fileName">string xml file to load and deserialize</param>
        ''' <param name="obj">Output JobConfig object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfig, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfig)
            Try
                obj = LoadFromFile(fileName)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfig) As Boolean
            Dim exception As System.Exception = Nothing
            Return LoadFromFile(fileName, obj, exception)
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String) As JobConfig
            Dim file As System.IO.FileStream = Nothing
            Dim sr As System.IO.StreamReader = Nothing
            Try
                file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = New System.IO.StreamReader(file)
                Dim xmlString As String = sr.ReadToEnd
                sr.Close()
                file.Close()
                Return Deserialize(xmlString)
            Finally
                If (Not (file) Is Nothing) Then
                    file.Dispose()
                End If
                If (Not (sr) Is Nothing) Then
                    sr.Dispose()
                End If
            End Try
        End Function
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class JobConfigJobInfo

#Region "Private fields"
        Private _jobProperties As JobConfigJobInfoJobProperties

        Private Shared sSerializer As XmlSerializer
#End Region

        Public Sub New()
            MyBase.New
            Me._jobProperties = New JobConfigJobInfoJobProperties()
        End Sub

        Public Property JobProperties() As JobConfigJobInfoJobProperties
            Get
                Return Me._jobProperties
            End Get
            Set
                Me._jobProperties = Value
            End Set
        End Property

        Private Shared ReadOnly Property Serializer() As XmlSerializer
            Get
                If (sSerializer Is Nothing) Then
                    sSerializer = New XmlSerializerFactory().CreateSerializer(GetType(JobConfigJobInfo))
                End If
                Return sSerializer
            End Get
        End Property

#Region "Serialize/Deserialize"
        ''' <summary>
        ''' Serializes current JobConfigJobInfo object into an XML string
        ''' </summary>
        ''' <returns>string XML value</returns>
        Public Overridable Function Serialize() As String
            Dim streamReader As System.IO.StreamReader = Nothing
            Dim memoryStream As System.IO.MemoryStream = Nothing
            Try
                memoryStream = New System.IO.MemoryStream()
                Dim xmlWriterSettings As System.Xml.XmlWriterSettings = New System.Xml.XmlWriterSettings()
                Dim xmlWriter As System.Xml.XmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings)
                Serializer.Serialize(xmlWriter, Me)
                memoryStream.Seek(0, SeekOrigin.Begin)
                streamReader = New System.IO.StreamReader(memoryStream)
                Return streamReader.ReadToEnd
            Finally
                If (Not (streamReader) Is Nothing) Then
                    streamReader.Dispose()
                End If
                If (Not (memoryStream) Is Nothing) Then
                    memoryStream.Dispose()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Deserializes workflow markup into an JobConfigJobInfo object
        ''' </summary>
        ''' <param name="input">string workflow markup to deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfo object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfo, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfo)
            Try
                obj = Deserialize(input)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfo) As Boolean
            Dim exception As System.Exception = Nothing
            Return Deserialize(input, obj, exception)
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String) As JobConfigJobInfo
            Dim stringReader As System.IO.StringReader = Nothing
            Try
                stringReader = New System.IO.StringReader(input)
                Return CType(Serializer.Deserialize(XmlReader.Create(stringReader)), JobConfigJobInfo)
            Finally
                If (Not (stringReader) Is Nothing) Then
                    stringReader.Dispose()
                End If
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal s As System.IO.Stream) As JobConfigJobInfo
            Return CType(Serializer.Deserialize(s), JobConfigJobInfo)
        End Function
#End Region

        ''' <summary>
        ''' Serializes current JobConfigJobInfo object into file
        ''' </summary>
        ''' <param name="fileName">full path of outupt xml file</param>
        ''' <param name="exception">output Exception value if failed</param>
        ''' <returns>true if can serialize and save into file; otherwise, false</returns>
        Public Overridable Overloads Function SaveToFile(ByVal fileName As String, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            Try
                SaveToFile(fileName)
                Return True
            Catch e As System.Exception
                exception = e
                Return False
            End Try
        End Function

        Public Overridable Overloads Sub SaveToFile(ByVal fileName As String)
            Dim streamWriter As System.IO.StreamWriter = Nothing
            Try
                Dim xmlString As String = Serialize()
                Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString)
                streamWriter.Close()
            Finally
                If (Not (streamWriter) Is Nothing) Then
                    streamWriter.Dispose()
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Deserializes xml markup from file into an JobConfigJobInfo object
        ''' </summary>
        ''' <param name="fileName">string xml file to load and deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfo object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfo, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfo)
            Try
                obj = LoadFromFile(fileName)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfo) As Boolean
            Dim exception As System.Exception = Nothing
            Return LoadFromFile(fileName, obj, exception)
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String) As JobConfigJobInfo
            Dim file As System.IO.FileStream = Nothing
            Dim sr As System.IO.StreamReader = Nothing
            Try
                file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = New System.IO.StreamReader(file)
                Dim xmlString As String = sr.ReadToEnd
                sr.Close()
                file.Close()
                Return Deserialize(xmlString)
            Finally
                If (Not (file) Is Nothing) Then
                    file.Dispose()
                End If
                If (Not (sr) Is Nothing) Then
                    sr.Dispose()
                End If
            End Try
        End Function
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class JobConfigJobInfoJobProperties

#Region "Private fields"
        Private _jobProperty As List(Of JobConfigJobInfoJobPropertiesJobProperty)

        Private _customJobProperty As List(Of JobConfigJobInfoJobPropertiesCustomJobProperty)

        Private Shared sSerializer As XmlSerializer
#End Region

        Public Sub New()
            MyBase.New
            Me._customJobProperty = New List(Of JobConfigJobInfoJobPropertiesCustomJobProperty)()
            Me._jobProperty = New List(Of JobConfigJobInfoJobPropertiesJobProperty)()
        End Sub

        <System.Xml.Serialization.XmlElementAttribute("JobProperty")>
        Public Property JobProperty() As List(Of JobConfigJobInfoJobPropertiesJobProperty)
            Get
                Return Me._jobProperty
            End Get
            Set
                Me._jobProperty = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlElementAttribute("CustomJobProperty")>
        Public Property CustomJobProperty() As List(Of JobConfigJobInfoJobPropertiesCustomJobProperty)
            Get
                Return Me._customJobProperty
            End Get
            Set
                Me._customJobProperty = Value
            End Set
        End Property

        Private Shared ReadOnly Property Serializer() As XmlSerializer
            Get
                If (sSerializer Is Nothing) Then
                    sSerializer = New XmlSerializerFactory().CreateSerializer(GetType(JobConfigJobInfoJobProperties))
                End If
                Return sSerializer
            End Get
        End Property

#Region "Serialize/Deserialize"
        ''' <summary>
        ''' Serializes current JobConfigJobInfoJobProperties object into an XML string
        ''' </summary>
        ''' <returns>string XML value</returns>
        Public Overridable Function Serialize() As String
            Dim streamReader As System.IO.StreamReader = Nothing
            Dim memoryStream As System.IO.MemoryStream = Nothing
            Try
                memoryStream = New System.IO.MemoryStream()
                Dim xmlWriterSettings As System.Xml.XmlWriterSettings = New System.Xml.XmlWriterSettings()
                Dim xmlWriter As System.Xml.XmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings)
                Serializer.Serialize(xmlWriter, Me)
                memoryStream.Seek(0, SeekOrigin.Begin)
                streamReader = New System.IO.StreamReader(memoryStream)
                Return streamReader.ReadToEnd
            Finally
                If (Not (streamReader) Is Nothing) Then
                    streamReader.Dispose()
                End If
                If (Not (memoryStream) Is Nothing) Then
                    memoryStream.Dispose()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Deserializes workflow markup into an JobConfigJobInfoJobProperties object
        ''' </summary>
        ''' <param name="input">string workflow markup to deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfoJobProperties object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfoJobProperties, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfoJobProperties)
            Try
                obj = Deserialize(input)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfoJobProperties) As Boolean
            Dim exception As System.Exception = Nothing
            Return Deserialize(input, obj, exception)
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String) As JobConfigJobInfoJobProperties
            Dim stringReader As System.IO.StringReader = Nothing
            Try
                stringReader = New System.IO.StringReader(input)
                Return CType(Serializer.Deserialize(XmlReader.Create(stringReader)), JobConfigJobInfoJobProperties)
            Finally
                If (Not (stringReader) Is Nothing) Then
                    stringReader.Dispose()
                End If
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal s As System.IO.Stream) As JobConfigJobInfoJobProperties
            Return CType(Serializer.Deserialize(s), JobConfigJobInfoJobProperties)
        End Function
#End Region

        ''' <summary>
        ''' Serializes current JobConfigJobInfoJobProperties object into file
        ''' </summary>
        ''' <param name="fileName">full path of outupt xml file</param>
        ''' <param name="exception">output Exception value if failed</param>
        ''' <returns>true if can serialize and save into file; otherwise, false</returns>
        Public Overridable Overloads Function SaveToFile(ByVal fileName As String, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            Try
                SaveToFile(fileName)
                Return True
            Catch e As System.Exception
                exception = e
                Return False
            End Try
        End Function

        Public Overridable Overloads Sub SaveToFile(ByVal fileName As String)
            Dim streamWriter As System.IO.StreamWriter = Nothing
            Try
                Dim xmlString As String = Serialize()
                Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString)
                streamWriter.Close()
            Finally
                If (Not (streamWriter) Is Nothing) Then
                    streamWriter.Dispose()
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Deserializes xml markup from file into an JobConfigJobInfoJobProperties object
        ''' </summary>
        ''' <param name="fileName">string xml file to load and deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfoJobProperties object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfoJobProperties, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfoJobProperties)
            Try
                obj = LoadFromFile(fileName)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfoJobProperties) As Boolean
            Dim exception As System.Exception = Nothing
            Return LoadFromFile(fileName, obj, exception)
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String) As JobConfigJobInfoJobProperties
            Dim file As System.IO.FileStream = Nothing
            Dim sr As System.IO.StreamReader = Nothing
            Try
                file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = New System.IO.StreamReader(file)
                Dim xmlString As String = sr.ReadToEnd
                sr.Close()
                file.Close()
                Return Deserialize(xmlString)
            Finally
                If (Not (file) Is Nothing) Then
                    file.Dispose()
                End If
                If (Not (sr) Is Nothing) Then
                    sr.Dispose()
                End If
            End Try
        End Function
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class JobConfigJobInfoJobPropertiesJobProperty

#Region "Private fields"
        Private _name As String

        Private _value As String

        Private Shared sSerializer As XmlSerializer
#End Region

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                Me._name = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property Value() As String
            Get
                Return Me._value
            End Get
            Set
                Me._value = Value
            End Set
        End Property

        Private Shared ReadOnly Property Serializer() As XmlSerializer
            Get
                If (sSerializer Is Nothing) Then
                    sSerializer = New XmlSerializerFactory().CreateSerializer(GetType(JobConfigJobInfoJobPropertiesJobProperty))
                End If
                Return sSerializer
            End Get
        End Property

#Region "Serialize/Deserialize"
        ''' <summary>
        ''' Serializes current JobConfigJobInfoJobPropertiesJobProperty object into an XML string
        ''' </summary>
        ''' <returns>string XML value</returns>
        Public Overridable Function Serialize() As String
            Dim streamReader As System.IO.StreamReader = Nothing
            Dim memoryStream As System.IO.MemoryStream = Nothing
            Try
                memoryStream = New System.IO.MemoryStream()
                Dim xmlWriterSettings As System.Xml.XmlWriterSettings = New System.Xml.XmlWriterSettings()
                Dim xmlWriter As System.Xml.XmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings)
                Serializer.Serialize(xmlWriter, Me)
                memoryStream.Seek(0, SeekOrigin.Begin)
                streamReader = New System.IO.StreamReader(memoryStream)
                Return streamReader.ReadToEnd
            Finally
                If (Not (streamReader) Is Nothing) Then
                    streamReader.Dispose()
                End If
                If (Not (memoryStream) Is Nothing) Then
                    memoryStream.Dispose()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Deserializes workflow markup into an JobConfigJobInfoJobPropertiesJobProperty object
        ''' </summary>
        ''' <param name="input">string workflow markup to deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfoJobPropertiesJobProperty object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfoJobPropertiesJobProperty, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfoJobPropertiesJobProperty)
            Try
                obj = Deserialize(input)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfoJobPropertiesJobProperty) As Boolean
            Dim exception As System.Exception = Nothing
            Return Deserialize(input, obj, exception)
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String) As JobConfigJobInfoJobPropertiesJobProperty
            Dim stringReader As System.IO.StringReader = Nothing
            Try
                stringReader = New System.IO.StringReader(input)
                Return CType(Serializer.Deserialize(XmlReader.Create(stringReader)), JobConfigJobInfoJobPropertiesJobProperty)
            Finally
                If (Not (stringReader) Is Nothing) Then
                    stringReader.Dispose()
                End If
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal s As System.IO.Stream) As JobConfigJobInfoJobPropertiesJobProperty
            Return CType(Serializer.Deserialize(s), JobConfigJobInfoJobPropertiesJobProperty)
        End Function
#End Region

        ''' <summary>
        ''' Serializes current JobConfigJobInfoJobPropertiesJobProperty object into file
        ''' </summary>
        ''' <param name="fileName">full path of outupt xml file</param>
        ''' <param name="exception">output Exception value if failed</param>
        ''' <returns>true if can serialize and save into file; otherwise, false</returns>
        Public Overridable Overloads Function SaveToFile(ByVal fileName As String, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            Try
                SaveToFile(fileName)
                Return True
            Catch e As System.Exception
                exception = e
                Return False
            End Try
        End Function

        Public Overridable Overloads Sub SaveToFile(ByVal fileName As String)
            Dim streamWriter As System.IO.StreamWriter = Nothing
            Try
                Dim xmlString As String = Serialize()
                Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString)
                streamWriter.Close()
            Finally
                If (Not (streamWriter) Is Nothing) Then
                    streamWriter.Dispose()
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Deserializes xml markup from file into an JobConfigJobInfoJobPropertiesJobProperty object
        ''' </summary>
        ''' <param name="fileName">string xml file to load and deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfoJobPropertiesJobProperty object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfoJobPropertiesJobProperty, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfoJobPropertiesJobProperty)
            Try
                obj = LoadFromFile(fileName)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfoJobPropertiesJobProperty) As Boolean
            Dim exception As System.Exception = Nothing
            Return LoadFromFile(fileName, obj, exception)
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String) As JobConfigJobInfoJobPropertiesJobProperty
            Dim file As System.IO.FileStream = Nothing
            Dim sr As System.IO.StreamReader = Nothing
            Try
                file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = New System.IO.StreamReader(file)
                Dim xmlString As String = sr.ReadToEnd
                sr.Close()
                file.Close()
                Return Deserialize(xmlString)
            Finally
                If (Not (file) Is Nothing) Then
                    file.Dispose()
                End If
                If (Not (sr) Is Nothing) Then
                    sr.Dispose()
                End If
            End Try
        End Function
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class JobConfigJobInfoJobPropertiesCustomJobProperty

#Region "Private fields"
        Private _name As String

        Private _value As String

        Private _required As Boolean

        Private Shared sSerializer As XmlSerializer
#End Region

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                Me._name = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property Value() As String
            Get
                Return Me._value
            End Get
            Set
                Me._value = Value
            End Set
        End Property

        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property Required() As Boolean
            Get
                Return Me._required
            End Get
            Set
                Me._required = Value
            End Set
        End Property

        Private Shared ReadOnly Property Serializer() As XmlSerializer
            Get
                If (sSerializer Is Nothing) Then
                    sSerializer = New XmlSerializerFactory().CreateSerializer(GetType(JobConfigJobInfoJobPropertiesCustomJobProperty))
                End If
                Return sSerializer
            End Get
        End Property

#Region "Serialize/Deserialize"
        ''' <summary>
        ''' Serializes current JobConfigJobInfoJobPropertiesCustomJobProperty object into an XML string
        ''' </summary>
        ''' <returns>string XML value</returns>
        Public Overridable Function Serialize() As String
            Dim streamReader As System.IO.StreamReader = Nothing
            Dim memoryStream As System.IO.MemoryStream = Nothing
            Try
                memoryStream = New System.IO.MemoryStream()
                Dim xmlWriterSettings As System.Xml.XmlWriterSettings = New System.Xml.XmlWriterSettings()
                Dim xmlWriter As System.Xml.XmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings)
                Serializer.Serialize(xmlWriter, Me)
                memoryStream.Seek(0, SeekOrigin.Begin)
                streamReader = New System.IO.StreamReader(memoryStream)
                Return streamReader.ReadToEnd
            Finally
                If (Not (streamReader) Is Nothing) Then
                    streamReader.Dispose()
                End If
                If (Not (memoryStream) Is Nothing) Then
                    memoryStream.Dispose()
                End If
            End Try
        End Function

        ''' <summary>
        ''' Deserializes workflow markup into an JobConfigJobInfoJobPropertiesCustomJobProperty object
        ''' </summary>
        ''' <param name="input">string workflow markup to deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfoJobPropertiesCustomJobProperty object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfoJobPropertiesCustomJobProperty, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfoJobPropertiesCustomJobProperty)
            Try
                obj = Deserialize(input)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String, ByRef obj As JobConfigJobInfoJobPropertiesCustomJobProperty) As Boolean
            Dim exception As System.Exception = Nothing
            Return Deserialize(input, obj, exception)
        End Function

        Public Overloads Shared Function Deserialize(ByVal input As String) As JobConfigJobInfoJobPropertiesCustomJobProperty
            Dim stringReader As System.IO.StringReader = Nothing
            Try
                stringReader = New System.IO.StringReader(input)
                Return CType(Serializer.Deserialize(XmlReader.Create(stringReader)), JobConfigJobInfoJobPropertiesCustomJobProperty)
            Finally
                If (Not (stringReader) Is Nothing) Then
                    stringReader.Dispose()
                End If
            End Try
        End Function

        Public Overloads Shared Function Deserialize(ByVal s As System.IO.Stream) As JobConfigJobInfoJobPropertiesCustomJobProperty
            Return CType(Serializer.Deserialize(s), JobConfigJobInfoJobPropertiesCustomJobProperty)
        End Function
#End Region

        ''' <summary>
        ''' Serializes current JobConfigJobInfoJobPropertiesCustomJobProperty object into file
        ''' </summary>
        ''' <param name="fileName">full path of outupt xml file</param>
        ''' <param name="exception">output Exception value if failed</param>
        ''' <returns>true if can serialize and save into file; otherwise, false</returns>
        Public Overridable Overloads Function SaveToFile(ByVal fileName As String, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            Try
                SaveToFile(fileName)
                Return True
            Catch e As System.Exception
                exception = e
                Return False
            End Try
        End Function

        Public Overridable Overloads Sub SaveToFile(ByVal fileName As String)
            Dim streamWriter As System.IO.StreamWriter = Nothing
            Try
                Dim xmlString As String = Serialize()
                Dim xmlFile As System.IO.FileInfo = New System.IO.FileInfo(fileName)
                streamWriter = xmlFile.CreateText
                streamWriter.WriteLine(xmlString)
                streamWriter.Close()
            Finally
                If (Not (streamWriter) Is Nothing) Then
                    streamWriter.Dispose()
                End If
            End Try
        End Sub

        ''' <summary>
        ''' Deserializes xml markup from file into an JobConfigJobInfoJobPropertiesCustomJobProperty object
        ''' </summary>
        ''' <param name="fileName">string xml file to load and deserialize</param>
        ''' <param name="obj">Output JobConfigJobInfoJobPropertiesCustomJobProperty object</param>
        ''' <param name="exception">output Exception value if deserialize failed</param>
        ''' <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfoJobPropertiesCustomJobProperty, ByRef exception As System.Exception) As Boolean
            exception = Nothing
            obj = CType(Nothing, JobConfigJobInfoJobPropertiesCustomJobProperty)
            Try
                obj = LoadFromFile(fileName)
                Return True
            Catch ex As System.Exception
                exception = ex
                Return False
            End Try
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String, ByRef obj As JobConfigJobInfoJobPropertiesCustomJobProperty) As Boolean
            Dim exception As System.Exception = Nothing
            Return LoadFromFile(fileName, obj, exception)
        End Function

        Public Overloads Shared Function LoadFromFile(ByVal fileName As String) As JobConfigJobInfoJobPropertiesCustomJobProperty
            Dim file As System.IO.FileStream = Nothing
            Dim sr As System.IO.StreamReader = Nothing
            Try
                file = New System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read)
                sr = New System.IO.StreamReader(file)
                Dim xmlString As String = sr.ReadToEnd
                sr.Close()
                file.Close()
                Return Deserialize(xmlString)
            Finally
                If (Not (file) Is Nothing) Then
                    file.Dispose()
                End If
                If (Not (sr) Is Nothing) Then
                    sr.Dispose()
                End If
            End Try
        End Function
    End Class
End Namespace
#Enable Warning
