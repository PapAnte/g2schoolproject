using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Bravo.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bravo.Models.DatabaseEntities;
using AutoMapper;
using Bravo.Models.ViewModels.Tool;

namespace Bravo.Controllers
{
    [Authorize]
    public class ToolController : Controller
    {
        private readonly IToolService _toolService;
        private readonly ILogger _logger;

        public ToolController(IToolService toolService, ILoggerFactory loggerFactory)
        {
            _toolService = toolService;
            _logger = loggerFactory.CreateLogger<ToolController>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ToolIndexViewModel() { ToolList = _toolService.Get().ToList() });
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            if(id == 0)
            {
                return View(new ToolEditViewModel());
            }

            ITool tool = _toolService.Get(id);
            return View(new ToolEditViewModel() { Id = tool.Id, Name = tool.Name });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ToolEditViewModel viewModel)
        {
            if (viewModel.Id > 0)
            {
                ITool toolFromDatabase = _toolService.Get(viewModel.Id);
                Mapper.Map(viewModel, toolFromDatabase);
            }
            else
            {
                _toolService.Add(Mapper.Map<Tool>(viewModel));
            }

            await _toolService.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
