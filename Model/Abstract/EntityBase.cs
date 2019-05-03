using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Abstract
{
    public abstract class EntityBase
    {
        public EntityBase()
        {

        }

        [Key]
        public long Id { get; set; }
    }
}
