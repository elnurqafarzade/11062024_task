using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.DTOs
{
    public record ProductGetDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public double SalePrice { get; init; }

        public ProductGetDto(int id, string name, double salePrice)
        {
            Id = id;
            Name = name;
            SalePrice = salePrice;
        }
    }
}


