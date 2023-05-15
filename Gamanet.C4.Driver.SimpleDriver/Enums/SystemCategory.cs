using System;

//   _____                           _           _                 _      
//  / ____|                         | |         | |               | |     
// | |  __  ___ _ __   ___ _ __ __ _| |_ ___  __| |   ___ ___   __| | ___ 
// | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \/ _` |  / __/ _ \ / _` |/ _ \
// | |__| |  __/ | | |  __/ | | (_| | ||  __/ (_| | | (_| (_) | (_| |  __/
//  \_____|\___|_| |_|\___|_|  \__,_|\__\___|\__,_|  \___\___/ \__,_|\___|
//                                                                        
//                                                                        
namespace Gamanet.C4.SDK.Enums.Logs
{
	/// <summary>
	/// SystemCategory
	/// </summary>
	internal static class SystemCategory
    {
		/// <summary>
		/// ActivatePresetPtzCommand
		/// </summary>
		public static readonly Guid ActivatePresetPtzCommand = new Guid(SystemCategoryConst.ActivatePresetPtzCommand);

		/// <summary>
		/// AddBusController
		/// </summary>
		public static readonly Guid AddBusController = new Guid(SystemCategoryConst.AddBusController);

		/// <summary>
		/// AddDiscovery
		/// </summary>
		public static readonly Guid AddDiscovery = new Guid(SystemCategoryConst.AddDiscovery);

		/// <summary>
		/// AddLoadConfiguration
		/// </summary>
		public static readonly Guid AddLoadConfiguration = new Guid(SystemCategoryConst.AddLoadConfiguration);

		/// <summary>
		/// BusControllerAdded
		/// </summary>
		public static readonly Guid BusControllerAdded = new Guid(SystemCategoryConst.BusControllerAdded);

		/// <summary>
		/// BusControllerExited
		/// </summary>
		public static readonly Guid BusControllerExited = new Guid(SystemCategoryConst.BusControllerExited);

		/// <summary>
		/// BusControllerRemoved
		/// </summary>
		public static readonly Guid BusControllerRemoved = new Guid(SystemCategoryConst.BusControllerRemoved);

		/// <summary>
		/// ChangeStreamVideoCommand
		/// </summary>
		public static readonly Guid ChangeStreamVideoCommand = new Guid(SystemCategoryConst.ChangeStreamVideoCommand);

		/// <summary>
		/// Command failed
		/// </summary>
		public static readonly Guid CommandFailed = new Guid(SystemCategoryConst.CommandFailed);

		/// <summary>
		/// DiscoveryAdded
		/// </summary>
		public static readonly Guid DiscoveryAdded = new Guid(SystemCategoryConst.DiscoveryAdded);

		/// <summary>
		/// DiscoveryFinished
		/// </summary>
		public static readonly Guid DiscoveryFinished = new Guid(SystemCategoryConst.DiscoveryFinished);

		/// <summary>
		/// FocusFarPtzCommand
		/// </summary>
		public static readonly Guid FocusFarPtzCommand = new Guid(SystemCategoryConst.FocusFarPtzCommand);

		/// <summary>
		/// FocusNearPtzCommand
		/// </summary>
		public static readonly Guid FocusNearPtzCommand = new Guid(SystemCategoryConst.FocusNearPtzCommand);

		/// <summary>
		/// IrisClosePtzCommand
		/// </summary>
		public static readonly Guid IrisClosePtzCommand = new Guid(SystemCategoryConst.IrisClosePtzCommand);

		/// <summary>
		/// IrisOpenPtzCommand
		/// </summary>
		public static readonly Guid IrisOpenPtzCommand = new Guid(SystemCategoryConst.IrisOpenPtzCommand);

		/// <summary>
		/// LoadConfigurationAdded
		/// </summary>
		public static readonly Guid LoadConfigurationAdded = new Guid(SystemCategoryConst.LoadConfigurationAdded);

		/// <summary>
		/// LoadConfigurationFinished
		/// </summary>
		public static readonly Guid LoadConfigurationFinished = new Guid(SystemCategoryConst.LoadConfigurationFinished);

		/// <summary>
		/// MoveDownLeftPtzCommand
		/// </summary>
		public static readonly Guid MoveDownLeftPtzCommand = new Guid(SystemCategoryConst.MoveDownLeftPtzCommand);

		/// <summary>
		/// MoveDownPtzCommand
		/// </summary>
		public static readonly Guid MoveDownPtzCommand = new Guid(SystemCategoryConst.MoveDownPtzCommand);

		/// <summary>
		/// MoveDownRightPtzCommand
		/// </summary>
		public static readonly Guid MoveDownRightPtzCommand = new Guid(SystemCategoryConst.MoveDownRightPtzCommand);

		/// <summary>
		/// MoveLeftPtzCommand
		/// </summary>
		public static readonly Guid MoveLeftPtzCommand = new Guid(SystemCategoryConst.MoveLeftPtzCommand);

		/// <summary>
		/// MoveRightPtzCommand
		/// </summary>
		public static readonly Guid MoveRightPtzCommand = new Guid(SystemCategoryConst.MoveRightPtzCommand);

		/// <summary>
		/// MoveUpLeftPtzCommand
		/// </summary>
		public static readonly Guid MoveUpLeftPtzCommand = new Guid(SystemCategoryConst.MoveUpLeftPtzCommand);

		/// <summary>
		/// MoveUpPtzCommand
		/// </summary>
		public static readonly Guid MoveUpPtzCommand = new Guid(SystemCategoryConst.MoveUpPtzCommand);

		/// <summary>
		/// MoveUpRightPtzCommand
		/// </summary>
		public static readonly Guid MoveUpRightPtzCommand = new Guid(SystemCategoryConst.MoveUpRightPtzCommand);

		/// <summary>
		/// MuteSoundVideoCommand
		/// </summary>
		public static readonly Guid MuteSoundVideoCommand = new Guid(SystemCategoryConst.MuteSoundVideoCommand);

		/// <summary>
		/// PauseVideoCommand
		/// </summary>
		public static readonly Guid PauseVideoCommand = new Guid(SystemCategoryConst.PauseVideoCommand);

		/// <summary>
		/// PlayLiveVideoCommand
		/// </summary>
		public static readonly Guid PlayLiveVideoCommand = new Guid(SystemCategoryConst.PlayLiveVideoCommand);

		/// <summary>
		/// PlayRecordVideoCommand
		/// </summary>
		public static readonly Guid PlayRecordVideoCommand = new Guid(SystemCategoryConst.PlayRecordVideoCommand);

		/// <summary>
		/// PlaytimeChangedVideoCommand
		/// </summary>
		public static readonly Guid PlaytimeChangedVideoCommand = new Guid(SystemCategoryConst.PlaytimeChangedVideoCommand);

		/// <summary>
		/// PluginRunnerConnected
		/// </summary>
		public static readonly Guid PluginRunnerConnected = new Guid(SystemCategoryConst.PluginRunnerConnected);

		/// <summary>
		/// PluginRunnerTerminated
		/// </summary>
		public static readonly Guid PluginRunnerTerminated = new Guid(SystemCategoryConst.PluginRunnerTerminated);

		/// <summary>
		/// ProgressReportVideoCommand
		/// </summary>
		public static readonly Guid ProgressReportVideoCommand = new Guid(SystemCategoryConst.ProgressReportVideoCommand);

		/// <summary>
		/// RecordVoiceVideoCommand
		/// </summary>
		public static readonly Guid RecordVoiceVideoCommand = new Guid(SystemCategoryConst.RecordVoiceVideoCommand);

		/// <summary>
		/// RefreshConfiguration
		/// </summary>
		public static readonly Guid RefreshConfiguration = new Guid(SystemCategoryConst.RefreshConfiguration);

		/// <summary>
		/// RemoveBusController
		/// </summary>
		public static readonly Guid RemoveBusController = new Guid(SystemCategoryConst.RemoveBusController);

		/// <summary>
		/// RewindFastBackwardVideoCommand
		/// </summary>
		public static readonly Guid RewindFastBackwardVideoCommand = new Guid(SystemCategoryConst.RewindFastBackwardVideoCommand);

		/// <summary>
		/// RewindFastForwardVideoCommand
		/// </summary>
		public static readonly Guid RewindFastForwardVideoCommand = new Guid(SystemCategoryConst.RewindFastForwardVideoCommand);

		/// <summary>
		/// SetCameraCapabilitiesMessage
		/// </summary>
		public static readonly Guid SetCameraCapabilitiesMessage = new Guid(SystemCategoryConst.SetCameraCapabilitiesMessage);

		/// <summary>
		/// SetPlayrateMultiplierVideoCommand
		/// </summary>
		public static readonly Guid SetPlayrateMultiplierVideoCommand = new Guid(SystemCategoryConst.SetPlayrateMultiplierVideoCommand);

		/// <summary>
		/// SetVolumeLevelVideoCommand
		/// </summary>
		public static readonly Guid SetVolumeLevelVideoCommand = new Guid(SystemCategoryConst.SetVolumeLevelVideoCommand);

		/// <summary>
		/// ShutdownDriver
		/// </summary>
		public static readonly Guid ShutdownDriver = new Guid(SystemCategoryConst.ShutdownDriver);

		/// <summary>
		/// StepBackwardVideoCommand
		/// </summary>
		public static readonly Guid StepBackwardVideoCommand = new Guid(SystemCategoryConst.StepBackwardVideoCommand);

		/// <summary>
		/// StepForwardVideoCommand
		/// </summary>
		public static readonly Guid StepForwardVideoCommand = new Guid(SystemCategoryConst.StepForwardVideoCommand);

		/// <summary>
		/// StopMovePtzCommand
		/// </summary>
		public static readonly Guid StopMovePtzCommand = new Guid(SystemCategoryConst.StopMovePtzCommand);

		/// <summary>
		/// StorePresetPtzCommand
		/// </summary>
		public static readonly Guid StorePresetPtzCommand = new Guid(SystemCategoryConst.StorePresetPtzCommand);

		/// <summary>
		/// StoreRecordStreamVideoCommand
		/// </summary>
		public static readonly Guid StoreRecordStreamVideoCommand = new Guid(SystemCategoryConst.StoreRecordStreamVideoCommand);

		/// <summary>
		/// StoreSnapshotVideoCommand
		/// </summary>
		public static readonly Guid StoreSnapshotVideoCommand = new Guid(SystemCategoryConst.StoreSnapshotVideoCommand);

		/// <summary>
		/// TerminateProcess
		/// </summary>
		public static readonly Guid TerminateProcess = new Guid(SystemCategoryConst.TerminateProcess);

		/// <summary>
		/// UninstallPackage
		/// </summary>
		public static readonly Guid UninstallPackage = new Guid(SystemCategoryConst.UninstallPackage);

		/// <summary>
		/// UpdatePackage
		/// </summary>
		public static readonly Guid UpdatePackage = new Guid(SystemCategoryConst.UpdatePackage);

		/// <summary>
		/// VideoSignalLostVideoCommand
		/// </summary>
		public static readonly Guid VideoSignalLostVideoCommand = new Guid(SystemCategoryConst.VideoSignalLostVideoCommand);

		/// <summary>
		/// VideoSignalRestoredVideoCommand
		/// </summary>
		public static readonly Guid VideoSignalRestoredVideoCommand = new Guid(SystemCategoryConst.VideoSignalRestoredVideoCommand);

		/// <summary>
		/// ViewerConnectedMessage
		/// </summary>
		public static readonly Guid ViewerConnectedMessage = new Guid(SystemCategoryConst.ViewerConnectedMessage);

		/// <summary>
		/// ViewerDisconnectedMessage
		/// </summary>
		public static readonly Guid ViewerDisconnectedMessage = new Guid(SystemCategoryConst.ViewerDisconnectedMessage);

		/// <summary>
		/// WindowEventMessage
		/// </summary>
		public static readonly Guid WindowMessage = new Guid(SystemCategoryConst.WindowMessage);

		/// <summary>
		/// ZoomInPtzCommand
		/// </summary>
		public static readonly Guid ZoomInPtzCommand = new Guid(SystemCategoryConst.ZoomInPtzCommand);

		/// <summary>
		/// ZoomOutPtzCommand
		/// </summary>
		public static readonly Guid ZoomOutPtzCommand = new Guid(SystemCategoryConst.ZoomOutPtzCommand);

    }
		
    /// <summary>
	/// SystemCategory Constants
	/// </summary>
	internal static class SystemCategoryConst
	{
		/// <summary>
		/// ActivatePresetPtzCommand
		/// </summary>
		public const string ActivatePresetPtzCommand = "CBDABE67-E1EC-4F35-A86A-58A7F55A7F5E";

		/// <summary>
		/// AddBusController
		/// </summary>
		public const string AddBusController = "71DDD726-9A19-4537-99EB-6DC4BC71E46B";

		/// <summary>
		/// AddDiscovery
		/// </summary>
		public const string AddDiscovery = "16C03B04-114F-4775-B886-D02D769ADDEA";

		/// <summary>
		/// AddLoadConfiguration
		/// </summary>
		public const string AddLoadConfiguration = "16F7A2BE-1E5D-48E0-94F4-AE391E78D3D2";

		/// <summary>
		/// BusControllerAdded
		/// </summary>
		public const string BusControllerAdded = "5330EEC2-9DB0-4B15-86D9-970C0556440C";

		/// <summary>
		/// BusControllerExited
		/// </summary>
		public const string BusControllerExited = "544D72AD-0910-410D-ACD5-6092784B9BF6";

		/// <summary>
		/// BusControllerRemoved
		/// </summary>
		public const string BusControllerRemoved = "0E03C3D5-A0FD-43F8-AA9D-1C12CEE1388C";

		/// <summary>
		/// ChangeStreamVideoCommand
		/// </summary>
		public const string ChangeStreamVideoCommand = "08C4319A-CB33-4451-AC52-1E362EC98E63";

		/// <summary>
		/// Command failed
		/// </summary>
		public const string CommandFailed = "0F1B8C2D-2D00-4BD8-90FB-E8DC43440C5C";

		/// <summary>
		/// DiscoveryAdded
		/// </summary>
		public const string DiscoveryAdded = "AC3A8757-97C7-41DE-A478-B86E18847F04";

		/// <summary>
		/// DiscoveryFinished
		/// </summary>
		public const string DiscoveryFinished = "3A2FCF84-AB47-49C3-9D44-43ECCC399226";

		/// <summary>
		/// FocusFarPtzCommand
		/// </summary>
		public const string FocusFarPtzCommand = "DB94F2EF-53EF-4B68-82B1-35A9CB19F2C1";

		/// <summary>
		/// FocusNearPtzCommand
		/// </summary>
		public const string FocusNearPtzCommand = "D01A2639-D093-4772-9996-3EFF521B9BBE";

		/// <summary>
		/// IrisClosePtzCommand
		/// </summary>
		public const string IrisClosePtzCommand = "0BA008CB-38B9-425C-ACA8-6946FF062032";

		/// <summary>
		/// IrisOpenPtzCommand
		/// </summary>
		public const string IrisOpenPtzCommand = "9BF80889-5B08-44EF-B10C-A019D4E67545";

		/// <summary>
		/// LoadConfigurationAdded
		/// </summary>
		public const string LoadConfigurationAdded = "7E8977CF-CB83-407D-9FE9-90D82498DEC6";

		/// <summary>
		/// LoadConfigurationFinished
		/// </summary>
		public const string LoadConfigurationFinished = "5D3EDADF-1DCD-4CDC-98AE-DD9B2346E98E";

		/// <summary>
		/// MoveDownLeftPtzCommand
		/// </summary>
		public const string MoveDownLeftPtzCommand = "A9552411-64A3-460A-9481-D2E53A104162";

		/// <summary>
		/// MoveDownPtzCommand
		/// </summary>
		public const string MoveDownPtzCommand = "AACBCC0D-910F-4BEC-AFD3-80E9ABEEE0F2";

		/// <summary>
		/// MoveDownRightPtzCommand
		/// </summary>
		public const string MoveDownRightPtzCommand = "E99EEBB3-69A8-401E-8869-DEBB290D1BB1";

		/// <summary>
		/// MoveLeftPtzCommand
		/// </summary>
		public const string MoveLeftPtzCommand = "7C4E1DB3-B002-4151-8E5D-CCC53ACBEEBC";

		/// <summary>
		/// MoveRightPtzCommand
		/// </summary>
		public const string MoveRightPtzCommand = "DC60FBEE-7E61-4AE3-A8A3-10E97DB78B3D";

		/// <summary>
		/// MoveUpLeftPtzCommand
		/// </summary>
		public const string MoveUpLeftPtzCommand = "7C4D8864-3734-48EC-B4F0-42F77F7B75BB";

		/// <summary>
		/// MoveUpPtzCommand
		/// </summary>
		public const string MoveUpPtzCommand = "9AD7E499-0529-4ED7-8144-5402BEB3F2FA";

		/// <summary>
		/// MoveUpRightPtzCommand
		/// </summary>
		public const string MoveUpRightPtzCommand = "6491EEBB-02F1-4DD3-83A6-246CAC8721FA";

		/// <summary>
		/// MuteSoundVideoCommand
		/// </summary>
		public const string MuteSoundVideoCommand = "141914CA-63C0-49DC-BE3D-45B4E13312B9";

		/// <summary>
		/// PauseVideoCommand
		/// </summary>
		public const string PauseVideoCommand = "AE4F6E6D-F9D8-4B9C-AC37-5DE6E113E3AD";

		/// <summary>
		/// PlayLiveVideoCommand
		/// </summary>
		public const string PlayLiveVideoCommand = "F249C917-2F64-4DF9-9EDF-6545470BB092";

		/// <summary>
		/// PlayRecordVideoCommand
		/// </summary>
		public const string PlayRecordVideoCommand = "7CA735AC-5F2D-483D-936D-DF0B82AC5F88";

		/// <summary>
		/// PlaytimeChangedVideoCommand
		/// </summary>
		public const string PlaytimeChangedVideoCommand = "5FF7121D-2038-4351-8F38-CF2EDCE64A5D";

		/// <summary>
		/// PluginRunnerConnected
		/// </summary>
		public const string PluginRunnerConnected = "B1864293-7F22-4A7E-9FDD-01CD0B6D9C48";

		/// <summary>
		/// PluginRunnerTerminated
		/// </summary>
		public const string PluginRunnerTerminated = "55E8E732-364F-48C9-B26F-E926E20FEE7F";

		/// <summary>
		/// ProgressReportVideoCommand
		/// </summary>
		public const string ProgressReportVideoCommand = "5BA59CFC-01C1-43DD-A068-7B35EC8860CC";

		/// <summary>
		/// RecordVoiceVideoCommand
		/// </summary>
		public const string RecordVoiceVideoCommand = "060B2681-F68A-46E3-B345-F182C0C9BDFE";

		/// <summary>
		/// RefreshConfiguration
		/// </summary>
		public const string RefreshConfiguration = "1F701393-41D5-4742-9DC3-92B607DAF511";

		/// <summary>
		/// RemoveBusController
		/// </summary>
		public const string RemoveBusController = "EF6F33EB-7AB9-4973-8539-97622C980E28";

		/// <summary>
		/// RewindFastBackwardVideoCommand
		/// </summary>
		public const string RewindFastBackwardVideoCommand = "3224A184-C88F-4D59-B40A-35AB41EC292A";

		/// <summary>
		/// RewindFastForwardVideoCommand
		/// </summary>
		public const string RewindFastForwardVideoCommand = "BA28C114-E6C3-4BFA-BC07-5C15DC027E9E";

		/// <summary>
		/// SetCameraCapabilitiesMessage
		/// </summary>
		public const string SetCameraCapabilitiesMessage = "896A8A96-D3EB-4BCF-A177-F6FC5AFC23C9";

		/// <summary>
		/// SetPlayrateMultiplierVideoCommand
		/// </summary>
		public const string SetPlayrateMultiplierVideoCommand = "CE8834A1-85FE-4C1A-B0AD-8D34F74E4527";

		/// <summary>
		/// SetVolumeLevelVideoCommand
		/// </summary>
		public const string SetVolumeLevelVideoCommand = "BABB8C61-44E9-4957-B8ED-0E361601D278";

		/// <summary>
		/// ShutdownDriver
		/// </summary>
		public const string ShutdownDriver = "65B50699-6CD1-47AC-BA7A-2BF012D3CA0F";

		/// <summary>
		/// StepBackwardVideoCommand
		/// </summary>
		public const string StepBackwardVideoCommand = "BB6B88BA-B93A-472B-BDB7-F29F1B575A6E";

		/// <summary>
		/// StepForwardVideoCommand
		/// </summary>
		public const string StepForwardVideoCommand = "64F05D05-D3E4-4BC8-A0E9-845C4F0BA554";

		/// <summary>
		/// StopMovePtzCommand
		/// </summary>
		public const string StopMovePtzCommand = "A86CE749-38BC-4499-A885-CE5049EBDDE7";

		/// <summary>
		/// StorePresetPtzCommand
		/// </summary>
		public const string StorePresetPtzCommand = "1FADE3A8-ACE4-4E9D-ADF1-E2F9BBE372C0";

		/// <summary>
		/// StoreRecordStreamVideoCommand
		/// </summary>
		public const string StoreRecordStreamVideoCommand = "A9F00D82-2C0C-4C2B-BC0B-15ADAC227D72";

		/// <summary>
		/// StoreSnapshotVideoCommand
		/// </summary>
		public const string StoreSnapshotVideoCommand = "8627679E-EEBF-48F9-8245-4025D92AAE9C";

		/// <summary>
		/// TerminateProcess
		/// </summary>
		public const string TerminateProcess = "A7FCBAA8-5215-4001-A0B5-8FCBF4634E20";

		/// <summary>
		/// UninstallPackage
		/// </summary>
		public const string UninstallPackage = "EE5F2898-C9E6-43D6-AADC-CE2663505147";

		/// <summary>
		/// UpdatePackage
		/// </summary>
		public const string UpdatePackage = "C93AC7C8-D122-4791-9599-24DCE2331C27";

		/// <summary>
		/// VideoSignalLostVideoCommand
		/// </summary>
		public const string VideoSignalLostVideoCommand = "A3702436-0E86-498D-A808-2B6087A79FE7";

		/// <summary>
		/// VideoSignalRestoredVideoCommand
		/// </summary>
		public const string VideoSignalRestoredVideoCommand = "191DE498-47ED-4E24-8B78-7AEF982DD3ED";

		/// <summary>
		/// ViewerConnectedMessage
		/// </summary>
		public const string ViewerConnectedMessage = "BD50CE51-6BA7-416C-9BC6-5969F46CC2EE";

		/// <summary>
		/// ViewerDisconnectedMessage
		/// </summary>
		public const string ViewerDisconnectedMessage = "B2C89823-5241-4A07-A6B5-5BF939DEF905";

		/// <summary>
		/// WindowEventMessage
		/// </summary>
		public const string WindowMessage = "54D32556-6BCA-437D-BB0D-9974F87007D6";

		/// <summary>
		/// ZoomInPtzCommand
		/// </summary>
		public const string ZoomInPtzCommand = "2C0F065F-625D-485D-9C90-3CCDD79F6E92";

		/// <summary>
		/// ZoomOutPtzCommand
		/// </summary>
		public const string ZoomOutPtzCommand = "5520BC46-ED01-4B65-9BFB-6277843B701D";

	}
}