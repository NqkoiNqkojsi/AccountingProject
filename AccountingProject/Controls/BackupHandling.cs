using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace AccountingProject.Controls
{
    class BackupHandling
    {
        static public void Export(bool custom)//checks if its made by the user
        {
            string startPath = @"..\..\Database";
            string zipPath = @"";
            if (custom)
            {
                zipPath = @"..\..\Backups\Custom-result-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "__" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".zip";
            }
            else
            {
                zipPath = @"..\..\Backups\result-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "__" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".zip";
            }
            //string extractPath = @"..\..\Database";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            //ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
        static public void Import(string path)
        {
            string extractPath = @"..\..\Database";

            //Delete Old Files
            System.IO.DirectoryInfo di = new DirectoryInfo(@"..\..\Database");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }

            ZipFile.ExtractToDirectory(path, extractPath);
            /*
            using (ZipArchive archive = ZipFile.OpenRead(filePath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    // Gets the full path to ensure that relative segments are removed.
                    string destinationPath = Path.GetFullPath(Path.Combine(extractPath, entry.FullName));

                    // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                    // are case-insensitive.
                    if (destinationPath.StartsWith(extractPath, StringComparison.Ordinal))
                        entry.ExtractToFile(destinationPath);
                }
            }*/
        
        }
    }
}
