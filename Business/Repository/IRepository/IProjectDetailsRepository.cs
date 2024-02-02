using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IProjectDetailsRepository
    {
        public Task<ProjectDetailsDTO> CreateProjectDetails(ProjectDetailsDTO projectDetails);
        public Task<ProjectDetailsDTO> UpdateProjectDetails(int pdID, ProjectDetailsDTO projectDetails);
        public Task<int> DeleteProjectDetails(int pdId);
        public Task<IEnumerable<ProjectDetailsDTO>> GetAllProjectDetails(int sfId);
        public Task<ProjectDetailsDTO> GetProjectDetails(int pdID);
    }
}
