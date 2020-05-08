using LimayracIsContactList.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Models
{
    public class Class : BaseEntity
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get; set; }
    }
}
