﻿using LimayracIsContactList.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Models
{
    public class Entreprise : BaseEntity
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string WebSite { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdate { get; set; }
        public virtual ICollection<Internship> Internships { get; set; }

        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
