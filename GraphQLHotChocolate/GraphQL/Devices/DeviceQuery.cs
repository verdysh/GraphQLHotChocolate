using Data;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace GraphQL.Devices
{
    public class DeviceQuery
    {
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable devices")]
        public IQueryable<DevicePayload> GetDevice(
            [Service] GQL_DbContext context,
            [Service] IHttpContextAccessor contextAccessor
        )
        {
            var tenantId = new Guid("711BE9AE-E5C9-4F20-B499-D0E4D97CCCC6");

            return context.Devices.Where(d => d.TenantId == tenantId)
                .Select(d => new DevicePayload
                {
                    Id = d.Id,
                    Name = d.Name,
                    TenantId = d.TenantId,
                    Active = d.Active,
                    MacAddress = d.MacAddress 
                });
        }
    }
}