using AutoMapper;
using Business.Repository.IRepository;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CompanyRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CompanyDTO> CreateCompany(CompanyDTO company)
        {
            var companyDT = _mapper.Map<CompanyDTO, Company>(company);
            var companyEntry = await _context.Company.AddAsync(companyDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<Company, CompanyDTO>(companyEntry.Entity);
        }

        public async Task<int> DeleteCompany(int companyId)
        {
            var companyDT = await _context.Company.FindAsync(companyId);
            if (companyDT != null)
            {
                _context.Company.Remove(companyDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<CompanyDTO>> GetAllCompany()
        {
            return _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyDTO>>(await _context.Company.ToListAsync());
        }

        public async Task<CompanyDTO> GetCompany(int companyId)
        {
            return _mapper.Map<Company, CompanyDTO>(await _context.Company.FirstOrDefaultAsync(x => x.Id == companyId));
        }

        public async Task<CompanyDTO> IsCompanyAlreadyExists(string name)
        {
            return _mapper.Map<Company, CompanyDTO>(await _context.Company.Where(x => x.CompanyName == name).FirstOrDefaultAsync());
        }

        public async Task<CompanyDTO> UpdateCompany(int companyId, CompanyDTO company)
        {
            if (companyId > 0)
            {
                var companyData = await _context.Company.FirstOrDefaultAsync(x => x.Id == companyId);

                if (companyData != null)
                {
                    companyData.CompanyName = company.CompanyName;
                    companyData.OwnerName = company.OwnerName;
                    companyData.Description = company.Description;

                    var updateCompany = _context.Company.Update(companyData);
                    _context.SaveChanges();
                }
                return company;
            }

            return new CompanyDTO();
        }
    }
}
