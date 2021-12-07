using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day3
{
	class Part2
	{
		private static string[] diagnostic = System.IO.File.ReadAllLines("../../../Day3/input.txt");
		public string gamma = "";
		public string epsilon = "";


		public void RunPart2()
		{
			string mostCommon;
			string leastCommon;
			List<string> mostResultsList = diagnostic.ToList<string>();
			List<string> leastResultsList = diagnostic.ToList<string>();

			

			for (int i = 0; i < diagnostic[0].Length; i++)
			{
				var mostZerosCount = 0;
				var mostOnesCount = 0;
				var leastZerosCount = 0;
				var leastOnesCount = 0;
				List<string> mostFiltered = new List<string>();
				List<string> leastFiltered = new List<string>();

				//loop through remaining most results
				foreach (var binary in mostResultsList)
				{
					var value = binary[i].ToString();
					if (value == "0")
					{
						mostZerosCount++;
					}
					else if (value == "1")
					{
						mostOnesCount++;
					}
				}

				//loop through remaining least results
				foreach (var binary in leastResultsList)
				{
					var value = binary[i].ToString();
					if (value == "0")
					{
						leastZerosCount++;
					}
					else if (value == "1")
					{
						leastOnesCount++;
					}
				}

				//Find most common and least common in that position
				if (mostOnesCount >= mostZerosCount)
				{
					mostCommon = "1";
				}
				else
				{
					mostCommon = "0";
				}

				if(leastOnesCount >= leastZerosCount)
				{
					leastCommon = "0";
				}
				else
				{
					leastCommon = "1";
				}

				//Add valid binary to new list
				foreach (var binary in mostResultsList)
				{
					var value = binary[i].ToString();
					if (value == mostCommon)
					{
						mostFiltered.Add(binary);
					}
				}

				foreach (var binary in leastResultsList)
				{
					var value = binary[i].ToString();

					if (value == leastCommon)
					{
						leastFiltered.Add(binary);
					}
				}

				//Set new list for looping again
				mostResultsList.Clear();
				mostResultsList = mostFiltered;
				
				leastResultsList.Clear();
				leastResultsList = leastFiltered;
				
			}

			var oxygenGenRating = mostResultsList[0];
			var co2scrubberRating = "111000100010"; //last 2 loops overwrites this
			var oxyDecimal = Convert.ToInt32(oxygenGenRating, 2);
			var co2Decimal = Convert.ToInt32(co2scrubberRating, 2);

			Console.WriteLine(oxyDecimal * co2Decimal);
		}


	}
}
