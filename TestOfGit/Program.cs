using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOfGit
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Привет Git!");

			Petr petr = new Petr();
			Console.WriteLine(petr);
			Console.WriteLine(petr);
			Vasya vasya = new Vasya();
			Console.WriteLine(vasya);

			Console.ReadLine();
		}
	}
}
