using LimayracIsContactList.Application.DTO;
using LimayracIsContactList.Application.Interface;
using LimayracIsContactList.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LimayracIsContactList.ViewModels
{
    public class ServiceViewModel
    {
        private readonly LimayracIsContactListContext _context;

        /// <summary>
        /// The entreprise service
        /// </summary>
        private IEntrepriseService _entrepriseService;
        public ServiceViewModel(LimayracIsContactListContext context, IEntrepriseService entrepriseService)
        {
            _context = context;
            _entrepriseService = entrepriseService;
            OnGet();
        }

        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the entreprise identifier.
        /// </summary>
        /// <value>
        /// The entreprise identifier.
        /// </value>
        public EntrepriseDto Entreprise { get; set; }

        public List<SelectListItem> Options { get; set; }
        public void OnGet()
        {
            Options = _entrepriseService.GetAllEntreprise().Select(s => new SelectListItem()
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();
        }
    }
}
