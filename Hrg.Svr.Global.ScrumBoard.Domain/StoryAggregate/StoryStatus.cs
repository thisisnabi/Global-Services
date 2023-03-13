using Ardalis.SmartEnum;

namespace Hrg.Srv.Global.ScrumBoard.Domain.StoryAggregate;

public class StoryStatus : SmartEnum<StoryStatus>
{
    public static readonly StoryStatus Approved = new(nameof(Approved), 0);
    public static readonly StoryStatus Rejected = new(nameof(Rejected), 1);
    public static readonly StoryStatus Done = new(nameof(Done), 1);

    protected StoryStatus(string name, int value) : base(name, value) { }
}
