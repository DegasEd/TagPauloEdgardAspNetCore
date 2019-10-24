using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Category : BaseEntity
    {

        public Category()
        {

        }

        public Category(long id, Guid key, String description)
        {
            Id = id;
            Key = key;
            Description = description;


        }

        public Category(long id, Guid key)
        {
            Id = id;
            Key = key;

        }

        public string Description { get; set; }

    }
}
