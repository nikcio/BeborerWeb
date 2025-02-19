﻿namespace BeboerWeb.Shared.Persistence.Repositories
{
    public interface ICrudRepository<TDomain> : IRepository
        where TDomain : class
    {
        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TDomain>> GetAllAsync();

        /// <summary>
        /// Gets an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TDomain> GetByIdAsync(int id);

        /// <summary>
        /// Deletes an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteByIdAsync(int id);

        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <param name="entity"></param>
        TDomain Update(TDomain entity);

        /// <summary>
        /// Adds an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TDomain> AddAsync(TDomain entity);
    }
}
