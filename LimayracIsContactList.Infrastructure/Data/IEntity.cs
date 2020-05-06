using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Data
{
    /// <summary>
    /// The i entity class
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; set; }
    }
}
