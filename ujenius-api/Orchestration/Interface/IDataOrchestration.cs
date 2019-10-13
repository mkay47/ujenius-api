using System.Collections.Generic;
using ujenius_api.Models;

namespace ujenius_api.Orchestration
{
    public interface IDataOrchestration
    {
        IEnumerable<Farmer> GetFarmers();

        IEnumerable<Job> GetJobs();
    }
}
