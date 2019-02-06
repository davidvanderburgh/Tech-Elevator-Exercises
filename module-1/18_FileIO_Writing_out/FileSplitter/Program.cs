using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where is the input file (please include the path to the file)? ");
            string filePath = Console.ReadLine();
            if (!filePath.Contains("input.txt"))
            {
                filePath = Path.Combine(filePath, "input.txt");
            }

            Console.Write("How many lines of text (max) should there be in the split files? ");
            bool enteredNumberCorrectly = int.TryParse(Console.ReadLine(), out int linesPerFile);

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found at {filePath}");
            }
            else if (!enteredNumberCorrectly || linesPerFile < 1)
            {
                Console.WriteLine("Invalid lines number entered");
            }
            else
            {
                CreateFiles(filePath, linesPerFile);
            }

            Console.ReadLine();

        }

        static void CreateFiles(string inputFilePath, int linesPerFile)
        {
            try
            {            
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    int fileCounter = 1;
                    string outputPath = Path.GetDirectoryName(inputFilePath); //eliminates "input.txt"

                    Console.WriteLine("\n**GENERATING OUTPUT **\n");

                    while (!sr.EndOfStream)
                    {
                        using (StreamWriter sw = new StreamWriter(Path.Combine(outputPath, $"input-{fileCounter}.txt")))
                        {
                            Console.WriteLine($"Generating input-" + fileCounter + ".txt");
                            for (int i = 1; i <= linesPerFile; i++)
                            {
                                string lineEntry = sr.ReadLine();
                                if (!string.IsNullOrEmpty(lineEntry))
                                {
                                    sw.WriteLine(lineEntry);
                                }
                            }
                            fileCounter++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
