using AuthDataLayer.Models;
using System;
using System.Threading.Tasks;

namespace AuthDataLayer.Repositories
{
    public interface IGroupsRepository
    {
        Task<GroupModel> GetGroupById(Guid id);
        Task<GroupConnectModel[]> GetGroupConnectByGroupId(Guid id);
        Task AddGroup(GroupModel groupModel);
        Task AddGroupConnect(GroupConnectModel groupConnectModel);
        Task<GroupModel[]> GetGroups();
    }
}