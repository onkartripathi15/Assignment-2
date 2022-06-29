using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.DataContext;
using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        //static void usertable()
        //{
        //    using (var results = new ApplicationDbContext())
        //    {

        //    }
        //}
        static void Main(string[] args)
        {

            //string sourceFile = @"C:\Users\thinksysuser\Desktop\Data\OldDate";
            //    string destinationFile = @"C:\Users\thinksysuser\Desktop\NewData";

            //    // To move a file or folder to a new location:
            //    //System.IO.File.Move(sourceFile, destinationFile);

            //    // To move an entire directory. To programmatically modify or combine
            //    // path strings, use the System.IO.Path class.
            //    Directory.Move(sourceFile, destinationFile);

            //}
          using(var results=new ApplicationDbContext())
            {
                var st = results.userdisplay.ToList();
                foreach(UserClass stobj in st)
                {
                    var source=stobj.source.ToString();
                    var destination = stobj.destination.ToString();
                }
            }
            string sourceFile = @"C:\Users\thinksysuser\Desktop\Data\OldDate\ofolder";
            string destinationFolderName = @"C:\Users\thinksysuser\Desktop\Data\NewData\";

            int fileCount = Directory.GetFiles(sourceFile, "*.*", SearchOption.AllDirectories).Length;
            string[] getAllFiles = Directory.GetFiles(sourceFile, "*.txt");
            while (fileCount > 0)
            {

                
                if (fileCount < 25)
                {
                    {
                        for (int i = 0; i < fileCount; i++)
                        //foreach (var file in getAllFiles)
                        {
                            var file = getAllFiles[i];
                            var fileName = Path.GetFileNameWithoutExtension(file);
                            var extension = Path.GetExtension(file);
                            var destFileName = destinationFolderName + fileName + extension;
                            File.Move(file, destFileName);
                            fileCount--;
                        }

                    }
                    break;
                }
                else
                {
                    {
                        int k = 0;
                        for ( k = 0; k < 25; k++)
                        //foreach (var file in getAllFiles)
                        {
                            var file = getAllFiles[k];
                            var fileName = Path.GetFileNameWithoutExtension(file);
                            var extension = Path.GetExtension(file);
                            var destFileName = destinationFolderName + fileName + extension;
                            File.Move(file, destFileName);
                        }
                        k = 0;
                    }
                    fileCount = fileCount - 25;
                }

                string path = destinationFolderName;
                string [] files = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
                using (var output = File.Create(path + "output.txt")) {
                    foreach (var file in files)
                    {
                        using (var data = File.OpenRead(file))
                        {
                            data.CopyTo(output);
                        }
                    }

                }
                //string[] getAllFiles = Directory.GetFiles(sourceFile, "*.txt");
                //{
                //     foreach (var file in getAllFiles)
                //    {
                //        var fileName = Path.GetFileNameWithoutExtension(file);
                //        var extension = Path.GetExtension(file);
                //        var destFileName = destinationFolderName + fileName + extension;
                //        File.Move(file, destFileName);
                //    }
                //}
              
            }
        }
    }
}