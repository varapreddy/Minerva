using Minerva.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.ViewModels
{
    public class BuildsViewModel
    {
        public string BuildName { get; set; }

        public TestRun LastTestRun { get; set; }

        public List<Dictionary<string, string>> GetChartData()
        {
            var passDict = new Dictionary<string, string>
            {
                ["value"] = LastTestRun.Passes.ToString(),
                ["color"] = "green"
            };

            var failDict = new Dictionary<string, string>
            {
                ["value"] = LastTestRun.Fails.ToString(),
                ["color"] = "red"
            };

            var skipsDict = new Dictionary<string, string>
            {
                ["value"] = LastTestRun.Skips.ToString(),
                ["color"] = "yellow"
            };

            var chartData = new List<Dictionary<string, string>>
            {
                passDict, failDict, skipsDict
            };

            return chartData;
        }
    }

}
