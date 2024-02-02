using AutoMapper;
using Business.Repository.IRepository;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ManufacturerRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ManufacturerDTO> CreateDefectType(ManufacturerDTO manufacturer)
        {
            var manufacturerDT = _mapper.Map<ManufacturerDTO, Manufacturer>(manufacturer);

            var manufacturerData = await _context.Manufacturer.AddAsync(manufacturerDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<Manufacturer, ManufacturerDTO>(manufacturerData.Entity);
        }

        public async Task<int> DeleteManufacturer(int mID)
        {
            var manufacturerDT = await _context.Manufacturer.FindAsync(mID);
            if (manufacturerDT != null)
            {
                _context.Manufacturer.Remove(manufacturerDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<ManufacturerDTO>> GetAllManufacturer()
        {
            return _mapper.Map<IEnumerable<Manufacturer>, IEnumerable<ManufacturerDTO>>(await _context.Manufacturer.ToListAsync());
        }

        public async Task<ManufacturerDTO> GetManufacturer(int Id)
        {
            return _mapper.Map<Manufacturer, ManufacturerDTO>(await _context.Manufacturer.FindAsync(Id));
        }

        public async Task<ManufacturerDTO> UpdateManufacturer(int Id, ManufacturerDTO manufacturer)
        {
            if (Id > 0)
            {
                var manufacturerData = await _context.Manufacturer.FirstOrDefaultAsync(x => x.Id == Id);

                if (manufacturerData != null)
                {
                    manufacturerData.CompanyName = manufacturer.CompanyName;
                    manufacturerData.OwnerFirstName = manufacturer.OwnerFirstName;
                    manufacturerData.OwnerMiddleName = manufacturer.OwnerMiddleName;
                    manufacturerData.OwnerLastName = manufacturer.OwnerLastName;
                    manufacturerData.EmailId = manufacturer.EmailId;
                    manufacturerData.MobileNo = manufacturer.MobileNo;
                    manufacturerData.Website = manufacturer.Website;
                    _context.Manufacturer.Update(manufacturerData);
                    _context.SaveChanges();
                }
                return manufacturer;
            }

            return new ManufacturerDTO();
        }
    }
}
