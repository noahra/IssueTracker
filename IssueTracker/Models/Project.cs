using System;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
    public class Project
    {
        public Project()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = DateTime.Today;
        public string Description { get; set; }
    }
}