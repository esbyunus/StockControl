namespace whilebasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the stock quantity: ");
            int stockQuantity = Convert.ToInt32(Console.ReadLine());

            while (stockQuantity > 0)
            {
                Console.WriteLine($"There are {stockQuantity} units of {productName} in stock. ");
                Console.WriteLine("Do you want to buy the product? (Yes/No)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("How many units do you want to buy?");
                    int purchasedQuantity = Convert.ToInt32(Console.ReadLine());
                    if (purchasedQuantity <= stockQuantity)
                    {
                        stockQuantity -= purchasedQuantity;
                        Console.WriteLine($"{purchasedQuantity} units of {productName} purchased. Remaining stock : {stockQuantity}");
                    }
                    else
                    {
                        Console.WriteLine("There is not enough product in stock");
                    }
                }
                else if (answer == "no")
                {
                    Console.WriteLine("End of shopping.");
                    break;
                }
                else
                {
                    Console.WriteLine("Please anwer 'Yes' or 'No'. ");
                }
                
                if (stockQuantity == 0)
                {
                    Console.WriteLine("There is no product in stock");
                }
            }
        }
    }
}