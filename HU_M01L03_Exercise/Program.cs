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
            System.Console.WriteLine("The avarage is {0}", (numOne + numTwo + NumThree) / 3);

            // Print the random numbers multiplying
            System.Console.WriteLine("The multiplying is {0}", numOne * numTwo * NumThree);

            // Define rectangle length and hight based on user input
            System.Console.WriteLine("Enter rectangle length:");
            double length = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter rectangle hight");
            double hight = double.Parse(System.Console.ReadLine());

            // Calculate rectangle whitespace based on user input
            System.Console.WriteLine("The rectangle whitespace is {0}", length * hight);

            // Define circle radius based on user input
            System.Console.WriteLine("Enter circle radius");
            double radius = double.Parse(System.Console.ReadLine());

            double pi = 3.14;
            System.Console.WriteLine("Pi will always be {0}",pi);

            // Calculate circle whitespace and diameter based on user input
            System.Console.WriteLine("Circle whitespace based on the radius you provided is {0}", (radius * radius) * pi);
            System.Console.WriteLine("Circle diameter based on the radius you provided is {0}", radius * pi * 2);

            // Define movie length in minutes
            System.Console.WriteLine("Enter movie length in minutes");
            int movieMin = int.Parse(System.Console.ReadLine());

            // Calculate movie length in hours based on movie length in minutes
            int movieHrNum = (movieMin / 60);
            int movieMinNum = (movieMin % 60);
            System.Console.WriteLine("The movie length is: {0}:{1}", movieHrNum, movieMinNum); // This will show result based on numbers
            System.Console.WriteLine("The movie length is " + movieHrNum + " hour, " + movieMinNum + " minutes"); // This will show results with text included

            // Show user number input in words without using Convert.ToString
            System.Console.WriteLine("Enter a four digit number");
            int fourDigitNum = int.Parse(System.Console.ReadLine());

            int thousands = fourDigitNum / 1000;
            int remainder = fourDigitNum % 1000;
            int hundreds = remainder / 100;
            remainder = remainder % 100;
            int tens = remainder / 10;
            remainder = remainder % 10;
            int units = remainder; 
                        
            System.Console.WriteLine("The number is {0} thousands, {1} hundreds, {2} tens, {3} ones", thousands, hundreds, tens, units);
            System.Console.WriteLine("The number is " + thousands + " thousands, " + hundreds + " hundreds, " + tens + " tens, " + units + " ones ");

            // Doing calculations on 2-digits number
            System.Console.WriteLine("Enter 2 digits number");
            int twoDigitNum = int.Parse(System.Console.ReadLine());

            int firstDigit = twoDigitNum / 10;
            int secondDigit = twoDigitNum % 10;

            System.Console.WriteLine("The sum of the 2-digits number is {0}", firstDigit + secondDigit);

        }
    }
}
