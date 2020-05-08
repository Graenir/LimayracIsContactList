using LimayracIsContactList.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Models
{
    public class Service : BaseEntity
    {

        public string Name { get; set; }

        public int EntrepriseId { get; set; }

        public virtual Entreprise Entreprise { get; set; }

    }
}
