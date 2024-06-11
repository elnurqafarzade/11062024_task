using ShopERP.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Business.Services.Interfaces
{
    public interface IProductService
    {
        public ProductGetDto Get(int id);
        public List<ProductGetDto> GetAll();
        public void Create(ProductCreateDto productCreateDto);
        public void Delete(int id);

    }
}
