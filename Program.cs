using System;
using System.Collections.Generic;
using System.Linq;

namespace PE1
{
    class Program
    {
		static void Main(string[] args)
		{
			//sum of all numbers under 100 that are multiples of 3 and 5

			int i;

			for (i = 0; 1 < 100; i++) ;
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					List<int> list = new List<int>() { i };

					int total = list.Sum();
				}
			}
		}
    }
}
