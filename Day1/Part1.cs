using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day1
{
	class Part1
	{
		private static string[] depths = System.IO.File.ReadAllLines("../../../Day1/input.txt");
		
		public void RunPart1()
		{
			var counter = 0;

			for (int i = 0; i < depths.Length; i++)
			{
				var currentDepth = Int32.Parse(depths[i]);
				var nextDepth = 0;

				if (i + 1 < depths.Length)
				{
					nextDepth = Int32.Parse(depths[i + 1]);
				}

				if (nextDepth > currentDepth)
				{
					counter++;
				}
			}

			Console.WriteLine(counter);
		}
		

	}
}
