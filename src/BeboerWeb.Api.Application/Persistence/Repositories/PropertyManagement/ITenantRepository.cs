﻿using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Shared.Persistence.Repositories;

namespace BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement
{
    public interface ITenantRepository : IRepository, ICrudRepository<Tenant>
    {
    }
}
