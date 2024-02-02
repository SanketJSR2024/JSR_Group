using AutoMapper;
using Business.Repository.IRepository;
using DataAcesss.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Business.Repository
{
    public class TextInImageRepository : ITextInImageRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public TextInImageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TextInImageDTO> CreateTextInImage(TextInImageDTO textInImage)
        {
            var textInImageDT = _mapper.Map<TextInImageDTO, TextInImage>(textInImage);
            var txtEntry = await _context.TextInImage.AddAsync(textInImageDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<TextInImage, TextInImageDTO>(txtEntry.Entity);
        }

        public async Task<int> DeleteTextInImage(int txtId)
        {
            var textDT = await _context.TextInImage.FindAsync(txtId);
            if (textDT != null)
            {
                _context.TextInImage.Remove(textDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<TextInImageDTO>> GetAllTextInImage(int pdID)
        {
            return _mapper.Map<IEnumerable<TextInImage>, IEnumerable<TextInImageDTO>>(await _context.TextInImage.ToListAsync());
        }

        public async Task<TextInImageDTO> GetTextInImage(int txtId)
        {
            return _mapper.Map<TextInImage, TextInImageDTO>(await _context.TextInImage.FindAsync(txtId));
        }

        public async Task<TextInImageDTO> UpdateTextInImage(int txtId, TextInImageDTO textInImage)
        {
            if (txtId > 0)
            {
                var txtData = await _context.TextInImage.FirstOrDefaultAsync(x => x.Id == txtId);

                if (txtData != null)
                {
                    txtData.WPOfProduct = textInImage.WPOfProduct;
                    txtData.IsManufacturer=textInImage.IsManufacturer;
                    txtData.ManufacturingPlantAndLine = textInImage.ManufacturingPlantAndLine;
                    txtData.CriteriaName = textInImage.CriteriaName;
                    txtData.PDId = textInImage.PDId;
                    txtData.SoftwareId = textInImage.SoftwareId;
                    txtData.CustomerName = textInImage.CustomerName;
                    txtData.DateAndShift = textInImage.DateAndShift;
                    txtData.IsImageName = textInImage.IsImageName;
                    txtData.SiteName = textInImage.SiteName;

                    var updateCompany = _context.TextInImage.Update(txtData);
                    _context.SaveChanges();
                }
                return textInImage;
            }

            return new TextInImageDTO();
        }
    }
}
