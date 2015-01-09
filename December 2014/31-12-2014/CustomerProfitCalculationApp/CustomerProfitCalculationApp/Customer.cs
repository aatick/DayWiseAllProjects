namespace CustomerProfitCalculationApp
{
    internal class Customer
    {
        private string id;
        private string name;
        private string address;
        public Account CustomerAccount { get; set; }
        public Customer(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}