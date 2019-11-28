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
            this.Apps = this.GetListOfApps();
        }
        public RokuControl(string IP_ADDRESS, string PORT) : this("http://" + IP_ADDRESS + ":" + PORT)
        {

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
            try
            {
                var response = _client.Execute(new RestRequest("keypress/" + buttonName, Method.POST));
                if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
            }
            catch
            {
                //OH NO
            }
        }
        public void LaunchApp(string appId)
        {
            try
            {
                var response = _client.Execute(new RestRequest("launch/" + appId, Method.POST));
                if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
            }
            catch
            {
                //OH NO
            }
        }
        public List<App> GetListOfApps()
        {     
            try
            {
                var response = _client.Execute<List<App>>(new RestRequest("query/apps", Method.GET, DataFormat.Xml));
                if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
                return response.Data;
            }
            catch (Exception ex)
            {
                List<App> a = new List<App>();
                var errorApp = new App { Id = "0", Value = ex.Message };
                a.Add(new App { Id = "0", Value = ex.Message });
                return a;
            }
        }
        public Deviceinfo GetDeviceInfo()
        {
            try
            {
                var response = _client.Execute<Deviceinfo>(new RestRequest("query/device-info", Method.GET, DataFormat.Xml));
                if (!response.IsSuccessful) throw new Exception("Cannot connect to Roku");
                return response.Data;
            }
            catch (Exception ex)
            {
                //OH NO
                return new Deviceinfo();
            }
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
    [XmlRoot(ElementName = "device-info")]
    public class Deviceinfo
    {
        [XmlElement(ElementName = "udn")]
        public string Udn { get; set; }
        [XmlElement(ElementName = "serial-number")]
        public string Serialnumber { get; set; }
        [XmlElement(ElementName = "device-id")]
        public string Deviceid { get; set; }
        [XmlElement(ElementName = "advertising-id")]
        public string Advertisingid { get; set; }
        [XmlElement(ElementName = "vendor-name")]
        public string Vendorname { get; set; }
        [XmlElement(ElementName = "model-name")]
        public string Modelname { get; set; }
        [XmlElement(ElementName = "model-number")]
        public string Modelnumber { get; set; }
        [XmlElement(ElementName = "model-region")]
        public string Modelregion { get; set; }
        [XmlElement(ElementName = "is-tv")]
        public string Istv { get; set; }
        [XmlElement(ElementName = "is-stick")]
        public string Isstick { get; set; }
        [XmlElement(ElementName = "screen-size")]
        public string Screensize { get; set; }
        [XmlElement(ElementName = "panel-id")]
        public string Panelid { get; set; }
        [XmlElement(ElementName = "tuner-type")]
        public string Tunertype { get; set; }
        [XmlElement(ElementName = "supports-ethernet")]
        public string Supportsethernet { get; set; }
        [XmlElement(ElementName = "wifi-mac")]
        public string Wifimac { get; set; }
        [XmlElement(ElementName = "wifi-driver")]
        public string Wifidriver { get; set; }
        [XmlElement(ElementName = "network-type")]
        public string Networktype { get; set; }
        [XmlElement(ElementName = "network-name")]
        public string Networkname { get; set; }
        [XmlElement(ElementName = "friendly-device-name")]
        public string Friendlydevicename { get; set; }
        [XmlElement(ElementName = "friendly-model-name")]
        public string Friendlymodelname { get; set; }
        [XmlElement(ElementName = "default-device-name")]
        public string Defaultdevicename { get; set; }
        [XmlElement(ElementName = "user-device-name")]
        public string Userdevicename { get; set; }
        [XmlElement(ElementName = "user-device-location")]
        public string Userdevicelocation { get; set; }
        [XmlElement(ElementName = "build-number")]
        public string Buildnumber { get; set; }
        [XmlElement(ElementName = "software-version")]
        public string Softwareversion { get; set; }
        [XmlElement(ElementName = "software-build")]
        public string Softwarebuild { get; set; }
        [XmlElement(ElementName = "secure-device")]
        public string Securedevice { get; set; }
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "locale")]
        public string Locale { get; set; }
        [XmlElement(ElementName = "time-zone-auto")]
        public string Timezoneauto { get; set; }
        [XmlElement(ElementName = "time-zone")]
        public string Timezone { get; set; }
        [XmlElement(ElementName = "time-zone-name")]
        public string Timezonename { get; set; }
        [XmlElement(ElementName = "time-zone-tz")]
        public string Timezonetz { get; set; }
        [XmlElement(ElementName = "time-zone-offset")]
        public string Timezoneoffset { get; set; }
        [XmlElement(ElementName = "clock-format")]
        public string Clockformat { get; set; }
        [XmlElement(ElementName = "uptime")]
        public string Uptime { get; set; }
        [XmlElement(ElementName = "power-mode")]
        public string Powermode { get; set; }
        [XmlElement(ElementName = "supports-suspend")]
        public string Supportssuspend { get; set; }
        [XmlElement(ElementName = "supports-find-remote")]
        public string Supportsfindremote { get; set; }
        [XmlElement(ElementName = "find-remote-is-possible")]
        public string Findremoteispossible { get; set; }
        [XmlElement(ElementName = "supports-audio-guide")]
        public string Supportsaudioguide { get; set; }
        [XmlElement(ElementName = "supports-rva")]
        public string Supportsrva { get; set; }
        [XmlElement(ElementName = "developer-enabled")]
        public string Developerenabled { get; set; }
        [XmlElement(ElementName = "keyed-developer-id")]
        public string Keyeddeveloperid { get; set; }
        [XmlElement(ElementName = "search-enabled")]
        public string Searchenabled { get; set; }
        [XmlElement(ElementName = "search-channels-enabled")]
        public string Searchchannelsenabled { get; set; }
        [XmlElement(ElementName = "voice-search-enabled")]
        public string Voicesearchenabled { get; set; }
        [XmlElement(ElementName = "notifications-enabled")]
        public string Notificationsenabled { get; set; }
        [XmlElement(ElementName = "notifications-first-use")]
        public string Notificationsfirstuse { get; set; }
        [XmlElement(ElementName = "supports-private-listening")]
        public string Supportsprivatelistening { get; set; }
        [XmlElement(ElementName = "supports-private-listening-dtv")]
        public string Supportsprivatelisteningdtv { get; set; }
        [XmlElement(ElementName = "supports-warm-standby")]
        public string Supportswarmstandby { get; set; }
        [XmlElement(ElementName = "headphones-connected")]
        public string Headphonesconnected { get; set; }
        [XmlElement(ElementName = "supports-ecs-textedit")]
        public string Supportsecstextedit { get; set; }
        [XmlElement(ElementName = "supports-ecs-microphone")]
        public string Supportsecsmicrophone { get; set; }
        [XmlElement(ElementName = "supports-wake-on-wlan")]
        public string Supportswakeonwlan { get; set; }
        [XmlElement(ElementName = "has-play-on-roku")]
        public string Hasplayonroku { get; set; }
        [XmlElement(ElementName = "has-mobile-screensaver")]
        public string Hasmobilescreensaver { get; set; }
        [XmlElement(ElementName = "support-url")]
        public string Supporturl { get; set; }
        [XmlElement(ElementName = "grandcentral-version")]
        public string Grandcentralversion { get; set; }
        [XmlElement(ElementName = "trc-version")]
        public string Trcversion { get; set; }
        [XmlElement(ElementName = "trc-channel-version")]
        public string Trcchannelversion { get; set; }
        [XmlElement(ElementName = "davinci-version")]
        public string Davinciversion { get; set; }
        [XmlElement(ElementName = "has-wifi-extender")]
        public string Haswifiextender { get; set; }
        [XmlElement(ElementName = "has-wifi-5G-support")]
        public string Haswifi5Gsupport { get; set; }
        [XmlElement(ElementName = "can-use-wifi-extender")]
        public string Canusewifiextender { get; set; }
    }
}
