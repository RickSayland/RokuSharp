using RestSharp;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RokuAPI
{
    public class RokuControl
    {
        private readonly RestSharp.RestClient _client;
        public readonly List<App> Apps = new List<App>();

        public RokuControl(string URI)
        {
            _client = new RestClient(URI);
            try
            {
                this.Apps = this.GetListOfApps();
            }
            catch (Exception ex)
            {
                this.Apps.Add(new App { Id = "0", Value = ex.Message });
            }
        }
        public RokuControl(string IP_ADDRESS, string PORT) : this("http://" + IP_ADDRESS + ":" + PORT)
        {

        }
        public void PressBack()
        {
            this.TryPressButton(Constants.Buttons.Back);
        }
        public void PressBackspace()
        {
            this.TryPressButton(Constants.Buttons.Backspace);
        }
        public void PressChannelDown()
        {
            this.TryPressButton(Constants.Buttons.ChannelDown);
        }
        public void PressChannelUp()
        {
            this.TryPressButton(Constants.Buttons.ChannelUp);
        }
        public void PressDown()
        {
            this.TryPressButton(Constants.Buttons.Down);
        }
        public void PressEnter()
        {
            this.TryPressButton(Constants.Buttons.Enter);
        }
        public void PressFindRemote()
        {
            this.TryPressButton(Constants.Buttons.FindRemote);
        }
        public void PressFwd()
        {
            this.TryPressButton(Constants.Buttons.Fwd);
        }
        public void PressHome()
        {
            this.TryPressButton(Constants.Buttons.Home);
        }
        public void PressInfo()
        {
            this.TryPressButton(Constants.Buttons.Info);
        }
        public void PressInputAV1()
        {
            this.TryPressButton(Constants.Buttons.InputAV1);
        }
        public void PressInputHDMI1()
        {
            this.TryPressButton(Constants.Buttons.InputHDMI1);
        }
        public void PressInputHDMI2()
        {
            this.TryPressButton(Constants.Buttons.InputHDMI2);
        }
        public void PressInputHDMI3()
        {
            this.TryPressButton(Constants.Buttons.InputHDMI3);
        }
        public void PressInputHDMI4()
        {
            this.TryPressButton(Constants.Buttons.InputHDMI4);
        }
        public void PressInputTuner()
        {
            this.TryPressButton(Constants.Buttons.InputTuner);
        }
        public void PressInstantReplay()
        {
            this.TryPressButton(Constants.Buttons.InstantReplay);
        }
        public void PressLeft()
        {
            this.TryPressButton(Constants.Buttons.Left);
        }
        public void PressPlay()
        {
            this.TryPressButton(Constants.Buttons.Play);
        }
        public void PressPowerOff()
        {
            this.TryPressButton(Constants.Buttons.PowerOff);
        }
        public void PressRev()
        {
            this.TryPressButton(Constants.Buttons.Rev);
        }
        public void PressRight()
        {
            this.TryPressButton(Constants.Buttons.Right);
        }
        public void PressSearch()
        {
            this.TryPressButton(Constants.Buttons.Search);
        }
        public void PressSelect()
        {
            this.TryPressButton(Constants.Buttons.Select);
        }
        public void PressUp()
        {
            this.TryPressButton(Constants.Buttons.Up);
        }
        public void PressVolumeDown()
        {
            this.TryPressButton(Constants.Buttons.VolumeDown);
        }
        public void PressVolumeMute()
        {
            this.TryPressButton(Constants.Buttons.VolumeMute);
        }
        public void PressVolumeUp()
        {
            this.TryPressButton(Constants.Buttons.VolumeUp);
        }
        public void TryPressButton(string buttonName)
        {
            try
            {
                this.PressButton(buttonName);
            }
            catch
            {
                //OH NO
            }
        }
        public void PressButton(string buttonName)
        {
            var response = _client.Execute(new RestRequest("keypress/"+ buttonName, Method.POST));
            if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
        }
        public void TryLaunchApp(string appId)
        {
            try
            {
                this.LaunchApp(appId);
            }
            catch
            {
                //OH NO
            }
        }
        public void LaunchApp(string appId)
        {
            var response = _client.Execute(new RestRequest("launch/" + appId, Method.POST));
            if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
        }
        public List<App> GetListOfApps()
        {
            var response = _client.Execute<List<App>>(new RestRequest("query/apps", Method.GET, DataFormat.Xml));
            if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
            return response.Data;
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
