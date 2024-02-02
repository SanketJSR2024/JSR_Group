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
    public class FactoryDetailsRepository : IFactoryDetailsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FactoryDetailsRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<FactoryDetailsDTO> CreateFactoryDetails(FactoryDetailsDTO factoryDetails)
        {
            var fdData = _mapper.Map<FactoryDetailsDTO, FactoryDetails>(factoryDetails);

            var fdEntry = await _context.FactoryDetails.AddAsync(fdData);
            await _context.SaveChangesAsync();

            return _mapper.Map<FactoryDetails, FactoryDetailsDTO>(fdEntry.Entity);
        }

        public async Task<int> DeleteFactoryDetailsSF(int fdId)
        {
            var fdData = await _context.FactoryDetails.FindAsync(fdId);
            if (fdData != null)
            {
                _context.FactoryDetails.Remove(fdData);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<FactoryDetailsDTO>> GetAllFactoryDetails(int sfID)
        {
            return _mapper.Map<IEnumerable<FactoryDetails>, IEnumerable<FactoryDetailsDTO>>(await _context.FactoryDetails.Where(x => x.SoftwareId == sfID).ToListAsync());
        }

        public async Task<FactoryDetailsDTO> GetFactoryDetails(int fdId)
        {
            return _mapper.Map<FactoryDetails, FactoryDetailsDTO>(await _context.FactoryDetails.Where(x => x.Id == fdId).FirstOrDefaultAsync());
        }

        public async Task<FactoryDetailsDTO> UpdateFactoryDetails(int fdId, FactoryDetailsDTO factoryDetails)
        {
            if (fdId > 0)
            {
                var fdData = await _context.FactoryDetails.FirstOrDefaultAsync(x => x.Id == fdId);

                if (fdData != null)
                {
                    fdData.DefectTypeId = factoryDetails.DefectTypeId;
                    fdData.SoftwareId = factoryDetails.SoftwareId;
                    fdData.AccCriteriaId = factoryDetails.AccCriteriaId;
                    fdData.UnitOfMeasurement = factoryDetails.UnitOfMeasurement;
                    fdData.AcceptableMeasurement = factoryDetails.AcceptableMeasurement;
                    fdData.QuantityAcceptablePerModule = factoryDetails.QuantityAcceptablePerModule;

                    var updateCompany = _context.FactoryDetails.Update(fdData);
                    _context.SaveChanges();
                }
                return factoryDetails;
            }

            return new FactoryDetailsDTO();
        }
    }
}
