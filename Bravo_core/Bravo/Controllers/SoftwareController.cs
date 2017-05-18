using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Bravo.Services;
using Bravo.Models.ViewModels.Software;
using Bravo.Models.DatabaseEntities;
using AutoMapper;

namespace Bravo.Controllers
{
    [Authorize]
    public class SoftwareController : Controller
    {
        private readonly ISoftwareService _softwareService;
        private readonly ILogger _logger;

        public SoftwareController(ISoftwareService softwareService, ILoggerFactory loggerFactory)
        {
            _softwareService = softwareService;
            _logger = loggerFactory.CreateLogger<SoftwareController>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SoftwareIndexViewModel() { SoftwareList = _softwareService.Get().ToList() });
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            if (id == 0)
            {
                return View(new SoftwareEditViewModel());
            }

            ISoftware software = _softwareService.Get(id);
            return View(new SoftwareEditViewModel() { Id = software.Id, Bezeichnung = software.Bezeichnung });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SoftwareEditViewModel viewModel)
        {
            if (viewModel.Id > 0)
            {
                ISoftware softwareFromDatabase = _softwareService.Get(viewModel.Id);
                Mapper.Map(viewModel, softwareFromDatabase);
            }
            else
            {
                _softwareService.Add(Mapper.Map<Software>(viewModel));
            }

            await _softwareService.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}