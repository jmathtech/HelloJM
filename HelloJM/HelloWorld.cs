using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/* 
Name: Jamil Matheny
Date: 10/05/2020
Class: CIS214
 */


// Namespace is the environment in which the entire program will work.
namespace HelloJM
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			Console.Write("Hello World \n"); // output statement without a break
			Console.WriteLine("My name is Jamil Matheny"); // output statement with newline
			Console.Write("Testing 123");

			//formatting text
			Console.WriteLine("\n{0}\n{1}\n{2}", "Working with", "text in", "C#...");

			string dayOfWeek = "Monday";   // 'string' is a primitive datatype // 'dayOfWeek' is the variable which is stored memory that can be changed. 
			string myName = "Jamil Matheny";


			//string interpolation
			Console.Write($"Hello World on,  {dayOfWeek} oh no another one"); // '$' is formatted text string w/ the variable
			Console.WriteLine($" with, {myName} !!!");


		}
	}
}
