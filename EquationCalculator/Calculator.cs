using EquationCalculator.Interfaces;

namespace EquationCalculator
{
	public class Calculator
	{
		private readonly IInputService _inputService;
		private readonly IOutputService _outputService;
		private readonly IEquationSolver _equationSolver;

		public Calculator(IInputService inputService, IOutputService outputService, IEquationSolver equationSolver)
		{
			_inputService = inputService;
			_outputService = outputService;
			_equationSolver = equationSolver;
		}

		public void Calculate()
		{
			SolveFromInput();
		}

		private void SolveFromInput()
		{
			try
			{
				foreach (var (a, b, c) in _inputService.GetCoefficients())
				{
					var result = _equationSolver.Solve(a, b, c);
					_outputService.WriteResults(a, b, c, result);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(($"Ошибка: {ex.Message}"));
			}
		}
	}
}
