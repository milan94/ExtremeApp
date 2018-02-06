using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeIS.DTO
{
    class MemberAttendanceDTO
    {
        public int member_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime check_in_time { get; set; }
    }
}
