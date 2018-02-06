using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.Model.Entities
{
    public partial class daily_ticket_type
    {
        public override string ToString()
        {
            return name + $" - {price}KM";
        }
    }
}
