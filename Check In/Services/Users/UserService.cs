using AuthDataLayer.Models;
using AuthDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_In.Services.users
{
    public class UserService
    {
        private readonly IUsersRepository usersRepository;


        public UserService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public bool CheckLogin(string login)
        {
            return usersRepository.CheckLogin(login);
        }

        public async Task<UserModel> GetCurrentUser(string login)
        {
            return await usersRepository.GetUserByLogin(login);
        }
    }
}
