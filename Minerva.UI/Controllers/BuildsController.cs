using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Minerva.UI.Services;
using Minerva.UI.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Minerva.UI.Controllers
{
    public class BuildsController : Controller
    {
        private readonly IMetricsService _metricsService;

        public BuildsController(IMetricsService metricsService)
        {
            _metricsService = metricsService;
        }

        public async Task<IActionResult> Index()
        {
            string[] builds = { "DefCore-2016.01-All", "Tempest-All-Tests" };

            var model = new List<BuildsViewModel>();
            foreach (var build in builds)
            {
                var testRuns = await _metricsService.GetRunsByBuildNameAsync(build);
                var lastRun = testRuns.OrderByDescending(r => r.RunAt).FirstOrDefault();
                var buildVM = new BuildsViewModel
                {
                    BuildName = build,
                    LastTestRun = lastRun
                };
                model.Add(buildVM);
            }

            return View(model);
        }

        public async Task<IActionResult> Details(string name)
        {
            var runs = await _metricsService.GetRunsByBuildNameAsync(name);
            var model = new BuildViewModel
            {
                Name = name,
                TestRuns = runs.OrderByDescending(r => r.RunAt).ToList()
            };
            return View(model);
        }

    }
}
