'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Tasks. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Tasks
Imports Aspose.Tasks.Saving

Namespace WritingFiscalYearPropertiesExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a project instance
			Dim prj As New Project(dataDir & "project.mpp")
			'Set fiscal year properties
			prj.Set(Prj.FyStartDate, Month.July)
			prj.Set(Prj.FiscalYearStart, True)
			prj.Save(dataDir & "saved.mpp", SaveFileFormat.MPP)
		End Sub
	End Class
End Namespace