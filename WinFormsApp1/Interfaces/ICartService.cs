using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Interfaces
{
    interface ICartService
    {
        [Get("/cart/{id}")]
        Task<CartResponse> GetCart(int id);

        [Post("/cart/{id}")]
        Task AddToCart(int id, int productId);

        [Post("/test/{method}")]
        Task Checkout([Body] CompositeResponse body,Models.Method method);

        [Delete("/cart/{id}")]
        Task RemoveOfCart(int id, int itemId);

        [Put("/cart/{id}")]
        Task FinishCart(int id, string method);

        [Post("/cart/{id}/{quantity}")]
        Task updateQuantity(int id, int quantity);

        [Get("/stats")]
        Task<List<Vendas>> GetAllFinishedSells();
    }

    public class CompositeResponse
    {
        public List<Items> items { get; set; }
        public User user { get; set; }

        public float discount { get; set; }
    }
}
