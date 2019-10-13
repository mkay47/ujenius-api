using CsvHelper;
using System.Collections.Generic;
using System.IO;
using ujenius_api.Models;

namespace ujenius_api.Orchestration
{
    public class DataOrchestration : IDataOrchestration
    {
        public IEnumerable<Farmer> GetFarmers()
        {
            var farmers = new List<Farmer>();

            using (var reader = new StreamReader(@"data\Farmers.csv"))
            {
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.GetRecords<Farmer>();
                    foreach(Farmer f in records)
                    {
                        farmers.Add(f);
                    }
                    return farmers;
                }
            }
        }

        public IEnumerable<Job> GetJobs()
        {
            var jobs = new List<Job>();

            using (var reader = new StreamReader(@"data\Jobs.csv"))
            {
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.GetRecords<Job>();
                    foreach (Job j in records)
                    {
                        jobs.Add(j);
                    }
                    return jobs;
                }
            }
        }
    }
}
