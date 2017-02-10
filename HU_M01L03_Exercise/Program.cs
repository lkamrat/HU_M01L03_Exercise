 namespace HU_M01L03_Exercise

{
    class Program
    {
        static void Main(string[] args)
        {
            // Define random double numbers (we need the avarage & multiplying of those numbers) from user input
            System.Console.WriteLine("Enter number 01");
            double numOne = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter number 02");
            double numTwo = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter number 03");
            double NumThree = double.Parse(System.Console.ReadLine());

            // Print the random numbers avarage
            System.Console.WriteLine("The avarage is: {0}", (numOne + numTwo + NumThree) / 3);

            // Print the random numbers multiplying
            System.Console.WriteLine("The multiplying is: {0}", numOne * numTwo * NumThree);

            // Define rectangle length and hight based on user input
            System.Console.WriteLine("Enter rectangle length:");
            double length = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter rectangle hight");
            double hight = double.Parse(System.Console.ReadLine());

            // Calculate rectangle whitespace based on user input
            System.Console.WriteLine("The rectangle whitespace is: {0}", length * hight);

            // Define circle radius based on user input
            System.Console.WriteLine("Enter circle radius");
            double radius = double.Parse(System.Console.ReadLine());

            double pi = 3.14;
            System.Console.WriteLine("Pi will always be {0}",pi);

            // Calculate circle whitespace and diameter based on user input
            System.Console.WriteLine("Circle whitespace based on the radius you provided is: {0}", (radius * radius) * pi);
            System.Console.WriteLine("Circle diameter based on the radius you provided is: {0}", radius * pi * 2);

            // Define movie length in minutes
            System.Console.WriteLine("Enter movie length in minutes");
            double movieMin = double.Parse(System.Console.ReadLine());

            // Calculate movie length in hours based on movie length in minutes using Casting and Convert
            double movieMinExpNum = (movieMin / 60); // x.xxxxxx
            int movieHrExpNum = (int)movieMinExpNum; // This will give the number of hours after Explicit Casting
            double movieMinNum = (movieMin % 60); // This will give the number of minutes
            string hrString = System.Convert.ToString(movieHrExpNum) + " hour and"; // Converting the explicit hour value to string
            string minString = System.Convert.ToString(movieMinNum) + " minutes"; // Converting the minutes number to string
            System.Console.WriteLine("The movie length is: {0}:{1}", movieHrExpNum, movieMinNum); // This will show result based on numbers
            System.Console.WriteLine("The movie length is: {0} {1}", hrString, minString); // This will show result based on converting integer and double to string

            
        }
    }
}
