using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.DTOs
{
    public record ProductCreateDto
    {
        public string Name { get; init; }
        public double CostPrice { get; init; }
        public double SalePrice { get; init; }

        public ProductCreateDto( string name, double sellPrice, double costPrice)
        { 
            {
                Name = name;
                SalePrice = sellPrice;
                CostPrice = costPrice;

            }
        }
    }
}
