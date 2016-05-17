using Humanizer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.Models
{
    public class TestRun
    {
        [JsonProperty(PropertyName = "artifacts")]
        public string Artifacts { get; set; }

        [JsonProperty(PropertyName = "fails")]
        public int Fails { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "passes")]
        public int Passes { get; set; }

        [JsonProperty(PropertyName = "run_at")]
        public DateTime RunAt { get; set; }

        [JsonProperty(PropertyName = "run_time")]
        public double RunTime { get; set; }

        [JsonProperty(PropertyName = "skips")]
        public int Skips { get; set; }

        public string GetHumanRunAt()
        {
            return RunAt.Humanize();
        }

        public string GetHumanRunTime()
        {
            return TimeSpan.FromSeconds(RunTime).Humanize(2);
        }
    }

    public class TestRunList
    {
        [JsonProperty(PropertyName = "runs")]
        public List<TestRun> TestRuns { get; set; }
    }

}
