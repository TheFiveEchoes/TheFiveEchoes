using System.IO;
using System.Threading;
using UnityEngine;

namespace TheFiveEchoes.SettingsImplementation
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    public class AutoCacheDeletion : MonoBehaviour
    {
        readonly string configName = "TheFiveEchoesSettings";
        public void Start()
        {
            string SettingsFile = KSPUtil.ApplicationRootPath + "GameData/TheFiveEchoes/TheFiveEchoesSettings.cfg";
            if (!File.Exists(SettingsFile))
            {
                Destroy(this);
            }
            UrlDir.UrlConfig[] configs = GameDatabase.Instance.GetConfigs(configName);
            foreach (UrlDir.UrlConfig file in configs)
            {
                ConfigNode config = file.config;
                var AutoDeleteCache = config.GetValue("AutoDeleteCache");
                bool CacheDeletion = bool.Parse(AutoDeleteCache);
                if (CacheDeletion == true)
                {
                    string CacheDirectory = KSPUtil.ApplicationRootPath + "GameData/TheFiveEchoes/Cache/";
                    if (Directory.Exists(CacheDirectory))
                    {
                        Directory.Delete(CacheDirectory, true);
                        Thread.Sleep(100);
                        Debug.Log("[TheFiveEchoes]: Deleting Cache Directory");
                        Destroy(this);
                    }
                    else
                    {
                        Debug.Log("[TheFiveEchoes]: Cache Directory has already been deleted");
                        Destroy(this);
                    }
                }
            }
        }
    }
}
