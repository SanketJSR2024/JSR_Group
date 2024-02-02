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
    public class DefectTypeRepository : IDefectTypeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DefectTypeRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DefectTypeDTO> CreateDefectType(DefectTypeDTO defectType)
        {
            var acDT = _mapper.Map<DefectTypeDTO, DefectType>(defectType);
            var txtEntry = await _context.DefectType.AddAsync(acDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<DefectType, DefectTypeDTO>(txtEntry.Entity);
        }

        public async Task<int> DeleteDefectTypeSF(int defectID)
        {
            var textDT = await _context.DefectType.FindAsync(defectID);
            if (textDT != null)
            {
                _context.DefectType.Remove(textDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<DefectTypeDTO>> GetAllDefectType(int sfID)
        {
            return _mapper.Map<IEnumerable<DefectType>, IEnumerable<DefectTypeDTO>>(await _context.DefectType.Where(x => x.SoftwareId == sfID).ToListAsync());
        }

        public async Task<DefectTypeDTO> GetDefectType(int defectID)
        {
            return _mapper.Map<DefectType, DefectTypeDTO>(await _context.DefectType.Where(x => x.Id == defectID).FirstOrDefaultAsync());
        }

        public async Task<DefectTypeDTO> UpdateDefectType(int defectId, DefectTypeDTO defectType)
        {

            if (defectId > 0)
            {
                var acData = await _context.DefectType.FirstOrDefaultAsync(x => x.Id == defectId);

                if (acData != null)
                {
                    acData.Value = defectType.Value;
                    acData.SoftwareId = defectType.SoftwareId;

                    var updateCompany = _context.DefectType.Update(acData);
                    _context.SaveChanges();
                }
                return defectType;
            }

            return new DefectTypeDTO();
        }
    }
}
