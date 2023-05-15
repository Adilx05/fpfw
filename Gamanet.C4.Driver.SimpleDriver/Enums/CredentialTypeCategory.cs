using System;

//   _____                           _           _                 _      
//  / ____|                         | |         | |               | |     
// | |  __  ___ _ __   ___ _ __ __ _| |_ ___  __| |   ___ ___   __| | ___ 
// | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \/ _` |  / __/ _ \ / _` |/ _ \
// | |__| |  __/ | | |  __/ | | (_| | ||  __/ (_| | | (_| (_) | (_| |  __/
//  \_____|\___|_| |_|\___|_|  \__,_|\__\___|\__,_|  \___\___/ \__,_|\___|
//                                                                        
//                                                                        
namespace Gamanet.C4.SDK.Enums.CredentialTypes
{
	/// <summary>
	/// CredentialTypeCategory
	/// </summary>
	internal static class CredentialTypeCategory
    {
		/// <summary>
		/// Ats
		/// </summary>
		public static readonly Guid Ats = new Guid(CredentialTypeCategoryConst.Ats);

		/// <summary>
		/// Barcode
		/// </summary>
		public static readonly Guid Barcode = new Guid(CredentialTypeCategoryConst.Barcode);

		/// <summary>
		/// Biometry
		/// </summary>
		public static readonly Guid Biometry = new Guid(CredentialTypeCategoryConst.Biometry);

		/// <summary>
		/// Card
		/// </summary>
		public static readonly Guid Card = new Guid(CredentialTypeCategoryConst.Card);

		/// <summary>
		/// CredentialTypeRoot
		/// </summary>
		public static readonly Guid CredentialTypeRoot = new Guid(CredentialTypeCategoryConst.CredentialTypeRoot);

		/// <summary>
		/// EM
		/// </summary>
		public static readonly Guid EM = new Guid(CredentialTypeCategoryConst.EM);

		/// <summary>
		/// Extension Pin
		/// </summary>
		public static readonly Guid ExtensionPin = new Guid(CredentialTypeCategoryConst.ExtensionPin);

		/// <summary>
		/// HID
		/// </summary>
		public static readonly Guid HID = new Guid(CredentialTypeCategoryConst.HID);

		/// <summary>
		/// LicensePlate
		/// </summary>
		public static readonly Guid LicensePlate = new Guid(CredentialTypeCategoryConst.LicensePlate);

		/// <summary>
		/// Motorola
		/// </summary>
		public static readonly Guid Motorola = new Guid(CredentialTypeCategoryConst.Motorola);

		/// <summary>
		/// Other
		/// </summary>
		public static readonly Guid Other = new Guid(CredentialTypeCategoryConst.Other);

		/// <summary>
		/// Others
		/// </summary>
		public static readonly Guid Others = new Guid(CredentialTypeCategoryConst.Others);

		/// <summary>
		/// Pin
		/// </summary>
		public static readonly Guid Pin = new Guid(CredentialTypeCategoryConst.Pin);

		/// <summary>
		/// Pins
		/// </summary>
		public static readonly Guid Pins = new Guid(CredentialTypeCategoryConst.Pins);

		/// <summary>
		/// FingerPrint
		/// </summary>
		public static readonly Guid FingerPrint = new Guid(CredentialTypeCategoryConst.FingerPrint);

		/// <summary>
		/// G-Prox
		/// </summary>
		public static readonly Guid G_Prox = new Guid(CredentialTypeCategoryConst.G_Prox);

    }
		
    /// <summary>
	/// CredentialTypeCategory Constants
	/// </summary>
	internal static class CredentialTypeCategoryConst
	{
		/// <summary>
		/// Ats
		/// </summary>
		public const string Ats = "685D20A0-26DA-475B-B9E1-5EB5F247221D";

		/// <summary>
		/// Barcode
		/// </summary>
		public const string Barcode = "0FE43DA5-7416-4687-AF0C-35F8AFE589A7";

		/// <summary>
		/// Biometry
		/// </summary>
		public const string Biometry = "4F5F1D0A-BDC5-4367-A879-EA7A55ABDD96";

		/// <summary>
		/// Card
		/// </summary>
		public const string Card = "FE88F1BB-1CCF-4FCA-80F7-CCB63D9F97C5";

		/// <summary>
		/// CredentialTypeRoot
		/// </summary>
		public const string CredentialTypeRoot = "60000000-0000-0000-0000-000000000000";

		/// <summary>
		/// EM
		/// </summary>
		public const string EM = "BB493B86-EAFB-4C07-9D15-AA2F679428A3";

		/// <summary>
		/// Extension Pin
		/// </summary>
		public const string ExtensionPin = "A07A4F6E-DA07-4631-89BE-B6E92A231DEB";

		/// <summary>
		/// HID
		/// </summary>
		public const string HID = "F0B75BAC-1F1B-4940-968C-F7947EA67B9B";

		/// <summary>
		/// LicensePlate
		/// </summary>
		public const string LicensePlate = "34A1629E-F14B-4E00-B85E-93295D892ADA";

		/// <summary>
		/// Motorola
		/// </summary>
		public const string Motorola = "27479E3C-B144-46B3-9678-DAC28FA94CA2";

		/// <summary>
		/// Other
		/// </summary>
		public const string Other = "76063912-C4B6-4BFD-AD58-9D4C0C99B8CE";

		/// <summary>
		/// Others
		/// </summary>
		public const string Others = "74C90E0A-9446-4886-8055-A8895BE2EB99";

		/// <summary>
		/// Pin
		/// </summary>
		public const string Pin = "91662A24-74A3-4C03-9ABA-DC82C45F012F";

		/// <summary>
		/// Pins
		/// </summary>
		public const string Pins = "DCA678EC-79AC-41B3-A8D8-F8E7971CBA1E";

		/// <summary>
		/// FingerPrint
		/// </summary>
		public const string FingerPrint = "04AC17E3-E561-456E-B18C-2F71E9A6AAE5";

		/// <summary>
		/// G-Prox
		/// </summary>
		public const string G_Prox = "174E68E0-B50D-4965-AD78-4C7DD13FFE67";

	}
}