using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using AuthDataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_In.Services.Groups
{
    public class GroupService
    {
        private readonly IGroupsRepository groupsRepository;

        public GroupService(IGroupsRepository groupsRepository)
        {
            this.groupsRepository = groupsRepository;
        }

        public async Task<GroupModel[]> GetGroups()
        {
            return await groupsRepository.GetGroups();
        }

        public async Task<GroupViewModel> GetGroupConnectsByGroupId(Guid id)
        {
          var connects = await groupsRepository.GetGroupConnectByGroupId(id);
            return new GroupViewModel
            {
                GroupId = id,
                Users = connects.Select(x => x.UserLogin).ToArray()
            };
        }
    }
}

