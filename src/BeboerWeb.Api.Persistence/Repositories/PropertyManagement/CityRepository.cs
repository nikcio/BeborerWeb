﻿using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class CityRepository : CrudRepositoryBase<City>, ICityRepository
    {
        public CityRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<City>> logger) : base(dbContext, logger)
        {
        }
    }
}
