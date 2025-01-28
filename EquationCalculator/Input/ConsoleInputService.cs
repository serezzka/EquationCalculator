using EquationCalculator.Interfaces;

namespace EquationCalculator
{
	public class ConsoleInputService : IInputService
	{
		public IEnumerable<(double a, double b, double c)> GetCoefficients()
		{
			Console.WriteLine("Введите коэффициенты A, B, C через пробел:");
			string input = Console.ReadLine();
			
			yield return EquationCalculatorUtil.ParseCoefficients(input);
		}
	}
}
