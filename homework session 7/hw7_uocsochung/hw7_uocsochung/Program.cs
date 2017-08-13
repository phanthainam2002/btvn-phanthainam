using System;
using System.Collections.Generic;
using System.Collections;

namespace hw7_uocsochung
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> number_list = new List<int> ();
			number_list.Add (50);
			number_list.Add (200);
			number_list.Add (10);
			number_list.Add (150);
			number_list.Sort();
			List<int> uocso_cua_so_dau_tien = new List<int> ();
			List<int> uocso_list = new List<int> ();
			for (int b = 1; b <= number_list[0]; b++) 
			{
				if (number_list[0] % b == 0) 
				{
					uocso_cua_so_dau_tien.Add (b);
				}
					
			}
			for (int i = 1; i < 4; i++)
			{
				for (int a = 1; a < number_list [i]; a++) 
				{
					if (number_list[i] % a == 0)
					{
						for (int c = 0; c < uocso_cua_so_dau_tien.Count ; c++) 
						{
							if (a == uocso_cua_so_dau_tien [c]) 
							{
								uocso_list.Add (a);

							}
						}

					}

				}
			}
			Console.Write ("Ươc sô chung lơn nhât la : ");
			int uocsolonnhat = 0;
				for (int i = 0; i < uocso_list.Count; i++) 
			{
				if (uocso_list[i] > uocsolonnhat)
				{
					uocsolonnhat = uocso_list[i];
				}

			}
			Console.WriteLine(uocsolonnhat);
		}
	}
}
