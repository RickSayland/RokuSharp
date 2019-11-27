using RestSharp;

namespace RokuAPI
{
    public class RokuControl
    {
        private readonly RestSharp.RestClient _client;

        public RokuControl(string IP_ADDRESS)
        {
            //_client = new RestSharp.RestClient("http://192.168.1.13:8060");
            _client = new RestClient(IP_ADDRESS);
        }
        public void PressUp()
        {
            this.PressButton(Constants.Buttons.Up);
        }
        public void PressDown()
        {
            this.PressButton(Constants.Buttons.Down);
        }
        public void PressButton(string buttonName)
        {
            _client.Execute(new RestRequest("keypress/"+ buttonName, Method.POST));
        }
        public void LaunchApp(string appId)
        {
            _client.Execute(new RestRequest("launch/" + appId, Method.POST));
        }
    }
}
