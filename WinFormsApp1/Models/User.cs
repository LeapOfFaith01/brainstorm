using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    public class User
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public Type type  { get; set; }
    }
    
    public enum Type
    {
        ADMIN,
        EMPLOYEE
    }
}
