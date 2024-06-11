using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopERP.Core.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        private int _counter;
        public BaseModel()
        {
            Id = ++_counter;
        }
    }
}
