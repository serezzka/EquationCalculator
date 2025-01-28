using EquationCalculator.Interfaces;

namespace EquationCalculator
{
	public class Program
	{
		static void Main()
		{
			Console.WriteLine("Выберите источник данных (1 - консоль, 2 - файл):");
			string? choice = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(choice))
				throw new InvalidOperationException("Введена пустая строка или null.");

			IInputService inputService;
			if (choice == "2")
			{
				Console.WriteLine("Укажите путь к файлу");
				string? filePath = Console.ReadLine();

				inputService = new FileInputService(filePath);
			}
			else
			{
				inputService = new ConsoleInputService();
			}

			var calculator = new Calculator(inputService, new ConsoleOutputService(), new QuadraticEquationSolver());
			calculator.Calculate();
		}
	}
}
