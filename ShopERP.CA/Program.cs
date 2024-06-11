using ShopERP.Business.DTOs;
using ShopERP.Business.Services.Implementations;
using ShopERP.Business.Services.Interfaces;

namespace ShopERP.CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService();
              var newProductDto = new ProductCreateDto("Nokia", 3500,4500);
            productService.Create(newProductDto);

            // var product = productService.Get(1);
            //    if (product != null)
            // Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Sale Price: {product.SalePrice}");



            var allproducts = productService.GetAll();
            foreach (var p in allproducts)
            {
                Console.WriteLine($"product id: {p.Id}, name: {p.Name}, sale price: {p.SalePrice}");
            }

            productService.Delete(1);
        }

    }
}
