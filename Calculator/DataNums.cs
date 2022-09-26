using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public  class DataNums
    {
        public DataNums(double firstNum, double secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }
        public DataNums()
        {

        }
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }
        
    }
}
