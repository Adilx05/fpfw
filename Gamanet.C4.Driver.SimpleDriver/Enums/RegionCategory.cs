using System;

//   _____                           _           _                 _      
//  / ____|                         | |         | |               | |     
// | |  __  ___ _ __   ___ _ __ __ _| |_ ___  __| |   ___ ___   __| | ___ 
// | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \/ _` |  / __/ _ \ / _` |/ _ \
// | |__| |  __/ | | |  __/ | | (_| | ||  __/ (_| | | (_| (_) | (_| |  __/
//  \_____|\___|_| |_|\___|_|  \__,_|\__\___|\__,_|  \___\___/ \__,_|\___|
//                                                                        
//                                                                        
namespace Gamanet.C4.SDK.Enums.Regions
{
	/// <summary>
	/// RegionCategory
	/// </summary>
	internal static class RegionCategory
    {
		/// <summary>
		/// Region
		/// </summary>
		public static readonly Guid Region = new Guid(RegionCategoryConst.Region);

		/// <summary>
		/// Root
		/// </summary>
		public static readonly Guid Root = new Guid(RegionCategoryConst.Root);

		/// <summary>
		/// RegionDeviceRef
		/// </summary>
		public static readonly Guid RegionDeviceRef = new Guid(RegionCategoryConst.RegionDeviceRef);

		/// <summary>
		/// SuperRoot
		/// </summary>
		public static readonly Guid SuperRoot = new Guid(RegionCategoryConst.SuperRoot);

		/// <summary>
		/// MusterRegion
		/// </summary>
		public static readonly Guid MusterRegion = new Guid(RegionCategoryConst.MusterRegion);

    }
		
    /// <summary>
	/// RegionCategory Constants
	/// </summary>
	internal static class RegionCategoryConst
	{
		/// <summary>
		/// Region
		/// </summary>
		public const string Region = "6D24BBD4-1FE5-45B4-9689-E1E2F9E87B8A";

		/// <summary>
		/// Root
		/// </summary>
		public const string Root = "5E66AD09-D329-4D74-A8EE-0905661CDC1B";

		/// <summary>
		/// RegionDeviceRef
		/// </summary>
		public const string RegionDeviceRef = "4AB0F19B-04F7-4E44-9D47-D2452A85C7C8";

		/// <summary>
		/// SuperRoot
		/// </summary>
		public const string SuperRoot = "83530166-70EE-41DE-B2E2-E7CAF40D55B2";

		/// <summary>
		/// MusterRegion
		/// </summary>
		public const string MusterRegion = "F10E97D9-595F-47A9-9D65-718964848E15";

	}
}