using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Core.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
    }
}
