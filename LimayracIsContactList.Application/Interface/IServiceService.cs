using LimayracIsContactList.Application.DTO;
using LimayracIsContactList.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Application.Interface
{
    public interface IServiceService
    {
        /// <summary>
        /// Gets all Service.
        /// </summary>
        /// <returns>The list of Service</returns>
        public List<ServiceDto> GetAllService();

        /// <summary>
        /// The function that will call the Service repository to insert our object
        /// </summary>
        /// <param name="ServiceDto">The Service dto</param>
        public void InsertService(ServiceDto ServiceDto);


        /// <summary>
        /// The function that will call the Service repository to update our object
        /// </summary>
        /// <param name="ServiceDto">The Service dto</param>
        public void UpdateService(ServiceDto ServiceDto);


        /// <summary>
        /// The function that will call the Service repository to delete our object
        /// </summary>
        /// <param name="ServiceDto">The Service dto</param>
        public void DeleteService(ServiceDto ServiceDto);

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ServiceDto FindById(int id);
    }
}
