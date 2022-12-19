using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 666; i >= 1;)
			{
				string row1 = new string('*', i);
				string row2 = new string(' ', i);
				Console.WriteLine(row1 +row2);
			}
		}
	}
}
