using System;
using Plugin.Connectivity;

namespace LaunchDarkly.Xamarin
{
    internal class MobileConnectionManager : IConnectionManager
    {
        internal Action<bool> ConnectionChanged;

        internal MobileConnectionManager()
        {
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
        }

        public bool IsConnected => CrossConnectivity.Current.IsConnected;

        void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            ConnectionChanged?.Invoke(IsConnected);
        }
    }
}
