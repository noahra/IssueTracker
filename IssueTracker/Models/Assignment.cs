using System;
namespace IssueTracker.Models
{
    public class Assignment
    {
        public Assignment()
        {
        }

        public int Id { get; set; }
        public string AssignedProject { get; set; }
        public string Role { get; set; }
        public string DeveloperName { get; set; }
    }
}
