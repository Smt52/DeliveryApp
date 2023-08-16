

namespace DeliveryApp
{
    class Orderer : Customer
    {
        private double _balance;
        private Dictionary<Food, double> _cart;

        public Orderer(string username, string password,string email,string addres) : base(username, password, email, addres)
        {
            _balance = 0;

        }

        public double GetBalance()
        {
            return _balance;
        }

        public void SetBalance(double value)
        {
            _balance = value;
        }

        public void AddToCart(Food food)
        {
            if (food.GetRestaurant() != food.GetRestaurant())
            {
                Console.WriteLine("You cannot order different restaurants.");
                return;
            }
            _cart.Add(food,food.GetPrice());
        }

        public void ClearCart()
        {
            _cart.Clear();
        }

        
    }
}
