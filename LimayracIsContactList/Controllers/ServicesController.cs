using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LimayracIsContactList.Infrastructure.Data;
using LimayracIsContactList.Infrastructure.Models;
using LimayracIsContactList.Application.Interface;
using LimayracIsContactList.Application.DTO;
using LimayracIsContactList.ViewModels;

namespace LimayracIsContactList.Controllers
{
    public class ServicesController : Controller
    {
        private readonly LimayracIsContactListContext _context;

        /// <summary>
        /// The entreprise service
        /// </summary>
        private IEntrepriseService _entrepriseService;

        /// <summary>
        /// The entreprise service
        /// </summary>
        private IServiceService _serviceService;

        public ServicesController(LimayracIsContactListContext context, IEntrepriseService entrepriseService, IServiceService serviceService)
        {
            _context = context;
            _entrepriseService = entrepriseService;
            _serviceService = serviceService;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            var limayracIsContactListContext = _context.Service.Include(s => s.Entreprise);
            return View(await limayracIsContactListContext.ToListAsync());
        }

        // GET: Services/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDto = _serviceService.FindById((int)id);
            serviceDto.Entreprise = _entrepriseService.FindById(serviceDto.EntrepriseId);
            if (serviceDto == null)
            {
                return NotFound();
            }


            return View(new ServiceViewModel(_context, _entrepriseService)
            {
                Entreprise = serviceDto.Entreprise,
                Id = serviceDto.Id,
                Name = serviceDto.Name
            });
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View(new ServiceViewModel(_context, _entrepriseService));
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,EntrepriseId")] ServiceDto serviceDto)
        {
            if (ModelState.IsValid)
            {
                _serviceService.InsertService(serviceDto);
                return RedirectToAction(nameof(Index));
            }
            return View(new ServiceViewModel(_context, _entrepriseService)
            {
                Entreprise = serviceDto.Entreprise,
                Id = serviceDto.Id,
                Name = serviceDto.Name
            });
        }

        // GET: Services/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceDto = _serviceService.FindById((int)id);
            serviceDto.Entreprise = _entrepriseService.FindById(serviceDto.EntrepriseId);
            if (serviceDto == null)
            {
                return NotFound();
            }

            return View(new ServiceViewModel(_context, _entrepriseService)
            {
                Entreprise = serviceDto.Entreprise,
                Id = serviceDto.Id,
                Name = serviceDto.Name
            });
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServiceDto serviceDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _serviceService.UpdateService(serviceDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(serviceDto.Id))
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
            return View(new ServiceViewModel(_context, _entrepriseService)
            {
                Entreprise = serviceDto.Entreprise,
                Id = serviceDto.Id,
                Name = serviceDto.Name
            });
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .Include(s => s.Entreprise)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Service.FindAsync(id);
            _context.Service.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return _context.Service.Any(e => e.Id == id);
        }
    }
}
