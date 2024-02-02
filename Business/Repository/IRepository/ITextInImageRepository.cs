using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ITextInImageRepository
    {
        public Task<TextInImageDTO> CreateTextInImage(TextInImageDTO textInImage);
        public Task<TextInImageDTO> UpdateTextInImage(int txtId, TextInImageDTO textInImage);
        public Task<int> DeleteTextInImage(int txtId);
        public Task<IEnumerable<TextInImageDTO>> GetAllTextInImage(int pdID);
        public Task<TextInImageDTO> GetTextInImage(int txtId);

    }
}
