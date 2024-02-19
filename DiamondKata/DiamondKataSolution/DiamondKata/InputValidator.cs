
namespace DiamondKata
{
    public class InputValidator
    {

        public bool IsValidInput(string input)
        {                    
            if (string.IsNullOrEmpty(input)) return false;  
            if (input.Length >1) return false;
            return Char.IsAsciiLetter(input[0]);
        }
    }
}
