using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISiteRepository
    {
        public Task<SiteDTO> Create(SiteDTO site);

        public Task<SiteDTO> GetSite(int id);

        public Task<IEnumerable<SiteDTO>> GetSites();

        public Task<bool> DeleteSite(int id);
    }
}
