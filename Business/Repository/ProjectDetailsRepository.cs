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
    public class ProjectDetailsRepository : IProjectDetailsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProjectDetailsRepository(ApplicationDbContext cotext, IMapper mapper)
        {
            _context = cotext;
            _mapper = mapper;
        }
        public async Task<ProjectDetailsDTO> CreateProjectDetails(ProjectDetailsDTO projectDetails)
        {
            var pdDT = _mapper.Map<ProjectDetailsDTO, ProjectDetails>(projectDetails);
            var pdEntry = await _context.ProjectDetails.AddAsync(pdDT);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProjectDetails, ProjectDetailsDTO>(pdEntry.Entity);
        }

        public async Task<int> DeleteProjectDetails(int pdId)
        {
            var pdDT = await _context.ProjectDetails.FindAsync(pdId);
            if (pdDT != null)
            {
                _context.ProjectDetails.Remove(pdDT);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<ProjectDetailsDTO>> GetAllProjectDetails(int sfId)
        {
            return _mapper.Map<IEnumerable<ProjectDetails>, IEnumerable<ProjectDetailsDTO>>(await _context.ProjectDetails.Where(x => x.SoftwareId == sfId).ToListAsync());
        }

        public async Task<ProjectDetailsDTO> GetProjectDetails(int pdID)
        {
            return _mapper.Map<ProjectDetails, ProjectDetailsDTO>(await _context.ProjectDetails.FindAsync(pdID));
        }

        public async Task<ProjectDetailsDTO> UpdateProjectDetails(int pdID, ProjectDetailsDTO projectDetails)
        {
            if (pdID > 0)
            {
                var pdDT = await _context.ProjectDetails.FirstOrDefaultAsync(x => x.Id == pdID);

                if (pdDT != null)
                {
                    pdDT.ManufacturerName = projectDetails.ManufacturerName;
                    pdDT.SoftwareId = projectDetails.SoftwareId;
                    pdDT.WP_Product = projectDetails.WP_Product;
                    pdDT.Date = projectDetails.Date;
                    pdDT.Shift = projectDetails.Shift;
                    pdDT.CustomerId = projectDetails.CustomerId;
                    pdDT.CriteriaBasket = projectDetails.CriteriaBasket;
                    pdDT.ModuleMatrix = projectDetails.ModuleMatrix;
                    pdDT.ElementWith = projectDetails.ElementWith;
                    pdDT.CellSize = projectDetails.CellSize;
                    pdDT.SiteName = projectDetails.SiteName;
                    pdDT.ManufacturingBy = projectDetails.ManufacturingBy;

                    var updateCompany = _context.ProjectDetails.Update(pdDT);
                    _context.SaveChanges();
                }
                return projectDetails;
            }

            return new ProjectDetailsDTO();
        }
    }
}
