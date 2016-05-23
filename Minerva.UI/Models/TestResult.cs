using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.Models
{
    public class TestResult
    {
        [JsonProperty(PropertyName = "start_time")]
        public string StartTime { get; set; }

        [JsonProperty(PropertyName = "stop_time")]
        public string StopTime { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "test_name")]
        public string TestName { get; set; }

        [JsonProperty(PropertyName = "run_id")]
        public int RunId { get; set; }

        [JsonProperty(PropertyName = "start_time_microsecond")]
        public int StartTimeMicroseconds { get; set; }

        [JsonProperty(PropertyName = "stop_time_microsecond")]
        public int StopTimeMicroseconds { get; set; }

        public int TestId { get; set; }

        public int Id { get; set; }

        public string GetRowStatus()
        {
            switch (Status)
            {
                case "fail":
                    return "danger";
                case "success":
                    return "success";
                case "skip":
                    return "warning";
                default:
                    return "info";
            }
        }

    }

}
