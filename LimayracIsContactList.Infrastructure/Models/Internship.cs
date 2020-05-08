using LimayracIsContactList.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Models
{
    public class Internship : BaseEntity
    {
        /// <summary>
        /// Gets or sets the begin intership.
        /// </summary>
        /// <value>
        /// The begin intership.
        /// </value>
        public DateTime BeginIntership { get; set; }

        /// <summary>
        /// Gets or sets the end internship.
        /// </summary>
        /// <value>
        /// The end internship.
        /// </value>
        public DateTime EndInternship { get; set; }

        /// <summary>
        /// Gets or sets the internship type identifier.
        /// </summary>
        /// <value>
        /// The internship type identifier.
        /// </value>
        public int InternshipTypeId { get; set; }

        /// <summary>
        /// Gets or sets the service identifier.
        /// </summary>
        /// <value>
        /// The service identifier.
        /// </value>
        public int EntrepriseId { get; set; }

        /// <summary>
        /// Gets or sets the person identifier.
        /// </summary>
        /// <value>
        /// The person identifier.
        /// </value>
        public int StudentId { get; set; }

        /// <summary>
        /// Gets or sets the type of the internship.
        /// </summary>
        /// <value>
        /// The type of the internship.
        /// </value>
        public InternshipType InternshipType { get; set; }

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        public Entreprise Entreprise { get; set; }

        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        /// <value>
        /// The person.
        /// </value>
        public Student Student { get; set; }
    }
}
