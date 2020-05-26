using EventsDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace EventsDataLayer.Resositories
{
    public interface IEventRepository
    {
        Task AddEvent(EventModel model);
        Task AddEventConnect(EventConnectModel model);
        Task<EventModel> GetEventById(int id);
        Task<EventModel[]> GetEventsByGroupId(Guid id);
        Task<EventConnectModel[]> GetEventConnectByEventId(int id);
        Task<EventConnectModel[]> GetEventConnectByGroupId(Guid id);
        Task<EventConnectModel[]> GetEventConnectByUserLoginId(string login);
        Task RemoveEvent(int id);
    }
}