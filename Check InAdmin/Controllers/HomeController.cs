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
    [Authorize(Roles = "admin")]
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
            var events = await eventRepository.GetEventsByGroupId(id);
            foreach (var even in events)
            {
                await eventRepository.RemoveEvent(even.EventId);
            }
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
            var questMini = questionBuilder.GenerateValidQuestion(quest,
                new QuestionViewModel
                {
                    QuestionName = quest.Name,
                    QuestionId = quest.Id,
                    GroupId = groupbyQuest.Id,
                    GroupName = groupbyQuest.Name
                }
                ); ;

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
            return RedirectToAction("Index");
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
            ViewBag.GroupThis = await groupsRepository.GetGroupById(id);
            var questions = await questinosRepository.GetQuestionsByGroupId(id);
            return View(questions);



        }
        [HttpGet]
        public async Task<IActionResult> GetResponses(int id)
        {
            var responses = await questinosRepository.GetResponseByQuestionId(id);

            return View(responses);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserProfile(string login)
        {
            var user = await usersRepository.GetUserByLogin(login);
            ViewBag.Group = await groupsRepository.GetGroupById(user.GroupId);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetEventData(int evId)
        {


            var eventModel = await eventRepository.GetEventById(evId);
            UserModel[] usersInGroup = await usersRepository.GetUsersByGroupId(eventModel.GroupId);
            GroupModel groupModel = await groupsRepository.GetGroupById(eventModel.GroupId);
            var eventConnect = await eventRepository.GetEventConnectByEventId(evId);
            EventViewModel eventViewModel = new EventViewModel
            {

                UsersNoActivate = usersInGroup.Where(x => !eventConnect.Select(x => x.UserLogin).Contains(x.Login)).ToArray(),
                Group = groupModel,
                Event = eventModel,
                CountActiveUsers = 0
            };

           
            if (eventConnect != null)
            {
                var activeUser = usersInGroup.Where(x => eventConnect.Select(x => x.UserLogin).Contains(x.Login)).ToArray();
                eventViewModel.UsersActivate = activeUser;
                eventViewModel.CountActiveUsers = activeUser.Count();
            }

            return View(eventViewModel);
        }

        [HttpGet]

        public async Task<IActionResult> DeleteEvent(int evId)
        {
            await eventRepository.RemoveEvent(evId);
            return RedirectToAction("Index");
        }

    }
        
    
}
