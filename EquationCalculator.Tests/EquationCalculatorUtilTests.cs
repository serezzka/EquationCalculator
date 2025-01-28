using EquationCalculator;

public class EquationCalculatorUtilTests
{
	[Theory]
	[InlineData("1 2 3", 1, 2, 3)]
	[InlineData("4.5 5.5 6.5", 4.5, 5.5, 6.5)]
	public void ParseCoefficients_ValidInput_ReturnsCorrectTuple(string input, double expectedA, double expectedB, double expectedC)
	{
		var result = EquationCalculatorUtil.ParseCoefficients(input);
		Assert.Equal(expectedA, result.a);
		Assert.Equal(expectedB, result.b);
		Assert.Equal(expectedC, result.c);
	}

	[Fact]
	public void ParseCoefficients_InvalidInput_ThrowsFormatException()
	{
		var input = "1 2";
		Assert.Throws<FormatException>(() => EquationCalculatorUtil.ParseCoefficients(input));
	}
}
