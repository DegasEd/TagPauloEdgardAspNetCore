using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Client : BaseEntity
    {
        
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }

    }
}
