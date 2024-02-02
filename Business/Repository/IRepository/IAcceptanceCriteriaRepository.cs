using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAcceptanceCriteriaRepository
    {
        public Task<AcceptanceCriteriaDTO> CreateAcceptanceCriteria(AcceptanceCriteriaDTO acceptanceCriteria);
        public Task<AcceptanceCriteriaDTO> UpdateAcceptanceCriteria(int imgProcessReqID, AcceptanceCriteriaDTO acceptanceCriteria);
        public Task<int> DeleteAcceptanceCriteria(int imgProcessReqID);
        public Task<IEnumerable<AcceptanceCriteriaDTO>> GetAllAcceptanceCriteria(int pdId);
        public Task<AcceptanceCriteriaDTO> GetAcceptanceCriteria(int imgProcessReqID);
    }
}
