using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ws17_service.dal
{
    public class Institutions_repo : IRepo<institution>
    {
        private lora_sofdDataContext context;

        public Institutions_repo(string constr)
        {
            this.context = new lora_sofdDataContext(constr);
        }

        public IQueryable<institution> Query => context.institutions.AsQueryable();

        public long Add(institution e)
        {
            throw new NotImplementedException();
        }

        public void Delete(institution e)
        {
            throw new NotImplementedException();
        }

        public void Update(institution e)
        {
            throw new NotImplementedException();
        }
    }
}
