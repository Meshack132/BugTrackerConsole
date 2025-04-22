using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerConsole.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Severity Severity { get; set; }
        public Status Status { get; set; }
        public string AssignedDeveloper { get; set; } = "Unassigned";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
