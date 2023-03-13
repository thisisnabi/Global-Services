using Hrg.Svr.CleanArchitecture.SharedKernel;

namespace Hrg.Svr.Global.ScrumBoard.Domain.ProjectAggregate
{
    public class Sprint : EntityBase<Guid>
    {
        public Sprint(Guid id) : base(id)
        {

        }
    }
}