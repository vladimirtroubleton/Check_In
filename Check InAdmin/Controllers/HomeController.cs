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
using EventsDataLayer.Resositories;
using EventsDataLayer.Models;

namespace Check_InAdmin.Controllers
{
    [Authorize(Roles ="admin")]
    public class HomeController : Controller
    {
       
        private IGroupsRepository groupsRepository;
        private IUsersRepository usersRepository;
        private IQuestinosRepository questinosRepository;
        private IQuestionModelBuilder questionBuilder;
        private IEventRepository eventRepository;

        public HomeController(IGroupsRepository groupsRepository, IUsersRepository usersRepository, IQuestinosRepository questinosRepository, IQuestionModelBuilder questionBuilder, IEventRepository eventRepository)
        {
            this.groupsRepository = groupsRepository;
            this.usersRepository = usersRepository;
            this.questinosRepository = questinosRepository;
            this.questionBuilder = questionBuilder;
            this.eventRepository = eventRepository;
        }

        public async Task<IActionResult> Index()
        {
            var allDataView = new AllDataInViewModel
            {
                Users = await usersRepository.GetAllUsers(),
                Groups = await groupsRepository.GetGroups()
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
            var users = await usersRepository.GetUsersByGroupId(id);
            await questinosRepository.DeleteQuestionsDataByGropId(id);
            foreach (var user in users)
            {
               await usersRepository.RemoveUser(user);
            }
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
        [HttpGet]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var quest = questinosRepository.GetQuestionsById(id);
            var questResps = await questinosRepository.GetResponseByQuestionId(id);
            foreach (var questResp in questResps)
            {
                await questinosRepository.DeleteQuestionResponseByModel(questResp);
            }
            await questinosRepository.DeleteQuestion(id);

            return RedirectToAction("Index");

        }

       

        [HttpGet]
        public async Task<IActionResult> EventCreate()
        {
            ViewBag.Groups = await groupsRepository.GetGroups();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EventCreate(EventModel eventModel)
        {
            eventModel.Active = true;
            await eventRepository.AddEvent(eventModel);
            return RedirectToAction("EventsView");
        }

        [HttpGet]
        public async Task<IActionResult> EventsViewGetByGroup(Guid id)
        {
            ViewBag.GroupThis = await groupsRepository.GetGroupById(id);
            var events = await eventRepository.GetEventsByGroupId(id);
            return View(events);



        }

        [HttpGet]
        public async Task<IActionResult> QuestionViewGetByGroup(Guid id)
        {
            ViewBag.GroupThis = await groupsRepository.GetGroupById(id) ;
            var questions = await questinosRepository.GetQuestionsByGroupId(id);
            return View(questions);



        }

        public async Task<IActionResult> GetResponses(int id)
        {
            var responses = await questinosRepository.GetResponseByQuestionId(id);

            return View(responses);
        }
    }
}
