using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public sealed class CEOPersonel : BeyazYakaPersonel
    {
        public double HisseOranı { get; set; }
        public CEOPersonel(int id) : base(id)
        {
        }
    }
}
