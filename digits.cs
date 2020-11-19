using System;
public class Digits
{
    public static void Main()
    {
        int dOne = 0, dTwo = 0, dThree = 0, dMore = 0, input = 0;
        string number = "";

        Console.Write("Insert a number (tap end to finish): ");
        number = Console.ReadLine();
        while(number != "end")
        {
            input = Convert.ToInt32(number);
            if (input != 0)
            {
                if (input/10 == 0)
                {
                    dOne ++;  // it only has one digit
                }
                else if (input/100 == 0)
                {
		            dTwo ++;  // the number has 2 digits
                }
                else if (input/1000 == 0)
                {
                    dThree ++;  // the number has 3 digits
                }
                else
                {
                    dMore ++;  // the number has more than 3 digits
                }
            }
            else{
                Console.WriteLine("'0' is not a valid enter.");
            }
            Console.Write("Insert another number (tap end to finish): ");
            number = Console.ReadLine();
        }
        Console.WriteLine("Quantity of numbers who has one, two, three or more digits:");
        Console.WriteLine("One: {0}, Two: {1}, Three: {2}, More: {3}", dOne, dTwo, dThree, dMore);
    }
}
