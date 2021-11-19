using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    public class CartResponse
    {
        public int? id { get; set; }
        public bool active { get; set; }
        public DateTime createdAt { get; set; }
        public List<Items> items { get; set; }
    }

    public class Items 
    {
        //public int? id { get; set; }
        public float valor { get; set; }
        public int quantidade { get; set; }

        //public int? cart_id { get; set; }
        public ProductResponse product { get; set; }
    }
}
