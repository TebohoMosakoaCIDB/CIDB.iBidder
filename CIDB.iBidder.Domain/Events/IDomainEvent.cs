namespace CIDB.iBidder.Domain.Events
{
    public interface IDomainEvent
    {
        DateTime OccurredOnUtc { get; }
    }
}
