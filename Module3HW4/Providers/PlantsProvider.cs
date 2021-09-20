namespace Module3HW4.Providers
{
    using Module3HW4.Providers.Abstractions;
    using Module3HW4.Models;
    using Module3HW4.Enums;
    using Module3HW4.Models.Plants.Shrubs.EvergreenShrubs;
    using Module3HW4.Models.Plants.Shrubs;

    public class PlantsProvider : IPlantsProvider
    {
        public PlantsProvider()
        {
            Plant[] plants = new Plant[]
                {
                    new FrostResistant
                    {
                     Name = "BuxusSempervirens",
                     OriginCountry = OriginCountry.Ukraine,
                     Space = new Space(2.5) { Unit = "squareMeters" },
                     ShrubShape = ShrubShape.Columnar,
                     EvergreenShrubType = EvergreenShrubType.Climbing,
                     MinTemperature = MinTemperature.MinusTen
                    },

                    new Undersized
                    {
                     Name = "UlmusParvifolia",
                     OriginCountry = OriginCountry.Canada,
                     Space = new Space(0.5) { Unit = "squareMeters" },
                     ShrubShape = ShrubShape.HorizontalSpreading,
                     EvergreenShrubType = EvergreenShrubType.Heather,
                     UndersizedType = UndersizedType.Border
                    },

                    new FloweringShrub
                    {
                     Name = "Callistemon",
                     OriginCountry = OriginCountry.France,
                     Space = new Space(1.5) { Unit = "squareMeters" },
                     ShrubShape = ShrubShape.HorizontalSpreading,
                     FloweringShrubType = FloweringShrubType.Azalea
                    },

                    new FruitAndBerryShrub
                    {
                     Name = "TrueGooseberries",
                     OriginCountry = OriginCountry.Ukraine,
                     Space = new Space(1) { Unit = "squareMeters" },
                     ShrubShape = ShrubShape.HorizontalSpreading,
                     FruitAndBerryShrubTypes = FruitAndBerryShrubTypes.Gooseberry
                    },

                    new FruitAndBerryShrub
                    {
                     Name = "CulinaryGooseberries",
                     OriginCountry = OriginCountry.Canada,
                     Space = new Space(2) { Unit = "squareMeters" },
                     ShrubShape = ShrubShape.HorizontalSpreading,
                     FruitAndBerryShrubTypes = FruitAndBerryShrubTypes.Gooseberry
                    }
                };
        }

        public Plant[] Plants { get; }
    }
}
