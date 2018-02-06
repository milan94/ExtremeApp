using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.Model
{
    class gear_detailed
    {
        public int gear_id { get; set; }
        public String name { get; set; }
        public int gear_category_id { get; set; }
        public String gear_category_name { get; set; }
        public int manufacturer_id { get; set; }
        public String manufacturer_name { get; set; }
        public String description { get; set; }
        public int size_id { get; set; }
        public String size_value { get; set; }
        public int quantity { get; set; }
        public int available { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
