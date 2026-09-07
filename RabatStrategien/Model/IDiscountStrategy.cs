using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabatStrategien.Model
{
    internal interface IDiscountStrategy
    {
        decimal applyDiscount(decimal subtotal);
    }
}
