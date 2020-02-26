namespace Assets.Scripts.SpaceX.SpaceXPosition
{
    public class SpaceXMotherObject
    {
        public static SpaceXEntity GetParameters()
        {
            return new SpaceXEntity
            {
                EarthDistanceKm = "earth_distance_km",
                MarsDistanceKm = "mars_distance_km",
                SpeedKph = "speed_kph",
                PeriodDays = "period_days",
                Longitude = "longitude"
            };
        }

    }
}
