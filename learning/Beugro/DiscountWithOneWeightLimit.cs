using learning;

namespace learning
{
    public class DiscountWithOneWeightLimit : Discount
    {
        private double weightLimit;
        private double discount;

        public DiscountWithOneWeightLimit(double weightLimit, double discount)
        {
            this.weightLimit = weightLimit;
            this.discount = discount;
        }
        public override double getDiscount(double amount)
        {
            if (amount > weightLimit)
            {
                return discount;
            }
            return 0.0;
        }
    }
}