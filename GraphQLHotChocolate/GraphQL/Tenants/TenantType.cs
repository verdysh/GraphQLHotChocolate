using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Tenants
{
    public class TenantType : ObjectType<TenantPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<TenantPayload> descriptor)
        {
            //descriptor.Field(d => d.Name).Ignore();

            base.Configure(descriptor);
        }
    }


}
