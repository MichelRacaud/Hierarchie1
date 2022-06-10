using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie1
{
    public interface ICar : IRoadVehicle
    {
        int MaxPassengerCount();
    }
}
