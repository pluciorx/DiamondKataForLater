namespace DiamondKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validator = new InputValidator();
            if (!validator.IsValidInput(args[0])) throw new ArgumentException("Invalid argument");
            
            var res = generator.
        }
    }
}
