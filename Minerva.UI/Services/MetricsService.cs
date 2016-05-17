using Minerva.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Minerva.UI.Services
{
    public class MetricsService : IMetricsService
    {
        public HttpClient Client { get; set; }
        public string BaseUrl { get; set; }

        public MetricsService()
        {
            BaseUrl = "http://127.0.0.1:5000";
            Client = new HttpClient();
        }

        public async Task<List<TestRun>> GetTestRunsAsync()
        {
            var response = await Client.GetAsync($"{BaseUrl}/runs");
            var responseBody = await response.Content.ReadAsStringAsync();
            var testRuns = JsonConvert.DeserializeObject<TestRunList>(responseBody);
            return testRuns.TestRuns;
        }

        public async Task<List<Test>> GetTestsAsync()
        {
            var response = await Client.GetAsync($"{BaseUrl}/tests");
            var responseBody = await response.Content.ReadAsStringAsync();
            var tests = JsonConvert.DeserializeObject<TestList>(responseBody);
            return tests.Tests;
        }

        public async Task<List<TestRun>> GetRunsByBuildNameAsync(string name)
        {
            var response = await Client.GetAsync($"{BaseUrl}/build_name/{name}/runs");
            var responseBody = await response.Content.ReadAsStringAsync();
            var testRuns = JsonConvert.DeserializeObject<TestRunList>(responseBody);
            return testRuns.TestRuns;
        }

        public async Task<Dictionary<string, TestResult>> GetTestResultsByRunId(string id)
        {
            var response = await Client.GetAsync($"{BaseUrl}/run/{id}/test_runs");
            var responseBody = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<Dictionary<string, TestResult>>(responseBody);
            return results;
        }

    }

}
