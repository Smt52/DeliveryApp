namespace DeliveryApp
{
    class Food
    {
        private string _name;
        private double _price;
        private string _description;
        private string _restaurant;

        public Food(string name, double price, string description, string restaurant)
        {
            _name = name;
            _price = price;
            _description = description;
            _restaurant = restaurant;
        }

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public string GetRestaurant()
        {
            return _restaurant;
        }
    }
}
