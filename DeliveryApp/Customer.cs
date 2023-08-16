namespace DeliveryApp
{
    class Customer : ILogin,ISignUp
    {
        protected string _username;
        protected string _password;
        protected string _email;
        protected string _address;

        public Customer(string username, string password, string email, string address)
        {
            _username = username;
            _password = password;
            _email = email;
            _address = address;
        }

        public string Login()
        {



            return "User login was succesful";

        }

        public string SignUp()
        {


            return "Signup succesful";
        }
    }
}
