using Hrg.Svr.CleanArchitecture.SharedKernel;
using Hrg.Svr.CleanArchitecture.SharedKernel.Interfaces;

namespace Hrg.Svr.Global.ScrumBoard.Domain.ProjectAggregate
{
    public class Project : EntityBase<Guid>, IAggregateRoot
    {
        public string Name { get; set; } = string.Empty;




        public Project(Guid id) : base(id)
        {

        }


    }
}
