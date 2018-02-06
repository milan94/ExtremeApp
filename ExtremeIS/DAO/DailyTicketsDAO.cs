using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.DTO;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class DailyTicketsDAO
    {
        public static Boolean insert(daily_ticket newDailyTicket)
        {
            int result = 0;

            using (var db = new ExtremeAppContext())
            {
                db.daily_ticket.Add(newDailyTicket);
                result = db.SaveChanges();
            }
            return result > 0 ? true : false;

        }


        public static List<daily_ticket_type> getAllTypes()
        {
            using (var db = new ExtremeAppContext())
            {
                var allTypes =
                    (from at in db.daily_ticket_type
                     select at).ToList();

                return allTypes;

            }
        }
        public static List<DailyTicketDTO> getDailyTicketsInDateRange(DateTime dateFrom,
            DateTime dateTo)
        {
            dateTo = dateTo.AddDays(1);
            using (var db = new ExtremeAppContext())
            {
                var dailyTickets =
                    (from dt in db.daily_ticket
                     where dt.create_date >= dateFrom.Date
                     where dt.create_date <= dateTo.Date
                     select new DailyTicketDTO
                     {
                         person_name = "Gost",//dt.person_name
                         issuer_user_name = dt.user_account.username,
                         price =  dt.price,
                         create_date = dt.create_date
                     }).ToList();

                return dailyTickets;

            }
        }
    }
}
