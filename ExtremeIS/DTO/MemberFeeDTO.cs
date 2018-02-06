using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.DTO
{
    class MemberFeeDTO
    {
        public int member_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int month { get; set; }
        public DateTime payingDate { get; set; }
        public string issuer_user_name { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
    }
}
