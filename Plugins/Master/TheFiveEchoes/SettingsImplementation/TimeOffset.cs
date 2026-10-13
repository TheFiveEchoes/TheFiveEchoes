using UnityEngine;

namespace TheFiveEchoes.SettingsImplementation
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    public class TimeOffset : MonoBehaviour
    {
        readonly string configName = "TheFiveEchoesSettings";
        public void Start()
        {
            string SettingsFile = KSPUtil.ApplicationRootPath + "GameData/TheFiveEchoes/TheFiveEchoesSettings.cfg";
            float offsetSeconds = 17287200;
            UrlDir.UrlConfig[] configs = GameDatabase.Instance.GetConfigs(configName);
            foreach (UrlDir.UrlConfig file in configs)
            {
                ConfigNode config = file.config;
                var TimeOffset = config.GetValue("TimeOffset");
                bool timeOffset = bool.Parse(TimeOffset);
                if (timeOffset == true)
                {
                    if (Planetarium.GetUniversalTime() < 20.0)
                    {
                        Debug.Log("[TFETimeOffset]: New Save detected! Initializing time offset...");

                        Planetarium.SetUniversalTime(offsetSeconds);

                        GamePersistence.SaveGame("persistent", HighLogic.SaveFolder, SaveMode.OVERWRITE);
                    }
                }
                Destroy(this);
            }
        }
    }
}
