using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
    public class DiamondGenerator
    {
        public List<string> GetDiamond(char c) 
        {
            var response = new List<string>();
            int positionA = 65;
            int position = c;
            int diff = position - positionA;
            
            if (diff == 0 )
            {
                response.Add("A");
                return response; ;
            }
            if (diff % 2 == 0) { diff = diff + 1; }
            var middleLine = c + new string(' ', diff) + c;           

            var sb = new StringBuilder(middleLine+Environment.NewLine);

            for (int i = 1; i < diff; i++)
            {                
                var sb2 = new StringBuilder( new string(' ', middleLine.Length));
                char letter = (char)(position - i);
                sb2[i] = letter;
                sb2[^(i+1)] = letter;

                var line = sb2.ToString();

                sb.Insert(0, line + Environment.NewLine);
                sb.Append(line + Environment.NewLine);                
            }
            response = sb.ToString().TrimEnd().Split(Environment.NewLine).ToList();
            
            return response;  
        }
    }
}