﻿using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace Cheesebaron.MvxPlugins.DeviceInfo.Touch
{
    [Preserve(AllMembers = true)]
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IDeviceInfo>(new TouchDeviceInfo());
            Mvx.RegisterSingleton<IDisplay>(new TouchDisplay());
        }
    }
}
