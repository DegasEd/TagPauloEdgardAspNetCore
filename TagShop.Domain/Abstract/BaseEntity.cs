using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TagShop.Domain.Abstract
{
    public abstract class BaseEntity : BaseResponse
    {
        public BaseEntity()
        {
            Id = 0;
            Key = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsActive = true;

        }
        public void SetUpdateDate()
        {
            UpdatedDate = DateTime.Now;
        }

        public void ChangeStatus()
        {
            IsActive = false;
        }

        [Key]
        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
