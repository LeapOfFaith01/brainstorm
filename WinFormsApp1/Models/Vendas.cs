using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Models
{
    class Vendas
    {
        public int id { get; set; }
        public float total { get; set; }
        public Method method { get; set; }
        public DateTime createdAt { get; set; }
        public CartResponse cart { get; set; }

        public User? user { get; set; }

        public float discount { get; set; }
    }

    public enum Method
    {
        DINHEIRO,
        CREDITO,
        DEBITO,
        PIX
    }
}
