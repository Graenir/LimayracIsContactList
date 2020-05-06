using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Application.DTO
{
    public class EntrepriseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Siren { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public int TelNumber { get; set; }

        public string WebSite { get; set; }
        
        public virtual ICollection<ServiceDto> ServicesDto { get; set; }
    }
}

