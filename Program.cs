namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Account() 
        {
            Console.Write("Enter Your ID Number :");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your First Name:");
            string Firstname = Console.ReadLine();

            Console.Write("Enter Your Last Name:");
            string Lastname = Console.ReadLine();

            Console.Write("Enter Your Initial Balance:");
            float InitialAmount = float.Parse(Console.ReadLine());
        }
    }
}
