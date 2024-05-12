namespace Ex_w_2_I_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string firstName, secondName, phone,email;

            int growth;
            
            double weight;

            Console.WriteLine("Write your firstname");
            firstName = (Console.ReadLine());

            Console.WriteLine("Write your secondName");
            secondName = (Console.ReadLine());

            Console.WriteLine("How tall are you");
            growth = int.Parse(Console.ReadLine());

            Console.WriteLine("How much you weigh");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Write your phpne  number");
            phone = (Console.ReadLine());

        }
    }
}
