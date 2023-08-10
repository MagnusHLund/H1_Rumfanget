namespace H1_Rumfanget
{
    internal class Program
    {
        static void Main()
        {
            // Creates variables 
            float height, width, length;

            // Explains what the user is doing
            Console.WriteLine("Calculate volume of a box!");

            // using try catch to avoid crashes, if user does an invalid input
            try
            {
                // Writes in the console what the user has to do 
                // the user then inputs their values for height, width and lenght

                Console.WriteLine("Please input height");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please input width");
                width = float.Parse(Console.ReadLine());

                Console.WriteLine("Please input length");
                length = float.Parse(Console.ReadLine());

                // Writes the result in the console
                Console.WriteLine($"The volume of your box is {height * width * length}");
            }
            catch
            {
                // Throws an error, due to user input being invalid
                Console.WriteLine("ERR: Please only write valid numbers");
            }
        }
    }
}