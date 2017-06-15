using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JASP.Model;

namespace JASP.IServices
{
    public interface IUser
    {
        Task<Boolean> AddUserAsync(UserBaseModel user);
    }
}
