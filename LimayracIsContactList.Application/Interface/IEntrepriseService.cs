using LimayracIsContactList.Application.DTO;
using LimayracIsContactList.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Application.Interface
{
    public interface IEntrepriseService
    {
        /// <summary>
        /// Gets all entreprise.
        /// </summary>
        /// <returns>The list of entreprise</returns>
        public List<EntrepriseDto> GetAllEntreprise();

        /// <summary>
        /// The function that will call the entreprise repository to insert our object
        /// </summary>
        /// <param name="entrepriseDto">The entreprise dto</param>
        public void InsertEntreprise(EntrepriseDto entrepriseDto);


        /// <summary>
        /// The function that will call the entreprise repository to update our object
        /// </summary>
        /// <param name="entrepriseDto">The entreprise dto</param>
        public void UpdateEntreprise(EntrepriseDto entrepriseDto);


        /// <summary>
        /// The function that will call the entreprise repository to delete our object
        /// </summary>
        /// <param name="entrepriseDto">The entreprise dto</param>
        public void DeleteEntreprise(EntrepriseDto entrepriseDto);

        /// <summary>
        /// Finds the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public EntrepriseDto FindById(int id);
    }
}
