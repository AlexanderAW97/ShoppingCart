namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {

        public static void Test()
        {
            Product melk = new Product("Tine lettmelk", 15);
            Product brød = new Product("Grans Grovbrød", 32);
            Cart cart = new Cart();
            cart.Buy(melk, 2);
            cart.Buy(brød, 2);
            cart.Buy(melk, 3);
            cart.ShowCart();
        }

    }
}


