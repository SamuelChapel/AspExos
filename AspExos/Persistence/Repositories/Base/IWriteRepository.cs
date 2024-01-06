using Location.Entities.Base;

namespace AspExos.Persistence.Repositories.Base;

public interface IWriteRepository<TEntity, TId> where TEntity : IEntity<TId>
{
    /// <summary>
    /// Create a <typeparamref name="TEntity"/>
    /// </summary>
    /// <param name="entity">The <typeparamref name="TEntity"/> to create</param>
    /// <returns>The <typeparamref name="TId"/> that corresponds to the id of the <typeparamref name="TEntity"/> created</returns>
    Task<TId> Create(TEntity entity);

    /// <summary>
    /// Modify a <typeparamref name="TEntity"/>
    /// </summary>
    /// <param name="entity">The <typeparamref name="TEntity"/> to modify</param>
    /// <returns>The number of <typeparamref name="TEntity"/> modified</returns>
    Task Update(TEntity entity);

    /// <summary>
    /// Delete a <typeparamref name="TEntity"/>
    /// </summary>
    /// <param name="entity">The <typeparamref name="TEntity"/> to delete</param>
    /// <returns>The number of <typeparamref name="TEntity"/> deleted</returns>
    Task Delete(TId id);
}
