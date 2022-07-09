using System;
using System.Collections.Generic;

namespace Computor
{
    class Program
    {
        static void Main(string[] args)
        {
			List<List<double>> test = new List<List<double>>() {
				new List<double>{ 1, 3, 8},
				new List<double>{ 1, 2, 4},
				new List<double>{ 1, 2, 85} };
			List<List<double>> test1 = new List<List<double>>() {
				new List<double>{ 1, 2, 8},
				new List<double>{ 1, 2, 4},
				new List<double>{ 1, 2, 85} };
			Matrix m1 = new Matrix(test), m2 = new Matrix(test1);

			Console.WriteLine(m1 - m2);
		}
    }
}
