using System;

//   _____                           _           _                 _      
//  / ____|                         | |         | |               | |     
// | |  __  ___ _ __   ___ _ __ __ _| |_ ___  __| |   ___ ___   __| | ___ 
// | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \/ _` |  / __/ _ \ / _` |/ _ \
// | |__| |  __/ | | |  __/ | | (_| | ||  __/ (_| | | (_| (_) | (_| |  __/
//  \_____|\___|_| |_|\___|_|  \__,_|\__\___|\__,_|  \___\___/ \__,_|\___|
//                                                                        
//                                                                        
namespace Gamanet.C4.SDK.Enums.Devices
{
	/// <summary>
	/// DeviceCategory
	/// </summary>
	internal static class DeviceCategory
    {
		/// <summary>
		/// Default Device
		/// </summary>
		public static readonly Guid DefaultDevice = new Guid(DeviceCategoryConst.DefaultDevice);

		/// <summary>
		/// Co Detector
		/// </summary>
		public static readonly Guid CoDetector = new Guid(DeviceCategoryConst.CoDetector);

		/// <summary>
		/// Key
		/// </summary>
		public static readonly Guid Key = new Guid(DeviceCategoryConst.Key);

		/// <summary>
		/// Camera
		/// </summary>
		public static readonly Guid Camera = new Guid(DeviceCategoryConst.Camera);

		/// <summary>
		/// Card Reader
		/// </summary>
		public static readonly Guid CardReader = new Guid(DeviceCategoryConst.CardReader);

		/// <summary>
		/// Light Bulb Monochrome
		/// </summary>
		public static readonly Guid LightBulbMonochrome = new Guid(DeviceCategoryConst.LightBulbMonochrome);

		/// <summary>
		/// Video Output
		/// </summary>
		public static readonly Guid VideoOutput = new Guid(DeviceCategoryConst.VideoOutput);

		/// <summary>
		/// Lighting
		/// </summary>
		public static readonly Guid Lighting = new Guid(DeviceCategoryConst.Lighting);

		/// <summary>
		/// Shock Detector
		/// </summary>
		public static readonly Guid ShockDetector = new Guid(DeviceCategoryConst.ShockDetector);

		/// <summary>
		/// Fire Detector In Floor
		/// </summary>
		public static readonly Guid FireDetectorInFloor = new Guid(DeviceCategoryConst.FireDetectorInFloor);

		/// <summary>
		/// BusController
		/// </summary>
		public static readonly Guid BusController = new Guid(DeviceCategoryConst.BusController);

		/// <summary>
		/// Fire Button
		/// </summary>
		public static readonly Guid FireButton = new Guid(DeviceCategoryConst.FireButton);

		/// <summary>
		/// Door
		/// </summary>
		public static readonly Guid Door = new Guid(DeviceCategoryConst.Door);

		/// <summary>
		/// System
		/// </summary>
		public static readonly Guid System = new Guid(DeviceCategoryConst.System);

		/// <summary>
		/// Keypad
		/// </summary>
		public static readonly Guid Keypad = new Guid(DeviceCategoryConst.Keypad);

		/// <summary>
		/// Automation
		/// </summary>
		public static readonly Guid Automation = new Guid(DeviceCategoryConst.Automation);

		/// <summary>
		/// HVAC
		/// </summary>
		public static readonly Guid HVAC = new Guid(DeviceCategoryConst.HVAC);

		/// <summary>
		/// Keypad And Card Reader
		/// </summary>
		public static readonly Guid KeypadAndCardReader = new Guid(DeviceCategoryConst.KeypadAndCardReader);

		/// <summary>
		/// Fire Group
		/// </summary>
		public static readonly Guid FireGroup = new Guid(DeviceCategoryConst.FireGroup);

		/// <summary>
		/// Video Input
		/// </summary>
		public static readonly Guid VideoInput = new Guid(DeviceCategoryConst.VideoInput);

		/// <summary>
		/// Audio Input
		/// </summary>
		public static readonly Guid AudioInput = new Guid(DeviceCategoryConst.AudioInput);

		/// <summary>
		/// Audio Output
		/// </summary>
		public static readonly Guid AudioOutput = new Guid(DeviceCategoryConst.AudioOutput);

		/// <summary>
		/// Generic Device
		/// </summary>
		public static readonly Guid GenericDevice = new Guid(DeviceCategoryConst.GenericDevice);

		/// <summary>
		/// EntityTypeRoot
		/// </summary>
		public static readonly Guid EntityTypeRoot = new Guid(DeviceCategoryConst.EntityTypeRoot);

		/// <summary>
		/// Max Temperature Detector
		/// </summary>
		public static readonly Guid MaxTemperatureDetector = new Guid(DeviceCategoryConst.MaxTemperatureDetector);

		/// <summary>
		/// PBX
		/// </summary>
		public static readonly Guid PBX = new Guid(DeviceCategoryConst.PBX);

		/// <summary>
		/// Lift Door
		/// </summary>
		public static readonly Guid LiftDoor = new Guid(DeviceCategoryConst.LiftDoor);

		/// <summary>
		/// Group
		/// </summary>
		public static readonly Guid Group = new Guid(DeviceCategoryConst.Group);

		/// <summary>
		/// DVR / NVR
		/// </summary>
		public static readonly Guid DVRNVR = new Guid(DeviceCategoryConst.DVRNVR);

		/// <summary>
		/// Intercom
		/// </summary>
		public static readonly Guid Intercom = new Guid(DeviceCategoryConst.Intercom);

		/// <summary>
		/// Magnetic Detector
		/// </summary>
		public static readonly Guid MagneticDetector = new Guid(DeviceCategoryConst.MagneticDetector);

		/// <summary>
		/// Dual Detector
		/// </summary>
		public static readonly Guid DualDetector = new Guid(DeviceCategoryConst.DualDetector);

		/// <summary>
		/// Gauge
		/// </summary>
		public static readonly Guid Gauge = new Guid(DeviceCategoryConst.Gauge);

		/// <summary>
		/// Expander
		/// </summary>
		public static readonly Guid Expander = new Guid(DeviceCategoryConst.Expander);

		/// <summary>
		/// Fire Detector In Ceiling
		/// </summary>
		public static readonly Guid FireDetectorInCeiling = new Guid(DeviceCategoryConst.FireDetectorInCeiling);

		/// <summary>
		/// Ptz Camera
		/// </summary>
		public static readonly Guid PtzCamera = new Guid(DeviceCategoryConst.PtzCamera);

		/// <summary>
		/// Central Unit
		/// </summary>
		public static readonly Guid CentralUnit = new Guid(DeviceCategoryConst.CentralUnit);

		/// <summary>
		/// Intercom Station
		/// </summary>
		public static readonly Guid IntercomStation = new Guid(DeviceCategoryConst.IntercomStation);

		/// <summary>
		/// Turnstile
		/// </summary>
		public static readonly Guid Turnstile = new Guid(DeviceCategoryConst.Turnstile);

		/// <summary>
		/// IsConnector
		/// </summary>
		public static readonly Guid IsConnector = new Guid(DeviceCategoryConst.IsConnector);

		/// <summary>
		/// Fire Panel
		/// </summary>
		public static readonly Guid FirePanel = new Guid(DeviceCategoryConst.FirePanel);

		/// <summary>
		/// Detectors
		/// </summary>
		public static readonly Guid Detectors = new Guid(DeviceCategoryConst.Detectors);

		/// <summary>
		/// Device Groups
		/// </summary>
		public static readonly Guid DeviceGroups = new Guid(DeviceCategoryConst.DeviceGroups);

		/// <summary>
		/// Thermo Differential Detector
		/// </summary>
		public static readonly Guid ThermoDifferentialDetector = new Guid(DeviceCategoryConst.ThermoDifferentialDetector);

		/// <summary>
		/// Audio / Video
		/// </summary>
		public static readonly Guid AudioVideo = new Guid(DeviceCategoryConst.AudioVideo);

		/// <summary>
		/// Input
		/// </summary>
		public static readonly Guid Input = new Guid(DeviceCategoryConst.Input);

		/// <summary>
		/// Finger Print Reader
		/// </summary>
		public static readonly Guid FingerPrintReader = new Guid(DeviceCategoryConst.FingerPrintReader);

		/// <summary>
		/// Panels
		/// </summary>
		public static readonly Guid Panels = new Guid(DeviceCategoryConst.Panels);

		/// <summary>
		/// Light Bulb
		/// </summary>
		public static readonly Guid LightBulb = new Guid(DeviceCategoryConst.LightBulb);

		/// <summary>
		/// Emergency Button
		/// </summary>
		public static readonly Guid EmergencyButton = new Guid(DeviceCategoryConst.EmergencyButton);

		/// <summary>
		/// Doors
		/// </summary>
		public static readonly Guid Doors = new Guid(DeviceCategoryConst.Doors);

		/// <summary>
		/// Lift Unit
		/// </summary>
		public static readonly Guid LiftUnit = new Guid(DeviceCategoryConst.LiftUnit);

		/// <summary>
		/// Ramp
		/// </summary>
		public static readonly Guid Ramp = new Guid(DeviceCategoryConst.Ramp);

		/// <summary>
		/// Infra Detector
		/// </summary>
		public static readonly Guid InfraDetector = new Guid(DeviceCategoryConst.InfraDetector);

		/// <summary>
		/// Input Output Devices
		/// </summary>
		public static readonly Guid InputOutputDevices = new Guid(DeviceCategoryConst.InputOutputDevices);

		/// <summary>
		/// Access Panel
		/// </summary>
		public static readonly Guid AccessPanel = new Guid(DeviceCategoryConst.AccessPanel);

		/// <summary>
		/// Detector
		/// </summary>
		public static readonly Guid Detector = new Guid(DeviceCategoryConst.Detector);

		/// <summary>
		/// Light Bulb Color
		/// </summary>
		public static readonly Guid LightBulbColor = new Guid(DeviceCategoryConst.LightBulbColor);

		/// <summary>
		/// Alarm Panel
		/// </summary>
		public static readonly Guid AlarmPanel = new Guid(DeviceCategoryConst.AlarmPanel);

		/// <summary>
		/// Parking System
		/// </summary>
		public static readonly Guid ParkingSystem = new Guid(DeviceCategoryConst.ParkingSystem);

		/// <summary>
		/// Readers
		/// </summary>
		public static readonly Guid Readers = new Guid(DeviceCategoryConst.Readers);

		/// <summary>
		/// Devices
		/// </summary>
		public static readonly Guid Devices = new Guid(DeviceCategoryConst.Devices);

		/// <summary>
		/// Output
		/// </summary>
		public static readonly Guid Output = new Guid(DeviceCategoryConst.Output);

		/// <summary>
		/// Glass Break Detector
		/// </summary>
		public static readonly Guid GlassBreakDetector = new Guid(DeviceCategoryConst.GlassBreakDetector);

		/// <summary>
		/// Center Detector
		/// </summary>
		public static readonly Guid CenterDetector = new Guid(DeviceCategoryConst.CenterDetector);

		/// <summary>
		/// PA Central Unit
		/// </summary>
		public static readonly Guid PACentralUnit = new Guid(DeviceCategoryConst.PACentralUnit);

		/// <summary>
		/// MultiDetector
		/// </summary>
		public static readonly Guid MultiDetector = new Guid(DeviceCategoryConst.MultiDetector);

		/// <summary>
		/// Fire Detector
		/// </summary>
		public static readonly Guid FireDetector = new Guid(DeviceCategoryConst.FireDetector);

		/// <summary>
		/// Sip Phone
		/// </summary>
		public static readonly Guid SipPhone = new Guid(DeviceCategoryConst.SipPhone);

    }
		
    /// <summary>
	/// DeviceCategory Constants
	/// </summary>
	internal static class DeviceCategoryConst
	{
		/// <summary>
		/// Default Device
		/// </summary>
		public const string DefaultDevice = "00000000-0000-0000-0000-000000000001";

		/// <summary>
		/// Co Detector
		/// </summary>
		public const string CoDetector = "00EDA739-DD90-4375-B403-ECEE9C7A09E9";

		/// <summary>
		/// Key
		/// </summary>
		public const string Key = "0165B8AF-7CF7-4827-A73A-2005754832D4";

		/// <summary>
		/// Camera
		/// </summary>
		public const string Camera = "061D6A6E-BB2F-426E-A453-A5FC34C955E1";

		/// <summary>
		/// Card Reader
		/// </summary>
		public const string CardReader = "07B3F7C2-EE79-417A-8106-26368D3F0E3D";

		/// <summary>
		/// Light Bulb Monochrome
		/// </summary>
		public const string LightBulbMonochrome = "0A775935-A24B-4602-9BE7-7191A024D984";

		/// <summary>
		/// Video Output
		/// </summary>
		public const string VideoOutput = "0AC6031B-AE75-4794-8193-AD05FA5629F6";

		/// <summary>
		/// Lighting
		/// </summary>
		public const string Lighting = "1F9D9DFF-A29D-4FAA-886E-1DE4FFEF7C04";

		/// <summary>
		/// Shock Detector
		/// </summary>
		public const string ShockDetector = "2811C6B4-17FB-4F23-A6F4-8FBFF8B0ED54";

		/// <summary>
		/// Fire Detector In Floor
		/// </summary>
		public const string FireDetectorInFloor = "285E1D9B-80F5-427F-A262-D11239447FAE";

		/// <summary>
		/// BusController
		/// </summary>
		public const string BusController = "2990DDD8-494C-4BE3-BF88-7488E8D2DF7F";

		/// <summary>
		/// Fire Button
		/// </summary>
		public const string FireButton = "2AA68B50-9BB2-42FB-9CA2-2654D809122C";

		/// <summary>
		/// Door
		/// </summary>
		public const string Door = "2DD63AF9-DF4B-4D7F-8055-905731ECF229";

		/// <summary>
		/// System
		/// </summary>
		public const string System = "2EA4AE6F-7C85-445B-A7BA-B1070B8A2E76";

		/// <summary>
		/// Keypad
		/// </summary>
		public const string Keypad = "305DF1DB-2FE7-4B19-8B89-2901EDAE6064";

		/// <summary>
		/// Automation
		/// </summary>
		public const string Automation = "31AA8D20-2D6C-426A-A8E6-2FAC1F288617";

		/// <summary>
		/// HVAC
		/// </summary>
		public const string HVAC = "36D3F530-DF26-4F10-A3E1-52181C5E6449";

		/// <summary>
		/// Keypad And Card Reader
		/// </summary>
		public const string KeypadAndCardReader = "38B7C505-2F65-4970-B924-8A89A29D7349";

		/// <summary>
		/// Fire Group
		/// </summary>
		public const string FireGroup = "3BB3334D-AA49-4D42-B22E-B9F7A9BB907D";

		/// <summary>
		/// Video Input
		/// </summary>
		public const string VideoInput = "3EF5F56F-9106-4BD4-A011-05F1D87A5F92";

		/// <summary>
		/// Audio Input
		/// </summary>
		public const string AudioInput = "409B14F3-F975-4C44-958E-39222D8D8E9C";

		/// <summary>
		/// Audio Output
		/// </summary>
		public const string AudioOutput = "423ED0C3-509C-4BB3-A778-0FED0766FE65";

		/// <summary>
		/// Generic Device
		/// </summary>
		public const string GenericDevice = "47186BD1-76C9-4D70-A65C-98DD8740D569";

		/// <summary>
		/// EntityTypeRoot
		/// </summary>
		public const string EntityTypeRoot = "4C2EFE4D-9D05-4106-ADC6-45F9802D3E8D";

		/// <summary>
		/// Max Temperature Detector
		/// </summary>
		public const string MaxTemperatureDetector = "5120E752-DF25-40DF-8F58-7F1D8C19786D";

		/// <summary>
		/// PBX
		/// </summary>
		public const string PBX = "53E05A47-E9BD-4A6E-89D2-7E87D23DB3AA";

		/// <summary>
		/// Lift Door
		/// </summary>
		public const string LiftDoor = "549B7209-9290-4A29-87BC-2E07223DA960";

		/// <summary>
		/// Group
		/// </summary>
		public const string Group = "551CF600-F5E7-4EA7-99AB-E1FE546A5335";

		/// <summary>
		/// DVR / NVR
		/// </summary>
		public const string DVRNVR = "570FC8F4-77CA-4ECF-A12B-DE318011B388";

		/// <summary>
		/// Intercom
		/// </summary>
		public const string Intercom = "57D0A9FA-0289-4EC1-8228-5BED173AC5EE";

		/// <summary>
		/// Magnetic Detector
		/// </summary>
		public const string MagneticDetector = "5B16FBBA-826B-4F9D-8EA7-36C7FB0BF759";

		/// <summary>
		/// Dual Detector
		/// </summary>
		public const string DualDetector = "5B62A36E-95AB-4623-8274-F8A85AC46A0C";

		/// <summary>
		/// Gauge
		/// </summary>
		public const string Gauge = "639F2E0F-A061-4464-A926-1741AD845500";

		/// <summary>
		/// Expander
		/// </summary>
		public const string Expander = "6445C73B-48EF-45DC-A000-82349AD7FACD";

		/// <summary>
		/// Fire Detector In Ceiling
		/// </summary>
		public const string FireDetectorInCeiling = "644A4665-A3F3-424B-B276-3390BFAB0C8F";

		/// <summary>
		/// Ptz Camera
		/// </summary>
		public const string PtzCamera = "64E4E0D4-141F-452E-93FC-85707DD03069";

		/// <summary>
		/// Central Unit
		/// </summary>
		public const string CentralUnit = "6FA69472-52EB-4656-A57A-748689C46EA1";

		/// <summary>
		/// Intercom Station
		/// </summary>
		public const string IntercomStation = "738C226B-7643-4127-A14E-596089885894";

		/// <summary>
		/// Turnstile
		/// </summary>
		public const string Turnstile = "75894B62-2BC3-42FE-87A7-29D08EF4D5ED";

		/// <summary>
		/// IsConnector
		/// </summary>
		public const string IsConnector = "771BA3DE-2B99-4096-B46B-557CD88CF239";

		/// <summary>
		/// Fire Panel
		/// </summary>
		public const string FirePanel = "83EC1C7B-80C3-4BED-982B-581CABBC58FF";

		/// <summary>
		/// Detectors
		/// </summary>
		public const string Detectors = "873D93A6-9709-40FB-9FCF-B02933FC6C68";

		/// <summary>
		/// Device Groups
		/// </summary>
		public const string DeviceGroups = "8C96B98F-5315-4E65-9A22-CC432EC42191";

		/// <summary>
		/// Thermo Differential Detector
		/// </summary>
		public const string ThermoDifferentialDetector = "93350A33-7100-43E8-AEF8-0E03564E5615";

		/// <summary>
		/// Audio / Video
		/// </summary>
		public const string AudioVideo = "A1ECC012-62E4-4176-BB55-F58BAB49A69B";

		/// <summary>
		/// Input
		/// </summary>
		public const string Input = "A90C6797-A975-409C-AAF7-BF61C17248BA";

		/// <summary>
		/// Finger Print Reader
		/// </summary>
		public const string FingerPrintReader = "AAC3D92A-93BA-4BB6-83DE-F5C516997D31";

		/// <summary>
		/// Panels
		/// </summary>
		public const string Panels = "AB3EB7B1-FF91-4E7A-A35C-4522E256F48B";

		/// <summary>
		/// Light Bulb
		/// </summary>
		public const string LightBulb = "AFCD94EF-5771-451E-8B35-9D7705C42B83";

		/// <summary>
		/// Emergency Button
		/// </summary>
		public const string EmergencyButton = "BBDA1B1F-8637-4991-AE3C-77B31C33F0FE";

		/// <summary>
		/// Doors
		/// </summary>
		public const string Doors = "D0AE28B1-6442-4A34-9A64-7458825FF4E1";

		/// <summary>
		/// Lift Unit
		/// </summary>
		public const string LiftUnit = "D12B9214-3BF2-4273-AC2F-F0A60D2393BA";

		/// <summary>
		/// Ramp
		/// </summary>
		public const string Ramp = "D3CE0523-1B50-4298-B5BE-4AECE1A59CB1";

		/// <summary>
		/// Infra Detector
		/// </summary>
		public const string InfraDetector = "DA9E6703-1D75-4395-A38A-D012A8090FF7";

		/// <summary>
		/// Input Output Devices
		/// </summary>
		public const string InputOutputDevices = "DBC0E427-44BE-4A6D-9FFD-198A8D2C29C5";

		/// <summary>
		/// Access Panel
		/// </summary>
		public const string AccessPanel = "DF742F8A-CCDA-48B1-980B-175E78F80A4A";

		/// <summary>
		/// Detector
		/// </summary>
		public const string Detector = "E0D60EEB-2E71-4A4E-A645-853B279D43E8";

		/// <summary>
		/// Light Bulb Color
		/// </summary>
		public const string LightBulbColor = "E1F4E8CE-D221-418F-84F7-3EA4A5E55035";

		/// <summary>
		/// Alarm Panel
		/// </summary>
		public const string AlarmPanel = "E20317BA-75E2-4220-8CF0-60B974B03ACA";

		/// <summary>
		/// Parking System
		/// </summary>
		public const string ParkingSystem = "E5BA214C-5718-495B-975E-CE62739FFED3";

		/// <summary>
		/// Readers
		/// </summary>
		public const string Readers = "E807DE7C-5671-4BDA-A630-624290253AEC";

		/// <summary>
		/// Devices
		/// </summary>
		public const string Devices = "E9DF5607-D01F-460E-874B-2BC822EAB185";

		/// <summary>
		/// Output
		/// </summary>
		public const string Output = "EAF1FB98-BB98-41F2-8003-6524CF3413AA";

		/// <summary>
		/// Glass Break Detector
		/// </summary>
		public const string GlassBreakDetector = "EE058D73-ABBF-4B24-AC6E-370F770952F2";

		/// <summary>
		/// Center Detector
		/// </summary>
		public const string CenterDetector = "F58E96B2-E0A2-4EF8-940D-63B2324E2BB9";

		/// <summary>
		/// PA Central Unit
		/// </summary>
		public const string PACentralUnit = "F6A45E14-ADF6-4BC2-856E-ED26DC28A524";

		/// <summary>
		/// MultiDetector
		/// </summary>
		public const string MultiDetector = "F6A9E7ED-1D2E-411F-B9EB-59F8DD5A1268";

		/// <summary>
		/// Fire Detector
		/// </summary>
		public const string FireDetector = "FAC556B8-AEDB-43EE-9E11-1F4E45088688";

		/// <summary>
		/// Sip Phone
		/// </summary>
		public const string SipPhone = "FC92E400-A63E-4684-AC5A-2F8BA5E702DB";

	}
}