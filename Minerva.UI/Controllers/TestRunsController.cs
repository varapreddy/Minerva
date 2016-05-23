using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Minerva.UI.Services;
using Minerva.UI.ViewModels;
using Minerva.UI.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Minerva.UI.Controllers
{
    public class TestRunsController : Controller
    {
        private readonly IMetricsService _metricsService;

        public TestRunsController(IMetricsService metricsService)
        {
            _metricsService = metricsService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _metricsService.GetTestRunsAsync();
            return View(model.OrderByDescending(r => r.RunAt).ToList());

        }

        public async Task<IActionResult> Details(string id)
        {
            var model = await _metricsService.GetTestResultsByRunId(id);
            return View(model);
        }

    }
}
