using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        Guid Add(Entity entity);
        Guid Adit(Entity entity);
        Guid Remove(Guid IdPersona);
        IEnumerable<Entity> GetAll(); 
    }
}
