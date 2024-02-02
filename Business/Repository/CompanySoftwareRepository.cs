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
    public class CompanySoftwareRepository : ICompanySoftware
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CompanySoftwareRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CompanySoftwareDTO> CreateCompanySoftware(CompanySoftwareDTO companySF)
        {
            var softDT = _mapper.Map<CompanySoftwareDTO, CompanySoftware>(companySF);
            var companySFEntry = await _context.CompanySoftware.AddAsync(softDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<CompanySoftware, CompanySoftwareDTO>(companySFEntry.Entity);
        }

        public async Task<int> DeleteCompanySF(int sfId)
        {
            var companyDT = await _context.CompanySoftware.FindAsync(sfId);
            if (companyDT != null)
            {
                _context.CompanySoftware.Remove(companyDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<CompanySoftwareDTO>> GetAllCompanySoftware()
        {
            return _mapper.Map<IEnumerable<CompanySoftware>, IEnumerable<CompanySoftwareDTO>>(await _context.CompanySoftware.ToListAsync());
        }

        public async Task<CompanySoftwareDTO> GetCompanySoftware(int sfId)
        {
            return _mapper.Map<CompanySoftware, CompanySoftwareDTO>(await _context.CompanySoftware.FirstOrDefaultAsync(x => x.Id == sfId));
        }

        public async Task<CompanySoftwareDTO> IsCompanyAlreadyExists(string name)
        {
            return _mapper.Map<CompanySoftware, CompanySoftwareDTO>(await _context.CompanySoftware.Where(x => x.CompanySectionName == name).FirstOrDefaultAsync());
        }

        public async Task<CompanySoftwareDTO> UpdateCompanySF(int sfId, CompanySoftwareDTO softDT)
        {
            if (sfId > 0)
            {
                var companyData = await _context.CompanySoftware.FirstOrDefaultAsync(x => x.Id == sfId);

                if (companyData != null)
                {
                    companyData.SoftwareKey = softDT.SoftwareKey;
                    companyData.CompanyId = softDT.CompanyId;
                    companyData.CompanySectionName = softDT.CompanySectionName;

                    var updateCompany = _context.CompanySoftware.Update(companyData);
                    _context.SaveChanges();
                }
                return softDT;
            }

            return new CompanySoftwareDTO();
        }
    }
}
