using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationCalculator.Interfaces
{
	public interface IEquationSolver
	{
		(double? x1, double? x2) Solve(double a, double b, double c);
	}
}
