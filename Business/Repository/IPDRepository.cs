using AutoMapper;
using Business.Repository.IRepository;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class IPDRepository : IImageProcessData
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public IPDRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ImageProcessData>> GetImageProcessData(int PDId)
        {
            return await _context.ImageProcessData.ToListAsync();
        }

        public async Task<List<ImageProcessData>> SaveImageProcessData(ImageProcessData imageProcessData)
        {
            throw new System.NotImplementedException();
        }
    }
}
