using Ardalis.Specification;

namespace Hrg.Svr.CleanArchitecture.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
