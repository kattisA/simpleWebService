using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://support.microsoft.com/en-us/help/308359/how-to-write-a-simple-web-service-by-using-visual-c-net

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			localhost.Service myMathService = new localhost.Service();
			Console.Write("2 + 4 = {0}", myMathService.Add(2, 4));
		}
	}
}
