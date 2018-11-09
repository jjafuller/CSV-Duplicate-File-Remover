using System.Collections.Generic;
using System.IO;

namespace CSV_Duplicate_File_Remover
{
    class CsvDuplicateFileRemover
    {
        public static void Main()
        {
            var basePath = @"C:\Users\jfuller\Downloads\CSV-Duplicate-File-Remover-master\DuplicateRemoverSample";

            var fileData = new HashSet<string>(File.ReadAllLines(basePath + "Input.csv"));
            File.WriteAllLines(basePath + "Output.csv", fileData);
        }
    }
}

