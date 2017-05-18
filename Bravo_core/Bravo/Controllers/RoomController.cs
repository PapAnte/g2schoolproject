using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Bravo.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bravo.Models.ViewModels.Room;
using Bravo.Models.DatabaseEntities;
using AutoMapper;
using Bravo.Models.DatabaseEntities.Relation;

namespace Bravo.Controllers
{
    [Authorize(Roles = "Administrator,Verwaltung")]
    public class RoomController : Controller
    {
        private readonly IToolService _toolService;
        private readonly IRoomService _roomService;
        private readonly ILogger _logger;

        public RoomController(IRoomService roomService, IToolService toolService, ILoggerFactory loggerFactory)
        {
            _toolService = toolService;
            _roomService = roomService;
            _logger = loggerFactory.CreateLogger<RoomController>();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new RoomIndexViewModel() { RoomList = _roomService.Get().ToList() });
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            if(id == 0)
            {
                return View(new RoomEditViewModel());
            }

            IRoom room = _roomService.Get(id);
            return View(new RoomEditViewModel() { Id = room.Id, Name = room.Name, ToolListFromRoom = room.Tools.Cast<Tool>().ToList(), AllTools = _toolService.Get().Cast<Tool>().ToList() });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoomEditViewModel viewModel)
        {
            if (viewModel.Id > 0)
            {
                IRoom roomFromDatabase = _roomService.Get(viewModel.Id);
                Mapper.Map(viewModel, roomFromDatabase);
            }
            else
            {
                _roomService.Add(Mapper.Map<Room>(viewModel));
            }

            await _roomService.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
