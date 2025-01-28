using EquationCalculator.Interfaces;

namespace EquationCalculator
{
	public class QuadraticEquationSolver : IEquationSolver
	{
		public (double? x1, double? x2) Solve(double a, double b, double c)
		{
			double discriminant = b * b - 4 * a * c;

			if (discriminant > 0)
			{
				double sqrtD = Math.Sqrt(discriminant);
				return ((-b + sqrtD) / (2 * a), (-b - sqrtD) / (2 * a));
			}
			else if (Math.Abs(discriminant) < 1e-10)
			{
				return (-b / (2 * a), null);
			}
			else
			{
				return (null, null);
			}
		}
	}
}
