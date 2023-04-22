

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(400);

            Wholesale wholesale = new Wholesale(product);
            Buyer buyer = new Buyer(product);

            product.ChangePrice(320);
            product.ChangePrice(280);
        }
    }
}
