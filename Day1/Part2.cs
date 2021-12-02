using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day1
{
	class Part2
	{
		private static string[] depths = System.IO.File.ReadAllLines("../../../Day1/input.txt");

		public void RunPart2()
		{
			var counter = 0;

			for (int i = 0; i < depths.Length; i++)
			{
				if (i+3 < depths.Length)
				{
					var depth1 = Int32.Parse(depths[i]);
					var depth2 = Int32.Parse(depths[i+1]);
					var depth3 = Int32.Parse(depths[i+2]);
					var depth4 = Int32.Parse(depths[i+3]);

					var sumOfFirstSet = depth1 + depth2 + depth3;
					var sumOfSecondSet = depth2 + depth3 + depth4;

					if (sumOfSecondSet > sumOfFirstSet)
					{
						counter++;
					}
				}
			}

			Console.WriteLine(counter);
		}
	}
}
