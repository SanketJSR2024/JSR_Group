using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IImageProcessRepository
    {
        Task<ImageProcessReqDTO> CreateImageProcessReq(ImageProcessReqDTO imageProcessReq);
        Task<ImageProcessReqDTO> UpdateImageProcessReq(int imgProcessReqID, ImageProcessReqDTO imageProcessReq);
        Task<int> DeleteImageProcessReq(int imgProcessReqID);
        Task<IEnumerable<ImageProcessReqDTO>> GetAllImageProcessReq(int pdId);
        Task<ImageProcessReqDTO> GetImageProcessReq(int imgProcessReqID);
    }
}
