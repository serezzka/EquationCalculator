using Calculator;
using Xunit;

namespace EquationCalculator.Tests
{
	public class EquationSolverTests
	{
		[Theory]
		[InlineData(1, -3, 2, 2, 1)]
		[InlineData(1, -2, 1, 1, null)]
		[InlineData(1, 0, 1, null, null)]
		public void SolveQuadraticEquation_ValidInputs_ReturnsExpectedResults(
			double a, double b, double c, double? expectedX1, double? expectedX2)
		{
			var result = EquationSolver.SolveQuadraticEquation(a, b, c);

			Assert.Equal(expectedX1, result.x1);
			Assert.Equal(expectedX2, result.x2);
		}

		[Fact]
		public void SolveQuadraticEquation_ZeroCoefficientA_ThrowsException()
		{
			Assert.Throws<DivideByZeroException>(() =>
				EquationSolver.SolveQuadraticEquation(0, 1, 2));
		}
	}

}