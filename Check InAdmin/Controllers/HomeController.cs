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
using Microsoft.AspNetCore.Authorization;
using QuestionDataLayer.Repository;
using QuestionDataLayer.Models;
using QuestionDataLayer.ModelBuilders;
using QuestionDataLayer.ViewModels;

namespace Check_InAdmin.Controllers
{
    [Authorize(Roles ="admin")]
    public class HomeController : Controller
    {
       
        private IGroupsRepository groupsRepository;
        private IUsersRepository usersRepository;
        private IQuestinosRepository questinosRepository;
        private IQuestionModelBuilder questionBuilder;

        public HomeController(IGroupsRepository groupsRepository, IUsersRepository usersRepository, IQuestinosRepository questinosRepository, IQuestionModelBuilder questionBuilder)
        {
            this.groupsRepository = groupsRepository;
            this.usersRepository = usersRepository;
            this.questinosRepository = questinosRepository;
            this.questionBuilder = questionBuilder;
        }

        public async Task<IActionResult> Index()
        {
            var allDataView = new AllDataInViewModel
            {
                Users = await usersRepository.GetAllUsers(),
                Groups = await groupsRepository.GetGroups(),
                Questions =await questinosRepository.GetQuestions()
            };
            return View(allDataView);
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

        [HttpGet]
        public async Task<IActionResult> DeleteGroup(Guid id)
        {
            await groupsRepository.DeleteGroup(id); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> AddQuestion()
        {
            ViewBag.Groups = await groupsRepository.GetGroups();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestion(QuestionModel questionModel)
        {
            await questinosRepository.CreateQuestion(questionModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestion(int id)
        {
            var quest = questinosRepository.GetQuestionsById(id);
            var groupbyQuest = await groupsRepository.GetGroupById(quest.GroupId);
            var questMini = questionBuilder.GenerateValidQuestion(quest , 
                new QuestionViewModel
                {
                    QuestionName = quest.Name,
                    QuestionId = quest.Id,
                    GroupId = groupbyQuest.Id,
                    GroupName = groupbyQuest.Name
                }
                );;

            return View(questMini);

        }

        
    }
}
