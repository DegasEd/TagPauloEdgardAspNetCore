using System;
using System.Collections.Generic;
using System.Text;

namespace TagShop.Domain.Models
{
    public abstract class Entity
    {
        protected Entity()
        {

        }

        public int Id { get; set; }

    }
}
