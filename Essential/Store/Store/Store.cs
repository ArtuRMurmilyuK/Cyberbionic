using System.Collections.Generic;

namespace Store
{
    class Store : Product
    {
        List<Product> product = new List<Product>();//arrays products  

        public void Add(Product prod)
        {
            product.Add(prod);
        }
    }
}