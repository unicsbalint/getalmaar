using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class Apple
    {
        private List<Discount> discounts = new List<Discount>();
        private double kgPrice = 100;

        public void SetKgPrice(double kgPrice)
        {
            this.kgPrice = kgPrice;
        }

        public double GetApplePrice(double amount)
        {
            
            return (amount * kgPrice) * (1-GetBestDiscount(amount));
        }

        public void AddDiscount(Discount discount)
        {
            discounts.Add(discount);
        }

        private double GetBestDiscount(double amount)
        {
            double bestDiscount = 0.0;
            foreach (var item in discounts)
            {
                double discountForCurrentItem = item.getDiscount(amount);
                if (discountForCurrentItem > bestDiscount)
                {
                    bestDiscount = discountForCurrentItem;
                }
            }
            return bestDiscount;
        }
    }
}
