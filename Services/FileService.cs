using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using BugTrackerConsole.Models;

public static class FileService
{
    private static readonly string _filePath = "bugs.json";

    public static void SaveBugs(List<Bug> bugs)
    {
        string json = JsonConvert.SerializeObject(bugs, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    public static List<Bug> LoadBugs()
    {
        if (!File.Exists(_filePath)) return new List<Bug>();

        string json = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<Bug>>(json) ?? new List<Bug>();
    }
}