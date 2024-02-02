using DataAcesss.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IImageProcessData
    {
        Task<List<ImageProcessData>> SaveImageProcessData(ImageProcessData imageProcessData);

        Task<List<ImageProcessData>> GetImageProcessData(int PDId);

    }
}
