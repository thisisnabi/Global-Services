using Ardalis.Specification;

namespace Hrg.Svr.CleanArchitecture.SharedKernel.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
