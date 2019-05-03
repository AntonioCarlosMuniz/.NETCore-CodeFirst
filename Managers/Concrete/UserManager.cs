using Data.Concrete;
using Managers.Abstract;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.Concrete
{
    public class UserManager: Repository<User>,IUserManager
    {
        public UserManager(ProfileContext dbContext):base(dbContext)
        {
            
        }
    }
}
