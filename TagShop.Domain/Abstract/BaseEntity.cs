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
        public long Id { get; set; }
        public Guid Key { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
