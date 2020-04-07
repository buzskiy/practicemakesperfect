using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsyncUsageExample.DataAccess.Contracts;
using AsyncUsageExample.DataAccess.Repository;

namespace AsyncUsageExample.Controllers
{
    [Route("api/entities")]
    [ApiController]
    public class SampleEntity1Controller : ControllerBase
    {
        private readonly IDataRepository<SampleEntity1> _repository;

        public SampleEntity1Controller(IDataRepository<SampleEntity1> repository)
        {
            _repository = repository;
        }

        
        [HttpGet]
        public async Task<IEnumerable<SampleEntity1>> GetEntities()
        {
            return await _repository.GetSampleEntities();
        }

        [HttpGet("{id}")]
        public async Task<SampleEntity1> GetSingleEntity(int id)
        {
            return await _repository.Get(id);
        }

        [HttpPost]
        public async Task CreateEntity(SampleEntity1 entity)
        {
            await _repository.Add(entity);
        }

        [HttpPatch("{id}")]
        public async Task UpdateEntity(int id, SampleEntity1 updatedEntity)
        {
            var entityToUpdate = await _repository.Get(id);
            await _repository.Update(updatedEntity, entityToUpdate);
        }


        [HttpDelete("{id}")]
        public async Task DeleteEntity(int id)
        {
            var entityToRemove = await _repository.Get(id);
            await _repository.Delete(entityToRemove);
        }

    }
}
