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
    public class ServiceService : IServiceService
    {
        /// <summary>
        /// Gets or sets the mapper.
        /// </summary>
        /// <value>
        /// The mapper.
        /// </value>
        public IMapper _mapper { get; set; }

        /// <summary>
        /// The entreprise repository
        /// </summary>
        private IRepository<Service> _serviceRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntrepriseService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ServiceService(IRepository<Service> repository, IMapper mapper)
        {
            this._serviceRepository = repository;
            this._mapper = mapper;
        }

        /// <summary>
        /// Gets all service.
        /// </summary>
        /// <returns>The list of service</returns>
        public List<ServiceDto> GetAllService()
        {
            IList<Service> services = _serviceRepository.GetAll().ToList();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service, ServiceDto>());
            var mapper = config.CreateMapper();
            var serviceDto = mapper.Map<List<ServiceDto>>(services).ToList();

            return serviceDto;
        }


        /// <summary>
        /// The function that will call the service repository to insert our object
        /// </summary>
        /// <param name="serviceDto">The service dto</param>
        public void InsertService(ServiceDto serviceDto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceDto, Service>());
            var mapper = config.CreateMapper();
            var service = mapper.Map<Service>(serviceDto);
            _serviceRepository.Insert(service);
        }

        /// <summary>
        /// The function that will call the service repository to update our object
        /// </summary>
        /// <param name="serviceDto">The service dto</param>
        public void UpdateService(ServiceDto serviceDto)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ServiceDto, Service>(); cfg.CreateMap<EntrepriseDto, Entreprise>(); });
            var mapper = config.CreateMapper();
            var service = mapper.Map<Service>(serviceDto);
            service.EntrepriseId = serviceDto.EntrepriseId;

            _serviceRepository.Update(service);
        }


        /// <summary>
        /// The function that will call the service repository to delete our object
        /// </summary>
        /// <param name="serviceDto">The service dto</param>
        public void DeleteService(ServiceDto serviceDto)
        {
            _serviceRepository.Delete(serviceDto.Id);
        }

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ServiceDto FindById(int id)
        {
            var service = _serviceRepository.GetById(id);
            var configuration = new MapperConfiguration(c => {
                c.CreateMap<Service, ServiceDto>();
                c.CreateMap<Entreprise, EntrepriseDto>();
            });
            var mapper = configuration.CreateMapper();
            var serviceDto = mapper.Map<ServiceDto>(service);
            return serviceDto;
        }
    }
}
