using Data;
using GraphQL.Devices;
using GraphQL.Tenants;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace GraphQL
{
    public class Query
    {
        [UsePaging()]
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

        [UseFiltering]
        [UseSorting]        
        [GraphQLDescription("Gets the queryable tenants")]
        public IQueryable<TenantPayload> GetTenants(
            [Service] GQL_DbContext context,
            [Service] IHttpContextAccessor contextAccessor,
            Guid? tenantId = null
        )
        {
            //var tenantId = new Guid("711BE9AE-E5C9-4F20-B499-D0E4D97CCCC6");

            var query = context.Tenants.AsQueryable();

            if (tenantId.HasValue)
                query = query.Where(t => t.Id == tenantId);

            return query.Select(t => new TenantPayload
            {
                Id = t.Id,
                Name = t.Name
                ,
                Devices = t.Devices.Select(d => new Devices.DevicePayload
                {
                    Id = d.Id,
                    MacAddress = d.MacAddress,
                    Name = d.Name,
                    Active = d.Active,
                    TenantId = d.TenantId
                })
            });
        }
    }
}