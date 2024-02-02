using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IFactoryDetailsRepository
    {
        public Task<FactoryDetailsDTO> CreateFactoryDetails(FactoryDetailsDTO factoryDetails);
        public Task<FactoryDetailsDTO> UpdateFactoryDetails(int fdId, FactoryDetailsDTO factoryDetails);
        public Task<int> DeleteFactoryDetailsSF(int fdId);
        public Task<IEnumerable<FactoryDetailsDTO>> GetAllFactoryDetails(int sfID);
        public Task<FactoryDetailsDTO> GetFactoryDetails(int fdId);
    }
}
