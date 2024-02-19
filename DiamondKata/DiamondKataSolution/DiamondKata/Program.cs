namespace DiamondKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = args[0].ToUpper();
            var validator = new InputValidator();
            if (!validator.IsValidInput(input)) throw new ArgumentException("Invalid argument");

            var generator = new DiamondGenerator();
            
            foreach (var line in generator.GetDiamond(input[0])) Console.WriteLine(line);
        }
    }
}
