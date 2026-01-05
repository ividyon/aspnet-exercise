namespace Server.Endpoints;

public record Timestamp(DateTime Date)
{
}

public interface ITimestampService
{
    public Timestamp GetTimestamp();
}

public class TimestampService : ITimestampService
{
    public Timestamp GetTimestamp()
    {
        return new Timestamp(DateTime.UtcNow);
    }
}