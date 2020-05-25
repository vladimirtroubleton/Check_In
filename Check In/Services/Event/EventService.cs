using AuthDataLayer.Repositories;
using EventsDataLayer.Models;
using EventsDataLayer.Resositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_In.Services.Event
{
    public class EventService
    {
        private readonly IEventRepository eventRepository;
        private readonly IUsersRepository usersRepository;
        private readonly IGroupsRepository groupsRepository;

        public EventService(IEventRepository eventRepository, IUsersRepository usersRepository, IGroupsRepository groupsRepository)
        {
            this.eventRepository = eventRepository;
            this.usersRepository = usersRepository;
            this.groupsRepository = groupsRepository;
        }

        public async Task<EventModel[]> GetEventsByGroupUser(Guid GroupId)
        {
            return await eventRepository.GetEventsByGroupId(GroupId);
        }
    }
}
