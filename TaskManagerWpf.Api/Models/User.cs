﻿namespace TaskManagerWpf.Api.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationOnDate { get; set; }
        public DateTime LastLoginOnDate { get; set; }
        public byte[] Photo { get; set; }    
    }
}