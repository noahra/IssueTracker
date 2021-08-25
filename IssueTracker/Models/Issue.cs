using System;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
    public class Issue
    {
        public Issue()
        {
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Submitter { get; set; }
        public string AssignedDev { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime Created { get; set; } = System.DateTime.Today;
        public string Project { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
    }
}
