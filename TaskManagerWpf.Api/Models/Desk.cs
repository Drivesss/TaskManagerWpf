﻿namespace TaskManagerWpf.Api.Models
{
    public class Desk : CommonObject
    {
        public int Id { get; set; }
        public bool IsPrivite { get; set; }
        public string Columns { get; set; }
        public User AdminId { get; set; }
        public User Admin { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }


    }
}