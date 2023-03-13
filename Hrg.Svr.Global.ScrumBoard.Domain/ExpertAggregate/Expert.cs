using Hrg.Svr.CleanArchitecture.SharedKernel;
using Hrg.Svr.CleanArchitecture.SharedKernel.Interfaces;

namespace Hrg.Svr.Global.ScrumBoard.Domain.ExpertAggregate
{
    public class Expert : EntityBase<Guid>, IAggregateRoot
    {
        public Expert(Guid id) : base(id)
        {

        }
    }
}
