using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.DTO
{
    class DailyTicketDTO
    {
        public string person_name { get; set; }
        public string issuer_user_name { get; set; }
        public decimal price { get; set; }
        public DateTime create_date { get; set; }
    }
}
