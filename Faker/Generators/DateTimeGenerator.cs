namespace DTOFiller;

public class DateTimeGenerator : IGenerator
{
    static Random rng = new Random();
    public object Get()
    {
        return RandomDay();
    }

    private DateTime RandomDay()
    {
        DateTime start = new DateTime(1995, 1, 1);
        int range = (DateTime.Today - start).Days; 
        start = start.AddDays(rng.Next(range))
                     .AddHours(rng.Next(24))
                     .AddMinutes(rng.Next(60))
                     .AddSeconds(rng.Next(60));
        return start;
    }
}
