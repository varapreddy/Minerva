using Minerva.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.Services
{
    public interface IMetricsService
    {
        Task<List<TestRun>> GetTestRunsAsync();

        Task<List<Test>> GetTestsAsync();

        Task<List<TestRun>> GetRunsByBuildNameAsync(string name);

        Task<Dictionary<string, TestResult>> GetTestResultsByRunId(string id);
    }

}
