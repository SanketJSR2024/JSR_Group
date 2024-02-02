using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICompanySoftware
    {
        public Task<CompanySoftwareDTO> CreateCompanySoftware(CompanySoftwareDTO companySF);
        public Task<CompanySoftwareDTO> UpdateCompanySF(int sfId, CompanySoftwareDTO softDT);
        public Task<int> DeleteCompanySF(int sfId);
        public Task<IEnumerable<CompanySoftwareDTO>> GetAllCompanySoftware();
        public Task<CompanySoftwareDTO> GetCompanySoftware(int sfId);
        public Task<CompanySoftwareDTO> IsCompanyAlreadyExists(string name);
    }
}
