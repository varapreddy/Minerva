using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.Models
{
    public class JobData
    {
        [JsonProperty(PropertyName = "fail")]
        public int Fail { get; set; }

        [JsonProperty(PropertyName = "job_name")]
        public string JobName { get; set; }

        [JsonProperty(PropertyName = "mean_run_time")]
        public double MeanRunTime { get; set; }

        [JsonProperty(PropertyName = "pass")]
        public int Pass { get; set; }

    }
}
