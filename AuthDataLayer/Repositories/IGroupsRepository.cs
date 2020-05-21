using AuthDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace AuthDataLayer.Repositories
{
    public interface IGroupsRepository
    {
        Task<GroupModel> GetGroupById(Guid id);
      
        Task AddGroup(GroupModel groupModel);
 
        Task<GroupModel[]> GetGroups();

        Task DeleteGroup(Guid Id);
    }
}