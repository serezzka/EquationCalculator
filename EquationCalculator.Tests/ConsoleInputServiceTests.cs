using EquationCalculator;

public class ConsoleInputServiceTests
{
	[Fact]
	public void GetCoefficients_ValidInput_ReturnsCorrectCoefficients()
	{
		var input = "1 2 3";
		var consoleInputService = new ConsoleInputService();
		using (var reader = new StringReader(input))
		{
			Console.SetIn(reader);
			var coefficients = consoleInputService.GetCoefficients();
			Assert.Equal((1, 2, 3), coefficients.First());
		}
	}

	[Fact]
	public void GetCoefficients_EmptyInput_ThrowsInvalidOperationException()
	{
		var consoleInputService = new ConsoleInputService();
		using (var reader = new StringReader(""))
		{
			Console.SetIn(reader);
			Assert.Throws<InvalidOperationException>(() => consoleInputService.GetCoefficients().ToList());
		}
	}
}