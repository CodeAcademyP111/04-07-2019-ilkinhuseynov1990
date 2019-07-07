using System;

namespace Homework
{
		public static class Extension
		{
			public static int MyLastindexof(this string str, string sim)
			{
				int pos = -1;

				for (int i = 0; i < str.Length; i++)
				{
					if (str[i] == sim[0])
					{
						pos = i;
						pos++;
					}
				}
				return pos;
			}



			public static void SimpleNumber(this int num)
			{
				string result = "";


				if (num % 2 != 0)
				{
					result = "Sade ededdir";
				}
				else
				{
					result = "Murekkeb ededdir";
				}

				Console.WriteLine(result);


			}
		}
	
}
