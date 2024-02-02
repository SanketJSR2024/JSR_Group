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
    public class AcceptanceCriteriaRepository : IAcceptanceCriteriaRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AcceptanceCriteriaRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<AcceptanceCriteriaDTO> CreateAcceptanceCriteria(AcceptanceCriteriaDTO acceptanceCriteria)
        {
            var acDT = _mapper.Map<AcceptanceCriteriaDTO, AcceptanceCriteria>(acceptanceCriteria);
            var txtEntry = await _context.AcceptanceCriteria.AddAsync(acDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<AcceptanceCriteria, AcceptanceCriteriaDTO>(txtEntry.Entity);
        }

        public async Task<int> DeleteAcceptanceCriteria(int imgProcessReqID)
        {
            var textDT = await _context.AcceptanceCriteria.FindAsync(imgProcessReqID);
            if (textDT != null)
            {
                _context.AcceptanceCriteria.Remove(textDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<AcceptanceCriteriaDTO> GetAcceptanceCriteria(int imgProcessReqID)
        {
            return _mapper.Map<AcceptanceCriteria, AcceptanceCriteriaDTO>(await _context.AcceptanceCriteria.FindAsync(imgProcessReqID));
        }

        public async Task<IEnumerable<AcceptanceCriteriaDTO>> GetAllAcceptanceCriteria(int pdId)
        {
            return _mapper.Map<IEnumerable<AcceptanceCriteria>, IEnumerable<AcceptanceCriteriaDTO>>(await _context.AcceptanceCriteria.Where(x => x.PDId == pdId).ToListAsync());
        }

        public async Task<AcceptanceCriteriaDTO> UpdateAcceptanceCriteria(int imgProcessReqID, AcceptanceCriteriaDTO acceptanceCriteria)
        {
            if (imgProcessReqID > 0)
            {
                var acData = await _context.AcceptanceCriteria.FirstOrDefaultAsync(x => x.Id == imgProcessReqID);

                if (acData != null)
                {
                    acData.AcceptableMeasurement = acceptanceCriteria.AcceptableMeasurement;
                    acData.UnitOfMeasurement = acceptanceCriteria.UnitOfMeasurement;
                    acData.DefectTypeId = acceptanceCriteria.DefectTypeId;
                    acData.QuantityAcceptable = acceptanceCriteria.QuantityAcceptable;
                    acData.PDId = acceptanceCriteria.PDId;

                    var updateCompany = _context.AcceptanceCriteria.Update(acData);
                    _context.SaveChanges();
                }
                return acceptanceCriteria;
            }

            return new AcceptanceCriteriaDTO();
        }
    }
}
