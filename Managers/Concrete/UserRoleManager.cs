using Data.Concrete;
using Managers.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.Concrete
{
    public class UserRoleManager:Repository<UserRole>, IUserRoleManager
    {
        public UserRoleManager(ProfileContext dbContext) : base(dbContext)
        {

        }
    }
}
