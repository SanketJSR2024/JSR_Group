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
    public class SiteRepository : ISiteRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SiteRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<SiteDTO> Create(SiteDTO site)
        {
            var siteDT = _mapper.Map<SiteDTO, Site>(site);

            var siteData = await _context.Site.AddAsync(siteDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<Site, SiteDTO>(siteData.Entity);
        }

        public async Task<bool> DeleteSite(int id)
        {
            try
            {
                var result = await _context.Site.FirstOrDefaultAsync(x => x.Id == id);
                _context.Site.Remove(result);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public async Task<SiteDTO> GetSite(int id)
        {
            return _mapper.Map<Site, SiteDTO>(await _context.Site.FirstOrDefaultAsync(x => x.Id == id));
        }

        //public async Task<IEnumerable<SiteDTO>> GetSites(int sfID)
        //{
        //    return _mapper.Map<IEnumerable<Site>, IEnumerable<SiteDTO>>(await _context.Site.Where(x => x.SoftwareId == sfID).ToListAsync());
        //}

        public async Task<IEnumerable<SiteDTO>> GetSites()
        {
            return _mapper.Map<IEnumerable<Site>, IEnumerable<SiteDTO>>(await _context.Site.ToListAsync());
        }
    }
}
