using AsyncUsageExample.DataAccess.Contracts;
using AsyncUsageExample.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncUsageExample.DataAccess.DataManager
{
    public class SampleEntityManager : IDataRepository<SampleEntity1>
    {

            readonly SampleDbContext _sampleDbContext;

            public SampleEntityManager(SampleDbContext context)
            {
                _sampleDbContext = context;
            }
            
            public async Task<IEnumerable<SampleEntity1>> GetSampleEntities()
            {
                return await _sampleDbContext.SampleEntities.ToListAsync();
            }

            public async Task<SampleEntity1> Get(int id)
            {
                var sampleEntity1 = await _sampleDbContext.SampleEntities.FindAsync(id);
                return sampleEntity1;
        }

            public async Task Add(SampleEntity1 entity)
            {
                _sampleDbContext.SampleEntities.Add(entity);
                await _sampleDbContext.SaveChangesAsync();

        }

            public async Task Update(SampleEntity1 incomingEntity, SampleEntity1 entity)
            {
                entity.Field1 = incomingEntity.Field1;
                entity.Field2 = incomingEntity.Field2;
                entity.Field3 = incomingEntity.Field3;
                entity.Field4 = incomingEntity.Field4;

                await _sampleDbContext.SaveChangesAsync();
            }

            public async Task Delete(SampleEntity1 entity)
            {
                _sampleDbContext.Remove(entity);
                await _sampleDbContext.SaveChangesAsync();
            }
        }
    }


