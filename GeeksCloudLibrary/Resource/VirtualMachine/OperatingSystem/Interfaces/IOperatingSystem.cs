﻿using GeeksCloudLibrary.Resource.VirtualMachine.OperatingSystem.Enum;
using GeeksCloudLibrary.Shared.Interfaces;

namespace GeeksCloudLibrary.Resource.VirtualMachine.OperatingSystem.Interfaces
{
    /// <summary>
    /// IOperatingSystem interface.
    /// </summary>
    public interface IOperatingSystem : IResource
    {
        int Version { get; set; }
        OperatingSystemArchitecture Architecture { get; set; }
        string Vendor { get; set; }
    }
}
