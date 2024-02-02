using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IManufacturerRepository
    {
        public Task<ManufacturerDTO> CreateDefectType(ManufacturerDTO manufacturer);
        public Task<ManufacturerDTO> UpdateManufacturer(int Id, ManufacturerDTO manufacturer);
        public Task<int> DeleteManufacturer(int mID);
        public Task<IEnumerable<ManufacturerDTO>> GetAllManufacturer();
        public Task<ManufacturerDTO> GetManufacturer(int Id);

    }
}
