using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.Categories
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCategoryViewModel
    {
        public long Id { get; set; }
        public Guid Key { get; set; }
        public string Descricao { get; set; }
    }
}
