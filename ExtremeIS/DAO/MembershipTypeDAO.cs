﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class MembershipTypeDAO
    {
        public static List<String> getAll()
        {

            using (var db = new ExtremeAppContext())
            {
                var allMembershipTypes =
                    (from e in db.membership_type
                     select e.name).ToList();

                return allMembershipTypes;

            }
        }

        public static membership_type getById(int id)
        {
            using (var db = new ExtremeAppContext())
            {
                var membershipType =
                    (from e in db.membership_type where e.membership_type_id==id
                     select e).First();

                return membershipType;

            }
        }
    }
}
