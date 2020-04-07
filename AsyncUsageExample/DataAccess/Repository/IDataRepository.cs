using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncUsageExample.DataAccess.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetSampleEntities();
        Task<TEntity> Get(int id);
        Task Add(TEntity entity);
        Task Update(TEntity dbEntity, TEntity entity);
        Task Delete(TEntity entity);
    }
}
