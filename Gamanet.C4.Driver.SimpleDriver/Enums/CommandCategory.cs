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
	/// CommandCategory
	/// </summary>
	internal static class CommandCategory
    {
		/// <summary>
		/// Activate Preset
		/// </summary>
		public static readonly Guid ActivatePreset = new Guid(CommandCategoryConst.ActivatePreset);

		/// <summary>
		/// Arm
		/// </summary>
		public static readonly Guid Arm = new Guid(CommandCategoryConst.Arm);

		/// <summary>
		/// Bypass Off
		/// </summary>
		public static readonly Guid BypassOff = new Guid(CommandCategoryConst.BypassOff);

		/// <summary>
		/// Bypass On
		/// </summary>
		public static readonly Guid BypassOn = new Guid(CommandCategoryConst.BypassOn);

		/// <summary>
		/// Bypass Timed
		/// </summary>
		public static readonly Guid BypassOnTimed = new Guid(CommandCategoryConst.BypassOnTimed);

		/// <summary>
		/// CallAutoanswerCommand
		/// </summary>
		public static readonly Guid CallAutoanswer = new Guid(CommandCategoryConst.CallAutoanswer);

		/// <summary>
		/// CallCommand
		/// </summary>
		public static readonly Guid Call = new Guid(CommandCategoryConst.Call);

		/// <summary>
		/// Capture Video Picture
		/// </summary>
		public static readonly Guid CaptureVideoPicture = new Guid(CommandCategoryConst.CaptureVideoPicture);

		/// <summary>
		/// Off
		/// </summary>
		public static readonly Guid DeviceOff = new Guid(CommandCategoryConst.DeviceOff);

		/// <summary>
		/// On
		/// </summary>
		public static readonly Guid DeviceOn = new Guid(CommandCategoryConst.DeviceOn);

		/// <summary>
		/// On Timed
		/// </summary>
		public static readonly Guid DeviceOnTimed = new Guid(CommandCategoryConst.DeviceOnTimed);

		/// <summary>
		/// Disarm
		/// </summary>
		public static readonly Guid Disarm = new Guid(CommandCategoryConst.Disarm);

		/// <summary>
		/// Discovery
		/// </summary>
		public static readonly Guid Discovery = new Guid(CommandCategoryConst.Discovery);

		/// <summary>
		/// Door Lock
		/// </summary>
		public static readonly Guid DoorLock = new Guid(CommandCategoryConst.DoorLock);

		/// <summary>
		/// Door Manual Override Off
		/// </summary>
		public static readonly Guid DoorManualOverrideOff = new Guid(CommandCategoryConst.DoorManualOverrideOff);

		/// <summary>
		/// Door Manual Override
		/// </summary>
		public static readonly Guid DoorManualOverrideOn = new Guid(CommandCategoryConst.DoorManualOverrideOn);

		/// <summary>
		/// Door Unlock
		/// </summary>
		public static readonly Guid DoorUnlock = new Guid(CommandCategoryConst.DoorUnlock);

		/// <summary>
		/// Door Unlock Permanently
		/// </summary>
		public static readonly Guid DoorUnlockPermanently = new Guid(CommandCategoryConst.DoorUnlockPermanently);

		/// <summary>
		/// Door Unlock Timed
		/// </summary>
		public static readonly Guid DoorUnlockTimed = new Guid(CommandCategoryConst.DoorUnlockTimed);

		/// <summary>
		/// Finish Test
		/// </summary>
		public static readonly Guid FinishTest = new Guid(CommandCategoryConst.FinishTest);

		/// <summary>
		/// Fire Protection Delay Off
		/// </summary>
		public static readonly Guid FireProtectionDelayOff = new Guid(CommandCategoryConst.FireProtectionDelayOff);

		/// <summary>
		/// Fire Protection Delay On
		/// </summary>
		public static readonly Guid FireProtectionDelayOn = new Guid(CommandCategoryConst.FireProtectionDelayOn);

		/// <summary>
		/// Fire Routing Delay Off
		/// </summary>
		public static readonly Guid FireRoutingDelayOff = new Guid(CommandCategoryConst.FireRoutingDelayOff);

		/// <summary>
		/// Fire Routing Delay On
		/// </summary>
		public static readonly Guid FireRoutingDelayOn = new Guid(CommandCategoryConst.FireRoutingDelayOn);

		/// <summary>
		/// Fire Sounders Delay Off
		/// </summary>
		public static readonly Guid FireSoundersDelayOff = new Guid(CommandCategoryConst.FireSoundersDelayOff);

		/// <summary>
		/// Fire Sounders Delay On
		/// </summary>
		public static readonly Guid FireSoundersDelayOn = new Guid(CommandCategoryConst.FireSoundersDelayOn);

		/// <summary>
		/// Forced Arm
		/// </summary>
		public static readonly Guid ForcedArm = new Guid(CommandCategoryConst.ForcedArm);

		/// <summary>
		/// Full Upload
		/// </summary>
		public static readonly Guid FullUpload = new Guid(CommandCategoryConst.FullUpload);

		/// <summary>
		/// Incremental Upload
		/// </summary>
		public static readonly Guid IncrementalUpload = new Guid(CommandCategoryConst.IncrementalUpload);

		/// <summary>
		/// Load Configuration
		/// </summary>
		public static readonly Guid LoadConfiguration = new Guid(CommandCategoryConst.LoadConfiguration);

		/// <summary>
		/// Lock
		/// </summary>
		public static readonly Guid Lock = new Guid(CommandCategoryConst.Lock);

		/// <summary>
		/// Mute Buzzer
		/// </summary>
		public static readonly Guid MuteBuzzer = new Guid(CommandCategoryConst.MuteBuzzer);

		/// <summary>
		/// Mute
		/// </summary>
		public static readonly Guid Mute = new Guid(CommandCategoryConst.Mute);

		/// <summary>
		/// Mute Sounder
		/// </summary>
		public static readonly Guid MuteSounder = new Guid(CommandCategoryConst.MuteSounder);

		/// <summary>
		/// PTZ Move
		/// </summary>
		public static readonly Guid PTZMove = new Guid(CommandCategoryConst.PTZMove);

		/// <summary>
		/// Reactivate Sounder
		/// </summary>
		public static readonly Guid ReactivateSounder = new Guid(CommandCategoryConst.ReactivateSounder);

		/// <summary>
		/// ReadDataCommand
		/// </summary>
		public static readonly Guid ReadData = new Guid(CommandCategoryConst.ReadData);

		/// <summary>
		/// Reinitialization
		/// </summary>
		public static readonly Guid Reinitialization = new Guid(CommandCategoryConst.Reinitialization);

		/// <summary>
		/// Reset setting
		/// </summary>
		public static readonly Guid ResetSettings = new Guid(CommandCategoryConst.ResetSettings);

		/// <summary>
		/// Save Preset
		/// </summary>
		public static readonly Guid SavePreset = new Guid(CommandCategoryConst.SavePreset);

		/// <summary>
		/// Save Video Record
		/// </summary>
		public static readonly Guid SaveVideoRecord = new Guid(CommandCategoryConst.SaveVideoRecord);

		/// <summary>
		/// Selective Upload
		/// </summary>
		public static readonly Guid SelectiveUpload = new Guid(CommandCategoryConst.SelectiveUpload);

		/// <summary>
		/// Send Configuration
		/// </summary>
		public static readonly Guid SendConfiguration = new Guid(CommandCategoryConst.SendConfiguration);

		/// <summary>
		/// ShowLiveVideoStream
		/// </summary>
		public static readonly Guid ShowLiveVideoStream = new Guid(CommandCategoryConst.ShowLiveVideoStream);

		/// <summary>
		/// Show On
		/// </summary>
		public static readonly Guid ShowOn = new Guid(CommandCategoryConst.ShowOn);

		/// <summary>
		/// Show Recorded Video
		/// </summary>
		public static readonly Guid ShowRecordedVideo = new Guid(CommandCategoryConst.ShowRecordedVideo);

		/// <summary>
		/// Start
		/// </summary>
		public static readonly Guid Start = new Guid(CommandCategoryConst.Start);

		/// <summary>
		/// Stop
		/// </summary>
		public static readonly Guid Stop = new Guid(CommandCategoryConst.Stop);

		/// <summary>
		/// Switch To Day Mode
		/// </summary>
		public static readonly Guid SwitchToDayMode = new Guid(CommandCategoryConst.SwitchToDayMode);

		/// <summary>
		/// Switch To Night Mode
		/// </summary>
		public static readonly Guid SwitchToNightMode = new Guid(CommandCategoryConst.SwitchToNightMode);

		/// <summary>
		/// Switch To T2 Time
		/// </summary>
		public static readonly Guid SwitchToT2Time = new Guid(CommandCategoryConst.SwitchToT2Time);

		/// <summary>
		/// Synchronize
		/// </summary>
		public static readonly Guid Synchronize = new Guid(CommandCategoryConst.Synchronize);

		/// <summary>
		/// Test
		/// </summary>
		public static readonly Guid Test = new Guid(CommandCategoryConst.Test);

		/// <summary>
		/// Toggle
		/// </summary>
		public static readonly Guid Toggle = new Guid(CommandCategoryConst.Toggle);

		/// <summary>
		/// Unlock
		/// </summary>
		public static readonly Guid Unlock = new Guid(CommandCategoryConst.Unlock);

		/// <summary>
		/// WriteDataCommand
		/// </summary>
		public static readonly Guid WriteData = new Guid(CommandCategoryConst.WriteData);

    }
		
    /// <summary>
	/// CommandCategory Constants
	/// </summary>
	internal static class CommandCategoryConst
	{
		/// <summary>
		/// Activate Preset
		/// </summary>
		public const string ActivatePreset = "A735FA88-5DA6-412E-AAE9-BB38A72B9FF3";

		/// <summary>
		/// Arm
		/// </summary>
		public const string Arm = "D97E962B-4A70-4ECA-8CCD-01795A9F5DDF";

		/// <summary>
		/// Bypass Off
		/// </summary>
		public const string BypassOff = "AB94610F-6824-490C-8E39-14A565825376";

		/// <summary>
		/// Bypass On
		/// </summary>
		public const string BypassOn = "50E35FBB-C5F9-4D75-A2CF-37C79DFE0CEB";

		/// <summary>
		/// Bypass Timed
		/// </summary>
		public const string BypassOnTimed = "FEE2CB75-D3E5-4A98-A197-F3B48D4AD90E";

		/// <summary>
		/// CallAutoanswerCommand
		/// </summary>
		public const string CallAutoanswer = "3B0A422F-A43B-4A3C-B357-E2B9767AE5EE";

		/// <summary>
		/// CallCommand
		/// </summary>
		public const string Call = "D26F96E3-BA41-4C53-B642-D53B32260EF5";

		/// <summary>
		/// Capture Video Picture
		/// </summary>
		public const string CaptureVideoPicture = "0FB19A81-DD63-4C56-B98D-98AEC215A8DA";

		/// <summary>
		/// Off
		/// </summary>
		public const string DeviceOff = "9C0C21DD-68B0-4722-AE6B-F98E7DF39BE1";

		/// <summary>
		/// On
		/// </summary>
		public const string DeviceOn = "C687C133-692C-4767-93F3-BC7E7C85619C";

		/// <summary>
		/// On Timed
		/// </summary>
		public const string DeviceOnTimed = "EA8A7BA3-BC87-4C5B-9B7A-27DB2162CBA1";

		/// <summary>
		/// Disarm
		/// </summary>
		public const string Disarm = "214368FB-1E7D-4A88-9F1F-1DE44E4D4FE0";

		/// <summary>
		/// Discovery
		/// </summary>
		public const string Discovery = "8AF2D771-EA9E-4604-B40D-64BC590C04BA";

		/// <summary>
		/// Door Lock
		/// </summary>
		public const string DoorLock = "75BE9604-A73D-4C00-9D05-5964392EC9C3";

		/// <summary>
		/// Door Manual Override Off
		/// </summary>
		public const string DoorManualOverrideOff = "DEB9FF51-FF05-4628-A4C0-1755F505C8DB";

		/// <summary>
		/// Door Manual Override
		/// </summary>
		public const string DoorManualOverrideOn = "34374D6B-CFBE-4F8E-8517-C70DFB39DF5C";

		/// <summary>
		/// Door Unlock
		/// </summary>
		public const string DoorUnlock = "C73239F1-EE2A-458D-96B0-D253C85FD164";

		/// <summary>
		/// Door Unlock Permanently
		/// </summary>
		public const string DoorUnlockPermanently = "3A201949-B6EB-447B-AEDC-A91358F194B3";

		/// <summary>
		/// Door Unlock Timed
		/// </summary>
		public const string DoorUnlockTimed = "2E39C6EA-9AE3-4645-A574-C996EC60CA2C";

		/// <summary>
		/// Finish Test
		/// </summary>
		public const string FinishTest = "0C07174D-FE89-465F-9CB5-BBC32D738ABE";

		/// <summary>
		/// Fire Protection Delay Off
		/// </summary>
		public const string FireProtectionDelayOff = "1B0EF5F4-8694-436D-AA4B-107EAE06D4FA";

		/// <summary>
		/// Fire Protection Delay On
		/// </summary>
		public const string FireProtectionDelayOn = "86BC487E-7A04-45D1-917A-767B02C34DE8";

		/// <summary>
		/// Fire Routing Delay Off
		/// </summary>
		public const string FireRoutingDelayOff = "91FCA185-1BA5-42FB-8C8A-4F579652A690";

		/// <summary>
		/// Fire Routing Delay On
		/// </summary>
		public const string FireRoutingDelayOn = "8A230D47-3CC6-4201-BC50-90F20028DDAF";

		/// <summary>
		/// Fire Sounders Delay Off
		/// </summary>
		public const string FireSoundersDelayOff = "2F0616F5-7481-4610-89C6-FBA1A57EA594";

		/// <summary>
		/// Fire Sounders Delay On
		/// </summary>
		public const string FireSoundersDelayOn = "62E5AAD9-8761-496F-86F4-69D8028FEEB6";

		/// <summary>
		/// Forced Arm
		/// </summary>
		public const string ForcedArm = "B68C628F-0A31-4B80-9662-8ACFDE5AE5C6";

		/// <summary>
		/// Full Upload
		/// </summary>
		public const string FullUpload = "B11583A2-6C11-4A10-9CC7-9917361C2D2F";

		/// <summary>
		/// Incremental Upload
		/// </summary>
		public const string IncrementalUpload = "74C7A219-A969-438C-8101-223C89F4C993";

		/// <summary>
		/// Load Configuration
		/// </summary>
		public const string LoadConfiguration = "E7487DEC-08D5-4886-98AC-F6B0D03EA9BD";

		/// <summary>
		/// Lock
		/// </summary>
		public const string Lock = "E85A10CD-46F7-4022-BD96-D38E15DB3E1C";

		/// <summary>
		/// Mute Buzzer
		/// </summary>
		public const string MuteBuzzer = "74A51F35-D668-4D77-9039-02D2B13BFF89";

		/// <summary>
		/// Mute
		/// </summary>
		public const string Mute = "C8A745F4-6B3A-4A57-B85A-8E3786A0B0B8";

		/// <summary>
		/// Mute Sounder
		/// </summary>
		public const string MuteSounder = "01C754FC-3014-4FAE-8950-93CF35D6EB9F";

		/// <summary>
		/// PTZ Move
		/// </summary>
		public const string PTZMove = "8C351D8C-4605-4F05-9F6E-587E5D90909E";

		/// <summary>
		/// Reactivate Sounder
		/// </summary>
		public const string ReactivateSounder = "34ED4743-9CFD-42AE-BE07-7BE0E67C22C0";

		/// <summary>
		/// ReadDataCommand
		/// </summary>
		public const string ReadData = "10E5EA31-1EFE-44A4-A4DA-0907DC210D2B";

		/// <summary>
		/// Reinitialization
		/// </summary>
		public const string Reinitialization = "8D2E9EF1-82B3-41BC-8C36-780A5C300780";

		/// <summary>
		/// Reset setting
		/// </summary>
		public const string ResetSettings = "F43C79D9-8DD5-46E8-AAAD-6E4BC3B4D8A3";

		/// <summary>
		/// Save Preset
		/// </summary>
		public const string SavePreset = "11A776CF-8BD2-4A95-8C99-79383A18E9FD";

		/// <summary>
		/// Save Video Record
		/// </summary>
		public const string SaveVideoRecord = "7CB26682-E204-4173-9946-DC86B1132E2A";

		/// <summary>
		/// Selective Upload
		/// </summary>
		public const string SelectiveUpload = "2D538BE6-AB89-45CC-BA0E-945FEFBB6BEA";

		/// <summary>
		/// Send Configuration
		/// </summary>
		public const string SendConfiguration = "C9B862B6-00E1-44B2-BE95-6B6F41F51935";

		/// <summary>
		/// ShowLiveVideoStream
		/// </summary>
		public const string ShowLiveVideoStream = "074EE968-BBC0-4694-A285-FD5B61994AC6";

		/// <summary>
		/// Show On
		/// </summary>
		public const string ShowOn = "31DFF7E5-C92D-48E9-920A-DA3230B3621C";

		/// <summary>
		/// Show Recorded Video
		/// </summary>
		public const string ShowRecordedVideo = "A1FBA1CA-9EDB-4B8C-93C3-E60704D55B30";

		/// <summary>
		/// Start
		/// </summary>
		public const string Start = "EE4741A1-9976-4B33-8BDF-0DAD15D76E6A";

		/// <summary>
		/// Stop
		/// </summary>
		public const string Stop = "4FA3452C-680D-441E-BD88-3510E6BA949A";

		/// <summary>
		/// Switch To Day Mode
		/// </summary>
		public const string SwitchToDayMode = "920F209B-5F11-4B94-A3FC-161F5259D702";

		/// <summary>
		/// Switch To Night Mode
		/// </summary>
		public const string SwitchToNightMode = "F43AB7CD-CEED-49E3-B47A-AE4A325684F9";

		/// <summary>
		/// Switch To T2 Time
		/// </summary>
		public const string SwitchToT2Time = "E0D07EE0-8CD0-4EAD-BB58-7A21E5AE27B6";

		/// <summary>
		/// Synchronize
		/// </summary>
		public const string Synchronize = "07035025-3B52-4C7A-BE4B-5810BF367A4D";

		/// <summary>
		/// Test
		/// </summary>
		public const string Test = "CBF63C59-7DA3-4824-9D4B-0793CBFDAB75";

		/// <summary>
		/// Toggle
		/// </summary>
		public const string Toggle = "BD501C0C-C077-4E71-841B-C92AD2E71AE0";

		/// <summary>
		/// Unlock
		/// </summary>
		public const string Unlock = "C4C32620-E28A-4A78-8EB4-8B657FE7222A";

		/// <summary>
		/// WriteDataCommand
		/// </summary>
		public const string WriteData = "6187FC69-2857-440C-B196-95BA29C9CB04";

	}
}