using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CronNET;
using System.Data.Entity;

namespace TaskScheduler
{
    class MinuteJob : CronNET.BaseJob
    {
        public override CronExpression Cron
        {
            get
            {
                return CronNET.CronExpression.EveryMinute;
            }
        }
        public override void Execute()
        {
            DemoDBEntities db = new DemoDBEntities();

            var query = from persons in db.Person select persons;

            foreach (var item in query)
            {
                DateTime DateNow = DateTime.Today;
                int Age = DateNow.Year - item.Birth_Date.Year;
                if (DateNow < item.Birth_Date.AddYears(Age))
                {
                    Age--;
                }

                if (item.IdentityID == item.IdentityID && Age > 30)
                {
                    item.CancelDate = DateTime.Now;
                    item.Status = "inActive";
                    db.Entry(item).State = EntityState.Modified;

                }
            }
            db.SaveChanges();
            Console.WriteLine("Dublicated Record Is Canceled");
            Console.ReadKey();
            
            

        }
    }
}
