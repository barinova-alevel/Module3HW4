namespace Module3HW4.Providers.Abstractions
{
    using Module3HW4.Models;

    public interface IShrubsProvider
    {
        Plant[] Plants { get; }
    }
}
