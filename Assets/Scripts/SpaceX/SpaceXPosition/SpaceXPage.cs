using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.SpaceX.SpaceXPosition
{
    public class SpaceXPage : MonoBehaviour
    {
        private readonly SpaceXActions _spaceXActions;
        public Text TextSpaceXEarthDistance;
        public Text TextSpaceXMarsDistance;
        public Text TextSpaceXSpeed;
        public Text TextSpaceXPeriod;
        public Text TextSpaceXLongitude;

        private SpaceXEntity _spaceX = SpaceXMotherObject.GetParameters();

        public SpaceXPage()
        {
            _spaceXActions = new SpaceXActions();
        }

        void Start()
        {

        }

        void Update()
        {
            TextSpaceXEarthDistance.text = "Distance to Earth: " + _spaceXActions.GetSpaceXParameters(_spaceX.EarthDistanceKm) + " km";
            TextSpaceXMarsDistance.text = "Distance to Mars: " + _spaceXActions.GetSpaceXParameters(_spaceX.MarsDistanceKm) + " km";
            TextSpaceXSpeed.text = "Speed : " + _spaceXActions.GetSpaceXParameters(_spaceX.SpeedKph) + " kph";
            TextSpaceXPeriod.text = "Period : " + _spaceXActions.GetSpaceXParameters(_spaceX.PeriodDays) + " days";
            TextSpaceXLongitude.text = "Space X Longitude : " + _spaceXActions.GetSpaceXParameters(_spaceX.Longitude);
        }
    }
}
