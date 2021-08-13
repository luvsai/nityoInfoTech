//Author  K lavanya Sai kumar


using System;

class Time
{

	// function to find the power of number n
	static void displaytime(int seconds)
	{

		//get hours
		int hrs = (int)(Math.Floor((float)(seconds / 3600)));

		//get minutes 
		seconds = (int)seconds % 3600;
		int mins = (int)(Math.Floor((float)(seconds / 60)));

		//get remaining seconds

		int secs = (int) seconds % 60;

		//format the display time

		string output = String.Format("{0}:{1}:{2}", hrs, mins, secs);

		Console.WriteLine(output);



	}

	//Main program
	public static void Main()
	{
	
		int seconds = Convert.ToInt32(Console.ReadLine());

		displaytime(seconds);

	}
}



