namespace CSV;

using System;
using System.IO;

public class Pro
{
    static void Main(string[] args)
    {
        mFileScan();
    }

        
    
    string filePath = "path/to/csv/file.csv";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');

                    // Process each field in the line
                    for (int i = 0; i < fields.Length; i++)
                    {
                        string field = fields[i].Trim();

                        // Do something with the field
                        Console.WriteLine($"Field {i}: {field}");
                    }
                }
            }
        
    
}