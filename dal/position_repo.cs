using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ws17_service.dal
{
    public class Position_repo : IRepo<position>
    {
        private lora_sofdDataContext context;
        public Position_repo(string constr)
        {
            this.context = new lora_sofdDataContext(constr);
        }

        public List<string> Cprs => context.positions.Select(p => p.person_ref).ToList<string>();

        public IQueryable<position> Query => throw new NotImplementedException();

        public long Add(position e)
        {
            throw new NotImplementedException();
        }

        public void Delete(position e)
        {
            throw new NotImplementedException();
        }

        public void Update(position e)
        {
            throw new NotImplementedException();
        }
    }
}
