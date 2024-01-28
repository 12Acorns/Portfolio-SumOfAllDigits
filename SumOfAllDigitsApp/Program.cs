using System.Text.RegularExpressions;

namespace SumOfAllDigitsApp
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			var _output = SumOfAllDigits("1234");
			Console.WriteLine(_output);
		}

		private static int SumOfAllDigits(string _inputDigits)
		{
			var _checkExpression = OnlyInts();

			if (!_checkExpression.IsMatch(_inputDigits))
			{
				return -1;
			}

			return _inputDigits.Sum(_t => (int)(_t - '0'));
		}

		[GeneratedRegex("^[0-9]+$")]
		private static partial Regex OnlyInts();
	}
}
