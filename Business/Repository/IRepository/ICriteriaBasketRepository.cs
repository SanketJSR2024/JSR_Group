using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICriteriaBasketRepository
    {
        public Task<CriteriaBasketDTO> CreateCriteriaBasket(CriteriaBasketDTO criteriaBasket);
        public Task<CriteriaBasketDTO> UpdateCriteriaBasket(int cbId, CriteriaBasketDTO criteriaBasket);
        public Task<int> DeleteCriteriaBasketSF(int fdId);
        public Task<IEnumerable<CriteriaBasketDTO>> GetAllCriteriaBasket();
        public Task<CriteriaBasketDTO> GetCriteriaBasket(int cbId);
    }
}
