
using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementBook.Models
{
    public class Book 
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int TotalPage { get; set; }
    }
}