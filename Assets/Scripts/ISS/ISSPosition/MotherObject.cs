namespace Assets.Scripts.ISS.ISSPosition
{
    public class ISSMotherObject
    {
        public static ISSEntity GetParameters()
        {
            return new ISSEntity
            {
                Latitude = "latitude",
                Longitude = "longitude",
                Timestamp = "timestamp"
            };
        }
    }
}
