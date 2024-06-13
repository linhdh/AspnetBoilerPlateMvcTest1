﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.MultiTenancy;
using AspnetBoilerPlateMvcTest1.Editions;
using AspnetBoilerPlateMvcTest1.MultiTenancy;

namespace AspnetBoilerPlateMvcTest1.EntityFrameworkCore.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly AspnetBoilerPlateMvcTest1DbContext _context;

        public DefaultTenantBuilder(AspnetBoilerPlateMvcTest1DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            // Default tenant

            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == AbpTenantBase.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
