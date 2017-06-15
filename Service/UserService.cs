using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JASP.IServices;
using JASP.Model;
using JASP.Service.DocumentDBService;

namespace JASP.Service
{
    public class UserService: IUser
    {
        public async Task<Boolean> AddUserAsync(UserBaseModel user)
        {
            await DocumentDBRepository<UserBaseModel>.CreateItemAsync(user);
            return true;
        }
    }
}
