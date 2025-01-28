using Xunit;
using EquationCalculator;

public class QuadraticEquationSolverTests
{
	[Theory]
	[InlineData(1, -3, 2, 2.0, 1.0)]
	[InlineData(1, 2, 1, -1.0, null)]
	[InlineData(1, 0, 1, null, null)]
	public void Solve_ValidCoefficients_ReturnsCorrectRoots(double a, double b, double c, double? expectedX1, double? expectedX2)
	{
		var solver = new QuadraticEquationSolver();
		var result = solver.Solve(a, b, c);
		Assert.Equal(expectedX1, result.x1);
		Assert.Equal(expectedX2, result.x2);
	}
}

