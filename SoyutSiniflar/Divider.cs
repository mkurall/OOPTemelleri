using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutSiniflar
{
    public class Divider : BaseCalculator
    {
        public Divider(int left, int right) : base(left, right)
        {
        }

        public override int Calculate(int left, int right)
        {
            return left / right;
        }
    }
}
