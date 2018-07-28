using App.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    class InitializeDb: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.WhatsNews.Add(new WhatsNew {

                Id = 1,
                CurrentDate = new DateTime(2017, 5, 15, 13, 45, 0),
                heading = "sajdhjasdn",
                description="sajdhsjand"


            });

            context.WhatsNews.Add(new WhatsNew
            {

                Id = 2,
                CurrentDate = new DateTime(2017, 5, 15, 13, 45, 0),
                heading = "sadvashvdh",
                description = "wqeytwqyteyt"


            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
