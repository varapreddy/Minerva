using Minerva.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.ViewModels
{
    public class BuildViewModel
    {
        public string Name { get; set; }

        public List<TestRun> TestRuns { get; set; }

        public string GetLabelsAsArray()
        {
            var runLabels = TestRuns.Select(r => r.RunAt.ToString()).ToArray();
            var stringArray = string.Join(",", runLabels);
            return stringArray;
        }

        public string GetPassesAsArray()
        {
            var passes = TestRuns.Select(r => r.Passes).ToArray();
            var stringArray = string.Join(",", passes);
            return stringArray;
        }

        public string GetFailsAsArray()
        {
            var fails = TestRuns.Select(r => r.Fails).ToArray();
            var stringArray = string.Join(",", fails);
            return stringArray;
        }

        public string GetSkipsAsArray()
        {
            var skips = TestRuns.Select(r => r.Skips).ToArray();
            var stringArray = string.Join(",", skips);
            return stringArray;
        }
    }

}
