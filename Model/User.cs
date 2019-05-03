using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Model.Abstract;

namespace Model
{
    public class User: EntityBase
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public string ProfileComplete { get; set; }

        public string Token { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
