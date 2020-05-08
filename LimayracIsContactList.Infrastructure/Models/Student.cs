using LimayracIsContactList.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Models
{
    public class Student : BaseEntity
    {

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string  Surname { get; set; }

        /// <summary>
        /// Gets or sets the email1.
        /// </summary>
        /// <value>
        /// The email1.
        /// </value>
        public string Email1 { get; set; }

        /// <summary>
        /// Gets or sets the email2.
        /// </summary>
        /// <value>
        /// The email2.
        /// </value>
        public string Email2 { get; set; }

        /// <summary>
        /// Gets or sets the phone1.
        /// </summary>
        /// <value>
        /// The phone1.
        /// </value>
        public int Phone1 { get; set; }

        /// <summary>
        /// Gets or sets the phone2.
        /// </summary>
        /// <value>
        /// The phone2.
        /// </value>
        public int Phone2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the class identifier.
        /// </summary>
        /// <value>
        /// The class identifier.
        /// </value>
        public int ClassId { get; set; }

        /// <summary>
        /// Gets or sets the class.
        /// </summary>
        /// <value>
        /// The class.
        /// </value>
        public Class Class { get; set; }
    }
}
