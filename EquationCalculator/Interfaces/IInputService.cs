using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationCalculator.Interfaces
{
	public interface IInputService
	{
		IEnumerable<(double a, double b, double c)> GetCoefficients();
	}
}
