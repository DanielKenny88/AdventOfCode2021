using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Day2
{
	class Part1
	{
		private static string[] instructions = System.IO.File.ReadAllLines("../../../Day2/input.txt");

		public void RunPart1()
		{
			var positionX = 0;
			var positionY = 0;

			foreach (var instruction in instructions)
			{
				var instructionSplit = instruction.Split(" ");

				switch (instructionSplit[0])
				{
					case "forward":
						positionX += Int32.Parse(instructionSplit[1]);
						break;
					case "up":
						positionY -= Int32.Parse(instructionSplit[1]);
						break;
					case "down":
						positionY += Int32.Parse(instructionSplit[1]);
						break;
				}
			}

			Console.WriteLine(positionX * positionY);
		}
	}
}
