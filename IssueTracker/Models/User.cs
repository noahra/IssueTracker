using System;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
    public class User
    {
        public User()
        {
            Admin = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Admin { get; set; }
    }
}

