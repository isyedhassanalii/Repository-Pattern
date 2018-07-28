using App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
   public class WhatsNewRepository : IRepository
    {
        DataContext data = new DataContext();
        public void Add(WhatsNew p)
        {
            data.WhatsNews.Add(p);
            data.SaveChanges();
        }

        public void Edit(WhatsNew p)
        {
            data.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public WhatsNew FindById(int Id)
        {
            var result = (from r in data.WhatsNews where r.Id == Id select r).FirstOrDefault();
            return (result);
        }

        public IEnumerable<WhatsNew> GetAll()
        {
            return data.WhatsNews;
        }

        public void Remove(int Id)
        {
            WhatsNew w = data.WhatsNews.Find(Id);
            data.WhatsNews.Remove(w);
            data.SaveChanges();

        }
    }
}
