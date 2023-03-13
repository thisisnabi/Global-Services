using Hrg.Svr.CleanArchitecture.SharedKernel.Interfaces;
using Hrg.Svr.CleanArchitecture.SharedKernel;

namespace Hrg.Svr.Global.ScrumBoard.Domain.StoryAggregate
{
    public class Task : EntityBase<Guid>, IAggregateRoot
    {
        public Task(Guid id) : base(id)
        {
        }
    }
}
