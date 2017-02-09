 namespace HU_M01L03_Exercise

{
    class Program
    {
        static void Main(string[] args)
        {
            // Define double numbers (we need the avarage of those numbers) from user input
            Console.WriteLine("Enter number 01");
            double numOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02");
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 03");
            double NumThree = double.Parse(Console.ReadLine());

            // Print the numbers
            Console.WriteLine("One: {0}, Two {1}, Three {2}", numOne, numTwo, NumThree);

            // Print the numbers avarage
            Console.WriteLine("The avarage is: {0}", (numOne + numTwo + NumThree) / 3);


        }
    }
}
