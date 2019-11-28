using RestSharp;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RokuAPI
{
    public class RokuControl
    {
        private readonly RestSharp.RestClient _client;

        public RokuControl(string IP_ADDRESS)
        {
            _client = new RestClient(IP_ADDRESS);
        }
        public void PressBack()
        {
            this.PressButton(Constants.Buttons.Back);
        }
        public void PressBackspace()
        {
            this.PressButton(Constants.Buttons.Backspace);
        }
        public void PressChannelDown()
        {
            this.PressButton(Constants.Buttons.ChannelDown);
        }
        public void PressChannelUp()
        {
            this.PressButton(Constants.Buttons.ChannelUp);
        }
        public void PressDown()
        {
            this.PressButton(Constants.Buttons.Down);
        }
        public void PressEnter()
        {
            this.PressButton(Constants.Buttons.Enter);
        }
        public void PressFindRemote()
        {
            this.PressButton(Constants.Buttons.FindRemote);
        }
        public void PressFwd()
        {
            this.PressButton(Constants.Buttons.Fwd);
        }
        public void PressHome()
        {
            this.PressButton(Constants.Buttons.Home);
        }
        public void PressInfo()
        {
            this.PressButton(Constants.Buttons.Info);
        }
        public void PressInputAV1()
        {
            this.PressButton(Constants.Buttons.InputAV1);
        }
        public void PressInputHDMI1()
        {
            this.PressButton(Constants.Buttons.InputHDMI1);
        }
        public void PressInputHDMI2()
        {
            this.PressButton(Constants.Buttons.InputHDMI2);
        }
        public void PressInputHDMI3()
        {
            this.PressButton(Constants.Buttons.InputHDMI3);
        }
        public void PressInputHDMI4()
        {
            this.PressButton(Constants.Buttons.InputHDMI4);
        }
        public void PressInputTuner()
        {
            this.PressButton(Constants.Buttons.InputTuner);
        }
        public void PressInstantReplay()
        {
            this.PressButton(Constants.Buttons.InstantReplay);
        }
        public void PressLeft()
        {
            this.PressButton(Constants.Buttons.Left);
        }
        public void PressPlay()
        {
            this.PressButton(Constants.Buttons.Play);
        }
        public void PressPowerOff()
        {
            this.PressButton(Constants.Buttons.PowerOff);
        }
        public void PressRev()
        {
            this.PressButton(Constants.Buttons.Rev);
        }
        public void PressRight()
        {
            this.PressButton(Constants.Buttons.Right);
        }
        public void PressSearch()
        {
            this.PressButton(Constants.Buttons.Search);
        }
        public void PressSelect()
        {
            this.PressButton(Constants.Buttons.Select);
        }
        public void PressUp()
        {
            this.PressButton(Constants.Buttons.Up);
        }
        public void PressVolumeDown()
        {
            this.PressButton(Constants.Buttons.VolumeDown);
        }
        public void PressVolumeMute()
        {
            this.PressButton(Constants.Buttons.VolumeMute);
        }
        public void PressVolumeUp()
        {
            this.PressButton(Constants.Buttons.VolumeUp);
        }
        public void PressButton(string buttonName)
        {
            _client.Execute(new RestRequest("keypress/"+ buttonName, Method.POST));
        }
        public void LaunchApp(string appId)
        {
            _client.Execute(new RestRequest("launch/" + appId, Method.POST));
        }
        public List<App> GetListOfApps()
        {
            List<App> appList = new List<App>();
            var request = new RestRequest("query/apps", Method.GET,DataFormat.Xml);

            var response = _client.Execute<List<App>>(request);
            foreach (App a in response.Data)
            {
                appList.Add(a);
            }
            return appList;
        }
    }
    [XmlRoot(ElementName = "app")]
    public class App
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlText]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "subtype")]
        public string Subtype { get; set; }
    }

    [XmlRoot(ElementName = "apps")]
    public class Apps
    {
        [XmlElement(ElementName = "app")]
        public List<App> App { get; set; }
    }
}
