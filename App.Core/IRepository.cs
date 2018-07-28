using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
   public interface IRepository
    {
        void Add(WhatsNew p);
        void Edit(WhatsNew p);
        void Remove(int Id);

        IEnumerable<WhatsNew> GetAll();

        WhatsNew FindById(int Id);
    }
}
