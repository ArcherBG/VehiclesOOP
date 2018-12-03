using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesOOP
{
    class FileManager
    {

        /** Reads a file and returns a list with every row in the file
         */
        public List<string> ReadFile(string pathToFile)
        {
            List<string> fileContent = new List<string>();

            FileStream fs = new FileStream(pathToFile, FileMode.Open);

            using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                string line = String.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {                 
                    fileContent.Add(line);
                }
            }

            fs.Close();
            return fileContent;
        }

        /** Tries to write text into file. If the file it not found
         * creates a new one and writes into it. 
         */
        public void WriteToFile(string pathToFile, string text)
        {
            FileStream fs;
            if (File.Exists(pathToFile))
            {
                fs = new FileStream(pathToFile, FileMode.Append);
            }
            else
            {
                fs = new FileStream(pathToFile, FileMode.Create);
            }

            byte[] info = new UTF8Encoding(true).GetBytes(text);
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}
