﻿#ExternalChecksum("..\..\..\MainWindow.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","D7F323B4557C53ECA1C35FAD278549F3")
'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.239
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Search_n_Load
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell
Imports Vlc.DotNet.Wpf

Namespace searchnload
    
    '''<summary>
    '''MainWindow
    '''</summary>
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Partial Public Class MainWindow
        Inherits System.Windows.Window
        Implements System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",9)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents Menu1 As System.Windows.Controls.Menu
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",15)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents ComboBox1 As System.Windows.Controls.ComboBox
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",20)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents Button1 As System.Windows.Controls.Button
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",21)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents ListView1 As System.Windows.Controls.ListView
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",75)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents Expander1 As System.Windows.Controls.Expander
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",77)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents Button2 As System.Windows.Controls.Button
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",78)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents TextBox2 As System.Windows.Controls.TextBox
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",79)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents ComboBox2 As System.Windows.Controls.ComboBox
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",86)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents ComboBox3 As System.Windows.Controls.ComboBox
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\MainWindow.xaml",88)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents myVlcControl As Vlc.DotNet.Wpf.VlcControl
        
        #End ExternalSource
        
        Private _contentLoaded As Boolean
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true
            Dim resourceLocater As System.Uri = New System.Uri("/Search_n_Load;component/mainwindow.xaml", System.UriKind.Relative)
            
            #ExternalSource("..\..\..\MainWindow.xaml",1)
            System.Windows.Application.LoadComponent(Me, resourceLocater)
            
            #End ExternalSource
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
        Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
            If (connectionId = 1) Then
                Me.Menu1 = CType(target,System.Windows.Controls.Menu)
                Return
            End If
            If (connectionId = 2) Then
                Me.ComboBox1 = CType(target,System.Windows.Controls.ComboBox)
                Return
            End If
            If (connectionId = 3) Then
                Me.Button1 = CType(target,System.Windows.Controls.Button)
                Return
            End If
            If (connectionId = 4) Then
                Me.ListView1 = CType(target,System.Windows.Controls.ListView)
                
                #ExternalSource("..\..\..\MainWindow.xaml",21)
                AddHandler Me.ListView1.MouseDoubleClick, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.itemclick)
                
                #End ExternalSource
                Return
            End If
            If (connectionId = 7) Then
                Me.Expander1 = CType(target,System.Windows.Controls.Expander)
                Return
            End If
            If (connectionId = 8) Then
                Me.Button2 = CType(target,System.Windows.Controls.Button)
                Return
            End If
            If (connectionId = 9) Then
                Me.TextBox2 = CType(target,System.Windows.Controls.TextBox)
                Return
            End If
            If (connectionId = 10) Then
                Me.ComboBox2 = CType(target,System.Windows.Controls.ComboBox)
                Return
            End If
            If (connectionId = 11) Then
                Me.ComboBox3 = CType(target,System.Windows.Controls.ComboBox)
                Return
            End If
            If (connectionId = 12) Then
                Me.myVlcControl = CType(target,Vlc.DotNet.Wpf.VlcControl)
                Return
            End If
            Me._contentLoaded = true
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")>  _
        Sub System_Windows_Markup_IStyleConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IStyleConnector.Connect
            If (connectionId = 5) Then
                
                #ExternalSource("..\..\..\MainWindow.xaml",50)
                AddHandler CType(target,System.Windows.Controls.Image).MouseLeftButtonUp, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.itemdl)
                
                #End ExternalSource
            End If
            If (connectionId = 6) Then
                
                #ExternalSource("..\..\..\MainWindow.xaml",60)
                AddHandler CType(target,System.Windows.Controls.Image).MouseLeftButtonUp, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.play)
                
                #End ExternalSource
            End If
        End Sub
    End Class
End Namespace

