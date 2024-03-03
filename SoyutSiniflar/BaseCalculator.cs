using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutSiniflar
{
    public abstract class BaseCalculator
    {
        public int LeftOperand { get; set; }
        public int RightOperand { get; set; }

        public BaseCalculator(int left, int right)
        {
            LeftOperand = left;
            RightOperand = right;
        }
        //Bu metot soyut
        public abstract int Calculate(int left, int right);

        public override string ToString()
        {
            return "Result = " + Calculate(LeftOperand, RightOperand);
        }
    }
}
