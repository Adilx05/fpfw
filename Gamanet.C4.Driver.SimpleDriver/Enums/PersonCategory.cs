using System;

//   _____                           _           _                 _      
//  / ____|                         | |         | |               | |     
// | |  __  ___ _ __   ___ _ __ __ _| |_ ___  __| |   ___ ___   __| | ___ 
// | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \/ _` |  / __/ _ \ / _` |/ _ \
// | |__| |  __/ | | |  __/ | | (_| | ||  __/ (_| | | (_| (_) | (_| |  __/
//  \_____|\___|_| |_|\___|_|  \__,_|\__\___|\__,_|  \___\___/ \__,_|\___|
//                                                                        
//                                                                        
namespace Gamanet.C4.SDK.Enums.Persons
{
	/// <summary>
	/// PersonCategory
	/// </summary>
	internal static class PersonCategory
    {
		/// <summary>
		/// PersonRef
		/// </summary>
		public static readonly Guid PersonRef = new Guid(PersonCategoryConst.PersonRef);

		/// <summary>
		/// Role
		/// </summary>
		public static readonly Guid Role = new Guid(PersonCategoryConst.Role);

		/// <summary>
		/// Person
		/// </summary>
		public static readonly Guid Person = new Guid(PersonCategoryConst.Person);

		/// <summary>
		/// RoleRoot
		/// </summary>
		public static readonly Guid RoleRoot = new Guid(PersonCategoryConst.RoleRoot);

		/// <summary>
		/// GroupRoot
		/// </summary>
		public static readonly Guid GroupRoot = new Guid(PersonCategoryConst.GroupRoot);

		/// <summary>
		/// Root
		/// </summary>
		public static readonly Guid Root = new Guid(PersonCategoryConst.Root);

		/// <summary>
		/// SuperRoot
		/// </summary>
		public static readonly Guid SuperRoot = new Guid(PersonCategoryConst.SuperRoot);

		/// <summary>
		/// Company
		/// </summary>
		public static readonly Guid Company = new Guid(PersonCategoryConst.Company);

		/// <summary>
		/// Group
		/// </summary>
		public static readonly Guid Group = new Guid(PersonCategoryConst.Group);

		/// <summary>
		/// Department
		/// </summary>
		public static readonly Guid Department = new Guid(PersonCategoryConst.Department);

		/// <summary>
		/// Division
		/// </summary>
		public static readonly Guid Division = new Guid(PersonCategoryConst.Division);

		/// <summary>
		/// Center
		/// </summary>
		public static readonly Guid Center = new Guid(PersonCategoryConst.Center);

		/// <summary>
		/// VisitorRoot
		/// </summary>
		public static readonly Guid VisitorRoot = new Guid(PersonCategoryConst.VisitorRoot);

		/// <summary>
		/// Visitor
		/// </summary>
		public static readonly Guid Visitor = new Guid(PersonCategoryConst.Visitor);

		/// <summary>
		/// ExternalEmployee
		/// </summary>
		public static readonly Guid ExternalEmployee = new Guid(PersonCategoryConst.ExternalEmployee);

		/// <summary>
		/// Vehicle
		/// </summary>
		public static readonly Guid Vehicle = new Guid(PersonCategoryConst.Vehicle);

		/// <summary>
		/// ManagerEmployee
		/// </summary>
		public static readonly Guid ManagerEmployee = new Guid(PersonCategoryConst.ManagerEmployee);

    }
		
    /// <summary>
	/// PersonCategory Constants
	/// </summary>
	internal static class PersonCategoryConst
	{
		/// <summary>
		/// PersonRef
		/// </summary>
		public const string PersonRef = "71D86917-2681-441B-AA6C-88C34129520A";

		/// <summary>
		/// Role
		/// </summary>
		public const string Role = "B51DB4E3-A9A5-422C-8629-98BA5100D692";

		/// <summary>
		/// Person
		/// </summary>
		public const string Person = "5FEFA0A9-70EE-46AA-BBBD-BED5888C445C";

		/// <summary>
		/// RoleRoot
		/// </summary>
		public const string RoleRoot = "24E562AB-86F9-4CA6-A1A8-D14448A13901";

		/// <summary>
		/// GroupRoot
		/// </summary>
		public const string GroupRoot = "8029908D-8C16-4DF0-B758-9D33BB40240A";

		/// <summary>
		/// Root
		/// </summary>
		public const string Root = "81EB624E-C2B3-4B75-8E77-A65A859EDBDA";

		/// <summary>
		/// SuperRoot
		/// </summary>
		public const string SuperRoot = "DCFF81D7-E899-4F0D-96DC-62AAD222B1C6";

		/// <summary>
		/// Company
		/// </summary>
		public const string Company = "47336057-7ECB-4D0B-9E82-48BE62556D95";

		/// <summary>
		/// Group
		/// </summary>
		public const string Group = "063422E9-3488-42A1-A521-48C9EACA1BE3";

		/// <summary>
		/// Department
		/// </summary>
		public const string Department = "8289478C-D06D-46D4-ADDE-729FD7A96798";

		/// <summary>
		/// Division
		/// </summary>
		public const string Division = "F9823EA2-D234-444C-B32D-7D45DBB5AB03";

		/// <summary>
		/// Center
		/// </summary>
		public const string Center = "1346E412-213E-4553-807A-7EE8C0944FD5";

		/// <summary>
		/// VisitorRoot
		/// </summary>
		public const string VisitorRoot = "31814B65-D513-4EE0-90D2-BEB9157FE5BB";

		/// <summary>
		/// Visitor
		/// </summary>
		public const string Visitor = "91DCA101-8AB3-4B96-B86B-6EA9A4B281F8";

		/// <summary>
		/// ExternalEmployee
		/// </summary>
		public const string ExternalEmployee = "AE1E65E5-1124-45D8-A6CF-930B9D96EB5E";

		/// <summary>
		/// Vehicle
		/// </summary>
		public const string Vehicle = "F26D0796-A751-4B78-A6ED-C154CBEC602B";

		/// <summary>
		/// ManagerEmployee
		/// </summary>
		public const string ManagerEmployee = "4DB7ED74-D567-478F-95F7-F6AADD9833E9";

	}
}