using Humanizer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.Models
{
    public class Test
    {
        [JsonProperty(PropertyName = "failure")]
        public int Failure { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "run_count")]
        public int RunCount { get; set; }

        [JsonProperty(PropertyName = "run_time")]
        public double RunTime { get; set; }

        [JsonProperty(PropertyName = "success")]
        public int Success { get; set; }

        [JsonProperty(PropertyName = "test_id")]
        public string TestId { get; set; }

        public string GetHumanRunTime()
        {
            return TimeSpan.FromSeconds(RunTime).Humanize(2);
        }

        public string GetSuccessRate()
        {
            if (RunCount == 0)
            {
                return "N/A";
            }
            return (Success / RunCount).ToString("0.0%");
        }
    }

    public class TestList
    {
        [JsonProperty(PropertyName = "tests")]
        public List<Test> Tests { get; set; }
    }

}
