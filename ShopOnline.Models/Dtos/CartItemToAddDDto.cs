using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CartItemToAddDDto
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}
