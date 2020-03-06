using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam_MyRecipes.ImplementDataAccess
{
    

    class DataImportExport
    {
        string folderToImportPath;
        string folderImportedPath;

        static void Main(string[] args)
        {
            DataImportExport import = new DataImportExport();

            import.GetAllFiles();
            import.MoveFileImported();

            Console.Read();
        }

        public DataImportExport()
        {
            folderToImportPath = @"C:\CSharpExam\FilesToImport";
            folderImportedPath = @"C:\CSharpExam\FilesImported";
        }

        public void GetAllFiles()
        {
            var folderToImport = new System.IO.DirectoryInfo(@"C:\CSharpExam\FilesToImport");

            foreach (var file in folderToImport.GetFiles())
            {
                Console.WriteLine(file.FullName);
            }
        }

        public void MoveFileImported()
        {
            var folderToImport = new System.IO.DirectoryInfo(folderToImportPath);
            
            foreach (var file in folderToImport.GetFiles())
            {
                string filePath = folderToImportPath + @"\" + file.Name;
                string fileNewPath = folderImportedPath + @"\" + file.Name;
                System.IO.File.Move(filePath, fileNewPath);
            }
        }
    }
}
