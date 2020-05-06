using LimayracIsContactList.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Data
{
    /// <summary>
    /// The LimayracIsContactListContext
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class LimayracIsContactListContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimayracIsContactListContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public LimayracIsContactListContext(DbContextOptions<LimayracIsContactListContext> options)
             : base(options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimayracIsContactListContext"/> class.
        /// </summary>
        public LimayracIsContactListContext()
        {

        }

        /// <summary>
        /// Gets or sets the entreprise.
        /// </summary>
        /// <value>
        /// The entreprise.
        /// </value>
        public DbSet<Entreprise> Entreprise { get; set; }

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        public DbSet<Service> Service { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>
        /// The contact.
        /// </value>
        public DbSet<Person> Person { get; set; }

        /// <summary>
        /// Gets or sets the internship.
        /// </summary>
        /// <value>
        /// The internship.
        /// </value>
        public DbSet<Internship> internship { get; set; }

        /// <summary>
        /// Gets or sets the type of the internship.
        /// </summary>
        /// <value>
        /// The type of the internship.
        /// </value>
        public DbSet<InternshipType> InternshipType { get; set; }
    }
}
