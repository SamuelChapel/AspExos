using Location.Entities.Base;

namespace AspExos.Persistence.Repositories.Base;

public interface IReadRepository<TEntity, TId> where TEntity : IEntity<TId>
{
    /// <summary>
    /// Get a <typeparamref name="TEntity"/> by his id 
    /// </summary>
    /// <param name="id"> <typeparamref name="Tid"/> of the <typeparamref name="TEntity"/> id to find</param>
    /// <returns>returns a <typeparamref name="Tid"/> of the <typeparamref name="TEntity"/> id</returns>
    Task<TEntity?> GetById(TId id);

    /// <summary>
    /// Method for getting all the <typeparamref name="TEntity"/> 
    /// </summary>
    /// <returns>returns an <typeparamref name="IEnumerable"/> of all the <typeparamref name="TEntity"/></returns>
    Task<IEnumerable<TEntity>> GetAll();
}
