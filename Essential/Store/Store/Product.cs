namespace Store
{
    class Product
    {

        public string NameProd { get; set; }
        private string NameofStore { get; set; }
        private int Price { get; set; }
        public Product(string _nameProd, string _nameofStore, int _price)
        {
            NameProd = _nameProd;
            NameofStore = _nameofStore;
            Price = _price;
        }
    }
}
