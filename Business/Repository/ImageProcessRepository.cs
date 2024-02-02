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
    public class ImageProcessRepository : IImageProcessRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ImageProcessRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ImageProcessReqDTO> CreateImageProcessReq(ImageProcessReqDTO imageProcessReq)
        {
            var imageProcessReqDT = _mapper.Map<ImageProcessReqDTO, ImageProcessReq>(imageProcessReq);
            var pdEntry = await _context.ImageProcessReq.AddAsync(imageProcessReqDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<ImageProcessReq, ImageProcessReqDTO>(pdEntry.Entity);
        }

        public async Task<int> DeleteImageProcessReq(int imgProcessReqID)
        {
            var imgProcessReqDT = await _context.ImageProcessReq.FindAsync(imgProcessReqID);
            if (imgProcessReqDT != null)
            {
                _context.ImageProcessReq.Remove(imgProcessReqDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<ImageProcessReqDTO>> GetAllImageProcessReq(int pdId)
        {
            return _mapper.Map<IEnumerable<ImageProcessReq>, IEnumerable<ImageProcessReqDTO>>(await _context.ImageProcessReq.Where(x => x.Id == pdId).ToListAsync());
        }

        public async Task<ImageProcessReqDTO> GetImageProcessReq(int imgProcessReqID)
        {
            return _mapper.Map<ImageProcessReq, ImageProcessReqDTO>(await _context.ImageProcessReq.FindAsync(imgProcessReqID));
        }

        public async Task<ImageProcessReqDTO> UpdateImageProcessReq(int imgProcessReqID, ImageProcessReqDTO imageProcessReq)
        {
            if (imgProcessReqID > 0)
            {
                var imgProcessReqData = await _context.ImageProcessReq.FirstOrDefaultAsync(x => x.Id == imgProcessReqID);

                if (imgProcessReqData != null)
                {
                    imgProcessReqData.SoftwareId = imageProcessReq.SoftwareId;
                    imgProcessReqData.IsExposureSet = imageProcessReq.IsExposureSet;
                    imgProcessReqData.ExposureSetValue = imageProcessReq.ExposureSetValue;
                    imgProcessReqData.IsDefectMarking = imageProcessReq.IsDefectMarking;
                    imgProcessReqData.IsPerspectiveCorrection = imageProcessReq.IsPerspectiveCorrection;
                    imgProcessReqData.IsRename = imageProcessReq.IsRename;
                    imgProcessReqData.RenameWith = imageProcessReq.RenameWith;
                    imgProcessReqData.IsTextInImage = imageProcessReq.IsTextInImage;
                    imgProcessReqData.TextInImage = imageProcessReq.TextInImage;
                    imgProcessReqData.IsImageFullScreen = imageProcessReq.IsImageFullScreen;
                    imgProcessReqData.IsSeverityScore = imageProcessReq.IsSeverityScore;
                    imgProcessReqData.AcceptanceCriteria = imageProcessReq.AcceptanceCriteria;
                    imgProcessReqData.PDId = imageProcessReq.PDId;

                    var updateCompany = _context.ImageProcessReq.Update(imgProcessReqData);
                    _context.SaveChanges();
                }
                return imageProcessReq;
            }

            return new ImageProcessReqDTO();
        }
    }
}
