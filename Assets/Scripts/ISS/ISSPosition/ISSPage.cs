using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.ISS.ISSPosition
{
    public class ISSPage : MonoBehaviour
    {
        public Text TextLatitude;
        public Text TextLongitude;
        public Text TextSpeedIss;
        public Text TextTimestamp;

        private ISSEntity _issParameters = ISSMotherObject.GetParameters();
        private readonly ISSActions _issActions;

        public ISSPage()
        {
            _issActions = new ISSActions();
        }

        void Update()
        {
            TextLatitude.text = "ISS Latitude : " + _issActions.ISSPositionGetter(_issParameters.Latitude);
            TextLongitude.text = "ISS Longitude : " + _issActions.ISSPositionGetter(_issParameters.Longitude);
            TextTimestamp.text = "Timestamp : " + _issActions.ISSTimeGetter(_issParameters.Timestamp);
            //TextSpeedIss.text = "Speed : " + getFinalSpeed() + " kps";
        }

        public double getFinalSpeed()
        {
            double oneX, twoX, oneY, twoY, timestamp, timestamp1;
            oneX = double.Parse(_issActions.ISSPositionGetter(_issParameters.Latitude), CultureInfo.InvariantCulture.NumberFormat);
            oneY = double.Parse(_issActions.ISSPositionGetter(_issParameters.Longitude), CultureInfo.InvariantCulture.NumberFormat);
            timestamp = double.Parse(_issActions.ISSTimeGetter(_issParameters.Timestamp), CultureInfo.InvariantCulture.NumberFormat);
            Thread.Sleep(5000);
            twoX = double.Parse(_issActions.ISSPositionGetter(_issParameters.Latitude), CultureInfo.InvariantCulture.NumberFormat);
            twoY = double.Parse(_issActions.ISSPositionGetter(_issParameters.Longitude), CultureInfo.InvariantCulture.NumberFormat);
            timestamp1 = double.Parse(_issActions.ISSTimeGetter(_issParameters.Timestamp), CultureInfo.InvariantCulture.NumberFormat);

            double speed = _issActions.TestGetSpeed(oneX, twoX, oneY, twoY) / (timestamp1 - timestamp);

            return speed;
        }

    }
}
