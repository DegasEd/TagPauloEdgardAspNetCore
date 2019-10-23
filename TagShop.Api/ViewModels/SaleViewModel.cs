using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels
{
    public class SaleViewModel
    {
        public SaleViewModel()
        {
            Client = new ClientViewModel();
            SaleItems = new List<SaleItemViewModel>();
        }

        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string SaleId { get; set; }
        public string Invoice { get; set; }
        public ClientViewModel Client { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPurchase { get; set; }
        public decimal Icms { get; set; }
        public decimal Pis { get; set; }
        public decimal Cofins { get; set; }
        public List<SaleItemViewModel> SaleItems { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
