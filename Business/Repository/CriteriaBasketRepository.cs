using AutoMapper;
using Business.Repository.IRepository;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class CriteriaBasketRepository : ICriteriaBasketRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CriteriaBasketRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CriteriaBasketDTO> CreateCriteriaBasket(CriteriaBasketDTO criteriaBasket)
        {
            var acDT = _mapper.Map<CriteriaBasketDTO, CriteriaBasket>(criteriaBasket);
            var txtEntry = await _context.CriteriaBasket.AddAsync(acDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<CriteriaBasket, CriteriaBasketDTO>(txtEntry.Entity);
        }

        public async Task<int> DeleteCriteriaBasketSF(int fdId)
        {
            var textDT = await _context.CriteriaBasket.FindAsync(fdId);
            if (textDT != null)
            {
                _context.CriteriaBasket.Remove(textDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<CriteriaBasketDTO>> GetAllCriteriaBasket()
        {
            return _mapper.Map<IEnumerable<CriteriaBasket>, IEnumerable<CriteriaBasketDTO>>(await _context.CriteriaBasket.ToListAsync());
        }

        public async Task<CriteriaBasketDTO> GetCriteriaBasket(int cbId)
        {
            return _mapper.Map<CriteriaBasket, CriteriaBasketDTO>(await _context.CriteriaBasket.FindAsync(cbId));
        }

        public async Task<CriteriaBasketDTO> UpdateCriteriaBasket(int cbId, CriteriaBasketDTO criteriaBasket)
        {
            if (cbId > 0)
            {
                var acData = await _context.CriteriaBasket.FirstOrDefaultAsync(x => x.Id == cbId);

                if (acData != null)
                {
                    acData.Name = criteriaBasket.Name;

                    var updateCompany = _context.CriteriaBasket.Update(acData);
                    _context.SaveChanges();
                }
                return criteriaBasket;
            }

            return new CriteriaBasketDTO();
        }
    }
}
