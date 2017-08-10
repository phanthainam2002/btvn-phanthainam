using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Your body weight:");
			var bodyweight = float.Parse(Console.ReadLine ());
			Console.Write ("Your height in cm:");
			var height = float.Parse(Console.ReadLine ());
			var heightinm = height / 100;
			Console.WriteLine (heightinm);
			var bmi = bodyweight/(heightinm*heightinm);
			Console.Write ("Your BMI :");
			Console.WriteLine (bmi);
			if (bmi <16)
			{
				string notice =("Severely underweight");
				Console.WriteLine (notice);

				
			}
			else if (bmi <= 18.5)
			{
				string notice = ("Underweight");
				Console.WriteLine (notice);
			
			}
			else if (bmi <= 25)
			{
				string notice = ("Normal");
				Console.WriteLine (notice);

			}
			else if (bmi <= 30)
			{
				string notice = ("Overweight");
				Console.WriteLine (notice);

			}
			else
			{
				string notice =("Obese");
				Console.WriteLine (notice);
					
			}
		}
	}
}
