using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Check_InAdmin.Models;
using AuthDataLayer.Models;
using AuthDataLayer.Repositories;

namespace Check_InAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGroupsRepository groupsRepository;

        public HomeController(ILogger<HomeController> logger, IGroupsRepository groupsRepository)
        {
            _logger = logger;
            this.groupsRepository = groupsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddGroup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGroup(GroupModel groupModel)
        {
            await groupsRepository.AddGroup(groupModel);
            return RedirectToAction("Index");
        }
    }
}
