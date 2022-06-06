using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Devices
{
    public class DeviceType : ObjectType<Device>
    {
        protected override void Configure(IObjectTypeDescriptor<Device> descriptor)
        {
            base.Configure(descriptor);
        }
    }
}
