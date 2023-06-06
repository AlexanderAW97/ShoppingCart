using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Cart
    {
        private List<int> Count { get; set; } 
        private List<Product> Products { get; set; }


        public Cart()
        {
            Count = new List<int>();
            Products = new List<Product>();

        }


        public void Buy(Product product, int amount)
        {
            if (Products.Contains(product))
            {
                var productLine = Products.IndexOf(product);
                Count[productLine] += amount;

            }
            else
            {
                Products.Add(product);
                Count.Add(amount);
            }

            Console.WriteLine($"Du har kjøpt {amount} stk. {product.Name}");
        }


        public void ShowCart()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("Handelvognen er tom");
                return;
            }
            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                var product = Products[i];
                var count = Count[i];
                var price = product.Price;
                var productLinePrice = price * count;
                Console.WriteLine($" {count} stk. {product.Name} a kr {price} = {productLinePrice}");
                totalPrice += productLinePrice;
            }
            Console.WriteLine($"Totalpris: {totalPrice}");
        }



       
        

    }

}
