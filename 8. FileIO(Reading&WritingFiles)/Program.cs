namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\testFiles\";
            Directory.CreateDirectory(path);

            string fileName = "log.txt";
            string filePath = Path.Combine(path, fileName);

            /* Override all text with WriteAlltext
            File.WriteAllText(filePath, "hello world");
            /*


            /* Append text with File.AppendAllText
            File.AppendAllText(filePath, "Log item 1\n");
            File.AppendAllText(filePath, "Log item 2\n");
            File.AppendAllText(filePath, "Log item 3\n");
            File.AppendAllText(filePath, "Log item 4\n");
            */

            /* Read all text with File.ReadAllText
            string contents = File.ReadAllText(filePath);
            */

            bool exists = File.Exists(filePath);
            if (exists)
            {
                string contents = File.ReadAllText(filePath);

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                    Console.WriteLine(line);

                string copyPath = @"E:\testfiles\copiedFile.txt";
                if (!File.Exists(copyPath))
                    File.Copy(filePath, copyPath);
                else
                {
                    Console.WriteLine("File already exists");
                }

                // string renamePath = @"E:\testfiles\renamedFile.txt";
                // File.Move(copyPath, renamePath);

                // File.Delete(@"E\doesntExistatAll.txt");
            }

            // Console.WriteLine(contents);

            Console.ReadLine();
        }
    }
}