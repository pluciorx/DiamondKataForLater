using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            var sb = new StringBuilder();
            
            for (int i = positionA; i <= position; i++)
            {
                var str = new string(' ', i);
                str += (char)positionA + i;
                str += new string(' ', i);
                response.Add(str);                
            }

            for (int i = position-1; i > positionA; i--)
            {
                var str = new string(' ', i);
                str += (char)positionA + i;
                str += new string(' ', i);
                response.Add(str);
            }

           
            return response;  
        }
    }
}