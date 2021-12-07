using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day3
{
	class Part1
	{
		private static string[] diagnostic = System.IO.File.ReadAllLines("../../../Day3/input.txt");
		public string gamma = "";
		public string epsilon = "";

		public void RunPart1()
		{

			List<string> firstBits = new List<string>();
			List<string> secondBits = new List<string>();
			List<string> thirdBits = new List<string>();
			List<string> fourthBits = new List<string>();
			List<string> fifthBits = new List<string>();
			List<string> sixthBits = new List<string>();
			List<string> seventhBits = new List<string>();
			List<string> eighthBits = new List<string>();
			List<string> ninethBits = new List<string>();
			List<string> tenthBits = new List<string>();
			List<string> eleventhBits = new List<string>();
			List<string> twelfthBits = new List<string>();

			foreach (var binary in diagnostic)
			{
				firstBits.Add(binary[0].ToString());
				secondBits.Add(binary[1].ToString());
				thirdBits.Add(binary[2].ToString());
				fourthBits.Add(binary[3].ToString());
				fifthBits.Add(binary[4].ToString());
				sixthBits.Add(binary[5].ToString());
				seventhBits.Add(binary[6].ToString());
				eighthBits.Add(binary[7].ToString());
				ninethBits.Add(binary[8].ToString());
				tenthBits.Add(binary[9].ToString());
				eleventhBits.Add(binary[10].ToString());
				twelfthBits.Add(binary[11].ToString());
			}

			CalculateBit(firstBits);
			CalculateBit(secondBits);
			CalculateBit(thirdBits);
			CalculateBit(fourthBits);
			CalculateBit(fifthBits);
			CalculateBit(sixthBits);
			CalculateBit(seventhBits);
			CalculateBit(eighthBits);
			CalculateBit(ninethBits);
			CalculateBit(tenthBits);
			CalculateBit(eleventhBits);
			CalculateBit(twelfthBits);

			foreach (var bit in gamma)
			{
				var character = bit.ToString();

				if (character == "0")
				{
					epsilon += "1";
				}
				else
				{
					epsilon += "0";
				}
			}

			var gammaResult = Convert.ToInt32(gamma, 2);
			var epsilonResult = Convert.ToInt32(epsilon, 2);

			var result = gammaResult * epsilonResult;

			Console.WriteLine(result);
		
		}

		public int CountInstances(string searchTerm, List<string> list)
		{
			var matchQuery = from word in list
							 where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
							 select word;
			return matchQuery.Count();
		}

		public void AddToGamma(int countZero, int countOne)
		{
			if (countZero > countOne)
			{
				gamma += "0";
			}
			else
			{
				gamma += "1";
			}
		}

		public void CalculateBit(List<string> list)
		{
			int zeros = CountInstances("0", list);
			int ones = CountInstances("1", list);
			AddToGamma(zeros, ones);
		}
	}
}
