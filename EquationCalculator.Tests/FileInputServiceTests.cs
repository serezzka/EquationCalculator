using EquationCalculator;

public class FileInputServiceTests
{
	[Fact]
	public void GetCoefficients_ValidFile_ReturnsCorrectCoefficients()
	{
		var filePath = "123.txt";
		File.WriteAllLines(filePath, new[] { "1 2 3", "4 5 6" });

		var service = new FileInputService(filePath);
		var coefficients = service.GetCoefficients();

		Assert.Equal(new List<(double, double, double)> { (1, 2, 3), (4, 5, 6) }, coefficients);

		File.Delete(filePath);
	}

	[Fact]
	public void GetCoefficients_FileNotFound_ThrowsFileNotFoundException()
	{
		var service = new FileInputService("456.txt");
		Assert.Throws<FileNotFoundException>(() => service.GetCoefficients().ToList());
	}
}
