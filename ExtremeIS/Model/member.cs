using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.Model.Entities
{
    public partial class member
    {
        public override string ToString()
        {
            return $"{first_name} {last_name} -{member_id}";
        }
    }
}
