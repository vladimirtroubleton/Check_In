using EventsDataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDataLayer.Resositories
{
    public class EventRepository
    {
        private EventContext eventContext;
        object locker = new object();

        public EventRepository(EventContext eventContext)
        {
            this.eventContext = eventContext;
        }

        public async Task AddEvent(EventModel model)
        {
            lock(locker)
            {
                eventContext.Events.Add(model);
            }
            await eventContext.SaveChangesAsync();
        }

        public async Task RemoveEvent(int id)
        {
            var model =await GetEventById(id);
            lock (locker)
            {
                eventContext.Events.Add(model);
            }
            await eventContext.SaveChangesAsync();
        }

        public async Task<EventModel> GetEventById(int id)
        {
            return await eventContext.Events.FindAsync(id);
        }

        public async Task<EventConnector[]> GetEventConnectById(int id)
        {
            return await eventContext.EventsConnect.Where( x=> x.EventId == id).ToArrayAsync();
        }
    }
}
