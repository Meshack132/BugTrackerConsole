using BugTrackerConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerConsole.Services
{
    public class BugService
    {
        private List<Bug> _bugs;
        private int _nextId = 1;

        public BugService()
        {
            _bugs = FileService.LoadBugs();
            _nextId = _bugs.Count > 0 ? _bugs.Max(b => b.Id) + 1 : 1;
        }

        public void AddBug(string title, string description, Severity severity)
        {
            _bugs.Add(new Bug { Id = _nextId++, Title = title, Description = description, Severity = severity });
            FileService.SaveBugs(_bugs);
        }

        public List<Bug> GetBugs() => _bugs;

        // Add Update, Delete, Filter methods...
    }
}
