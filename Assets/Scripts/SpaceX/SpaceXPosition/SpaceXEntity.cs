namespace Assets.Scripts.SpaceX.SpaceXPosition
{
    [System.Serializable]
    public class SpaceXEntity
    {
        public string EarthDistanceKm { get; set; }
        public string MarsDistanceKm { get; set; }
        public string SpeedKph { get; set; }
        public string PeriodDays { get; set; }
        public string Longitude { get; set; }
    }
}
