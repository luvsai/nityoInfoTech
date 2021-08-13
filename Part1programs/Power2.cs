using System;

class Power2
{

	// function to find the power of number n
	static bool isPowerOfTwo(int n)
	{
		if (n == 0)
			return false;

		while (n != 1)
		{
			if (n % 2 != 0)
				return false;

			n = n / 2;
		}
		return true;
	}

	//Main program
	public static void Main()
	{
		string T = Console.ReadLine();
		int ntest = Convert.ToInt32(T);
		//Looping through test cases
		for (int i = 0;i < ntest;i++) {
			string tc = Console.ReadLine();
			
			int testcase = Convert.ToInt32(tc);

			Console.WriteLine(isPowerOfTwo(testcase) ? "True" : "False");

		}

	}
}



