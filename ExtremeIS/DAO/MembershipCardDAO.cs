using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class MembershipCardDAO
    {

        public static int insert(membership_card membership_card)
        {
            int result = 0;

            using (var db = new ExtremeAppContext())
            {
                db.membership_card.Add(membership_card);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
