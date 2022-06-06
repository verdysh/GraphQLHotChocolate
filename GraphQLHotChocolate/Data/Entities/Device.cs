using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Device
    {
        public Guid Id { get; set; }
        [MaxLength(200)] public string Name { get; set; }
        public Guid TenantId { get; set; }
        public bool Active { get; set; }
        [MaxLength(17)] public string MacAddress { get; set; }

        public Tenant Tenant { get; set; }
    }
}
