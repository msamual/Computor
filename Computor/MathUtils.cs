using System;
using System.Collections.Generic;
using System.Text;

namespace Computor
{
    class MathUtils
    {
		public static double Abs(double n)
		{
			return n < 0 ? -n : n;
		}

		public static double Pow2(double n)
		{
			return n * n;
		}
	}
}
