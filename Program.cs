using System;
using System.Collections.Generic;
using System.Linq;
using BugTrackerConsole.Models;
using BugTrackerConsole.Services;

class Program
{
    static void Main()
    {
        var bugService = new BugService();

        while (true)
        {
            Console.WriteLine("\n🐞 BugTracker Console");
            Console.WriteLine("1. Add Bug");
            Console.WriteLine("2. View All Bugs");
            Console.WriteLine("3. Filter by Status");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddBug(bugService);
                    break;
                case "2":
                    ViewBugs(bugService.GetBugs());
                    break;
                case "3":
                    FilterByStatus(bugService);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }

    static void AddBug(BugService bugService)
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Severity (Low/Medium/High/Critical): ");
        if (Enum.TryParse(Console.ReadLine(), out Severity severity))
        {
            bugService.AddBug(title, desc, severity);
            Console.WriteLine("✅ Bug added!");
        }
        else
        {
            Console.WriteLine("❌ Invalid severity!");
        }
    }

    static void ViewBugs(List<Bug> bugs)
    {
        foreach (var bug in bugs)
        {
            Console.WriteLine($"ID: {bug.Id} | Title: {bug.Title} | Status: {bug.Status}");
        }
    }

    static void FilterByStatus(BugService bugService)
    {
        Console.Write("Enter status (Open/InProgress/Resolved): ");
        if (Enum.TryParse(Console.ReadLine(), out Status status))
        {
            var filteredBugs = bugService.GetBugs().Where(b => b.Status == status).ToList();
            ViewBugs(filteredBugs);
        }
        else
        {
            Console.WriteLine("❌ Invalid status!");
        }
    }
}