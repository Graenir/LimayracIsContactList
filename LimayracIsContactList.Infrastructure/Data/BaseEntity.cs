using System;
using System.Collections.Generic;
using System.Text;

namespace LimayracIsContactList.Infrastructure.Data
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
