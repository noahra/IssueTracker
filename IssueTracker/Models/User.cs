using System;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

