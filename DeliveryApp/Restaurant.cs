

namespace DeliveryApp
{
    class Restaurant : Customer
    {
        private Dictionary<Food, double> _menu;
        private string _brand;

        public Restaurant(string brand, string username, string password, string email, string addres) : base(username, password, email, addres)
        {

            _brand = brand;
        }

        public void AddDishToMenu(Food food, double price)
        {
            food.SetPrice(price);
            _menu.Add(food, food.GetPrice());
        }

        public Food GetFood()
        {
            Console.WriteLine("Enter the name of dish:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price of your dish:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ingredients:");
            string description = Console.ReadLine();

            Food dish = new Food(name, price, description, _brand);

            return dish;
        }
    }
}
