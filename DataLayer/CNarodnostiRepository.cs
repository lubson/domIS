using Model;
using System.Data.Entity;

namespace DataLayer
{
    public class CNarodnostRepository : Repository<CNarodnost>
    {
                public CNarodnostRepository(DbContext context) : base(context) { }
    }
}
