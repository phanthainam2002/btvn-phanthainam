using System;

namespace hw7_converter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int given_number = 298673;
			int converted_number;
			int devided_number;
			while (true) 
			{
				converted_number = (given_number % 2);
				devided_number = (given_number / 2);
				Console.Write (converted_number);
				given_number = devided_number;
				if (devided_number == 0)
				{
					break;
					
				}

			}

		}
	}
}
