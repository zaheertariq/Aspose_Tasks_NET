//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Tasks. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Tasks;
using Aspose.Tasks.Saving;

namespace WritingProjectInformationExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            Project project = new Project(dataDir+ "project.mpp");
            project.Set(Prj.Author, "Author");
            project.Set(Prj.LastAuthor, "Last Author");
            project.Set(Prj.Revision, 15);
            project.Set(Prj.Keywords, "MSP Aspose");
            project.Set(Prj.Comments, "Comments");

            project.Save(dataDir+ "saved.mpp", SaveFileFormat.MPP);
            
        }
    }
}