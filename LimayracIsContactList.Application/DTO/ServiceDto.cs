namespace LimayracIsContactList.Application.DTO
{
    using LimayracIsContactList.Infrastructure.Models;
    using System.Collections.Generic;

    /// <summary>
    /// The serviceDto
    /// </summary>
    public class ServiceDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
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
        public int EntrepriseId { get; set; }


        /// <summary>
        /// Gets or sets the entreprise identifier.
        /// </summary>
        /// <value>
        /// The entreprise identifier.
        /// </value>
        public EntrepriseDto Entreprise { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        /// <value>
        /// The contacts.
        /// </value>
        public virtual ICollection<Person> Persons { get; set; }
    }
}
