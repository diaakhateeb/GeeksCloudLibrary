﻿using GeeksCloudLibrary.Resource.VirtualMachine.OperatingSystem.Enum;
using GeeksCloudLibrary.Resource.VirtualMachine.OperatingSystem.Interfaces;

namespace GeeksCloudLibrary.Resource.VirtualMachine.OperatingSystem
{
    public class WindowsOperatingSystem : IOperatingSystem
    {
        public int Version { get; set; }
        public OperatingSystemArchitecture Architecture { get; set; }
        public string Vendor { get; set; }
        public string Name { get; set; }
    }
}