using System;
using System.Collections.Generic;
using System.Text;

using static Computor.MathUtils;

namespace Computor
{
    class Complex
    {
		public double Real { get; private set; }
		public double Imag { get; private set; }

		public Complex()
		{
		}

		public Complex(double real, double imag = 0)
		{
			this.Real = real;
			this.Imag = imag;
		}

		public Complex(Complex other)
		{
			this.Real = other.Real;
			this.Imag = other.Imag;
		}

		public static Complex operator +(Complex lhs, Complex rhs)
		{
			return new Complex(lhs.Real + rhs.Real, lhs.Imag + rhs.Imag);
		}

		public static Complex operator -(Complex left, Complex rigth)
		{
			return new Complex(left.Real - rigth.Real, left.Imag - rigth.Imag);
		}

		public static Complex operator *(Complex left, Complex right)
		{
			double a = (left.Real * right.Real) - (left.Imag * right.Imag);
			double b = (left.Real * right.Imag) + (left.Imag * right.Real);
			return new Complex(a, b);
		}

		public static Complex operator /(Complex left, Complex right)
		{
			double den = Pow2(right.Real) + Pow2(right.Imag);
			double a = ((left.Real * right.Real) + (left.Imag * right.Imag)) / den;
			double b = ((right.Real * left.Imag) - (left.Real * right.Imag)) / den;
			return new Complex(a, b);
		}

		public override string ToString()
		{
			string res = Real.ToString();
			if (this.Imag != 0)
			{
				res += this.Imag > 0 ? " + " : " - ";
				res += Abs(this.Imag).ToString() + "i";
			}
			return res;
		}
	}
}
