using ShopERP.Business.DTOs;
using ShopERP.Business.Services.Interfaces;
using ShopERP.Core.Models;
using ShopERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Services.Implementations
{
    public class ProductService : IProductService
    {
        public void Create(ProductCreateDto productCreateDto)
        {
       
            {
                var product = new Product
                {
                    Name = productCreateDto.Name,
                    CostPrice = productCreateDto.CostPrice,
                    SalePrice = productCreateDto.SalePrice

                };
                ShopERPDatabase.Products.Add(product);
                Console.WriteLine($"{product.Name} ugurla elave edildi");
            }
        }

        public void Delete(int id)
        {
            ShopERPDatabase.Products.RemoveAll(p => p.Id == id);
            Console.WriteLine("silindi");
        }

        public ProductGetDto Get(int id)
        {
                 var product = ShopERPDatabase.Products.Find(p => p.Id == id);

                   return product != null ? new ProductGetDto(product.Id, product.Name, product.SalePrice) : null;
          }


            public List<ProductGetDto> GetAll()
        {
            return ShopERPDatabase.Products.ConvertAll(p => new ProductGetDto(p.Id, p.Name, p.SalePrice));
        }
    }
}
