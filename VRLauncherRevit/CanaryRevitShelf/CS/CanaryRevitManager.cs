using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using System.IO;
using System.Diagnostics;

static class CanaryRevitManager
    {
        static string defaultObjFile = "C:\\LocalBuilds\\CanaryRevit\\test.obj";
        static string defaultViewer = "E:\\RND\\CanaryRevit_Viewer\\Build\\CanaryRevitViewer.exe";

        public static string exportFile(Document activeDoc, View3D main3Dview)
        {
            string MsStr = RevitOBJExport.Main.ExportView3D(activeDoc,
                main3Dview,
                defaultObjFile,
                0.3048,
                1,
                8,
                true,
                false,
                false,
                true,
                true,
                true,
                2,
                "textures",
                1,
                1,
                1);

            return MsStr;
        }

        static CanaryRevitManager()
        {
                   
        }

    internal static void launchViewer()
    {
        if (File.Exists(defaultObjFile))
        {
            Console.WriteLine("Launching App: " + defaultViewer);
            Process process = Process.Start(defaultViewer);
            //int id = process.Id;
            //Process tempProc = Process.GetProcessById(id);
        }
        else
        {
            Console.WriteLine("hmm... something went wrong, cant launch app: " + defaultViewer);
        }

    }
}

