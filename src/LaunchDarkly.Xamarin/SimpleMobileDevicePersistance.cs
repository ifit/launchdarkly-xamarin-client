using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace LaunchDarkly.Xamarin
{
    internal class SimpleMobileDevicePersistance : ISimplePersistance
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public void Save(string key, string value)
        {
            AppSettings.AddOrUpdateValue(key, value);
        }

        public string GetValue(string key)
        {
            return AppSettings.GetValueOrDefault(key, null);
        }
    }
}
