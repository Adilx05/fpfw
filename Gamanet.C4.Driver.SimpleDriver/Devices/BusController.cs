using Gamanet.C4.SDK.Framework4.Device.Builder;
using Gamanet.C4.SimpleInterfaces;

namespace Gamanet.C4.Driver.SimpleDriver.Devices
{
    public partial class BusController
    {
        internal CentralUnit CentralUnit { get; private set; }

        partial void OnInitialized(SimpleDeviceV1 simpleDevice, IDriverContext driverContext)
        {
            CentralUnit = (CentralUnit)DriverContext.DeviceTree.GetNode(Id).ChildNodes[0].Device;
        }
    }
}