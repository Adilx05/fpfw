// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a C4 community web.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     INFO: For extending behaviour of each generated class create another partial 
//     class in same namespace (public partial class [ClassName] { })
// </auto-generated>
// ------------------------------------------------------------------------------
using Gamanet.C4.Driver.SimpleDriver.Helpers;
using Gamanet.C4.SDK.Framework4.Device.Builder;
using Gamanet.C4.SimpleInterfaces;
using System;

namespace Gamanet.C4.Driver.SimpleDriver.Devices
{
    internal static partial class CentralUnitExtensions
    {
        internal static void SendingDeviceConfiguration(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("8f04cfb1-10bf-4778-902b-1778b7ad212a"));
        }
        internal static void Unknown(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("58390eda-38bf-43a0-ba33-48cc1750b831"));
        }
        internal static void Idle(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("829e9918-56b1-4c31-b689-8097fe222c65"));
        }
        internal static void LoadingDeviceConfiguration(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("b776690d-7b10-45b6-ab79-817eaccb085c"));
        }
        internal static void Bypass(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("b9283265-c4c8-4677-867d-5b8af6b79a68"));
        }
        internal static void DownloadingHistory(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("4af77e7d-90ec-4498-b3a1-3fd538492831"));
        }
        internal static void Alarm(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("498ff28a-69d9-44d7-8564-a6a9a64873c4"));
        }
        internal static void Tamper(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("aa437e24-42ef-4c67-8b30-68f8654ddf4d"));
        }
        internal static void ConfigurationFailure(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("eb843b75-1e34-4588-96fd-12f00c4993c6"));
        }
        internal static void Failure(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("42e668f6-40be-4d51-972d-f24f6afbdbe3"));
        }
        internal static void Disconnected(this IStatusSender statusSender, CentralUnit device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("72a463fd-8004-4196-a06c-f328f8db7f42"));
        }
    }
}