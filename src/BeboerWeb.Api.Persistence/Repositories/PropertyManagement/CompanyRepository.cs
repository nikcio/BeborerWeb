﻿using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class CompanyRepository : CrudRepositoryBase<ICompany>, ICompanyRepository
    {
        public CompanyRepository(DbContext dbContext, ILogger<CrudRepositoryBase<ICompany>> logger) : base(dbContext, logger)
        {
        }
    }
}
