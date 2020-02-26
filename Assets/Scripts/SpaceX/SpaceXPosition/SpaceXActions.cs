using SimpleJSON;
using System.Net;

namespace Assets.Scripts.SpaceX.SpaceXPosition
{
    internal class SpaceXActions
    {
        public string GetSpaceXParameters(string value)
        {
            WebClient client = new WebClient();
            string strPageCode = client.DownloadString("https://api.spacexdata.com/v3/roadster");
            var N = JSON.Parse(strPageCode);
            string sparam = N["" + value + ""].Value;
            //Debug.Log(sparam);

            return sparam;
        }
    }
}
