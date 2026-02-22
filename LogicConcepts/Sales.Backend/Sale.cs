namespace Sales.Backend
{
    public class Sale
    {
        private int _amount;
        private const double _price = 650000;


        public Sale(int amount)
        {
            Amount = amount;
        }

        public int Amount
        {
            get => _amount;
            set => _amount = SaveQuantity(value);
        }

        private double Price
        {
            get => _price;
        }

        public double SubTotal
        {
            get => CalculateSubtotal();
        }

        public double FinalPrice
        {
            get => CalculateFinalPrice();
        }

        public override string ToString()
        {
            return $"Número de escritorios: {Amount}\nEl valor a pagar es: {FinalPrice:C}";
        }

        private int SaveQuantity( int amount)
        {
            return amount;
        }

        private double CalculateSubtotal()
        {
            return Amount * Price;
        }

        private double CalculateFinalPrice()
        {
            if (Amount < 5)
            {
                return SubTotal - (SubTotal * 0.10);
            }
            else if (Amount < 10)
            {
                return SubTotal - (SubTotal * 0.20);
            }
            else
            {
                return SubTotal - (SubTotal * 0.40);
            }
        }

    }
}
