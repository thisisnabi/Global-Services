using Hrg.Svr.CleanArchitecture.SharedKernel;

namespace Hrg.Svr.Global.ScrumBoard.Domain.ProjectAggregate
{
    public class Backlog : EntityBase<Guid>
    {
        public Backlog(Guid id) : base(id)
        {

        }
    }
}
