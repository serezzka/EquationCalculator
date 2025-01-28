using EquationCalculator.Interfaces;

namespace EquationCalculator
{
	public class FileInputService : IInputService
	{
		private string _filePath;
		public FileInputService(string filePath)
		{
			_filePath = filePath;
		}

		public IEnumerable<(double a, double b, double c)> GetCoefficients()
		{
			if (!File.Exists(_filePath)) throw new FileNotFoundException("Файл не найден.");
			List<string> strings = File.ReadAllLines(_filePath).ToList();

			foreach (string s in strings) 
			{
				yield return EquationCalculatorUtil.ParseCoefficients(s);
			}
		}
	}


}
