namespace Topic_7._2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "", name;
            int number = 10;

            //Console.WriteLine("Press enter to start the countdown!");
            //input = Console.ReadLine();
            //for (int i = 10; i >= 0; i = i - 1)
            //{
            //    Console.WriteLine(i + ".");
            //    if (i == 0)
            //        Console.WriteLine("Blast off!");
            //}

            //for (int i = -10; i <= 10; i = i + 2)
            //{
            //    Console.WriteLine(i + "\t" + (i * i));
            //}
            
            Console.WriteLine("Enter your name and I will display it ten times, unless its aldworth.");
            name = Console.ReadLine().ToLower();
            for (int i = 1; i <= number; i = i + 1)
            {
                if (name == "aldworth")
                    number = 5;
                Console.WriteLine(i + ". " + name);
            }

        }
    }
}
