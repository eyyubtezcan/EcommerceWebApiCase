using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Entities
{
    public class Language:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; } // tr-eng etc.

    }
}
