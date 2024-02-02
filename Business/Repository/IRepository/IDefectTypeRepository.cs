using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IDefectTypeRepository
    {
        public Task<DefectTypeDTO> CreateDefectType(DefectTypeDTO defectType);
        public Task<DefectTypeDTO> UpdateDefectType(int defectId, DefectTypeDTO defectType);
        public Task<int> DeleteDefectTypeSF(int defectID);
        public Task<IEnumerable<DefectTypeDTO>> GetAllDefectType(int sfID);
        public Task<DefectTypeDTO> GetDefectType(int defectID);
    }
}
