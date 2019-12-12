using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ws17_service.dal
{
    public class Unic_usernames_repo : IRepo<unic_username>
    {
        private lora_sofdDataContext context;
        public Unic_usernames_repo(string constr)
        {
            this.context = new lora_sofdDataContext(constr);
        }
        public IQueryable<unic_username> Query => context.unic_usernames.AsQueryable();

        public long Add(unic_username e)
        {
            context.unic_usernames.InsertOnSubmit(e);
            context.SubmitChanges();
            return e.system_id;
        }

        public void Delete(unic_username e)
        {
            context.unic_usernames.DeleteOnSubmit(e);
            context.SubmitChanges();
        }

        public void Update(unic_username e)
        {
            context.SubmitChanges();
        }
    }
}
