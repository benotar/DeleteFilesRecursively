namespace HW_15_01_2024;

public class WorkWithFiles
{
    private readonly string _dirPath;
    public WorkWithFiles(string dirPath) 
        => _dirPath = dirPath;
    private static void DeleteFilesRecursively(string dirPath)
    {
        try
        {
            if (!Directory.Exists(dirPath))
            {
                throw new ArgumentException("Folder not found!");
            }

            string[] files = Directory.GetFiles(dirPath);

            HashSet<string> uniqueContent = new HashSet<string>();

            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);

                if (!uniqueContent.Add(fileContent))
                {
                    File.Delete(file);
                }
            }

            string[] subDirectories = Directory.GetDirectories(dirPath);

            foreach (string subDirectory in subDirectories)
            {
                DeleteFilesRecursively(subDirectory);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void DeleteFile()
    {
        DeleteFilesRecursively(_dirPath);
    }
}
