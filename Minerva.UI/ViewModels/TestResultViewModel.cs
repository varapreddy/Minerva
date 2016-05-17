using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minerva.UI.ViewModels
{
    public class TestResultViewModel
    {
        public string Name { get; set; }

        public string StartTime { get; set; }

        public string StopTime { get; set; }

        public string Status { get; set; }

        public string Metadata { get; set; }

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
