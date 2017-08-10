using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int a = 0; a < 15; a++) 
			{
				
			
				for (int i = 0; i < 20; i++) 
				{
					Console.Write("*X");
					
				}
				Console.WriteLine ();
				for (int e = 0; e < 20; e++) 
				{
					Console.Write ("X*");

				}
				Console.WriteLine ();
			}
		}
	}
}
