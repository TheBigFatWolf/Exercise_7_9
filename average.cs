using System;
public class Average
{
	static void Main()
	{
		double totalSum = 0, value = 0, numCounter = 0, marksAverage = 0;
		string mark = "" ;
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine(); 
		while(mark != "end") // if the mark isn't an "end" then we pass it to double to work with it
		{  
			b = Convert.ToDouble(mark);
			numCounter ++;
			totalSum += b;  // We add the new mark value to the sum
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		if(numCounter != 0)
		{
			marksAverage = totalSum / numCounter;
			Console.WriteLine("The average is {0}.", marksAverage);
		}
		else{
			Console.WriteLine("Invalid mark value.")
		}
	}
}
if(c!=0){
	d=a/c;  //calculate the average
Console.WriteLine("The average is {0}.",d);
}
}
}
