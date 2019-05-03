using Data.Concrete;
using Managers.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Managers.Concrete
{
    public class RoleManager : Repository<Role>, IRoleManager
    {
        public RoleManager(ProfileContext dbContext) : base(dbContext)
        {

        }
    }
}
