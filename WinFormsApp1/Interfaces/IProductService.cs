using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Interfaces
{
    public interface IProductService
    {
        [Get("/product")]
        public Task<List<ProductResponse>> GetProducts();

        [Get("/product/{id}")]
        public Task<ProductResponse> GetProduct(int id);
        [Post("/product/{id}")]
        public Task<ProductResponse> SaveOrUpdate(int? id,[Body] ProductResponse product);
    }
}
