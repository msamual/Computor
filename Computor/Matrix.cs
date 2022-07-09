using System;
using System.Collections.Generic;
using System.Text;

namespace Computor
{
    class Matrix
    {
		public List<List<double>> M { get; set; }
		public int SizeX { get; private set; }
		public int SizeY { get; private set; }

		public double this[int y, int x]
		{
			get
			{
				return this.M[y][x];
			}
		}

		public Matrix()
		{
		}

		public Matrix(List<List<double>> m)
		{
			this.M = m;
			this.SizeY = m.Count;
			this.SizeX = this.SizeY != 0 ? m[0].Count : 0;
		}

		public Matrix(Matrix other)
		{
			this.M = other.M;
		}

		public static Matrix operator +(Matrix left, Matrix right)
		{
			if (left.SizeX != right.SizeX | left.SizeY != right.SizeY)
				throw new ApplicationException(
					$"matrices of different dimensions [{left.SizeY}:{left.SizeX}] " +
					$"and [{right.SizeY}:{right.SizeX}]. i dont know what addicting it");
			List<List<double>> res = new List<List<double>>();
			List<double> tmp;
			for (int i = 0; i < left.SizeY; ++i)
			{
				tmp = new List<double>();
				for (int j = 0; j < left.SizeX; ++j)
				{
					tmp.Add(left.M[i][j] + right.M[i][j]);
				}
				res.Add(tmp);
			}
			return new Matrix(res);
		}

		public static Matrix operator -(Matrix left, Matrix right)
		{
			if (left.SizeX != right.SizeX | left.SizeY != right.SizeY)
				throw new ApplicationException(
					$"matrices of different dimensions [{left.SizeY}:{left.SizeX}] " +
					$"and [{right.SizeY}:{right.SizeX}]. i dont know what subtract it");
			List<List<double>> res = new List<List<double>>();
			List<double> tmp;
			for (int i = 0; i < left.SizeY; ++i)
			{
				tmp = new List<double>();
				for (int j = 0; j < left.SizeX; ++j)
				{
					tmp.Add(left.M[i][j] - right.M[i][j]);
				}
				res.Add(tmp);
			}
			return new Matrix(res);
		}

		public static Matrix operator *(Matrix left, Matrix right)
		{
			if (left.SizeY != right.SizeX)
				throw new ApplicationException($"Incompatible matrixes [{left.SizeY}:{left.SizeX}] " +
					$"and [{right.SizeY}:{right.SizeX}] i dont know what multiply their");
			return new Matrix();
		}


		public override string ToString()
		{
			string res = "";

			foreach (var line in this.M)
			{
				res += "[ ";
				foreach (var n in line)
					res += n.ToString() + ", ";
				res = res.Trim(new char[] { ',', ' ' });
				res += " ]\n";
			}
			return res;
		}

	}
}
