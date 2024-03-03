using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public interface IEntity
    {
        int Id { get; set; }

        int CreatedByUser { get; set; }
    }
}
