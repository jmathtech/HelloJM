using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

// Namespace is the environment in which the entire program will work.
namespace HelloJM
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			Console.Write("Hello World \n"); // output statement
			Console.WriteLine("My name is Jamil Matheny"); // output statement with newline
			Console.Write("Testing 123");

			string dayOfWeek = "Monday";
			string myName = "Dr. H";

			Console.Write($ "Hello World on,  {dayOfWeek}");


		}
	}
}
