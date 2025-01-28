namespace Calculator
{
	public class Calculator
	{
		public static void Main(string[] args)
		{
			OutputService.WriteMessage("Введите коэффициенты A, B, C в строку через пробел. Если хотите считать данные из файла, просто нажмите Enter");

			string input = InputService.ReadLineFromConsole();

			if (string.IsNullOrWhiteSpace(input))
			{
				SolveEquationFromFile();
			}
			else
			{
				SolveEquationFromConsole(input);
			}
		}

		private static void SolveEquationFromConsole(string input)
		{
			try
			{
				var (a, b, c) = InputService.ParseCoefficients(input);
				var result = EquationSolver.SolveQuadraticEquation(a, b, c);

				OutputService.WriteResultsToConsole(a, b, c, result);
			}
			catch (Exception ex)
			{
				OutputService.WriteMessage($"Ошибка: {ex.Message}");
			}
		}

		private static void SolveEquationFromFile()
		{
			OutputService.WriteMessage("Введите путь к файлу с коэффициентами:");
			string filePath = InputService.ReadLineFromConsole();

			if (!File.Exists(filePath))
			{
				OutputService.WriteMessage("Файл не найден.");
				return;
			}

			try
			{
				var equations = InputService.ReadEquationsFromFile(filePath);

				foreach (var eq in equations)
				{
					var result = EquationSolver.SolveQuadraticEquation(eq.a, eq.b, eq.c);
					OutputService.WriteResultsToConsole(eq.a, eq.b, eq.c, result);
				}
			}
			catch (Exception ex)
			{
				OutputService.WriteMessage($"Ошибка: {ex.Message}");
			}
		}
	}
}
