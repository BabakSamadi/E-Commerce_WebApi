using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Common;
using Microsoft.VisualBasic;

namespace E_Commerce.Domain.Entities
{                       
    //Cart product سبد خرید 
    public class Cart : BaseEntity
    {
        public ICollection<CartItem> CartItem { get; set; }
    }
}
