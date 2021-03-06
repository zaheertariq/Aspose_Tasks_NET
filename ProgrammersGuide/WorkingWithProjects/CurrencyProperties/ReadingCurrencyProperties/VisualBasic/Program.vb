'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports System

Namespace ReadingCurrencyProperties
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			Dim project As New Project(dataDir & "project.mpp")

			'Display currency properties
			Console.WriteLine("Currency Code : " & project.Get(Prj.CurrencyCode).ToString())
			Console.WriteLine("<br>Currency Digits : " & project.Get(Prj.CurrencyDigits).ToString())
			Console.WriteLine("<br>Currency Symbol : " & project.Get(Prj.CurrencySymbol).ToString())
			Console.WriteLine("Currency Symbol Position" & project.Get(Prj.CurrencySymbolPosition).ToString())
		End Sub
	End Class
End Namespace