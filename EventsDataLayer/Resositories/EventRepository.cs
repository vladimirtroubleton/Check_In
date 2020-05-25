using EventsDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDataLayer.Resositories
{
    public class EventRepository : IEventRepository
    {
        private EventContext eventContext;
        object locker = new object();

        public EventRepository(EventContext eventContext)
        {
            this.eventContext = eventContext;
        }

        public async Task AddEvent(EventModel model)
        {
            lock (locker)
            {
                eventContext.Events.Add(model);
            }
            await eventContext.SaveChangesAsync();
        }

        public async Task RemoveEvent(int id)
        {
            var model = await GetEventById(id);
            lock (locker)
            {
                eventContext.Events.Remove(model);
            }

            await eventContext.SaveChangesAsync();
            await RemoveEventConnect(id);
        }

        public async Task<EventModel> GetEventById(int id)
        {
            return await eventContext.Events.FindAsync(id);
        }

        public async Task<EventConnectModel[]> GetEventConnectByEventId(int id)
        {
            return await eventContext.EventsConnect.Where(x => x.EventId == id).ToArrayAsync();
        }

        public async Task<EventConnectModel[]> GetEventConnectByGroupId(Guid id)
        {
            return await eventContext.EventsConnect.Where(x => x.GroupId == id).ToArrayAsync();
        }

        public async Task<EventConnectModel[]> GetEventConnectByUserLoginId(string login)
        {
            return await eventContext.EventsConnect.Where(x => x.UserLogin == login).ToArrayAsync();
        }

        public async Task AddEventConnect(EventConnectModel model)
        {
            lock (locker)
            {
                eventContext.EventsConnect.Add(model);
            }
            await eventContext.SaveChangesAsync();
        }

        public async Task RemoveEventConnect(int id)
        {
            var model = await GetEventConnectByEventId(id);
            lock (locker)
            {
                eventContext.EventsConnect.RemoveRange(model);
            }
            await eventContext.SaveChangesAsync();
        }

        public async Task<EventModel[]> GetEventsByGroupId(Guid id)
        {
            return await eventContext.Events.Where(x => x.GroupId == id).ToArrayAsync();
        }
    }
}
