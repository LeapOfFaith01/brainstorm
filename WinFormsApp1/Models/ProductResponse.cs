using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    public class ProductResponse
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float custo { get; set; }
        public float lucro { get; set; }
        public float valor { get; set; }
        public int qnt { get; set; }
        public bool active { get; set; }

        public User? userUpdate { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
