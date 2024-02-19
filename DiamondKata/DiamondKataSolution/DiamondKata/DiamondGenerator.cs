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
            var middleLine = c + new string(' ', diff) + c;
            int len = middleLine.Length;

            var sb = new StringBuilder(middleLine+Environment.NewLine);

            for (int i = 1; i <= diff; i++)
            {                
                var sb2 = new StringBuilder( new string(' ', len));
                char letter = (char)(position - i);
                sb2[i] = letter;
                sb2[^(i+1)] = letter;

                var line = sb2.ToString() + Environment.NewLine;

                sb.Insert(0, line);
                sb.Append(line);                
            }
            response = sb.ToString().Split(Environment.NewLine).ToList();
            
            return response;  
        }
    }
}