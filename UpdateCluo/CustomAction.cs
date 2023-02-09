using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mazzzing
{
    class CustomAction
    {

        public static void OnInstall(string[] args)
        {
            string Roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string path = System.IO.Path.Combine(Roaming, "Cluo-Database");
            System.IO.Directory.CreateDirectory(path);
            //Now I will create a file in this Directory
            string Location = System.IO.Path.Combine(Roaming, "Cluo-Database");
            var sourceFile = Path.Combine(Environment.CurrentDirectory, "AppData\\servers.s3db");
            var destin = Path.Combine(Roaming, "Cluo-Database\\servers.s3db");
            string markerFile = Path.Combine(Roaming, "Cluo-Database\\Isinstalled2.txt");


            if (!File.Exists(markerFile))
            {
                File.Delete(destin);
            }
        }

       
    }

}
