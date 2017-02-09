 namespace HU_M01L03_Exercise

{
    class Program
    {
        static void Main(string[] args)
        {
            // Define double numbers (we need the avarage & multiplying of those numbers) from user input
            System.Console.WriteLine("Enter number 01");
            double numOne = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter number 02");
            double numTwo = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter number 03");
            double NumThree = double.Parse(System.Console.ReadLine());

            // Print the numbers avarage
            System.Console.WriteLine("The avarage is: {0}", (numOne + numTwo + NumThree) / 3);

            // Print the numbers multiplying
            System.Console.WriteLine("The multiplying is: {0}", numOne * numTwo * NumThree);

            // Define rectangle length and hight based on user input
            System.Console.WriteLine("Enter rectangle length:");
            double length = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter rectangle hight");
            double hight = double.Parse(System.Console.ReadLine());

            // Calculate rectangle whitespace based on user input
            System.Console.WriteLine("The rectangle whitespace is: {0}", length * hight);

        }
    }
}
