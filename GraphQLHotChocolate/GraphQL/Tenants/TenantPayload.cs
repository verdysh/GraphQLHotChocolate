using GraphQL.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Tenants
{
    public class TenantPayload
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<DevicePayload> Devices { get; set; }
    }
}
