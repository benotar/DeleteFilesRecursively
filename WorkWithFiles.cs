﻿namespace HW_15_01_2024;

public class WorkWithFiles
{
    private string _dirPath;
    public WorkWithFiles(string dirPath)
        => _dirPath = dirPath;

    void DeleteFile()
    {
        if (!Directory.Exists(_dirPath))
        {
            throw new ArgumentException("Folder not found!");
        }

        string[] files = Directory.GetFiles(_dirPath);


    }
}
