using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Devices
{
    public class DeviceType : ObjectType<DevicePayload>
    {
        protected override void Configure(IObjectTypeDescriptor<DevicePayload> descriptor)
        {
            //descriptor.Field(d => d.Name).Ignore();

            base.Configure(descriptor);
        }
    }
}
