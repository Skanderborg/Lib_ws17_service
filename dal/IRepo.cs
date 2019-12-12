using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ws17_service.dal
{
    public interface IRepo<entity>
    {
        IQueryable<entity> Query { get; }
        long Add(entity e);
        void Delete(entity e);
        void Update(entity e);
    }
}
