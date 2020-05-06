using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LimayracIsContactList.Infrastructure.Data;
using LimayracIsContactList.Infrastructure.Models;
using LimayracIsContactList.Application.Services;
using AutoMapper;
using LimayracIsContactList.Application.DTO;
using LimayracIsContactList.Application.Interface;

namespace LimayracIsContactList.Controllers
{
    public class EntreprisesController : Controller
    {
        /// <summary>
        /// The context
        /// </summary>
        private LimayracIsContactListContext _context;

        /// <summary>
        /// The entreprise service
        /// </summary>
        private IEntrepriseService _entrepriseService;

        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        public IMapper _mapper { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntreprisesController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="mapper">The mapper.</param>
        /// <param name="entrepriseService">The entreprise service.</param>
        public EntreprisesController(LimayracIsContactListContext context,IMapper mapper, IEntrepriseService entrepriseService)
        {
            _context = context;
            _entrepriseService = entrepriseService;
            _mapper = mapper;
        }

        // GET: Entreprises
        public IActionResult Index()
        {
            List<EntrepriseDto> entrepriseDtos = _entrepriseService.GetAllEntreprise();

            return View(entrepriseDtos);
        }

        // GET: Entreprises/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrepriseDto = _entrepriseService.FindById((int)id);
            if (entrepriseDto == null)
            {
                return NotFound();
            }

            return View(entrepriseDto);
        }

        // GET: Entreprises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entreprises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EntrepriseDto entrepriseDto)
        {
            if (ModelState.IsValid)
            {
                _entrepriseService.InsertEntreprise(entrepriseDto);
                return RedirectToAction(nameof(Index));
            }
            return View(entrepriseDto);
        }

        // GET: Entreprises/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrepriseDto = _entrepriseService.FindById((int)id);
            if (entrepriseDto == null)
            {
                return NotFound();
            }
            return View(entrepriseDto);
        }

        // POST: Entreprises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Siren,City,Address,TelNumber,WebSite")] EntrepriseDto entrepriseDto)
        {
            if (id != entrepriseDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _entrepriseService.UpdateEntreprise(entrepriseDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntrepriseExists(entrepriseDto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(entrepriseDto);
        }

        // GET: Entreprises/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrepriseDto = _entrepriseService.FindById((int)id);
            if (entrepriseDto == null)
            {
                return NotFound();
            }

            return View(entrepriseDto);
        }

        // POST: Entreprises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var entrepriseDto = _entrepriseService.FindById(id);
            _entrepriseService.DeleteEntreprise(entrepriseDto);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Entreprises the exists.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        private bool EntrepriseExists(int id)
        {
            return _context.Entreprise.Any(e => e.Id == id);
        }
    }
}
