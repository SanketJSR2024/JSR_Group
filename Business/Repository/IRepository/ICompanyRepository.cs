using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICompanyRepository
    {
        public Task<CompanyDTO> CreateCompany(CompanyDTO company);
        public Task<CompanyDTO> UpdateCompany(int companyId, CompanyDTO company);
        public Task<int> DeleteCompany(int companyId);
        public Task<IEnumerable<CompanyDTO>> GetAllCompany();
        public Task<CompanyDTO> GetCompany(int companyId);
        public Task<CompanyDTO> IsCompanyAlreadyExists(string name);

    }
}
