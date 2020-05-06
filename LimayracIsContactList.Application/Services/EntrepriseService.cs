using LimayracIsContactList.Application.DTO;
using LimayracIsContactList.Infrastructure.Data;
using LimayracIsContactList.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using LimayracIsContactList.Application.Interface;

namespace LimayracIsContactList.Application.Services
{
    public class EntrepriseService : IEntrepriseService
    {
        /// <summary>
        /// The entreprise repository
        /// </summary>
        private IRepository<Entreprise> _entrepriseRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntrepriseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public EntrepriseService(IRepository<Entreprise> repository, IMapper mapper)
        { 
            this._entrepriseRepository = repository;
            this._mapper = mapper;
        }
        
        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        public IMapper _mapper { get; set; }

        /// <summary>
        /// Gets all entreprise.
        /// </summary>
        /// <returns>The list of entreprise</returns>
        public List<EntrepriseDto> GetAllEntreprise()
        {
            IList<Entreprise> entreprises = _entrepriseRepository.GetAll().ToList();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Entreprise, EntrepriseDto>());
            var mapper = config.CreateMapper();
            var entrepriseDto = mapper.Map<List<EntrepriseDto>>(entreprises).ToList();

            return entrepriseDto;
        }


        /// <summary>
        /// The function that will call the entreprise repository to insert our object
        /// </summary>
        /// <param name="entrepriseDto">The entreprise dto</param>
        public void InsertEntreprise(EntrepriseDto entrepriseDto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntrepriseDto, Entreprise>());
            var mapper = config.CreateMapper();
            var entreprise = mapper.Map<Entreprise>(entrepriseDto);

            entreprise.CreateDate = DateTime.Now;
            entreprise.LastUpdate = DateTime.Now;
            _entrepriseRepository.Insert(entreprise);
        }

        /// <summary>
        /// The function that will call the entreprise repository to update our object
        /// </summary>
        /// <param name="entrepriseDto">The entreprise dto</param>
        public void UpdateEntreprise(EntrepriseDto entrepriseDto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EntrepriseDto, Entreprise>());
            var mapper = config.CreateMapper();
            var entreprise = mapper.Map<Entreprise>(entrepriseDto);

            entreprise.LastUpdate = DateTime.Now;
            _entrepriseRepository.Update(entreprise);
        }


        /// <summary>
        /// The function that will call the entreprise repository to delete our object
        /// </summary>
        /// <param name="entrepriseDto">The entreprise dto</param>
        public void DeleteEntreprise(EntrepriseDto entrepriseDto)
        {
            _entrepriseRepository.Delete(entrepriseDto.Id);
        }

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public EntrepriseDto FindById(int id)
        {
            var entreprise = _entrepriseRepository.GetById(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Entreprise, EntrepriseDto>());
            var mapper = config.CreateMapper();
            var entrepriseDto = mapper.Map<EntrepriseDto>(entreprise);
            return entrepriseDto;
        }
    }
}
