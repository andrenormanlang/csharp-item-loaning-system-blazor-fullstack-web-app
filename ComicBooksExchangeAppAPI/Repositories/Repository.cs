using Microsoft.EntityFrameworkCore;
using ComicBooksExchangeAppAPI.Data;

namespace ComicBooksExchangeAppAPI.Repositories
{
    /// <summary>
    /// Generic repository implementation providing base CRUD operations for any entity.
    /// Uses Entity Framework Core for data persistence.
    /// </summary>
    /// <typeparam name="TEntity">The entity type.</typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ComicBooksExchangeDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        /// <summary>
        /// Initializes a new instance of the Repository class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public Repository(ComicBooksExchangeDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Gets all entities asynchronously.
        /// </summary>
        /// <returns>A collection of all entities.</returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        /// <summary>
        /// Gets an entity by its ID asynchronously.
        /// </summary>
        /// <param name="id">The entity ID.</param>
        /// <returns>The entity if found, otherwise null.</returns>
        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        /// <summary>
        /// Adds a new entity to the database asynchronously.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        /// <summary>
        /// Updates an existing entity in the database asynchronously.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Deletes an entity from the database asynchronously.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Saves all pending changes to the database asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
