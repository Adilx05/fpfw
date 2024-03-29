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
    internal static partial class InputExtensions
    {
        internal static void Activated(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("367b86c5-4b5d-4748-b2fc-7ba2f8514e70"));
        }
        internal static void Unknown(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("58390eda-38bf-43a0-ba33-48cc1750b831"));
        }
        internal static void Idle(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("829e9918-56b1-4c31-b689-8097fe222c65"));
        }
        internal static void FireAlarm(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("ac9a8470-59d6-43ec-9176-b11de1233339"));
        }
        internal static void Alarm(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("498ff28a-69d9-44d7-8564-a6a9a64873c4"));
        }
        internal static void Tamper(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("aa437e24-42ef-4c67-8b30-68f8654ddf4d"));
        }
        internal static void ConfigurationFailure(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("eb843b75-1e34-4588-96fd-12f00c4993c6"));
        }
        internal static void Failure(this IStatusSender statusSender, Input device)
        {
            device.DriverContext.StatusSender.Send(device.SimpleDevice.Id, Guid.Parse("42e668f6-40be-4d51-972d-f24f6afbdbe3"));
        }
    }
}