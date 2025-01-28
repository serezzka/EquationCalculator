using EquationCalculator.Interfaces;

namespace EquationCalculator
{
	public class ConsoleOutputService : IOutputService
	{
		public void WriteMessage(string message) => Console.WriteLine(message);

		public void WriteResults(double a, double b, double c, (double? x1, double? x2) result)
		{
			Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
			if (result.x1.HasValue && result.x2.HasValue)
				Console.WriteLine($"Корни: x1 = {result.x1:F2}, x2 = {result.x2:F2}");
			else if (result.x1.HasValue)
				Console.WriteLine($"Корень: x = {result.x1:F2}");
			else
				Console.WriteLine("Нет действительных корней.");
		}
	}
}
