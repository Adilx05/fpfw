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
	/// DriverCategory
	/// </summary>
	internal static class DriverCategory
    {
		/// <summary>
		/// Device is an access control.
		/// </summary>
		public static readonly Guid AccessControl = new Guid(DriverCategoryConst.AccessControl);

		/// <summary>
		/// Device is an attendance register.
		/// </summary>
		public static readonly Guid Attendance = new Guid(DriverCategoryConst.Attendance);

		/// <summary>
		/// The smart devices (lighting, power sockets, ...)
		/// </summary>
		public static readonly Guid BuildingAutomation = new Guid(DriverCategoryConst.BuildingAutomation);

		/// <summary>
		/// Device is a CCTV.
		/// </summary>
		public static readonly Guid CCTV = new Guid(DriverCategoryConst.CCTV);

		/// <summary>
		/// The DVR category (CCTV + recording)
		/// </summary>
		public static readonly Guid Dvr = new Guid(DriverCategoryConst.Dvr);

		/// <summary>
		/// The external notifier device (SMS, e-mail...)
		/// </summary>
		public static readonly Guid ExternalNotification = new Guid(DriverCategoryConst.ExternalNotification);

		/// <summary>
		/// Device is an fire alarm.
		/// </summary>
		public static readonly Guid FireAlarm = new Guid(DriverCategoryConst.FireAlarm);

		/// <summary>
		/// The hvac device (air condition, heating...)
		/// </summary>
		public static readonly Guid Hvac = new Guid(DriverCategoryConst.Hvac);

		/// <summary>
		/// Device is an intrusion alarm.
		/// </summary>
		public static readonly Guid IntrusionAlarm = new Guid(DriverCategoryConst.IntrusionAlarm);

		/// <summary>
		/// The connetion to other IS.
		/// </summary>
		public static readonly Guid IsConnector = new Guid(DriverCategoryConst.IsConnector);

		/// <summary>
		/// The key management device.
		/// </summary>
		public static readonly Guid KeyManagement = new Guid(DriverCategoryConst.KeyManagement);

		/// <summary>
		/// Other device type.
		/// </summary>
		public static readonly Guid Other = new Guid(DriverCategoryConst.Other);

		/// <summary>
		/// The perimeter intrusion protection device.
		/// </summary>
		public static readonly Guid Perimeter = new Guid(DriverCategoryConst.Perimeter);

    }
		
    /// <summary>
	/// DriverCategory Constants
	/// </summary>
	internal static class DriverCategoryConst
	{
		/// <summary>
		/// Device is an access control.
		/// </summary>
		public const string AccessControl = "A93C44F0-2A81-46F3-BA46-9F3564427C8E";

		/// <summary>
		/// Device is an attendance register.
		/// </summary>
		public const string Attendance = "F264A8EC-BDDF-48B8-9FA5-572307A34D62";

		/// <summary>
		/// The smart devices (lighting, power sockets, ...)
		/// </summary>
		public const string BuildingAutomation = "9807df55-06ef-4e78-8589-a2eac427b00b";

		/// <summary>
		/// Device is a CCTV.
		/// </summary>
		public const string CCTV = "8FEEF734-B6A0-4F2D-95B0-282732964278";

		/// <summary>
		/// The DVR category (CCTV + recording)
		/// </summary>
		public const string Dvr = "CB58A683-5E2A-40DA-8FAB-6D2DCF3E7B0C";

		/// <summary>
		/// The external notifier device (SMS, e-mail...)
		/// </summary>
		public const string ExternalNotification = "7558B2A6-8B7E-43CD-9260-DB1A69E0A69D";

		/// <summary>
		/// Device is an fire alarm.
		/// </summary>
		public const string FireAlarm = "F64B8841-2D63-4317-A2FF-8E725988EFA5";

		/// <summary>
		/// The hvac device (air condition, heating...)
		/// </summary>
		public const string Hvac = "7759C440-4DA7-47E1-AEF1-09678ED7538E";

		/// <summary>
		/// Device is an intrusion alarm.
		/// </summary>
		public const string IntrusionAlarm = "004E2645-598A-4DDC-8B6F-8EC52307D961";

		/// <summary>
		/// The connetion to other IS.
		/// </summary>
		public const string IsConnector = "8F6D23D1-9DC1-4C6A-B145-B20A6F273C8B";

		/// <summary>
		/// The key management device.
		/// </summary>
		public const string KeyManagement = "547FF9A2-63D1-497C-B085-051D4732DED6";

		/// <summary>
		/// Other device type.
		/// </summary>
		public const string Other = "542D0A27-A9DB-4CE5-9E2D-7B560E323A05";

		/// <summary>
		/// The perimeter intrusion protection device.
		/// </summary>
		public const string Perimeter = "0ABC08D9-A934-4864-B197-58C2BEA5F0FC";

	}
}