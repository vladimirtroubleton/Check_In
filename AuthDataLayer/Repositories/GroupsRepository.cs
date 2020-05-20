using AuthDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthDataLayer.Repositories
{
    public class GroupsRepository : IGroupsRepository
    {
        private UserContext context;
        object locker = new object();
        public GroupsRepository(UserContext context)
        {
            this.context = context;
        }

        public Task<GroupModel[]> GetGroups()
        {
            return Task.FromResult(context.Groups.ToArray());
        }

        public async Task AddGroup(GroupModel groupModel)
        {
            lock (locker)
            {
                context.Groups.Add(groupModel);
            }
            await context.SaveChangesAsync();
        }

      

        public async Task<GroupModel> GetGroupById(Guid id)
        {
           return await context.Groups.FindAsync(id);
        }

        
    }
}
