namespace Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input all of the available products");
            string[] products = Console.ReadLine().Split().ToArray();
            Console.WriteLine("Please input their respective quantities (should match the count of products)");
            int[] quantities = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Please input their respective prices (should match the count of products)");
            double[] prices = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine("Which product would you like to see?");
            string answer = Console.ReadLine();
            bool matchFind = false;
            do
            {
                for (int i = 0; i < products.Length; i++)
                {

                    if (answer == products[i])
                    {
                        matchFind = true;
                    }
                    {

                    }
                    if (matchFind)
                    {
                        Console.WriteLine($"The total price of {products[i]} (quanity({quantities[i]}) * single price({prices[i]})) = {quantities[i] * prices[i]}");
                        matchFind = false;
                        break;
                    }
                }
                if (!matchFind)
                {
                    Console.WriteLine("The product isnt in the storage");
                }
                Console.WriteLine("Would you like another product? (type \"done\" to end)");
                answer = Console.ReadLine();
            } while (answer != "done");
        }
    }
}
