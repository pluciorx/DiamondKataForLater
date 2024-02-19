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

            var middleLine = diff > 0 ? c + new string(' ', diff) + c : c.ToString();


            var sb = new StringBuilder(middleLine);
            for (int i = 0; i < diff; i++)
            {
                var line = ((char)((byte)c - i)) + new string('_', diff) + ((char)((byte)c - i))+ Environment.NewLine;
                sb.Insert(0, line);
                sb.Append(line);
                
            }
            response = sb.ToString().Split(Environment.NewLine).ToList();
            
            return response;  
        }
    }
}