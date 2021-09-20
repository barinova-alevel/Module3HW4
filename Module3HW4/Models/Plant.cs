namespace Module3HW4.Models
{
    using Module3HW4.Enums;
    public abstract class Plant
    {
        public string Name { get; init; }
        public OriginCountry OriginCountry { get; init; }
        public Space Space { get; init; }
    }
}
