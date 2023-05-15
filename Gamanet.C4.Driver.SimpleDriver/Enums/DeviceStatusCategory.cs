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
	/// DeviceStatusCategory
	/// </summary>
	internal static class DeviceStatusCategory
    {
		/// <summary>
		/// msgArmedStatus
		/// </summary>
		public static readonly Guid Armed = new Guid(DeviceStatusCategoryConst.Armed);

		/// <summary>
		/// msgDoorOpenedForciblyStatus
		/// </summary>
		public static readonly Guid DoorForciblyOpened = new Guid(DeviceStatusCategoryConst.DoorForciblyOpened);

		/// <summary>
		/// msgAlarmInTestStatus
		/// </summary>
		public static readonly Guid AlarmInTest = new Guid(DeviceStatusCategoryConst.AlarmInTest);

		/// <summary>
		/// msgConfigurationFailureStatus
		/// </summary>
		public static readonly Guid ConfigurationFailure = new Guid(DeviceStatusCategoryConst.ConfigurationFailure);

		/// <summary>
		/// msgWritingDeviceConfigurationStatus
		/// </summary>
		public static readonly Guid SendingDeviceConfiguration = new Guid(DeviceStatusCategoryConst.SendingDeviceConfiguration);

		/// <summary>
		/// msgWritingDataStatus
		/// </summary>
		public static readonly Guid WritingData = new Guid(DeviceStatusCategoryConst.WritingData);

		/// <summary>
		/// msgNotReadyToArmStatus
		/// </summary>
		public static readonly Guid NotReadyToArm = new Guid(DeviceStatusCategoryConst.NotReadyToArm);

		/// <summary>
		/// msgDoorUnlockedPermanentlyStatus
		/// </summary>
		public static readonly Guid DoorUnlockedPermanently = new Guid(DeviceStatusCategoryConst.DoorUnlockedPermanently);

		/// <summary>
		/// msgDownloadingHistoryStatus
		/// </summary>
		public static readonly Guid DownloadingHistory = new Guid(DeviceStatusCategoryConst.DownloadingHistory);

		/// <summary>
		/// msgVideoLossStatus
		/// </summary>
		public static readonly Guid VideoLoss = new Guid(DeviceStatusCategoryConst.VideoLoss);

		/// <summary>
		/// msgDoorOpenedTooLongStatus
		/// </summary>
		public static readonly Guid DoorOpenedTooLong = new Guid(DeviceStatusCategoryConst.DoorOpenedTooLong);

		/// <summary>
		/// msgUnknownStatus
		/// </summary>
		public static readonly Guid Unknown = new Guid(DeviceStatusCategoryConst.Unknown);

		/// <summary>
		/// msgRearmStatus
		/// </summary>
		public static readonly Guid Rearm = new Guid(DeviceStatusCategoryConst.Rearm);

		/// <summary>
		/// msgFailureInTestStatus
		/// </summary>
		public static readonly Guid FailureInTest = new Guid(DeviceStatusCategoryConst.FailureInTest);

		/// <summary>
		/// msgDoorOpenedStatus
		/// </summary>
		public static readonly Guid DoorOpened = new Guid(DeviceStatusCategoryConst.DoorOpened);

		/// <summary>
		/// msgDoorLockedStatus
		/// </summary>
		public static readonly Guid DoorNormal = new Guid(DeviceStatusCategoryConst.DoorNormal);

		/// <summary>
		/// msgBypassStatus
		/// </summary>
		public static readonly Guid Bypass = new Guid(DeviceStatusCategoryConst.Bypass);

		/// <summary>
		/// msgConnectingInProgressStatus
		/// </summary>
		public static readonly Guid ConnectingInProgress = new Guid(DeviceStatusCategoryConst.ConnectingInProgress);

		/// <summary>
		/// msgRingingStatus
		/// </summary>
		public static readonly Guid Ringing = new Guid(DeviceStatusCategoryConst.Ringing);

		/// <summary>
		/// msgTamperStatus
		/// </summary>
		public static readonly Guid Tamper = new Guid(DeviceStatusCategoryConst.Tamper);

		/// <summary>
		/// msgRegionPropagateStatus
		/// </summary>
		public static readonly Guid RegionPropagate = new Guid(DeviceStatusCategoryConst.RegionPropagate);

		/// <summary>
		/// msgDoorUnlockedTimedStatus
		/// </summary>
		public static readonly Guid DoorUnlockedTimed = new Guid(DeviceStatusCategoryConst.DoorUnlockedTimed);

		/// <summary>
		/// msgActivatedStatus
		/// </summary>
		public static readonly Guid Activated = new Guid(DeviceStatusCategoryConst.Activated);

		/// <summary>
		/// msgSynchronizingStatus
		/// </summary>
		public static readonly Guid Synchronizing = new Guid(DeviceStatusCategoryConst.Synchronizing);

		/// <summary>
		/// msgIdleStatus
		/// </summary>
		public static readonly Guid Idle = new Guid(DeviceStatusCategoryConst.Idle);

		/// <summary>
		/// msgReadingDeviceConfigurationStatus
		/// </summary>
		public static readonly Guid LoadingDeviceConfiguration = new Guid(DeviceStatusCategoryConst.LoadingDeviceConfiguration);

		/// <summary>
		/// msgUnknownStatus
		/// </summary>
		public static readonly Guid UnknownDirect = new Guid(DeviceStatusCategoryConst.UnknownDirect);

		/// <summary>
		/// msgCallingStatus
		/// </summary>
		public static readonly Guid Calling = new Guid(DeviceStatusCategoryConst.Calling);

		/// <summary>
		/// msgCallingEncryptedStatus
		/// </summary>
		public static readonly Guid CallingEncrypted = new Guid(DeviceStatusCategoryConst.CallingEncrypted);

		/// <summary>
		/// msgPreAlarmStatus
		/// </summary>
		public static readonly Guid PreAlarm = new Guid(DeviceStatusCategoryConst.PreAlarm);

		/// <summary>
		/// msgTestingStatus
		/// </summary>
		public static readonly Guid Testing = new Guid(DeviceStatusCategoryConst.Testing);

		/// <summary>
		/// msgResetRequiredStatus
		/// </summary>
		public static readonly Guid ResetRequired = new Guid(DeviceStatusCategoryConst.ResetRequired);

		/// <summary>
		/// msgStartingStatus
		/// </summary>
		public static readonly Guid Starting = new Guid(DeviceStatusCategoryConst.Starting);

		/// <summary>
		/// msgArmedPartiallyStatus
		/// </summary>
		public static readonly Guid ArmedPartially = new Guid(DeviceStatusCategoryConst.ArmedPartially);

		/// <summary>
		/// msgReadingDataStatus
		/// </summary>
		public static readonly Guid ReadingData = new Guid(DeviceStatusCategoryConst.ReadingData);

		/// <summary>
		/// msgAlarmStatus
		/// </summary>
		public static readonly Guid Alarm = new Guid(DeviceStatusCategoryConst.Alarm);

		/// <summary>
		/// msgFireAlarmStatus
		/// </summary>
		public static readonly Guid FireAlarm = new Guid(DeviceStatusCategoryConst.FireAlarm);

		/// <summary>
		/// msgReadyToArmStatus
		/// </summary>
		public static readonly Guid ReadyToArm = new Guid(DeviceStatusCategoryConst.ReadyToArm);

		/// <summary>
		/// msgDisarmedStatus
		/// </summary>
		public static readonly Guid Disarmed = new Guid(DeviceStatusCategoryConst.Disarmed);

		/// <summary>
		/// msgRegionNormalStatus
		/// </summary>
		public static readonly Guid RegionNormal = new Guid(DeviceStatusCategoryConst.RegionNormal);

		/// <summary>
		/// msgUploadingCredentialsStatus
		/// </summary>
		public static readonly Guid UploadingCredentials = new Guid(DeviceStatusCategoryConst.UploadingCredentials);

		/// <summary>
		/// msgDoorManualOverrideOnStatus
		/// </summary>
		public static readonly Guid DoorManualOverride = new Guid(DeviceStatusCategoryConst.DoorManualOverride);

		/// <summary>
		/// msgInitializedStatus
		/// </summary>
		public static readonly Guid Initialized = new Guid(DeviceStatusCategoryConst.Initialized);

		/// <summary>
		/// msgFailureStatus
		/// </summary>
		public static readonly Guid Failure = new Guid(DeviceStatusCategoryConst.Failure);

		/// <summary>
		/// msgDisconnectedStatus
		/// </summary>
		public static readonly Guid Disconnected = new Guid(DeviceStatusCategoryConst.Disconnected);

		/// <summary>
		/// msgDiscoveryInProgressStatus
		/// </summary>
		public static readonly Guid DiscoveryInProgress = new Guid(DeviceStatusCategoryConst.DiscoveryInProgress);

		/// <summary>
		/// msgDoorUnlockedStatus
		/// </summary>
		public static readonly Guid DoorUnlocked = new Guid(DeviceStatusCategoryConst.DoorUnlocked);

    }
		
    /// <summary>
	/// DeviceStatusCategory Constants
	/// </summary>
	internal static class DeviceStatusCategoryConst
	{
		/// <summary>
		/// msgArmedStatus
		/// </summary>
		public const string Armed = "6F218295-37AD-42F5-9104-041FC468471D";

		/// <summary>
		/// msgDoorOpenedForciblyStatus
		/// </summary>
		public const string DoorForciblyOpened = "1D181972-31EC-4DDC-AC58-0555BD4C284E";

		/// <summary>
		/// msgAlarmInTestStatus
		/// </summary>
		public const string AlarmInTest = "527B5104-F8F0-4A57-BA7C-091E0EDD90D1";

		/// <summary>
		/// msgConfigurationFailureStatus
		/// </summary>
		public const string ConfigurationFailure = "EB843B75-1E34-4588-96FD-12F00C4993C6";

		/// <summary>
		/// msgWritingDeviceConfigurationStatus
		/// </summary>
		public const string SendingDeviceConfiguration = "8F04CFB1-10BF-4778-902B-1778B7AD212A";

		/// <summary>
		/// msgWritingDataStatus
		/// </summary>
		public const string WritingData = "675D7D6A-D022-4E3D-AFCF-2FDCE40701DB";

		/// <summary>
		/// msgNotReadyToArmStatus
		/// </summary>
		public const string NotReadyToArm = "27546EE3-2E57-48E2-80F2-3A70DD8B57F9";

		/// <summary>
		/// msgDoorUnlockedPermanentlyStatus
		/// </summary>
		public const string DoorUnlockedPermanently = "2B9D17B8-EF67-4791-B812-3AFE507CD650";

		/// <summary>
		/// msgDownloadingHistoryStatus
		/// </summary>
		public const string DownloadingHistory = "4AF77E7D-90EC-4498-B3A1-3FD538492831";

		/// <summary>
		/// msgVideoLossStatus
		/// </summary>
		public const string VideoLoss = "C19B2F72-7779-4E78-8BB2-413D4204B78D";

		/// <summary>
		/// msgDoorOpenedTooLongStatus
		/// </summary>
		public const string DoorOpenedTooLong = "793ECB17-2315-46BE-8994-4477745FBAB2";

		/// <summary>
		/// msgUnknownStatus
		/// </summary>
		public const string Unknown = "58390EDA-38BF-43A0-BA33-48CC1750B831";

		/// <summary>
		/// msgRearmStatus
		/// </summary>
		public const string Rearm = "4ACE6778-8720-4004-99BA-4BF7B53CB9C4";

		/// <summary>
		/// msgFailureInTestStatus
		/// </summary>
		public const string FailureInTest = "CC968E5F-2C62-40B6-A65D-55843F2E1361";

		/// <summary>
		/// msgDoorOpenedStatus
		/// </summary>
		public const string DoorOpened = "6EDA6590-3606-48DC-A2F1-58724D7B1B4F";

		/// <summary>
		/// msgDoorLockedStatus
		/// </summary>
		public const string DoorNormal = "36847C68-AB8B-438C-A9F3-58BF626E77A3";

		/// <summary>
		/// msgBypassStatus
		/// </summary>
		public const string Bypass = "B9283265-C4C8-4677-867D-5B8AF6B79A68";

		/// <summary>
		/// msgConnectingInProgressStatus
		/// </summary>
		public const string ConnectingInProgress = "F3597EE7-429A-490B-A195-6722E1556A85";

		/// <summary>
		/// msgRingingStatus
		/// </summary>
		public const string Ringing = "9522CC44-4979-46A2-9A05-68CF4DE53900";

		/// <summary>
		/// msgTamperStatus
		/// </summary>
		public const string Tamper = "AA437E24-42EF-4C67-8B30-68F8654DDF4D";

		/// <summary>
		/// msgRegionPropagateStatus
		/// </summary>
		public const string RegionPropagate = "3AC21649-97FC-453A-95BC-712CA315C4DE";

		/// <summary>
		/// msgDoorUnlockedTimedStatus
		/// </summary>
		public const string DoorUnlockedTimed = "FC2F7128-E31F-48C0-BC25-7A130D536616";

		/// <summary>
		/// msgActivatedStatus
		/// </summary>
		public const string Activated = "367B86C5-4B5D-4748-B2FC-7BA2F8514E70";

		/// <summary>
		/// msgSynchronizingStatus
		/// </summary>
		public const string Synchronizing = "CF21853F-B158-4D7E-861E-7D6230CFCD77";

		/// <summary>
		/// msgIdleStatus
		/// </summary>
		public const string Idle = "829E9918-56B1-4C31-B689-8097FE222C65";

		/// <summary>
		/// msgReadingDeviceConfigurationStatus
		/// </summary>
		public const string LoadingDeviceConfiguration = "B776690D-7B10-45B6-AB79-817EACCB085C";

		/// <summary>
		/// msgUnknownStatus
		/// </summary>
		public const string UnknownDirect = "FCE4E33A-CD67-4DE1-83E1-825D02CD0FBB";

		/// <summary>
		/// msgCallingStatus
		/// </summary>
		public const string Calling = "5A4473F8-4365-4B87-8A4A-8736A67E49E5";

		/// <summary>
		/// msgCallingEncryptedStatus
		/// </summary>
		public const string CallingEncrypted = "EB5FD155-A395-481C-83FA-8D3D8742C226";

		/// <summary>
		/// msgPreAlarmStatus
		/// </summary>
		public const string PreAlarm = "FF7F0447-DCD6-4F79-A67C-8D925C833479";

		/// <summary>
		/// msgTestingStatus
		/// </summary>
		public const string Testing = "47A0233F-157E-4CD1-B71B-8E411F038A22";

		/// <summary>
		/// msgResetRequiredStatus
		/// </summary>
		public const string ResetRequired = "A1CCBA8B-1051-48BD-9D6F-98DB57191DB0";

		/// <summary>
		/// msgStartingStatus
		/// </summary>
		public const string Starting = "858D47FF-B5E3-469D-96F5-9C16E3081E4A";

		/// <summary>
		/// msgArmedPartiallyStatus
		/// </summary>
		public const string ArmedPartially = "CC38A50E-C3C3-421A-887D-A1E3C7AB3A3C";

		/// <summary>
		/// msgReadingDataStatus
		/// </summary>
		public const string ReadingData = "FFBAEAEA-58C7-4B71-9EC3-A447E927F87E";

		/// <summary>
		/// msgAlarmStatus
		/// </summary>
		public const string Alarm = "498FF28A-69D9-44D7-8564-A6A9A64873C4";

		/// <summary>
		/// msgFireAlarmStatus
		/// </summary>
		public const string FireAlarm = "AC9A8470-59D6-43EC-9176-B11DE1233339";

		/// <summary>
		/// msgReadyToArmStatus
		/// </summary>
		public const string ReadyToArm = "AC78DDFB-E737-4475-A291-B42485945AD9";

		/// <summary>
		/// msgDisarmedStatus
		/// </summary>
		public const string Disarmed = "1D99AC33-BF9F-4542-8FFE-B9B6F9EE2FEA";

		/// <summary>
		/// msgRegionNormalStatus
		/// </summary>
		public const string RegionNormal = "21F5CBAD-2F22-4496-94B0-CF0CAC7A2761";

		/// <summary>
		/// msgUploadingCredentialsStatus
		/// </summary>
		public const string UploadingCredentials = "5DED4AA3-6243-44B5-8E77-D28F74122F3D";

		/// <summary>
		/// msgDoorManualOverrideOnStatus
		/// </summary>
		public const string DoorManualOverride = "50D80DF5-A8F2-4540-8CEA-D3DDC990DA4B";

		/// <summary>
		/// msgInitializedStatus
		/// </summary>
		public const string Initialized = "FECE493C-D5D8-47E6-8812-D9D165E14439";

		/// <summary>
		/// msgFailureStatus
		/// </summary>
		public const string Failure = "42E668F6-40BE-4D51-972D-F24F6AFBDBE3";

		/// <summary>
		/// msgDisconnectedStatus
		/// </summary>
		public const string Disconnected = "72A463FD-8004-4196-A06C-F328F8DB7F42";

		/// <summary>
		/// msgDiscoveryInProgressStatus
		/// </summary>
		public const string DiscoveryInProgress = "5AAECAB6-E98E-4764-91ED-F33E4D89C92E";

		/// <summary>
		/// msgDoorUnlockedStatus
		/// </summary>
		public const string DoorUnlocked = "C0D26A8F-7710-4F90-A2E7-F79B24DAEE5E";

	}
}