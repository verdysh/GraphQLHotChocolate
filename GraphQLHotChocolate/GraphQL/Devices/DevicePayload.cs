using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Devices
{
    public class DevicePayload
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TenantId { get; set; }
        public bool Active { get; set; }
        public string? MacAddress { get; set; }
    }
}
