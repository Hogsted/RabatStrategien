using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabatStrategien.Model
{
    internal class PriceCalculator
    {
        private IDiscountStrategy discountStrategy;
        public PriceCalculator(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }
        public decimal calculatePrice(decimal subtotal)
        {
            return discountStrategy.applyDiscount(subtotal);
        }
    }
}
