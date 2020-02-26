using SimpleJSON;
using System;
using System.Net;
using System.Collections.Generic;

namespace Assets.Scripts.ISS.ISSPosition
{
    internal class ISSActions
    {

        internal List<string> GetISSParametersList()
        {
            List<string> listPosition = new List<string>();
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("http://api.open-notify.org/iss-now.json");
            var N = JSON.Parse(strPageCode);
            string latitude = N["iss_position"]["latitude"].Value;
            string longitude = N["iss_position"]["longitude"].Value;
            string timestamp = N["timestamp"].Value;
            listPosition.Add(latitude);
            listPosition.Add(longitude);
            listPosition.Add(timestamp);

            return listPosition;
        }

        internal string ISSPositionGetter(string value)
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("http://api.open-notify.org/iss-now.json");
            var N = JSON.Parse(strPageCode);
            string searchedPosition = N["iss_position"]["" + value + ""].Value;

            return searchedPosition;
        }

        internal string ISSTimeGetter(string value)
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("http://api.open-notify.org/iss-now.json");
            var N = JSON.Parse(strPageCode);
            string searchedTime = N["" + value + ""].Value;
            //Debug.Log(searchedTime);

            return searchedTime;
        }

        internal double TestGetSpeed(double firstPositionX, double secondPositionX, double firstPositionY, double secondPositionY)
        {
            double road, speed;      
            road = Math.Sqrt(((Math.Pow(Math.Abs(firstPositionX - secondPositionX), 2)) + (Math.Pow(Math.Abs(firstPositionY - secondPositionY), 2))));
            road = road * 111.196672;

            return road;
        }
    }
}
