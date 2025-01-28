namespace Calculator
{
	public static class InputService
	{
		public static string ReadLineFromConsole()
		{
			return Console.ReadLine();
		}
		public static (double a, double b, double c) ParseCoefficients(string input)
		{
			input = input.Replace('.', ','); // если есть точку, меняем их на запятую
			var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

			if (parts.Length != 3)
				throw new FormatException("Ожидалось три коэффициента: A, B, C.");

			return (
				double.Parse(parts[0]),
				double.Parse(parts[1]),
				double.Parse(parts[2])
			);
		}

		public static (double a, double b, double c)[] ReadEquationsFromFile(string filePath)
		{
			var lines = File.ReadAllLines(filePath);
			var equations = new (double a, double b, double c)[lines.Length];

			for (int i = 0; i < lines.Length; i++)
			{
				equations[i] = ParseCoefficients(lines[i]);
			}

			return equations;
		}
	}
}
