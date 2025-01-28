namespace EquationCalculator
{
	public static class EquationCalculatorUtil
	{
		public static (double a, double b, double c) ParseCoefficients(string input)
		{
			input = input.Replace('.', ',');
			var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			if (parts.Length != 3) throw new FormatException("Ожидалось три коэффициента.");
			return (double.Parse(parts[0]), double.Parse(parts[1]), double.Parse(parts[2]));
		}
	}
}
