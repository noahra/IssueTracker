using System;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
    public class Comment
    {
        public Comment()
        {
        }

        public int Id { get; set; }
        public string Project { get; set; }
        public string DeveloperName { get; set; }
        public string Message { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = System.DateTime.Today;
    }
}