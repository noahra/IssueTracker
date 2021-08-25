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
        public DateTime Created { get; set; }
        public string Project { get; set; }
        public decimal Priority { get; set; }
        public decimal Type { get; set; }
    }
}
