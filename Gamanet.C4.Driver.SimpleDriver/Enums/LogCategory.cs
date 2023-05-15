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
	/// LogCategory
	/// </summary>
	internal static class LogCategory
    {
		/// <summary>
		/// IncompatibleFirmwareVersionWithExpectedVersionEvent
		/// </summary>
		public static readonly Guid IncompatibleFirmwareVersionWithExpectedVersion = new Guid(LogCategoryConst.IncompatibleFirmwareVersionWithExpectedVersion);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Active time restriction
		/// </summary>
		public static readonly Guid AccessDeniedActiveTimeRestriction = new Guid(LogCategoryConst.AccessDeniedActiveTimeRestriction);

		/// <summary>
		/// AccessDeniedAntiPassbackViolationEvent
		/// </summary>
		public static readonly Guid AccessDeniedAntiPassbackViolation = new Guid(LogCategoryConst.AccessDeniedAntiPassbackViolation);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Area is armed
		/// </summary>
		public static readonly Guid AccessDeniedAreaIsArmed = new Guid(LogCategoryConst.AccessDeniedAreaIsArmed);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Card is archived
		/// </summary>
		public static readonly Guid AccessDeniedCardIsArchived = new Guid(LogCategoryConst.AccessDeniedCardIsArchived);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Card is disabled
		/// </summary>
		public static readonly Guid AccessDeniedCardIsDisabled = new Guid(LogCategoryConst.AccessDeniedCardIsDisabled);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Card is lost
		/// </summary>
		public static readonly Guid AccessDeniedCardIsLost = new Guid(LogCategoryConst.AccessDeniedCardIsLost);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Configuration error
		/// </summary>
		public static readonly Guid AccessDeniedConfigurationError = new Guid(LogCategoryConst.AccessDeniedConfigurationError);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Credential unknown at this device
		/// </summary>
		public static readonly Guid AccessDeniedCredentialUnknownAtThisDevice = new Guid(LogCategoryConst.AccessDeniedCredentialUnknownAtThisDevice);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Door is manually overridden
		/// </summary>
		public static readonly Guid AccessDeniedDoorIsManuallyOverridden = new Guid(LogCategoryConst.AccessDeniedDoorIsManuallyOverridden);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Door not allowed
		/// </summary>
		public static readonly Guid AccessDeniedDoorNotAllowed = new Guid(LogCategoryConst.AccessDeniedDoorNotAllowed);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Floor not allowed
		/// </summary>
		public static readonly Guid AccessDeniedFloorNotAllowed = new Guid(LogCategoryConst.AccessDeniedFloorNotAllowed);

		/// <summary>
		/// AccessDeniedGlobalAntiPassbackViolationEvent
		/// </summary>
		public static readonly Guid AccessDeniedGlobalAntiPassbackViolation = new Guid(LogCategoryConst.AccessDeniedGlobalAntiPassbackViolation);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Hard Anti-passback violation
		/// </summary>
		public static readonly Guid AccessDeniedHardAntiPassbackViolation = new Guid(LogCategoryConst.AccessDeniedHardAntiPassbackViolation);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential
		/// </summary>
		public static readonly Guid AccessDeniedIncompleteCredential = new Guid(LogCategoryConst.AccessDeniedIncompleteCredential);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential - Missing card
		/// </summary>
		public static readonly Guid AccessDeniedIncompleteCredentialMissingCard = new Guid(LogCategoryConst.AccessDeniedIncompleteCredentialMissingCard);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential - Missing PIN
		/// </summary>
		public static readonly Guid AccessDeniedIncompleteCredentialMissingPIN = new Guid(LogCategoryConst.AccessDeniedIncompleteCredentialMissingPIN);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential - PIN entered before card
		/// </summary>
		public static readonly Guid AccessDeniedIncompleteCredentialPINEnteredBeforeCard = new Guid(LogCategoryConst.AccessDeniedIncompleteCredentialPINEnteredBeforeCard);

		/// <summary>
		/// Access denied for unknown credential at '{0:DeviceIdName}' using credential '{0:Code}' on reader '{0:ReaderIdName}'. Reason: Invalid card format
		/// </summary>
		public static readonly Guid AccessDeniedInvalidCardFormat = new Guid(LogCategoryConst.AccessDeniedInvalidCardFormat);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Invalid issue state
		/// </summary>
		public static readonly Guid AccessDeniedInvalidIssueState = new Guid(LogCategoryConst.AccessDeniedInvalidIssueState);

		/// <summary>
		/// Access denied to unknown credential at '{0:DeviceIdName}' on keypad '{0:ReaderIdName}'. Reason: Invalid PIN code
		/// </summary>
		public static readonly Guid AccessDeniedInvalidPINCode = new Guid(LogCategoryConst.AccessDeniedInvalidPINCode);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Invalid site code
		/// </summary>
		public static readonly Guid AccessDeniedInvalidSiteCode = new Guid(LogCategoryConst.AccessDeniedInvalidSiteCode);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Lockout timer active
		/// </summary>
		public static readonly Guid AccessDeniedLockoutTimerActive = new Guid(LogCategoryConst.AccessDeniedLockoutTimerActive);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: No alarm control
		/// </summary>
		public static readonly Guid AccessDeniedNoAlarmControl = new Guid(LogCategoryConst.AccessDeniedNoAlarmControl);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: No area control
		/// </summary>
		public static readonly Guid AccessDeniedNoAreaControl = new Guid(LogCategoryConst.AccessDeniedNoAreaControl);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Not enough high security users
		/// </summary>
		public static readonly Guid AccessDeniedNotEnoughHighSecurityUsers = new Guid(LogCategoryConst.AccessDeniedNotEnoughHighSecurityUsers);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Other
		/// </summary>
		public static readonly Guid AccessDeniedOther = new Guid(LogCategoryConst.AccessDeniedOther);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Outside of validity period
		/// </summary>
		public static readonly Guid AccessDeniedOutsideOfValidityPeriod = new Guid(LogCategoryConst.AccessDeniedOutsideOfValidityPeriod);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Reader is disabled
		/// </summary>
		public static readonly Guid AccessDeniedReaderIsDisabled = new Guid(LogCategoryConst.AccessDeniedReaderIsDisabled);

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Timed Anti-passback violation
		/// </summary>
		public static readonly Guid AccessDeniedTimedAntiPassbackViolation = new Guid(LogCategoryConst.AccessDeniedTimedAntiPassbackViolation);

		/// <summary>
		/// Access denied for unknown credential "{0:CardCode} ({0:CredentialTypeIdName})" at '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid AccessDeniedUnknownCredential = new Guid(LogCategoryConst.AccessDeniedUnknownCredential);

		/// <summary>
		/// Access denied for unknown credential at '{0:DeviceIdName}' on keypad '{0:ReaderIdName}'. Reason: Unknown PIN code
		/// </summary>
		public static readonly Guid AccessDeniedUnknownPINCode = new Guid(LogCategoryConst.AccessDeniedUnknownPINCode);

		/// <summary>
		/// AccessGrantedAttendanceEvent
		/// </summary>
		public static readonly Guid AccessGrantedAttendance = new Guid(LogCategoryConst.AccessGrantedAttendance);

		/// <summary>
		/// Access granted to '{0:PersonIdName}' at '{0:DeviceIdName}' using combined credential at reader '{0:ReaderIdName}'.
		/// </summary>
		public static readonly Guid AccessGrantedCombinedCredential = new Guid(LogCategoryConst.AccessGrantedCombinedCredential);

		/// <summary>
		/// Access granted to '{0:PersonIdName}' at '{0:DeviceIdName}' using '{0:CredentialTypeIdName}' '{0:CredentialIdName}' at reader '{0:ReaderIdName}'.
		/// </summary>
		public static readonly Guid AccessGranted = new Guid(LogCategoryConst.AccessGranted);

		/// <summary>
		/// Access granted with soft anti-passback violation to '{0:PersonIdName}' at '{0:DeviceIdName}' using '{0:CredentialTypeIdName}' '{0:CredentialIdName}' at reader '{0:ReaderIdName}'.
		/// </summary>
		public static readonly Guid AccessGrantedSoftAntipassbackViolation = new Guid(LogCategoryConst.AccessGrantedSoftAntipassbackViolation);

		/// <summary>
		/// Access granted for unknown credential "{0:CardCode} ({0:CredentialTypeIdName})" at '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid AccessGrantedUnknownCredential = new Guid(LogCategoryConst.AccessGrantedUnknownCredential);

		/// <summary>
		/// Access granted with entry made to '{0:PersonIdName}' at '{0:DeviceIdName}' using '{0:CredentialTypeIdName}' '{0:CredentialIdName}' at reader '{0:ReaderIdName}'.
		/// </summary>
		public static readonly Guid AccessGrantedWithEntryMade = new Guid(LogCategoryConst.AccessGrantedWithEntryMade);

		/// <summary>
		/// AccessInExitTimeEvent
		/// </summary>
		public static readonly Guid AccessInExitTime = new Guid(LogCategoryConst.AccessInExitTime);

		/// <summary>
		/// '{0:AuthorIdName}' created new access level '{0:AccessLevelIdName}'.
		/// </summary>
		public static readonly Guid AccessLevelCreated = new Guid(LogCategoryConst.AccessLevelCreated);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted access level '{0:AccessLevelIdName}'.
		/// </summary>
		public static readonly Guid AccessLevelDeleted = new Guid(LogCategoryConst.AccessLevelDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of access level '{0:AccessLevelIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid AccessLevelPropertyChanged = new Guid(LogCategoryConst.AccessLevelPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' assigned access point '{0:DeviceIdName}' to the access level '{0:AccessLevelIdName}'
		/// </summary>
		public static readonly Guid AccessPointAssigned = new Guid(LogCategoryConst.AccessPointAssigned);

		/// <summary>
		/// '{0:AuthorIdName}' unassigned access point '{0:DeviceIdName}' from the access level '{0:AccessLevelIdName}'
		/// </summary>
		public static readonly Guid AccessPointUnassigned = new Guid(LogCategoryConst.AccessPointUnassigned);

		/// <summary>
		/// AgentAssignedEvent
		/// </summary>
		public static readonly Guid AgentAssigned = new Guid(LogCategoryConst.AgentAssigned);

		/// <summary>
		/// Agent '{0:AgentIdName}' connected from '{0:IpAddress}'.
		/// </summary>
		public static readonly Guid AgentConnected = new Guid(LogCategoryConst.AgentConnected);

		/// <summary>
		/// {0:AuthorIdName}' created agent '{0:AgentIdName}'.
		/// </summary>
		public static readonly Guid AgentCreated = new Guid(LogCategoryConst.AgentCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted agent '{0:AgentIdName}'.
		/// </summary>
		public static readonly Guid AgentDeleted = new Guid(LogCategoryConst.AgentDeleted);

		/// <summary>
		/// Agent '{0:AgentIdName}' disconnected from '{0:IpAddress}'.
		/// </summary>
		public static readonly Guid AgentDisconnected = new Guid(LogCategoryConst.AgentDisconnected);

		/// <summary>
		/// Agent '{0:AgentIdName}' assigned to group '{0:ParentIdName}' by  '{0:AuthorIdName}'.
		/// </summary>
		public static readonly Guid AgentGroupAssigned = new Guid(LogCategoryConst.AgentGroupAssigned);

		/// <summary>
		/// Agent '{0:AgentIdName}' unassigned from group '{0:ParentIdName}' by  '{0:AuthorIdName}'.
		/// </summary>
		public static readonly Guid AgentGroupUnassigned = new Guid(LogCategoryConst.AgentGroupUnassigned);

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of agent '{0:AgentIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid AgentPropertyChanged = new Guid(LogCategoryConst.AgentPropertyChanged);

		/// <summary>
		/// AlarmAntimaskingEvent
		/// </summary>
		public static readonly Guid AlarmAntimasking = new Guid(LogCategoryConst.AlarmAntimasking);

		/// <summary>
		/// AlarmCancelledByKeyswitchEvent
		/// </summary>
		public static readonly Guid AlarmCancelledByKeyswitch = new Guid(LogCategoryConst.AlarmCancelledByKeyswitch);

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' was cancelled by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid AlarmCancelledByPerson = new Guid(LogCategoryConst.AlarmCancelledByPerson);

		/// <summary>
		/// Duress alarm on '{0:DeviceIdName}' by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid AlarmDuressByPerson = new Guid(LogCategoryConst.AlarmDuressByPerson);

		/// <summary>
		/// Duress alarm from '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid AlarmDuress = new Guid(LogCategoryConst.AlarmDuress);

		/// <summary>
		/// AlarmDuressResetByUserEvent
		/// </summary>
		public static readonly Guid AlarmDuressResetByUser = new Guid(LogCategoryConst.AlarmDuressResetByUser);

		/// <summary>
		/// Alarm on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid Alarm = new Guid(LogCategoryConst.Alarm);

		/// <summary>
		/// Flooding alarm on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid AlarmFlooding = new Guid(LogCategoryConst.AlarmFlooding);

		/// <summary>
		/// Flooding alarm on '{0:DeviceIdName}' restored.
		/// </summary>
		public static readonly Guid AlarmFloodingRestored = new Guid(LogCategoryConst.AlarmFloodingRestored);

		/// <summary>
		/// AlarmInExitTimeEvent
		/// </summary>
		public static readonly Guid AlarmInExitTime = new Guid(LogCategoryConst.AlarmInExitTime);

		/// <summary>
		/// AlarmLocalEvent
		/// </summary>
		public static readonly Guid AlarmLocal = new Guid(LogCategoryConst.AlarmLocal);

		/// <summary>
		/// AlarmLocalRecoveredEvent
		/// </summary>
		public static readonly Guid AlarmLocalRecovered = new Guid(LogCategoryConst.AlarmLocalRecovered);

		/// <summary>
		/// AlarmManagementEvent
		/// </summary>
		public static readonly Guid AlarmManagement = new Guid(LogCategoryConst.AlarmManagement);

		/// <summary>
		/// Panic alarm on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid AlarmPanic = new Guid(LogCategoryConst.AlarmPanic);

		/// <summary>
		/// Panic alarm on '{0:DeviceIdName}' recovered.
		/// </summary>
		public static readonly Guid AlarmPanicRecovered = new Guid(LogCategoryConst.AlarmPanicRecovered);

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' restored.
		/// </summary>
		public static readonly Guid AlarmRecovered = new Guid(LogCategoryConst.AlarmRecovered);

		/// <summary>
		/// AlarmRecoveredInExitTimeEvent
		/// </summary>
		public static readonly Guid AlarmRecoveredInExitTime = new Guid(LogCategoryConst.AlarmRecoveredInExitTime);

		/// <summary>
		/// AlarmSoonAfterArmEvent
		/// </summary>
		public static readonly Guid AlarmSoonAfterArm = new Guid(LogCategoryConst.AlarmSoonAfterArm);

		/// <summary>
		/// AlarmTicketEvent
		/// </summary>
		public static readonly Guid AlarmTicket = new Guid(LogCategoryConst.AlarmTicket);

		/// <summary>
		/// '{0:DeviceIdName}' was armed automatically.
		/// </summary>
		public static readonly Guid ArmedAutomatically = new Guid(LogCategoryConst.ArmedAutomatically);

		/// <summary>
		/// ArmedAutomaticPostponedByUserEvent
		/// </summary>
		public static readonly Guid ArmedAutomaticPostponedByUser = new Guid(LogCategoryConst.ArmedAutomaticPostponedByUser);

		/// <summary>
		/// ArmedByKeySwitchEvent
		/// </summary>
		public static readonly Guid ArmedByKeySwitch = new Guid(LogCategoryConst.ArmedByKeySwitch);

		/// <summary>
		/// '{0:DeviceIdName}' was armed by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid ArmedByPerson = new Guid(LogCategoryConst.ArmedByPerson);

		/// <summary>
		/// ArmedEvent
		/// </summary>
		public static readonly Guid Armed = new Guid(LogCategoryConst.Armed);

		/// <summary>
		/// '{0:DeviceIdName}' was forcibly armed by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid ArmedForciblyByPerson = new Guid(LogCategoryConst.ArmedForciblyByPerson);

		/// <summary>
		/// ArmFailureTooLateEvent
		/// </summary>
		public static readonly Guid ArmFailureTooLate = new Guid(LogCategoryConst.ArmFailureTooLate);

		/// <summary>
		/// ArmedInExitTimeEvent
		/// </summary>
		public static readonly Guid ArmedInExitTime = new Guid(LogCategoryConst.ArmedInExitTime);

		/// <summary>
		/// ArmedPartiallyByPersonEvent
		/// </summary>
		public static readonly Guid ArmedPartiallyByPerson = new Guid(LogCategoryConst.ArmedPartiallyByPerson);

		/// <summary>
		/// ArmFailureEvent
		/// </summary>
		public static readonly Guid ArmFailure = new Guid(LogCategoryConst.ArmFailure);

		/// <summary>
		/// '{0:AuthorIdName}' changed owner of credential '{0:CredentialIdName}' held by '{0:HolderIdName}' to '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid AssignedCredentialOwnerChanged = new Guid(LogCategoryConst.AssignedCredentialOwnerChanged);

		/// <summary>
		/// '{0:AuthorIdName}' changed content of the credential '{0:CredentialIdName}' held by '{0:HolderIdName}' under '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid AssignedTransferableCredentialCodeChanged = new Guid(LogCategoryConst.AssignedTransferableCredentialCodeChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created credential '{0:CredentialIdName}' with credential type '{0:CategoryIdName}' for '{0:HolderIdName}' into '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid AssignedTransferableCredentialCreated = new Guid(LogCategoryConst.AssignedTransferableCredentialCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted '{0:CredentialIdName}' held by '{0:HolderIdName}' into '{0:OwnerIdName}' .
		/// </summary>
		public static readonly Guid AssignedTransferableCredentialDeleted = new Guid(LogCategoryConst.AssignedTransferableCredentialDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:CredentialIdName}' held by '{0:HolderIdName}' into '{0:OwnerIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid AssignedTransferableCredentialPropertyChanged = new Guid(LogCategoryConst.AssignedTransferableCredentialPropertyChanged);

		/// <summary>
		/// AudioDecibelSteepDropEvent
		/// </summary>
		public static readonly Guid AudioDecibelSteepDrop = new Guid(LogCategoryConst.AudioDecibelSteepDrop);

		/// <summary>
		/// AudioSignalLostEvent
		/// </summary>
		public static readonly Guid AudioSignalLost = new Guid(LogCategoryConst.AudioSignalLost);

		/// <summary>
		/// Authentication for '{0:PersonIdName}' through SafeConnect failed from IP address '{0:IpAddress}' ('{0:IpAddressDomainName}'), using Portal Account '{0:SafeConnectPortalUserIdName}', SafeConnect Device '{0:SafeConnectDeviceIdName}'.
		/// </summary>
		public static readonly Guid AuthenticationBySafeConnectFailed = new Guid(LogCategoryConst.AuthenticationBySafeConnectFailed);

		/// <summary>
		/// Authentication for '{0:PersonIdName}' failed from IP address '{0:IpAddress}' ('{0:IpAddressDomainName}').
		/// </summary>
		public static readonly Guid AuthenticationFailed = new Guid(LogCategoryConst.AuthenticationFailed);

		/// <summary>
		/// Authentication for '{0:PersonIdName}' through SafeConnect failed from IP address '{0:IpAddress}' ('{0:IpAddressDomainName}'), using Portal Account '{0:SafeConnectPortalUserIdName}', SafeConnect Device '{0:SafeConnectDeviceIdName}', because current person is not merged with used Portal Account.
		/// </summary>
		public static readonly Guid AuthenticationFailedPortalUserDoesNotMatch = new Guid(LogCategoryConst.AuthenticationFailedPortalUserDoesNotMatch);

		/// <summary>
		/// {0:AuthorIdName}' changed acount of person '{0:PersonIdName}' from '{0:OldAccount}' to '{0:Account}'.
		/// </summary>
		public static readonly Guid AuthenticationLoginAccountChanged = new Guid(LogCategoryConst.AuthenticationLoginAccountChanged);

		/// <summary>
		/// {0:AuthorIdName}' created user account '{0:Account}' for '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid AuthenticationLoginCreated = new Guid(LogCategoryConst.AuthenticationLoginCreated);

		/// <summary>
		/// {0:AuthorIdName}' deleted user account '{0:Account}' from '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid AuthenticationLoginDeleted = new Guid(LogCategoryConst.AuthenticationLoginDeleted);

		/// <summary>
		/// {0:AuthorIdName}' changed password of '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid AuthenticationLoginPasswordChanged = new Guid(LogCategoryConst.AuthenticationLoginPasswordChanged);

		/// <summary>
		/// Authentication to '{0:DeviceIdName}' failed.
		/// </summary>
		public static readonly Guid AuthenticationToDeviceFailed = new Guid(LogCategoryConst.AuthenticationToDeviceFailed);

		/// <summary>
		/// Authentication to '{0:DeviceIdName}' failed. Reason: Invalid password
		/// </summary>
		public static readonly Guid AuthenticationToDeviceFailedInvalidPassword = new Guid(LogCategoryConst.AuthenticationToDeviceFailedInvalidPassword);

		/// <summary>
		/// Authentication to '{0:DeviceIdName}' failed. Reason: Invalid security certificate.
		/// </summary>
		public static readonly Guid AuthenticationToDeviceFailedInvalidSecurityCertificate = new Guid(LogCategoryConst.AuthenticationToDeviceFailedInvalidSecurityCertificate);

		/// <summary>
		/// Authorization level was changed on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid AuthorizationLevelChanged = new Guid(LogCategoryConst.AuthorizationLevelChanged);

		/// <summary>
		/// '{0:DeviceIdName}' - low battery.
		/// </summary>
		public static readonly Guid BatteryLowWarning = new Guid(LogCategoryConst.BatteryLowWarning);

		/// <summary>
		/// '{0:DeviceIdName}' - low battery restored.
		/// </summary>
		public static readonly Guid BatteryLowWarningRecovered = new Guid(LogCategoryConst.BatteryLowWarningRecovered);

		/// <summary>
		/// BatteryTestFinishedEvent
		/// </summary>
		public static readonly Guid BatteryTestFinished = new Guid(LogCategoryConst.BatteryTestFinished);

		/// <summary>
		/// BatteryTestStartedEvent
		/// </summary>
		public static readonly Guid BatteryTestStarted = new Guid(LogCategoryConst.BatteryTestStarted);

		/// <summary>
		/// {0:AuthorIdName}' deleted blob '{0:BlobIdName}' for device '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid BlobDeleted = new Guid(LogCategoryConst.BlobDeleted);

		/// <summary>
		/// {0:AuthorIdName}' deleted blob history '{0:BlobIdName}' for device '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid BlobHistoryDeleted = new Guid(LogCategoryConst.BlobHistoryDeleted);

		/// <summary>
		/// {0:AuthorIdName}' saved blob '{0:BlobIdName}' for device '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid BlobSaved = new Guid(LogCategoryConst.BlobSaved);

		/// <summary>
		/// '{0:DeviceIdName}' buzzer disabled.
		/// </summary>
		public static readonly Guid BuzzerDisabled = new Guid(LogCategoryConst.BuzzerDisabled);

		/// <summary>
		/// BuzzerEnableEvent
		/// </summary>
		public static readonly Guid BuzzerEnable = new Guid(LogCategoryConst.BuzzerEnable);

		/// <summary>
		/// BuzzerFailureEvent
		/// </summary>
		public static readonly Guid BuzzerFailure = new Guid(LogCategoryConst.BuzzerFailure);

		/// <summary>
		/// BuzzerFailureRecoveredEvent
		/// </summary>
		public static readonly Guid BuzzerFailureRecovered = new Guid(LogCategoryConst.BuzzerFailureRecovered);

		/// <summary>
		/// '{0:DeviceIdName}' buzzer muted.
		/// </summary>
		public static readonly Guid BuzzerMuted = new Guid(LogCategoryConst.BuzzerMuted);

		/// <summary>
		/// '{0:DeviceIdName}' was bypassed automatically.
		/// </summary>
		public static readonly Guid BypassAutomatically = new Guid(LogCategoryConst.BypassAutomatically);

		/// <summary>
		/// '{0:DeviceIdName}' bypass was cancelled automatically.
		/// </summary>
		public static readonly Guid BypassCancelAutomatically = new Guid(LogCategoryConst.BypassCancelAutomatically);

		/// <summary>
		/// '{0:DeviceIdName}' bypass was cancelled by user '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid BypassCancel = new Guid(LogCategoryConst.BypassCancel);

		/// <summary>
		/// '{0:DeviceIdName}' was bypassed by user '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid Bypass = new Guid(LogCategoryConst.Bypass);

		/// <summary>
		/// '{0:DeviceIdName}' was bypassed timed (duration {0:Time}).
		/// </summary>
		public static readonly Guid BypassTimed = new Guid(LogCategoryConst.BypassTimed);

		/// <summary>
		/// '{0:AuthorIdName}' created calendar '{0:CalendarIdName}'
		/// </summary>
		public static readonly Guid CalendarCreated = new Guid(LogCategoryConst.CalendarCreated);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of Calendar'{0:CalendarIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid CalendarDataChanged = new Guid(LogCategoryConst.CalendarDataChanged);

		/// <summary>
		/// '{0:AuthorIdName}' deleted calendar '{0:CalendarIdName}'.
		/// </summary>
		public static readonly Guid CalendarDeleted = new Guid(LogCategoryConst.CalendarDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed time restriction for '{0:CalendarIdName}'.
		/// </summary>
		public static readonly Guid CalendarTimeFrameChanged = new Guid(LogCategoryConst.CalendarTimeFrameChanged);

		/// <summary>
		/// CallEvent
		/// </summary>
		public static readonly Guid Call = new Guid(LogCategoryConst.Call);

		/// <summary>
		/// CallRedirectedEvent
		/// </summary>
		public static readonly Guid CallRedirected = new Guid(LogCategoryConst.CallRedirected);

		/// <summary>
		/// '{0:AuthorIdName}' has read card '{0:CardVendorIdName} {0:CardTypeIdName}' on '{0:DeviceIdName}'. Card length: '{0:CodeLength}'. Card code: '{0:CodeHexa}'
		/// </summary>
		public static readonly Guid CardEnrolledFromReader = new Guid(LogCategoryConst.CardEnrolledFromReader);

		/// <summary>
		/// '{0:AuthorIdName}' has read card '{0:CardTypeIdName}' on '{0:DeviceIdName}'. Card length: '{0:CodeLength}'. Card code: '{0:Code}'
		/// </summary>
		public static readonly Guid CardRead = new Guid(LogCategoryConst.CardRead);

		/// <summary>
		/// '{0:DeviceIdName}' closed.
		/// </summary>
		public static readonly Guid Closed = new Guid(LogCategoryConst.Closed);

		/// <summary>
		/// CodeEnteredEvent
		/// </summary>
		public static readonly Guid CodeEntered = new Guid(LogCategoryConst.CodeEntered);

		/// <summary>
		/// Command '[$msg{0:CommandIdName}$]' from '{0:IssuerPersonIdName}' was delivered to '{0:EntityIdName}'.
		/// </summary>
		public static readonly Guid CommandDelivered = new Guid(LogCategoryConst.CommandDelivered);

		/// <summary>
		/// Command '[$msg{0:CommandIdName}$]' issued by '{0:IssuerPersonIdName}' on '{0:DeviceIdName}' failed. Reason: {0:Description}
		/// </summary>
		public static readonly Guid CommandFailed = new Guid(LogCategoryConst.CommandFailed);

		/// <summary>
		/// '{0:IssuerPersonIdName}' sent command '[$msg{0:CommandIdName}$]' to '{0:EntityIdName}'.
		/// </summary>
		public static readonly Guid CommandIssued = new Guid(LogCategoryConst.CommandIssued);

		/// <summary>
		/// Communication with '{0:DeviceIdName}' lost.
		/// </summary>
		public static readonly Guid CommunicationLost = new Guid(LogCategoryConst.CommunicationLost);

		/// <summary>
		/// 'Communication with '{0:DeviceIdName}' restored.
		/// </summary>
		public static readonly Guid CommunicationRestored = new Guid(LogCategoryConst.CommunicationRestored);

		/// <summary>
		/// CommunicationTestEvent
		/// </summary>
		public static readonly Guid CommunicationTest = new Guid(LogCategoryConst.CommunicationTest);

		/// <summary>
		/// ConfigurationChangedEvent
		/// </summary>
		public static readonly Guid ConfigurationChanged = new Guid(LogCategoryConst.ConfigurationChanged);

		/// <summary>
		/// ConfigurationChangedTimeEvent
		/// </summary>
		public static readonly Guid ConfigurationChangedTime = new Guid(LogCategoryConst.ConfigurationChangedTime);

		/// <summary>
		/// Technician entered into the local configuration of '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid ConfigurationEnteredByTechnician = new Guid(LogCategoryConst.ConfigurationEnteredByTechnician);

		/// <summary>
		/// {0:PropertyName}' property value on device '{0:DeviceIdName}' has invalid format.
		/// </summary>
		public static readonly Guid ConfigurationErrorInvalidPropertyValue = new Guid(LogCategoryConst.ConfigurationErrorInvalidPropertyValue);

		/// <summary>
		/// {0:PropertyName}' property value on device '{0:DeviceIdName}' is out of allowed range ('{0:MinValue}' - '{0:MaxValue}').
		/// </summary>
		public static readonly Guid ConfigurationErrorInvalidPropertyValueOutOfRange = new Guid(LogCategoryConst.ConfigurationErrorInvalidPropertyValueOutOfRange);

		/// <summary>
		/// {0:PropertyName}' property value length on device '{0:DeviceIdName}' is out of allowed range ('{0:MinValue}' - '{0:MaxValue}').
		/// </summary>
		public static readonly Guid ConfigurationErrorInvalidPropertyValueOutOfRangeLength = new Guid(LogCategoryConst.ConfigurationErrorInvalidPropertyValueOutOfRangeLength);

		/// <summary>
		/// ConfigurationErrorInvalidTreeEvent
		/// </summary>
		public static readonly Guid ConfigurationErrorInvalidTree = new Guid(LogCategoryConst.ConfigurationErrorInvalidTree);

		/// <summary>
		/// Technician exited the configuration of '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid ConfigurationExitedByTechnician = new Guid(LogCategoryConst.ConfigurationExitedByTechnician);

		/// <summary>
		/// Connection of '{0:DeviceIdName}' to '{0:DeviceOutIdName}' established.
		/// </summary>
		public static readonly Guid ConnectionEstablished = new Guid(LogCategoryConst.ConnectionEstablished);

		/// <summary>
		/// Connection between '{0:DeviceIdName}' and '{0:DeviceOutIdName}' interrupted.
		/// </summary>
		public static readonly Guid ConnectionInterrupted = new Guid(LogCategoryConst.ConnectionInterrupted);

		/// <summary>
		/// CredentialCodeChangedEvent
		/// </summary>
		public static readonly Guid CredentialCodeChanged = new Guid(LogCategoryConst.CredentialCodeChanged);

		/// <summary>
		/// CredentialCreatedEvent
		/// </summary>
		public static readonly Guid CredentialCreated = new Guid(LogCategoryConst.CredentialCreated);

		/// <summary>
		/// CredentialDeletedEvent
		/// </summary>
		public static readonly Guid CredentialDeleted = new Guid(LogCategoryConst.CredentialDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' deactivated '{0:CredentialIdName}' from '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid CredentialHolderRemoved = new Guid(LogCategoryConst.CredentialHolderRemoved);

		/// <summary>
		/// '{0:AuthorIdName}' activated '{0:CredentialIdName}' to '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid CredentialHolderSet = new Guid(LogCategoryConst.CredentialHolderSet);

		/// <summary>
		/// CredentialOwnerChanged
		/// </summary>
		public static readonly Guid CredentialOwnerChanged = new Guid(LogCategoryConst.CredentialOwnerChanged);

		/// <summary>
		/// CredentialPropertyChanged
		/// </summary>
		public static readonly Guid CredentialPropertyChanged = new Guid(LogCategoryConst.CredentialPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' combined credentials held by '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid CredentialsCombined = new Guid(LogCategoryConst.CredentialsCombined);

		/// <summary>
		/// '{0:AuthorIdName}' splitted credentials held by '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid CredentialsSplitted = new Guid(LogCategoryConst.CredentialsSplitted);

		/// <summary>
		/// '{0:AuthorIdName}' changed status of credential '{0:CredentialIdName}' from '{0:OldValue}' to '{0:NewValue}'.
		/// </summary>
		public static readonly Guid CredentialStatusChanged = new Guid(LogCategoryConst.CredentialStatusChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created credential type '{0:CredentialTypeIdName}'.
		/// </summary>
		public static readonly Guid CredentialTypeCreated = new Guid(LogCategoryConst.CredentialTypeCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted credential type '{0:CredentialTypeIdName}'
		/// </summary>
		public static readonly Guid CredentialTypeDeleted = new Guid(LogCategoryConst.CredentialTypeDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of credential type '{0:CredentialTypeIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid CredentialTypePropertyChanged = new Guid(LogCategoryConst.CredentialTypePropertyChanged);

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup failed due insufficient permissions.
		/// </summary>
		public static readonly Guid DatabaseBackupFailedInsufficientPermissions = new Guid(LogCategoryConst.DatabaseBackupFailedInsufficientPermissions);

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup failed due to low disk space in target location.
		/// </summary>
		public static readonly Guid DatabaseBackupFailedLowDiskSpace = new Guid(LogCategoryConst.DatabaseBackupFailedLowDiskSpace);

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup started.
		/// </summary>
		public static readonly Guid DatabaseBackupStarted = new Guid(LogCategoryConst.DatabaseBackupStarted);

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup succesfully finished.
		/// </summary>
		public static readonly Guid DatabaseBackupSuccesful = new Guid(LogCategoryConst.DatabaseBackupSuccesful);

		/// <summary>
		/// '{0:DeviceIdName}' database cleanup failed. Reason: '{0:Description}'
		/// </summary>
		public static readonly Guid DatabaseCleanupFailed = new Guid(LogCategoryConst.DatabaseCleanupFailed);

		/// <summary>
		/// '{0:DeviceIdName}' database cleanup successfully finished and deleted {0:Amount} events older than {0:Date}. Reduced database size {0:Size}.
		/// </summary>
		public static readonly Guid DatabaseCleanupFinished = new Guid(LogCategoryConst.DatabaseCleanupFinished);

		/// <summary>
		/// '{0:DeviceIdName}' database cleanup started.
		/// </summary>
		public static readonly Guid DatabaseCleanupStarted = new Guid(LogCategoryConst.DatabaseCleanupStarted);

		/// <summary>
		/// {0:DeviceIdName}' database size reached the configured treshold '{0:Threshold}' GB. Consider further steps to reduce database size for proper system operation.
		/// </summary>
		public static readonly Guid DatabaseSizeReachedTreshold = new Guid(LogCategoryConst.DatabaseSizeReachedTreshold);

		/// <summary>
		/// DefocusDetectedEvent
		/// </summary>
		public static readonly Guid DefocusDetected = new Guid(LogCategoryConst.DefocusDetected);

		/// <summary>
		/// '{0:AuthorIdName}' archived '{0:DeviceIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid DeviceArchived = new Guid(LogCategoryConst.DeviceArchived);

		/// <summary>
		/// '{0:AuthorIdName}' changed category of '{0:DeviceIdName}' from '{0:PreviousCategoryIdName}' to '{0:NewCategoryIdName}'.
		/// </summary>
		public static readonly Guid DeviceCategoryChanged = new Guid(LogCategoryConst.DeviceCategoryChanged);

		/// <summary>
		/// DeviceColdRestartedEvent
		/// </summary>
		public static readonly Guid DeviceColdRestarted = new Guid(LogCategoryConst.DeviceColdRestarted);

		/// <summary>
		/// Configuration retrieval from '{0:DeviceIdName}' failed.
		/// </summary>
		public static readonly Guid DeviceConfigurationRetrievalFailed = new Guid(LogCategoryConst.DeviceConfigurationRetrievalFailed);

		/// <summary>
		/// Configuration retrieval from '{0:DeviceIdName}' started.
		/// </summary>
		public static readonly Guid DeviceConfigurationRetrievalStarted = new Guid(LogCategoryConst.DeviceConfigurationRetrievalStarted);

		/// <summary>
		/// Configuration succesfully retrieved from '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid DeviceConfigurationRetrievalSuccessful = new Guid(LogCategoryConst.DeviceConfigurationRetrievalSuccessful);

		/// <summary>
		/// Configuration sending to '{0:DeviceIdName}' failed.
		/// </summary>
		public static readonly Guid DeviceConfigurationSendingFailed = new Guid(LogCategoryConst.DeviceConfigurationSendingFailed);

		/// <summary>
		/// Configuration sending to '{0:DeviceIdName}' started.
		/// </summary>
		public static readonly Guid DeviceConfigurationSendingStarted = new Guid(LogCategoryConst.DeviceConfigurationSendingStarted);

		/// <summary>
		/// Configuration succesfully sent to '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid DeviceConfigurationSendingSuccessful = new Guid(LogCategoryConst.DeviceConfigurationSendingSuccessful);

		/// <summary>
		/// '{0:DeviceIdName}' is connected.
		/// </summary>
		public static readonly Guid DeviceConnected = new Guid(LogCategoryConst.DeviceConnected);

		/// <summary>
		/// '{0:AuthorIdName}' created '{0:DeviceIdName}' under '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid DeviceCreated = new Guid(LogCategoryConst.DeviceCreated);

		/// <summary>
		/// DeviceDisabledEvent
		/// </summary>
		public static readonly Guid DeviceDisabled = new Guid(LogCategoryConst.DeviceDisabled);

		/// <summary>
		/// '{0:DeviceIdName}' is disconnected.
		/// </summary>
		public static readonly Guid DeviceDisconnected = new Guid(LogCategoryConst.DeviceDisconnected);

		/// <summary>
		/// Device '{0:DeviceIdName}' discovered with address '{0:Address}'.
		/// </summary>
		public static readonly Guid DeviceDiscovered = new Guid(LogCategoryConst.DeviceDiscovered);

		/// <summary>
		/// Device discovery on '{0:DeviceIdName}' failed.
		/// </summary>
		public static readonly Guid DeviceDiscoveryFailed = new Guid(LogCategoryConst.DeviceDiscoveryFailed);

		/// <summary>
		/// Device discovery on '{0:DeviceIdName}' started.
		/// </summary>
		public static readonly Guid DeviceDiscoveryStarted = new Guid(LogCategoryConst.DeviceDiscoveryStarted);

		/// <summary>
		/// Device discovery on '{0:DeviceIdName}' successfully finished.
		/// </summary>
		public static readonly Guid DeviceDiscoverySuccessful = new Guid(LogCategoryConst.DeviceDiscoverySuccessful);

		/// <summary>
		/// DeviceEnabledEvent
		/// </summary>
		public static readonly Guid DeviceEnabled = new Guid(LogCategoryConst.DeviceEnabled);

		/// <summary>
		/// '{0:AuthorIdName}' added '{0:DeviceIdName}' to '{0:LinkIdName}'.
		/// </summary>
		public static readonly Guid DeviceLinkCreated = new Guid(LogCategoryConst.DeviceLinkCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted '{0:DeviceIdName}' from '{0:LinkIdName}'.
		/// </summary>
		public static readonly Guid DeviceLinkDeleted = new Guid(LogCategoryConst.DeviceLinkDeleted);

		/// <summary>
		/// DeviceModeActivatedEvent
		/// </summary>
		public static readonly Guid DeviceModeActivated = new Guid(LogCategoryConst.DeviceModeActivated);

		/// <summary>
		/// '{0:AuthorIdName}' changed parent of '{0:DeviceIdName}' from '{0:OldParentIdName}' to '{0:NewParentIdName}'.
		/// </summary>
		public static readonly Guid DeviceParentChanged = new Guid(LogCategoryConst.DeviceParentChanged);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:DeviceIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid DevicePermanentlyDeleted = new Guid(LogCategoryConst.DevicePermanentlyDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed photo for '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid DevicePhotoChanged = new Guid(LogCategoryConst.DevicePhotoChanged);

		/// <summary>
		/// '{0:AuthorIdName}' uploaded photo for '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid DevicePhotoCreated = new Guid(LogCategoryConst.DevicePhotoCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted photo for '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid DevicePhotoDeleted = new Guid(LogCategoryConst.DevicePhotoDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:DeviceIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid DevicePropertyChanged = new Guid(LogCategoryConst.DevicePropertyChanged);

		/// <summary>
		/// '{0:DeviceIdName}' restarted.
		/// </summary>
		public static readonly Guid DeviceRestarted = new Guid(LogCategoryConst.DeviceRestarted);

		/// <summary>
		/// '{0:AuthorIdName}' restored '{0:DeviceIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid DeviceRestored = new Guid(LogCategoryConst.DeviceRestored);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:DeviceIdName}' from '{0:OldValueName}' to '{0:ValueName}'.
		/// </summary>
		public static readonly Guid DeviceSchedulerPropertyChanged = new Guid(LogCategoryConst.DeviceSchedulerPropertyChanged);

		/// <summary>
		/// DeviceShortSupervisionEvent
		/// </summary>
		public static readonly Guid DeviceShortSupervision = new Guid(LogCategoryConst.DeviceShortSupervision);

		/// <summary>
		/// DeviceShortSupervisionRestoredEvent
		/// </summary>
		public static readonly Guid DeviceShortSupervisionRestored = new Guid(LogCategoryConst.DeviceShortSupervisionRestored);

		/// <summary>
		/// DeviceSupervisionEvent
		/// </summary>
		public static readonly Guid DeviceSupervision = new Guid(LogCategoryConst.DeviceSupervision);

		/// <summary>
		/// DeviceSupervisionRestoredEvent
		/// </summary>
		public static readonly Guid DeviceSupervisionRestored = new Guid(LogCategoryConst.DeviceSupervisionRestored);

		/// <summary>
		/// DeviceSupportedCredentialTypeAddedEvent
		/// </summary>
		public static readonly Guid DeviceSupportedCredentialTypeAdded = new Guid(LogCategoryConst.DeviceSupportedCredentialTypeAdded);

		/// <summary>
		/// DeviceSupportedCredentialTypeRemovedEvent
		/// </summary>
		public static readonly Guid DeviceSupportedCredentialTypeRemoved = new Guid(LogCategoryConst.DeviceSupportedCredentialTypeRemoved);

		/// <summary>
		/// '{0:DeviceIdName}' turned off.
		/// </summary>
		public static readonly Guid DeviceTurnedOff = new Guid(LogCategoryConst.DeviceTurnedOff);

		/// <summary>
		/// '{0:DeviceIdName}' turned on.
		/// </summary>
		public static readonly Guid DeviceTurnedOn = new Guid(LogCategoryConst.DeviceTurnedOn);

		/// <summary>
		/// '{0:DeviceIdName}' turned on timed (duration {0:Time}).
		/// </summary>
		public static readonly Guid DeviceTurnedOnTimed = new Guid(LogCategoryConst.DeviceTurnedOnTimed);

		/// <summary>
		/// DiallerRetryAttemptEvent
		/// </summary>
		public static readonly Guid DiallerRetryAttempt = new Guid(LogCategoryConst.DiallerRetryAttempt);

		/// <summary>
		/// '{0:DeviceIdName}' was disarmed automatically.
		/// </summary>
		public static readonly Guid DisarmedAutomatically = new Guid(LogCategoryConst.DisarmedAutomatically);

		/// <summary>
		/// DisarmedByKeySwitchEvent
		/// </summary>
		public static readonly Guid DisarmedByKeySwitch = new Guid(LogCategoryConst.DisarmedByKeySwitch);

		/// <summary>
		/// '{0:DeviceIdName}' was disarmed by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid DisarmedByPerson = new Guid(LogCategoryConst.DisarmedByPerson);

		/// <summary>
		/// DisarmedDuringAlarmEvent
		/// </summary>
		public static readonly Guid DisarmedDuringAlarm = new Guid(LogCategoryConst.DisarmedDuringAlarm);

		/// <summary>
		/// DisarmedEvent
		/// </summary>
		public static readonly Guid Disarmed = new Guid(LogCategoryConst.Disarmed);

		/// <summary>
		/// DisarmedFailureTooEarlyEvent
		/// </summary>
		public static readonly Guid DisarmedFailureTooEarly = new Guid(LogCategoryConst.DisarmedFailureTooEarly);

		/// <summary>
		/// DisarmedPartiallyByPersonEvent
		/// </summary>
		public static readonly Guid DisarmedPartiallyByPerson = new Guid(LogCategoryConst.DisarmedPartiallyByPerson);

		/// <summary>
		/// {0:AuthorIdName}' changed content of document '{0:DocumentIdName}'.
		/// </summary>
		public static readonly Guid DocumentContentChanged = new Guid(LogCategoryConst.DocumentContentChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created document '{0:DocumentIdName}' for '{0:EntityIdName}'
		/// </summary>
		public static readonly Guid DocumentCreated = new Guid(LogCategoryConst.DocumentCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted document '{0:DocumentIdName}' from '{0:EntityIdName}'
		/// </summary>
		public static readonly Guid DocumentDeleted = new Guid(LogCategoryConst.DocumentDeleted);

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of document '{0:DocumentIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid DocumentPropertyChanged = new Guid(LogCategoryConst.DocumentPropertyChanged);

		/// <summary>
		/// '{0:DeviceIdName}' closed.
		/// </summary>
		public static readonly Guid DoorClosed = new Guid(LogCategoryConst.DoorClosed);

		/// <summary>
		/// '{0:DeviceIdName}' remotely closed by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid DoorClosedRemotely = new Guid(LogCategoryConst.DoorClosedRemotely);

		/// <summary>
		/// '{0:DeviceIdName}' locked.
		/// </summary>
		public static readonly Guid DoorLocked = new Guid(LogCategoryConst.DoorLocked);

		/// <summary>
		/// '{0:DeviceIdName}' manual override finished.
		/// </summary>
		public static readonly Guid DoorManualOverrideEnd = new Guid(LogCategoryConst.DoorManualOverrideEnd);

		/// <summary>
		/// '{0:DeviceIdName}' manual override started.
		/// </summary>
		public static readonly Guid DoorManualOverrideStart = new Guid(LogCategoryConst.DoorManualOverrideStart);

		/// <summary>
		/// '{0:DeviceIdName}' opened.
		/// </summary>
		public static readonly Guid DoorOpened = new Guid(LogCategoryConst.DoorOpened);

		/// <summary>
		/// Door '{0:DeviceIdName}' forced open.
		/// </summary>
		public static readonly Guid DoorOpenedForcibly = new Guid(LogCategoryConst.DoorOpenedForcibly);

		/// <summary>
		/// '{0:DeviceIdName}' remotely opened by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid DoorOpenedRemotely = new Guid(LogCategoryConst.DoorOpenedRemotely);

		/// <summary>
		/// Door '{0:DeviceIdName}' open too long.
		/// </summary>
		public static readonly Guid DoorOpenedTooLong = new Guid(LogCategoryConst.DoorOpenedTooLong);

		/// <summary>
		/// '{0:DeviceIdName}' unlocked.
		/// </summary>
		public static readonly Guid DoorUnlocked = new Guid(LogCategoryConst.DoorUnlocked);

		/// <summary>
		/// '{0:DeviceIdName}' unlocked permanently.
		/// </summary>
		public static readonly Guid DoorUnlockedPermanently = new Guid(LogCategoryConst.DoorUnlockedPermanently);

		/// <summary>
		/// '{0:DeviceIdName}' unlocked timed (duration {0:Time}).
		/// </summary>
		public static readonly Guid DoorUnlockedTimed = new Guid(LogCategoryConst.DoorUnlockedTimed);

		/// <summary>
		/// DriverAbortedEvent
		/// </summary>
		public static readonly Guid DriverAborted = new Guid(LogCategoryConst.DriverAborted);

		/// <summary>
		/// '{0:DeviceIdName}' successfully connected to the device.
		/// </summary>
		public static readonly Guid DriverConnectedToDevice = new Guid(LogCategoryConst.DriverConnectedToDevice);

		/// <summary>
		/// '{0:DeviceIdName}' connecting to the device.
		/// </summary>
		public static readonly Guid DriverConnectingToDevice = new Guid(LogCategoryConst.DriverConnectingToDevice);

		/// <summary>
		/// Network connection interrupted to '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid DriverConnectionLost = new Guid(LogCategoryConst.DriverConnectionLost);

		/// <summary>
		/// Network connection with '{0:DeviceIdName}' restored. Number of attempts: '{0:RetriesCount}'
		/// </summary>
		public static readonly Guid DriverConnectionRestored = new Guid(LogCategoryConst.DriverConnectionRestored);

		/// <summary>
		/// {0:AuthorIdName}' created driver '{0:DriverIdName}'.
		/// </summary>
		public static readonly Guid DriverCreated = new Guid(LogCategoryConst.DriverCreated);

		/// <summary>
		/// {0:AuthorIdName}' deleted driver '{0:DriverIdName}'.
		/// </summary>
		public static readonly Guid DriverDeleted = new Guid(LogCategoryConst.DriverDeleted);

		/// <summary>
		/// '{0:DeviceIdName}' initiated.
		/// </summary>
		public static readonly Guid DriverInitiated = new Guid(LogCategoryConst.DriverInitiated);

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of driver '{0:DriverIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid DriverPropertyChanged = new Guid(LogCategoryConst.DriverPropertyChanged);

		/// <summary>
		/// '{0:DeviceIdName}' started.
		/// </summary>
		public static readonly Guid DriverStarted = new Guid(LogCategoryConst.DriverStarted);

		/// <summary>
		/// {0:DeviceIdName}' failed to start.
		/// </summary>
		public static readonly Guid DriverStartFailure = new Guid(LogCategoryConst.DriverStartFailure);

		/// <summary>
		/// DriverStartFailureNotAssignedForAgentEvent
		/// </summary>
		public static readonly Guid DriverStartFailureNotAssignedForAgent = new Guid(LogCategoryConst.DriverStartFailureNotAssignedForAgent);

		/// <summary>
		/// '{0:DeviceIdName}' stopped.
		/// </summary>
		public static readonly Guid DriverStopped = new Guid(LogCategoryConst.DriverStopped);

		/// <summary>
		/// Duplicated address '{0:HardwareAddress}' detected between '{0:Device1IdName}' and '{0:Device2IdName}'.
		/// </summary>
		public static readonly Guid DuplicateAddressDetected = new Guid(LogCategoryConst.DuplicateAddressDetected);

		/// <summary>
		/// EgressTimeoutEvent
		/// </summary>
		public static readonly Guid EgressTimeout = new Guid(LogCategoryConst.EgressTimeout);

		/// <summary>
		/// EngineerResetPerformedEvent
		/// </summary>
		public static readonly Guid EngineerResetPerformed = new Guid(LogCategoryConst.EngineerResetPerformed);

		/// <summary>
		/// EngineerResetRequiredEvent
		/// </summary>
		public static readonly Guid EngineerResetRequired = new Guid(LogCategoryConst.EngineerResetRequired);

		/// <summary>
		/// {0:AuthorIdName}' created entity definition '{0:EntityDefinitionIdName}'.
		/// </summary>
		public static readonly Guid EntityDefinitionCreated = new Guid(LogCategoryConst.EntityDefinitionCreated);

		/// <summary>
		/// {0:AuthorIdName}' deleted entity definition '{0:EntityDefinitionIdName}'.
		/// </summary>
		public static readonly Guid EntityDefinitionDeleted = new Guid(LogCategoryConst.EntityDefinitionDeleted);

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of entity definition '{0:EntityDefinitionIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid EntityDefinitionPropertyChanged = new Guid(LogCategoryConst.EntityDefinitionPropertyChanged);

		/// <summary>
		/// {0:AuthorIdName}' created event '{0:EventIdName}'.
		/// </summary>
		public static readonly Guid Created = new Guid(LogCategoryConst.Created);

		/// <summary>
		/// ExceptionUnhandledEvent
		/// </summary>
		public static readonly Guid ExceptionUnhandled = new Guid(LogCategoryConst.ExceptionUnhandled);

		/// <summary>
		/// Exit button pushed '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid ExitButtonPushed = new Guid(LogCategoryConst.ExitButtonPushed);

		/// <summary>
		/// ExitFailureEvent
		/// </summary>
		public static readonly Guid ExitFailure = new Guid(LogCategoryConst.ExitFailure);

		/// <summary>
		/// FaceDetectedEvent
		/// </summary>
		public static readonly Guid FaceDetected = new Guid(LogCategoryConst.FaceDetected);

		/// <summary>
		/// '{0:DeviceIdName}' factory default settings successfully restored.
		/// </summary>
		public static readonly Guid FactoryDefaultCompleted = new Guid(LogCategoryConst.FactoryDefaultCompleted);

		/// <summary>
		/// '{0:DeviceIdName}' factory default reset initiated.
		/// </summary>
		public static readonly Guid FactoryDefaultInitiated = new Guid(LogCategoryConst.FactoryDefaultInitiated);

		/// <summary>
		/// Failure on '{0:DeviceIdName}'. Description: '{0:Description}'.
		/// </summary>
		public static readonly Guid Failure = new Guid(LogCategoryConst.Failure);

		/// <summary>
		/// FailureRecoveredEncryptionErrorEvent
		/// </summary>
		public static readonly Guid FailureRecoveredEncryptionError = new Guid(LogCategoryConst.FailureRecoveredEncryptionError);

		/// <summary>
		/// Failure on '{0:DeviceIdName}' restored. Description: '{0:Description}'.
		/// </summary>
		public static readonly Guid FailureRecovered = new Guid(LogCategoryConst.FailureRecovered);

		/// <summary>
		/// '{0:DeviceIdName}' alarm counter value: {0:AlarmCounter}.
		/// </summary>
		public static readonly Guid FireAlarmCounterValueChanged = new Guid(LogCategoryConst.FireAlarmCounterValueChanged);

		/// <summary>
		/// Fire alarm on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid FireAlarm = new Guid(LogCategoryConst.FireAlarm);

		/// <summary>
		/// Fire precondition on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid FireAlarmPrecondition = new Guid(LogCategoryConst.FireAlarmPrecondition);

		/// <summary>
		/// Fire precondition on '{0:DeviceIdName}' ended.
		/// </summary>
		public static readonly Guid FireAlarmPreconditionRecovered = new Guid(LogCategoryConst.FireAlarmPreconditionRecovered);

		/// <summary>
		/// Fire alarm restored on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid FireAlarmRecovered = new Guid(LogCategoryConst.FireAlarmRecovered);

		/// <summary>
		/// '{0:DeviceIdName}' fire fighting delay disabled.
		/// </summary>
		public static readonly Guid FireFightingDelayDisabled = new Guid(LogCategoryConst.FireFightingDelayDisabled);

		/// <summary>
		/// '{0:DeviceIdName}' fire fighting delay enabled.
		/// </summary>
		public static readonly Guid FireFightingDelayEnabled = new Guid(LogCategoryConst.FireFightingDelayEnabled);

		/// <summary>
		/// '{0:DeviceIdName}' fire fighting disabled.
		/// </summary>
		public static readonly Guid FireFightingDisabled = new Guid(LogCategoryConst.FireFightingDisabled);

		/// <summary>
		/// FireFightingEnabledEvent
		/// </summary>
		public static readonly Guid FireFightingEnabled = new Guid(LogCategoryConst.FireFightingEnabled);

		/// <summary>
		/// '{0:DeviceIdName}' firmware upgrade successfully completed.
		/// </summary>
		public static readonly Guid FirmwareUpgradeCompleted = new Guid(LogCategoryConst.FirmwareUpgradeCompleted);

		/// <summary>
		/// '{0:DeviceIdName}' firmware upgrade started.
		/// </summary>
		public static readonly Guid FirmwareUpgradeStarted = new Guid(LogCategoryConst.FirmwareUpgradeStarted);

		/// <summary>
		/// '{0:DeviceIdName}' fuse failed.
		/// </summary>
		public static readonly Guid FuseFailure = new Guid(LogCategoryConst.FuseFailure);

		/// <summary>
		/// '{0:DeviceIdName}' restored after a fuse failure.
		/// </summary>
		public static readonly Guid FuseFailureRestored = new Guid(LogCategoryConst.FuseFailureRestored);

		/// <summary>
		/// '{0:AuthorIdName}' assigned '{0:PersonIdName}' to group '{0:GroupIdName}'.
		/// </summary>
		public static readonly Guid GroupAssigned = new Guid(LogCategoryConst.GroupAssigned);

		/// <summary>
		/// '{0:AuthorIdName}' created new group '{0:GroupIdName}'.
		/// </summary>
		public static readonly Guid GroupCreated = new Guid(LogCategoryConst.GroupCreated);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:GroupIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid GroupDataChanged = new Guid(LogCategoryConst.GroupDataChanged);

		/// <summary>
		/// '{0:AuthorIdName}' deleted group '{0:GroupIdName}'.
		/// </summary>
		public static readonly Guid GroupDeleted = new Guid(LogCategoryConst.GroupDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' unassigned '{0:PersonIdName}' from group '{0:GroupIdName}'.
		/// </summary>
		public static readonly Guid GroupUnassigned = new Guid(LogCategoryConst.GroupUnassigned);

		/// <summary>
		/// '{0:AuthorIdName}' created holiday '{0:HolidayIdName}'.
		/// </summary>
		public static readonly Guid HolidayCreated = new Guid(LogCategoryConst.HolidayCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted holiday '{0:HolidayIdName}'.
		/// </summary>
		public static readonly Guid HolidayDeleted = new Guid(LogCategoryConst.HolidayDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:HolidayIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid HolidayPropertyChanged = new Guid(LogCategoryConst.HolidayPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created a holiday set '{0:HolidaySetIdName}'.
		/// </summary>
		public static readonly Guid HolidaySetCreated = new Guid(LogCategoryConst.HolidaySetCreated);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:HolidaySetIdName}'.
		/// </summary>
		public static readonly Guid HolidaySetDeleted = new Guid(LogCategoryConst.HolidaySetDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:HolidaySetIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid HolidaySetPropertyChanged = new Guid(LogCategoryConst.HolidaySetPropertyChanged);

		/// <summary>
		/// HotSpareExceptionEvent
		/// </summary>
		public static readonly Guid HotSpareException = new Guid(LogCategoryConst.HotSpareException);

		/// <summary>
		/// Invalid code attempted too often on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid IdentificationRepeatedInvalid = new Guid(LogCategoryConst.IdentificationRepeatedInvalid);

		/// <summary>
		/// IdentityCardReadEvent
		/// </summary>
		public static readonly Guid IdentityCardRead = new Guid(LogCategoryConst.IdentityCardRead);

		/// <summary>
		/// IncomingCallEvent
		/// </summary>
		public static readonly Guid IncomingCall = new Guid(LogCategoryConst.IncomingCall);

		/// <summary>
		/// IncomingCallFailedEvent
		/// </summary>
		public static readonly Guid IncomingCallFailed = new Guid(LogCategoryConst.IncomingCallFailed);

		/// <summary>
		/// IncomingCallSuccessfulEvent
		/// </summary>
		public static readonly Guid IncomingCallSuccessful = new Guid(LogCategoryConst.IncomingCallSuccessful);

		/// <summary>
		/// IncomingEncryptedCallSuccessfulEvent
		/// </summary>
		public static readonly Guid IncomingEncryptedCallSuccessful = new Guid(LogCategoryConst.IncomingEncryptedCallSuccessful);

		/// <summary>
		/// IncomingUnencryptedCallSuccessfulEvent
		/// </summary>
		public static readonly Guid IncomingUnencryptedCallSuccessful = new Guid(LogCategoryConst.IncomingUnencryptedCallSuccessful);

		/// <summary>
		/// '{0:DeviceIdName}' firmware version is incompatible with the driver. Current firmware in device '{0:DeviceFirmware}'.
		/// </summary>
		public static readonly Guid IncompatibleFirmwareVersion = new Guid(LogCategoryConst.IncompatibleFirmwareVersion);

		/// <summary>
		/// IngressTimeoutEvent
		/// </summary>
		public static readonly Guid IngressTimeout = new Guid(LogCategoryConst.IngressTimeout);

		/// <summary>
		/// InstructionSetCanceledEvent
		/// </summary>
		public static readonly Guid InstructionSetCanceled = new Guid(LogCategoryConst.InstructionSetCanceled);

		/// <summary>
		/// InstructionSetFilledOutEvent
		/// </summary>
		public static readonly Guid InstructionSetFilledOut = new Guid(LogCategoryConst.InstructionSetFilledOut);

		/// <summary>
		/// Failed to run '{0:DeviceIdName}' - insufficient license.
		/// </summary>
		public static readonly Guid InsufficientLicense = new Guid(LogCategoryConst.InsufficientLicense);

		/// <summary>
		/// Internal communication error to '{0:DeviceIdName}'. Description: {0:Description}'.
		/// </summary>
		public static readonly Guid InternalCommunicationError = new Guid(LogCategoryConst.InternalCommunicationError);

		/// <summary>
		/// Internal communication error to '{0:DeviceIdName}' restored. Description: {0:Description}'.
		/// </summary>
		public static readonly Guid InternalCommunicationErrorRestored = new Guid(LogCategoryConst.InternalCommunicationErrorRestored);

		/// <summary>
		/// IPConflictEvent
		/// </summary>
		public static readonly Guid IPConflict = new Guid(LogCategoryConst.IPConflict);

		/// <summary>
		/// '{0:DeviceIdName}' jamming failure.
		/// </summary>
		public static readonly Guid JammingFailure = new Guid(LogCategoryConst.JammingFailure);

		/// <summary>
		/// '{0:DeviceIdName}' restored after a jamming failure.
		/// </summary>
		public static readonly Guid JammingFailureRestored = new Guid(LogCategoryConst.JammingFailureRestored);

		/// <summary>
		/// '{0:DeviceIdName}' key turned to 'Off' position.
		/// </summary>
		public static readonly Guid KeyTurnDisabled = new Guid(LogCategoryConst.KeyTurnDisabled);

		/// <summary>
		/// '{0:DeviceIdName}' key turned to 'On' position.
		/// </summary>
		public static readonly Guid KeyTurnEnabled = new Guid(LogCategoryConst.KeyTurnEnabled);

		/// <summary>
		/// '{0:AuthorIdName}' appended new license file.
		/// </summary>
		public static readonly Guid LicenseAppended = new Guid(LogCategoryConst.LicenseAppended);

		/// <summary>
		/// {0:InstallationIdName} license is corrupted.
		/// </summary>
		public static readonly Guid LicenseCorrupted = new Guid(LogCategoryConst.LicenseCorrupted);

		/// <summary>
		/// License Events
		/// </summary>
		public static readonly Guid Licenses = new Guid(LogCategoryConst.Licenses);

		/// <summary>
		/// LineCrossedEvent
		/// </summary>
		public static readonly Guid LineCrossed = new Guid(LogCategoryConst.LineCrossed);

		/// <summary>
		/// '{0:DeviceIdName}' locked.
		/// </summary>
		public static readonly Guid Locked = new Guid(LogCategoryConst.Locked);

		/// <summary>
		/// '{0:DeviceIdName}' remotely locked by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid LockedRemotely = new Guid(LogCategoryConst.LockedRemotely);

		/// <summary>
		/// '{0:DeviceIdName}' mains failed.
		/// </summary>
		public static readonly Guid MainsFailure = new Guid(LogCategoryConst.MainsFailure);

		/// <summary>
		/// Restore '{0:DeviceIdName}' after a mains failure.
		/// </summary>
		public static readonly Guid MainsFailureRecovered = new Guid(LogCategoryConst.MainsFailureRecovered);

		/// <summary>
		/// MemoryFailureEvent
		/// </summary>
		public static readonly Guid MemoryFailure = new Guid(LogCategoryConst.MemoryFailure);

		/// <summary>
		/// MemoryFailureRecoveredEvent
		/// </summary>
		public static readonly Guid MemoryFailureRecovered = new Guid(LogCategoryConst.MemoryFailureRecovered);

		/// <summary>
		/// MemoryWarningAlmostFullEvent
		/// </summary>
		public static readonly Guid MemoryWarningAlmostFull = new Guid(LogCategoryConst.MemoryWarningAlmostFull);

		/// <summary>
		/// MenuEnteredEvent
		/// </summary>
		public static readonly Guid MenuEntered = new Guid(LogCategoryConst.MenuEntered);

		/// <summary>
		/// MenuExitedEvent
		/// </summary>
		public static readonly Guid MenuExited = new Guid(LogCategoryConst.MenuExited);

		/// <summary>
		/// Configuration failure '{0:DeviceIdName}': Missing device '{0:DeviceIdName} [${0:MissingDeviceTypeIdName}$]' with address: '{0:Address}'. Detail: {0:Description}
		/// </summary>
		public static readonly Guid MissingDeviceInTree = new Guid(LogCategoryConst.MissingDeviceInTree);

		/// <summary>
		/// MotionDetectedEvent
		/// </summary>
		public static readonly Guid MotionDetected = new Guid(LogCategoryConst.MotionDetected);

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' at subaddress '{0:SubAddressIdName}'.
		/// </summary>
		public static readonly Guid MultidetectorAlarm = new Guid(LogCategoryConst.MultidetectorAlarm);

		/// <summary>
		/// '{0:AuthorIdName}' changed owner of credential '{0:CredentialIdName}' to '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid NonAssignedCredentialOwnerChanged = new Guid(LogCategoryConst.NonAssignedCredentialOwnerChanged);

		/// <summary>
		/// {0:AuthorIdName}' changed content of the credential '{0:CredentialIdName}' under '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid NonAssignedTransferableCredentialCodeChanged = new Guid(LogCategoryConst.NonAssignedTransferableCredentialCodeChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created credential '{0:CredentialIdName}' with credential type '{0:CategoryIdName}' into '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid NonAssignedTransferableCredentialCreated = new Guid(LogCategoryConst.NonAssignedTransferableCredentialCreated);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:CredentialIdName}' from '{0:OwnerIdName}'.
		/// </summary>
		public static readonly Guid NonAssignedTransferableCredentialDeleted = new Guid(LogCategoryConst.NonAssignedTransferableCredentialDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:CredentialIdName}' held by '{0:OwnerIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid NonAssignedTransferableCredentialPropertyChanged = new Guid(LogCategoryConst.NonAssignedTransferableCredentialPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' changed content of the credential '{0:CredentialIdName}' held by '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid NonTransferableCredentialCodeChanged = new Guid(LogCategoryConst.NonTransferableCredentialCodeChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created credential '{0:CredentialIdName}' with category '{0:CategoryIdName}' into '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid NonTransferableCredentialCreated = new Guid(LogCategoryConst.NonTransferableCredentialCreated);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:CredentialIdName}' from '{0:HolderIdName}'.
		/// </summary>
		public static readonly Guid NonTransferableCredentialDeleted = new Guid(LogCategoryConst.NonTransferableCredentialDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:CredentialIdName}' held by '{0:HolderIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid NonTransferableCredentialPropertyChanged = new Guid(LogCategoryConst.NonTransferableCredentialPropertyChanged);

		/// <summary>
		/// ObjectRemovalDetectedEvent
		/// </summary>
		public static readonly Guid ObjectRemovalDetected = new Guid(LogCategoryConst.ObjectRemovalDetected);

		/// <summary>
		/// '{0:DeviceIdName}' opened.
		/// </summary>
		public static readonly Guid Opened = new Guid(LogCategoryConst.Opened);

		/// <summary>
		/// OutgoingCallEvent
		/// </summary>
		public static readonly Guid OutgoingCall = new Guid(LogCategoryConst.OutgoingCall);

		/// <summary>
		/// OutgoingCallFailedEvent
		/// </summary>
		public static readonly Guid OutgoingCallFailed = new Guid(LogCategoryConst.OutgoingCallFailed);

		/// <summary>
		/// OutgoingCallSuccessfulEvent
		/// </summary>
		public static readonly Guid OutgoingCallSuccessful = new Guid(LogCategoryConst.OutgoingCallSuccessful);

		/// <summary>
		/// OutgoingEncryptedCallSuccessfulEvent
		/// </summary>
		public static readonly Guid OutgoingEncryptedCallSuccessful = new Guid(LogCategoryConst.OutgoingEncryptedCallSuccessful);

		/// <summary>
		/// OutgoingUnencryptedCallSuccessfulEvent
		/// </summary>
		public static readonly Guid OutgoingUnencryptedCallSuccessful = new Guid(LogCategoryConst.OutgoingUnencryptedCallSuccessful);

		/// <summary>
		/// OverloadedEvent
		/// </summary>
		public static readonly Guid Overloaded = new Guid(LogCategoryConst.Overloaded);

		/// <summary>
		/// OverloadedRecoveredEvent
		/// </summary>
		public static readonly Guid OverloadedRecovered = new Guid(LogCategoryConst.OverloadedRecovered);

		/// <summary>
		/// {0:AuthorIdName}' installed package '{0:PackageIdName}' of '{0:Version}' version.
		/// </summary>
		public static readonly Guid PackageInstalled = new Guid(LogCategoryConst.PackageInstalled);

		/// <summary>
		/// '{0:AuthorIdName}' uninstalled package '{0:PackageIdName}' of '{0:Version}' version.
		/// </summary>
		public static readonly Guid PackageUninstalled = new Guid(LogCategoryConst.PackageUninstalled);

		/// <summary>
		/// '{0:AuthorIdName}' archived panel '{0:PanelIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid PanelArchived = new Guid(LogCategoryConst.PanelArchived);

		/// <summary>
		/// {0:AuthorIdName}' created panel '{0:PanelIdName}'.
		/// </summary>
		public static readonly Guid PanelCreated = new Guid(LogCategoryConst.PanelCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted panel '{0:PanelIdName}'.
		/// </summary>
		public static readonly Guid PanelDeleted = new Guid(LogCategoryConst.PanelDeleted);

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of panel '{0:PanelIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid PanelPropertyChanged = new Guid(LogCategoryConst.PanelPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' restored panel '{0:PanelIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid PanelRestored = new Guid(LogCategoryConst.PanelRestored);

		/// <summary>
		/// '{0:AuthorIdName}' changed calendar '{0:CalendarIdName}' of permission of person '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PermissionCalendarChanged = new Guid(LogCategoryConst.PermissionCalendarChanged);

		/// <summary>
		/// '{0:AuthorIdName}' denied '{0:PermissionTypeName}' for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PermissionDenied = new Guid(LogCategoryConst.PermissionDenied);

		/// <summary>
		/// '{0:AuthorIdName}' denied '{0:PermissionTypeName}' without inheritance for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PermissionDeniedNonInherited = new Guid(LogCategoryConst.PermissionDeniedNonInherited);

		/// <summary>
		/// '{0:AuthorIdName}' granted '{0:PermissionTypeName}' for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PermissionGranted = new Guid(LogCategoryConst.PermissionGranted);

		/// <summary>
		/// '{0:AuthorIdName}' granted '{0:PermissionTypeName}' without inheritance for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PermissionGrantedNotInherited = new Guid(LogCategoryConst.PermissionGrantedNotInherited);

		/// <summary>
		/// {0:AuthorIdName}' revoked '{0:PermissionTypeName}' for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PermissionRevoked = new Guid(LogCategoryConst.PermissionRevoked);

		/// <summary>
		/// '{0:AuthorIdName}' loaded personal data for '{0:PersonIdName}' using identification document reader '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid PersonalDataLoadedUsingReader = new Guid(LogCategoryConst.PersonalDataLoadedUsingReader);

		/// <summary>
		/// '{0:AuthorIdName}' archived '{0:PersonIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid PersonArchived = new Guid(LogCategoryConst.PersonArchived);

		/// <summary>
		/// '{0:AuthorIdName}' changed category of '{0:PersonIdName}' from '{0:PreviousCategoryIdName}' to '{0:NewCategoryIdName}'.
		/// </summary>
		public static readonly Guid PersonCategoryChanged = new Guid(LogCategoryConst.PersonCategoryChanged);

		/// <summary>
		/// '{0:AuthorIdName}' created '{0:PersonIdName}' under '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid PersonCreated = new Guid(LogCategoryConst.PersonCreated);

		/// <summary>
		/// '{0:AuthorIdName}' changed parent of '{0:PersonIdName}' from '{0:OldParentIdName}' to '{0:NewParentIdName}'.
		/// </summary>
		public static readonly Guid PersonParentChanged = new Guid(LogCategoryConst.PersonParentChanged);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:PersonIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid PersonPermanentlyDeleted = new Guid(LogCategoryConst.PersonPermanentlyDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed photo for '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PersonPhotoChanged = new Guid(LogCategoryConst.PersonPhotoChanged);

		/// <summary>
		/// '{0:AuthorIdName}' uploaded photo for '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PersonPhotoCreated = new Guid(LogCategoryConst.PersonPhotoCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted photo for '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid PersonPhotoDeleted = new Guid(LogCategoryConst.PersonPhotoDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:PersonIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid PersonPropertyChanged = new Guid(LogCategoryConst.PersonPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' restored '{0:PersonIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid PersonRestored = new Guid(LogCategoryConst.PersonRestored);

		/// <summary>
		/// '{0:DeviceIdName}' phone communicator failure.
		/// </summary>
		public static readonly Guid PhoneCommunicatorFailure = new Guid(LogCategoryConst.PhoneCommunicatorFailure);

		/// <summary>
		/// '{0:DeviceIdName}' restored after a phone communicator failure.
		/// </summary>
		public static readonly Guid PhoneCommunicatorFailureRestored = new Guid(LogCategoryConst.PhoneCommunicatorFailureRestored);

		/// <summary>
		/// Preset '{0:PresetId}' on '{0:DeviceIdName}' was activated.
		/// </summary>
		public static readonly Guid PresetActivated = new Guid(LogCategoryConst.PresetActivated);

		/// <summary>
		/// '{0:DeviceIdName}' printer failure.
		/// </summary>
		public static readonly Guid PrinterFailure = new Guid(LogCategoryConst.PrinterFailure);

		/// <summary>
		/// '{0:DeviceIdName}' restored after a printer failure.
		/// </summary>
		public static readonly Guid PrinterFailureRestored = new Guid(LogCategoryConst.PrinterFailureRestored);

		/// <summary>
		/// '{0:AuthorIdName}' created profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfileCreated = new Guid(LogCategoryConst.ProfileCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfileDeleted = new Guid(LogCategoryConst.ProfileDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' assigned '{0:DeviceIdName}' to profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfileDeviceAssigned = new Guid(LogCategoryConst.ProfileDeviceAssigned);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of DeviceData '{0:DeviceDataId}' of profile '{0:ProfileIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid ProfileDeviceDataChanged = new Guid(LogCategoryConst.ProfileDeviceDataChanged);

		/// <summary>
		/// '{0:AuthorIdName}' assigned DeviceType '{0:DeviceTypeIdName}' to profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfileDeviceTypeAssigned = new Guid(LogCategoryConst.ProfileDeviceTypeAssigned);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of DeviceType '{0:DeviceTypeIdName}' of profile '{0:ProfileIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid ProfileDeviceTypeDataChanged = new Guid(LogCategoryConst.ProfileDeviceTypeDataChanged);

		/// <summary>
		/// '{0:AuthorIdName}' unassigned DeviceType '{0:DeviceTypeIdName}' from profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfileDeviceTypeUnassigned = new Guid(LogCategoryConst.ProfileDeviceTypeUnassigned);

		/// <summary>
		/// '{0:AuthorIdName}' unassigned '{0:DeviceIdName}' from profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfileDeviceUnassigned = new Guid(LogCategoryConst.ProfileDeviceUnassigned);

		/// <summary>
		/// '{0:AuthorIdName}' attached person '{0:PersonIdName}' to profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfilePersonAttached = new Guid(LogCategoryConst.ProfilePersonAttached);

		/// <summary>
		/// '{0:AuthorIdName}' dettached person '{0:PersonIdName}' from profile '{0:ProfileIdName}'.
		/// </summary>
		public static readonly Guid ProfilePersonDettached = new Guid(LogCategoryConst.ProfilePersonDettached);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of profile '{0:ProfileIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid ProfilePropertyChanged = new Guid(LogCategoryConst.ProfilePropertyChanged);

		/// <summary>
		/// RearmedAfterAlarmEvent
		/// </summary>
		public static readonly Guid RearmedAfterAlarm = new Guid(LogCategoryConst.RearmedAfterAlarm);

		/// <summary>
		/// '{0:AuthorIdName}' added checkout device '{0:DeviceIdName}' to reception '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionCheckoutDeviceAdded = new Guid(LogCategoryConst.ReceptionCheckoutDeviceAdded);

		/// <summary>
		/// '{0:AuthorIdName}' removed checkout device '{0:DeviceIdName}' from reception '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionCheckoutDeviceRemoved = new Guid(LogCategoryConst.ReceptionCheckoutDeviceRemoved);

		/// <summary>
		/// {0:AuthorIdName}' created reception '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionCreated = new Guid(LogCategoryConst.ReceptionCreated);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:ReceptionIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid ReceptionDataChanged = new Guid(LogCategoryConst.ReceptionDataChanged);

		/// <summary>
		/// '{0:AuthorIdName}' deleted reception '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionDeleted = new Guid(LogCategoryConst.ReceptionDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' disabled required field '{0:Name}' of '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionRequiredFieldDisabled = new Guid(LogCategoryConst.ReceptionRequiredFieldDisabled);

		/// <summary>
		/// '{0:AuthorIdName}' enabled required field '{0:Name}' of '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionRequiredFieldEnabled = new Guid(LogCategoryConst.ReceptionRequiredFieldEnabled);

		/// <summary>
		/// '{0:AuthorIdName}' added supported credential type '{0:CredentialTypeIdName}' to reception '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionSupportedCredentialTypeAdded = new Guid(LogCategoryConst.ReceptionSupportedCredentialTypeAdded);

		/// <summary>
		/// '{0:AuthorIdName}' removed supported credential type '{0:CredentialTypeIdName}' from reception '{0:ReceptionIdName}'.
		/// </summary>
		public static readonly Guid ReceptionSupportedCredentialTypeRemoved = new Guid(LogCategoryConst.ReceptionSupportedCredentialTypeRemoved);

		/// <summary>
		/// RedialEvent
		/// </summary>
		public static readonly Guid Redial = new Guid(LogCategoryConst.Redial);

		/// <summary>
		/// '{0:AuthorIdName}' archived '{0:RegionIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid RegionArchived = new Guid(LogCategoryConst.RegionArchived);

		/// <summary>
		/// '{0:AuthorIdName}' created '{0:RegionIdName}' under '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid RegionCreated = new Guid(LogCategoryConst.RegionCreated);

		/// <summary>
		/// '{0:AuthorIdName}' added '{0:DeviceIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid RegionDeviceLinkCreated = new Guid(LogCategoryConst.RegionDeviceLinkCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted '{0:DeviceIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid RegionDeviceLinkDeleted = new Guid(LogCategoryConst.RegionDeviceLinkDeleted);

		/// <summary>
		/// RegionEntranceDetectedEvent
		/// </summary>
		public static readonly Guid RegionEntranceDetected = new Guid(LogCategoryConst.RegionEntranceDetected);

		/// <summary>
		/// RegionExitingDetectedEvent
		/// </summary>
		public static readonly Guid RegionExitingDetected = new Guid(LogCategoryConst.RegionExitingDetected);

		/// <summary>
		/// '{0:AuthorIdName}' changed parent of '{0:RegionIdName}' from '{0:OldParentIdName}' to '{0:NewParentIdName}'.
		/// </summary>
		public static readonly Guid RegionParentChanged = new Guid(LogCategoryConst.RegionParentChanged);

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:RegionIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid RegionPermanentlyDeleted = new Guid(LogCategoryConst.RegionPermanentlyDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed photo for '{0:RegionIdName}'.
		/// </summary>
		public static readonly Guid RegionPhotoChanged = new Guid(LogCategoryConst.RegionPhotoChanged);

		/// <summary>
		/// '{0:AuthorIdName}' uploaded photo for '{0:RegionIdName}'.
		/// </summary>
		public static readonly Guid RegionPhotoCreated = new Guid(LogCategoryConst.RegionPhotoCreated);

		/// <summary>
		/// '{0:AuthorIdName}' deleted photo for '{0:RegionIdName}'.
		/// </summary>
		public static readonly Guid RegionPhotoDeleted = new Guid(LogCategoryConst.RegionPhotoDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:RegionIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid RegionPropertyChanged = new Guid(LogCategoryConst.RegionPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' restored '{0:RegionIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public static readonly Guid RegionRestored = new Guid(LogCategoryConst.RegionRestored);

		/// <summary>
		/// '{0:DeviceIdName}' reset setting.
		/// </summary>
		public static readonly Guid Reset = new Guid(LogCategoryConst.Reset);

		/// <summary>
		/// '{0:DeviceIdName}' restored after a ring failure.
		/// </summary>
		public static readonly Guid RingFailureRecoveredShunt = new Guid(LogCategoryConst.RingFailureRecoveredShunt);

		/// <summary>
		/// '{0:DeviceIdName}' ring failure.
		/// </summary>
		public static readonly Guid RingFailureShunt = new Guid(LogCategoryConst.RingFailureShunt);

		/// <summary>
		/// '{0:AuthorIdName}' assigned '{0:PersonIdName}' to the '{0:RoleIdName}' role.
		/// </summary>
		public static readonly Guid RoleAssigned = new Guid(LogCategoryConst.RoleAssigned);

		/// <summary>
		/// '{0:AuthorIdName}' unassigned '{0:PersonIdName}' from the '{0:RoleIdName}' role.
		/// </summary>
		public static readonly Guid RoleUnassigned = new Guid(LogCategoryConst.RoleUnassigned);

		/// <summary>
		/// '{0:AuthorIdName}' activated Safe Connect Gateway service.
		/// </summary>
		public static readonly Guid SafeConnectGatewayActivated = new Guid(LogCategoryConst.SafeConnectGatewayActivated);

		/// <summary>
		/// '{0:AuthorIdName}' deactivated Safe Connect Gateway service.
		/// </summary>
		public static readonly Guid SafeConnectGatewayDeactivated = new Guid(LogCategoryConst.SafeConnectGatewayDeactivated);

		/// <summary>
		/// '{0:AuthorIdName}' restarted Safe Connect Gateway service.
		/// </summary>
		public static readonly Guid SafeConnectGatewayRestarted = new Guid(LogCategoryConst.SafeConnectGatewayRestarted);

		/// <summary>
		/// '{0:AuthorIdName}' started Safe Connect Gateway service.
		/// </summary>
		public static readonly Guid SafeConnectGatewayStarted = new Guid(LogCategoryConst.SafeConnectGatewayStarted);

		/// <summary>
		/// '{0:AuthorIdName}' stopped Safe Connect Gateway service.
		/// </summary>
		public static readonly Guid SafeConnectGatewayStopped = new Guid(LogCategoryConst.SafeConnectGatewayStopped);

		/// <summary>
		/// SceneChangeSuddenEvent
		/// </summary>
		public static readonly Guid SceneChangeSudden = new Guid(LogCategoryConst.SceneChangeSudden);

		/// <summary>
		/// ServiceModeEnteredEvent
		/// </summary>
		public static readonly Guid ServiceModeEntered = new Guid(LogCategoryConst.ServiceModeEntered);

		/// <summary>
		/// ServiceModeExitedEvent
		/// </summary>
		public static readonly Guid ServiceModeExited = new Guid(LogCategoryConst.ServiceModeExited);

		/// <summary>
		/// ServiceOnEvent
		/// </summary>
		public static readonly Guid ServiceOn = new Guid(LogCategoryConst.ServiceOn);

		/// <summary>
		/// ServiceOutEvent
		/// </summary>
		public static readonly Guid ServiceOut = new Guid(LogCategoryConst.ServiceOut);

		/// <summary>
		/// '{0:AuthorIdName}' created setting for '{0:EntityIdName}'.
		/// </summary>
		public static readonly Guid SettingCreated = new Guid(LogCategoryConst.SettingCreated);

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of Setting of '{0:EntityIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid SettingDataChanged = new Guid(LogCategoryConst.SettingDataChanged);

		/// <summary>
		/// '{0:AuthorIdName}' deleted setting for '{0:EntityIdName}'.
		/// </summary>
		public static readonly Guid SettingDeleted = new Guid(LogCategoryConst.SettingDeleted);

		/// <summary>
		/// SmartRoutineActivatedEvent
		/// </summary>
		public static readonly Guid SmartRoutineActivated = new Guid(LogCategoryConst.SmartRoutineActivated);

		/// <summary>
		/// SmartRoutineCreatedEvent
		/// </summary>
		public static readonly Guid SmartRoutineCreated = new Guid(LogCategoryConst.SmartRoutineCreated);

		/// <summary>
		/// SmartRoutineDeactivatedEvent
		/// </summary>
		public static readonly Guid SmartRoutineDeactivated = new Guid(LogCategoryConst.SmartRoutineDeactivated);

		/// <summary>
		/// SmartRoutineDeletedEvent
		/// </summary>
		public static readonly Guid SmartRoutineDeleted = new Guid(LogCategoryConst.SmartRoutineDeleted);

		/// <summary>
		/// SmartRoutineExecutedEvent
		/// </summary>
		public static readonly Guid SmartRoutineExecuted = new Guid(LogCategoryConst.SmartRoutineExecuted);

		/// <summary>
		/// SmartRoutineUpdatedEvent
		/// </summary>
		public static readonly Guid SmartRoutineUpdated = new Guid(LogCategoryConst.SmartRoutineUpdated);

		/// <summary>
		/// SMSConnectionTestAutomaticCallEvent
		/// </summary>
		public static readonly Guid SMSConnectionTestAutomaticCall = new Guid(LogCategoryConst.SMSConnectionTestAutomaticCall);

		/// <summary>
		/// SoakTestFinishedEvent
		/// </summary>
		public static readonly Guid SoakTestFinished = new Guid(LogCategoryConst.SoakTestFinished);

		/// <summary>
		/// SoakTestStartedEvent
		/// </summary>
		public static readonly Guid SoakTestStarted = new Guid(LogCategoryConst.SoakTestStarted);

		/// <summary>
		/// '{0:DeviceIdName}' sounder activated.
		/// </summary>
		public static readonly Guid SounderActivated = new Guid(LogCategoryConst.SounderActivated);

		/// <summary>
		/// SounderActivationDelayDisabledEvent
		/// </summary>
		public static readonly Guid SounderActivationDelayDisabled = new Guid(LogCategoryConst.SounderActivationDelayDisabled);

		/// <summary>
		/// SounderActivationDelayEnabledEvent
		/// </summary>
		public static readonly Guid SounderActivationDelayEnabled = new Guid(LogCategoryConst.SounderActivationDelayEnabled);

		/// <summary>
		/// '{0:DeviceIdName}' sounder deactivated.
		/// </summary>
		public static readonly Guid SounderDeactivated = new Guid(LogCategoryConst.SounderDeactivated);

		/// <summary>
		/// '{0:DeviceIdName}' sounder disabled.
		/// </summary>
		public static readonly Guid SounderDisabled = new Guid(LogCategoryConst.SounderDisabled);

		/// <summary>
		/// '{0:DeviceIdName}' sounder enabled.
		/// </summary>
		public static readonly Guid SounderEnabled = new Guid(LogCategoryConst.SounderEnabled);

		/// <summary>
		/// '{0:DeviceIdName}' sounder failure.
		/// </summary>
		public static readonly Guid SounderFailure = new Guid(LogCategoryConst.SounderFailure);

		/// <summary>
		/// '{0:DeviceIdName}' restored after a sounder failure.
		/// </summary>
		public static readonly Guid SounderFailureRecovered = new Guid(LogCategoryConst.SounderFailureRecovered);

		/// <summary>
		/// SounderMutedEvent
		/// </summary>
		public static readonly Guid SounderMuted = new Guid(LogCategoryConst.SounderMuted);

		/// <summary>
		/// SoundIntensityChangeSuddenEvent
		/// </summary>
		public static readonly Guid SoundIntensityChangeSudden = new Guid(LogCategoryConst.SoundIntensityChangeSudden);

		/// <summary>
		/// SynchronizationFailedEvent
		/// </summary>
		public static readonly Guid SynchronizationFailed = new Guid(LogCategoryConst.SynchronizationFailed);

		/// <summary>
		/// SynchronizationFinishedEvent
		/// </summary>
		public static readonly Guid SynchronizationFinished = new Guid(LogCategoryConst.SynchronizationFinished);

		/// <summary>
		/// SynchronizationStartedEvent
		/// </summary>
		public static readonly Guid SynchronizationStarted = new Guid(LogCategoryConst.SynchronizationStarted);

		/// <summary>
		/// Tamper on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid Tamper = new Guid(LogCategoryConst.Tamper);

		/// <summary>
		/// Tamper completed on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid TamperRecovered = new Guid(LogCategoryConst.TamperRecovered);

		/// <summary>
		/// TemplateCreatedEvent
		/// </summary>
		public static readonly Guid TemplateCreated = new Guid(LogCategoryConst.TemplateCreated);

		/// <summary>
		/// TemplateDeletedEvent
		/// </summary>
		public static readonly Guid TemplateDeleted = new Guid(LogCategoryConst.TemplateDeleted);

		/// <summary>
		/// TemplateDisabledEvent
		/// </summary>
		public static readonly Guid TemplateDisabled = new Guid(LogCategoryConst.TemplateDisabled);

		/// <summary>
		/// TemplateEnabledEvent
		/// </summary>
		public static readonly Guid TemplateEnabled = new Guid(LogCategoryConst.TemplateEnabled);

		/// <summary>
		/// TemplatePrintedEvent
		/// </summary>
		public static readonly Guid TemplatePrinted = new Guid(LogCategoryConst.TemplatePrinted);

		/// <summary>
		/// TemplateUpdatedEvent
		/// </summary>
		public static readonly Guid TemplateUpdated = new Guid(LogCategoryConst.TemplateUpdated);

		/// <summary>
		/// TestAlarmFinishedSoakEvent
		/// </summary>
		public static readonly Guid TestAlarmFinishedSoak = new Guid(LogCategoryConst.TestAlarmFinishedSoak);

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' in test mode.
		/// </summary>
		public static readonly Guid TestAlarmInTest = new Guid(LogCategoryConst.TestAlarmInTest);

		/// <summary>
		/// TestAlarmStartedSoakEvent
		/// </summary>
		public static readonly Guid TestAlarmStartedSoak = new Guid(LogCategoryConst.TestAlarmStartedSoak);

		/// <summary>
		/// TestAutomaticEvent
		/// </summary>
		public static readonly Guid TestAutomatic = new Guid(LogCategoryConst.TestAutomatic);

		/// <summary>
		/// TestFailureBatteryEvent
		/// </summary>
		public static readonly Guid TestFailureBattery = new Guid(LogCategoryConst.TestFailureBattery);

		/// <summary>
		/// Failure on '{0:DeviceIdName}' in test mode.
		/// </summary>
		public static readonly Guid TestFailureInTest = new Guid(LogCategoryConst.TestFailureInTest);

		/// <summary>
		/// TestFailureRecoveredBatteryEvent
		/// </summary>
		public static readonly Guid TestFailureRecoveredBattery = new Guid(LogCategoryConst.TestFailureRecoveredBattery);

		/// <summary>
		/// Testing of '{0:DeviceIdName}' was finished.
		/// </summary>
		public static readonly Guid TestFinished = new Guid(LogCategoryConst.TestFinished);

		/// <summary>
		/// Recovery of normal state on '{0:DeviceIdName}' in test mode.
		/// </summary>
		public static readonly Guid TestNormalInTest = new Guid(LogCategoryConst.TestNormalInTest);

		/// <summary>
		/// '{0:DeviceIdName}' test mode started.
		/// </summary>
		public static readonly Guid TestStarted = new Guid(LogCategoryConst.TestStarted);

		/// <summary>
		/// TicketAssignedToPersonEvent
		/// </summary>
		public static readonly Guid TicketAssignedToPerson = new Guid(LogCategoryConst.TicketAssignedToPerson);

		/// <summary>
		/// TicketClosedEvent 
		/// </summary>
		public static readonly Guid TicketClosed = new Guid(LogCategoryConst.TicketClosed);

		/// <summary>
		/// TicketCreatedEvent
		/// </summary>
		public static readonly Guid TicketCreated = new Guid(LogCategoryConst.TicketCreated);

		/// <summary>
		/// TicketImageAddedEvent
		/// </summary>
		public static readonly Guid TicketImageAdded = new Guid(LogCategoryConst.TicketImageAdded);

		/// <summary>
		/// TicketNoteAddedEvent
		/// </summary>
		public static readonly Guid TicketNoteAdded = new Guid(LogCategoryConst.TicketNoteAdded);

		/// <summary>
		/// TicketResponsiblePersonSetEvent 
		/// </summary>
		public static readonly Guid TicketResponsiblePersonSet = new Guid(LogCategoryConst.TicketResponsiblePersonSet);

		/// <summary>
		/// TicketStateChangedEvent
		/// </summary>
		public static readonly Guid TicketStateChanged = new Guid(LogCategoryConst.TicketStateChanged);

		/// <summary>
		/// Time set to '{0:DeviceIdName}'. Offset with real time was {0:TimeDiff} minutes.
		/// </summary>
		public static readonly Guid TimeDifferenceWarningTooBig = new Guid(LogCategoryConst.TimeDifferenceWarningTooBig);

		/// <summary>
		/// '{0:DeviceIdName}' switched to T2 time.
		/// </summary>
		public static readonly Guid TimeSwitchedToT2 = new Guid(LogCategoryConst.TimeSwitchedToT2);

		/// <summary>
		/// '{0:AuthorIdName}' changed property Time Zone of Setting of '{0:EntityIdName}' from '[${0:OldValue}$]' to '[${0:Value}$]'.
		/// </summary>
		public static readonly Guid TimeZoneSettingDataChanged = new Guid(LogCategoryConst.TimeZoneSettingDataChanged);

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of trace log info from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public static readonly Guid TraceLogInfoPropertyChanged = new Guid(LogCategoryConst.TraceLogInfoPropertyChanged);

		/// <summary>
		/// '{0:AuthorIdName}' deleted trace logs.
		/// </summary>
		public static readonly Guid TraceLogsDeleted = new Guid(LogCategoryConst.TraceLogsDeleted);

		/// <summary>
		/// '{0:AuthorIdName}' disabled diagnostic trace logging.
		/// </summary>
		public static readonly Guid TraceLogsDisabled = new Guid(LogCategoryConst.TraceLogsDisabled);

		/// <summary>
		/// '{0:AuthorIdName}' downloaded trace logs.
		/// </summary>
		public static readonly Guid TraceLogsDownloaded = new Guid(LogCategoryConst.TraceLogsDownloaded);

		/// <summary>
		/// '{0:AuthorIdName}' enabled diagnostic trace logging.
		/// </summary>
		public static readonly Guid TraceLogsEnabled = new Guid(LogCategoryConst.TraceLogsEnabled);

		/// <summary>
		/// UnattendedBaggageDetectedEvent
		/// </summary>
		public static readonly Guid UnattendedBaggageDetected = new Guid(LogCategoryConst.UnattendedBaggageDetected);

		/// <summary>
		/// Technical event on device '{0:DeviceIdName}'. More details: '{0:Description}'
		/// </summary>
		public static readonly Guid Unknown = new Guid(LogCategoryConst.Unknown);

		/// <summary>
		/// '{0:DeviceIdName}' unlocked.
		/// </summary>
		public static readonly Guid Unlocked = new Guid(LogCategoryConst.Unlocked);

		/// <summary>
		/// '{0:DeviceIdName}' remotely unlocked by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid UnlockedRemotely = new Guid(LogCategoryConst.UnlockedRemotely);

		/// <summary>
		/// '{0:DeviceIdName}' is unable to recognize the data that has been read. Data: '{0:Data}'
		/// </summary>
		public static readonly Guid UnrecognizedDataRead = new Guid(LogCategoryConst.UnrecognizedDataRead);

		/// <summary>
		/// Untrusted assembly: '{0:AssemblyName}' loaded from location: '{0:AssemblyLocation}', reason: '{0:Reason}'
		/// </summary>
		public static readonly Guid UntrustedAssemblyLoaded = new Guid(LogCategoryConst.UntrustedAssemblyLoaded);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' was cancelled by '{0:PersonIdName}'.
		/// </summary>
		public static readonly Guid UploadCancelled = new Guid(LogCategoryConst.UploadCancelled);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to communication failure (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailedCommunicationFailure = new Guid(LogCategoryConst.UploadFailedCommunicationFailure);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to busy device (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailedDeviceBusy = new Guid(LogCategoryConst.UploadFailedDeviceBusy);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to full memory (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailedDeviceMemoryFull = new Guid(LogCategoryConst.UploadFailedDeviceMemoryFull);

		/// <summary>
		/// UploadFailedDuplicatedCredential
		/// </summary>
		public static readonly Guid UploadFailedDuplicatedCredential = new Guid(LogCategoryConst.UploadFailedDuplicatedCredential);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to insufficient license on device (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailedInsufficientLicenseOnDevice = new Guid(LogCategoryConst.UploadFailedInsufficientLicenseOnDevice);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to internal failure on device (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailedInternalDeviceFailure = new Guid(LogCategoryConst.UploadFailedInternalDeviceFailure);

		/// <summary>
		/// UploadFailedInvalidCredentialEvent
		/// </summary>
		public static readonly Guid UploadFailedInvalidCredential = new Guid(LogCategoryConst.UploadFailedInvalidCredential);

		/// <summary>
		/// UploadFailedOtherReasonEvent
		/// </summary>
		public static readonly Guid UploadFailedOtherReason = new Guid(LogCategoryConst.UploadFailedOtherReason);

		/// <summary>
		/// UploadFailedOutOfRangeEvent
		/// </summary>
		public static readonly Guid UploadFailedOutOfRange = new Guid(LogCategoryConst.UploadFailedOutOfRange);

		/// <summary>
		/// UploadFailedPersonOutOfRange
		/// </summary>
		public static readonly Guid UploadFailedPersonOutOfRange = new Guid(LogCategoryConst.UploadFailedPersonOutOfRange);

		/// <summary>
		/// UploadFailedReservedPositonEvent
		/// </summary>
		public static readonly Guid UploadFailedReservedPositon = new Guid(LogCategoryConst.UploadFailedReservedPositon);

		/// <summary>
		/// UploadFailedTimeoutEvent
		/// </summary>
		public static readonly Guid UploadFailedTimeout = new Guid(LogCategoryConst.UploadFailedTimeout);

		/// <summary>
		/// UploadFailedTooComplexEvent
		/// </summary>
		public static readonly Guid UploadFailedTooComplex = new Guid(LogCategoryConst.UploadFailedTooComplex);

		/// <summary>
		/// UploadFailedValidationEvent
		/// </summary>
		public static readonly Guid UploadFailedValidation = new Guid(LogCategoryConst.UploadFailedValidation);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to wrong person configuration (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailedWrongPersonConfiguration = new Guid(LogCategoryConst.UploadFailedWrongPersonConfiguration);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload failed in '{0:DeviceIdName}' (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadFailure = new Guid(LogCategoryConst.UploadFailure);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' started.
		/// </summary>
		public static readonly Guid UploadStarted = new Guid(LogCategoryConst.UploadStarted);

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' successfully completed (duration'{0:Time}').
		/// </summary>
		public static readonly Guid UploadSuccessfullyCompleted = new Guid(LogCategoryConst.UploadSuccessfullyCompleted);

		/// <summary>
		/// '{0:PersonIdName}' signed in through SafeConnect from agent '{0:AgentIdName}', IP address '{0:IpAddress}' ('{0:IpAddressDomainName}'), using Portal Account '{0:SafeConnectPortalUserIdName}', SafeConnect Device '{0:SafeConnectDeviceIdName}'.
		/// </summary>
		public static readonly Guid UserSignedInBySafeConnect = new Guid(LogCategoryConst.UserSignedInBySafeConnect);

		/// <summary>
		/// '{0:PersonIdName}' signed in from agent '{0:AgentIdName}', IP address '{0:IpAddress}' ('{0:IpAddressDomainName}').
		/// </summary>
		public static readonly Guid UserSignedIn = new Guid(LogCategoryConst.UserSignedIn);

		/// <summary>
		/// '{0:PersonIdName}' signed off from agent '{0:AgentIdName}'.
		/// </summary>
		public static readonly Guid UserSignedOff = new Guid(LogCategoryConst.UserSignedOff);

		/// <summary>
		/// VehicleRegistrationPlateRecordedEvent
		/// </summary>
		public static readonly Guid VehicleRegistrationPlateRecorded = new Guid(LogCategoryConst.VehicleRegistrationPlateRecorded);

		/// <summary>
		/// VideosignalLostEvent
		/// </summary>
		public static readonly Guid VideosignalLost = new Guid(LogCategoryConst.VideosignalLost);

		/// <summary>
		/// VideosignalLostRestoredEvent
		/// </summary>
		public static readonly Guid VideosignalLostRestored = new Guid(LogCategoryConst.VideosignalLostRestored);

		/// <summary>
		/// VisitCreatedEvent
		/// </summary>
		public static readonly Guid VisitCreated = new Guid(LogCategoryConst.VisitCreated);

		/// <summary>
		/// VisitDataChangedEvent
		/// </summary>
		public static readonly Guid VisitDataChanged = new Guid(LogCategoryConst.VisitDataChanged);

		/// <summary>
		/// VisitEvents
		/// </summary>
		public static readonly Guid Visits = new Guid(LogCategoryConst.Visits);

		/// <summary>
		/// Walk test failed on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid WalkTestFailed = new Guid(LogCategoryConst.WalkTestFailed);

		/// <summary>
		/// Walk test finished on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid WalkTestFinished = new Guid(LogCategoryConst.WalkTestFinished);

		/// <summary>
		/// Walk test started on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid WalkTestStarted = new Guid(LogCategoryConst.WalkTestStarted);

		/// <summary>
		/// Walk test succeeded on '{0:DeviceIdName}'.
		/// </summary>
		public static readonly Guid WalkTestSucceeded = new Guid(LogCategoryConst.WalkTestSucceeded);

		/// <summary>
		/// WarningBeforeAutomaticArmingEvent
		/// </summary>
		public static readonly Guid WarningBeforeAutomaticArming = new Guid(LogCategoryConst.WarningBeforeAutomaticArming);

		/// <summary>
		/// '{0:DeviceIdName}' warning.
		/// </summary>
		public static readonly Guid Warning = new Guid(LogCategoryConst.Warning);

		/// <summary>
		/// '{0:DeviceIdName}' warning ended.
		/// </summary>
		public static readonly Guid WarningRecovered = new Guid(LogCategoryConst.WarningRecovered);

		/// <summary>
		/// ZoneInActivatedStateEvent
		/// </summary>
		public static readonly Guid ZoneInActivatedState = new Guid(LogCategoryConst.ZoneInActivatedState);

		/// <summary>
		/// ZoneInNormalStateEvent
		/// </summary>
		public static readonly Guid ZoneInNormalState = new Guid(LogCategoryConst.ZoneInNormalState);

    }
		
    /// <summary>
	/// LogCategory Constants
	/// </summary>
	internal static class LogCategoryConst
	{
		/// <summary>
		/// IncompatibleFirmwareVersionWithExpectedVersionEvent
		/// </summary>
		public const string IncompatibleFirmwareVersionWithExpectedVersion = "55CFA425-F594-45C6-9F24-2C0EC2727348";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Active time restriction
		/// </summary>
		public const string AccessDeniedActiveTimeRestriction = "997511D7-5AF3-4C13-9CA6-94C7F29E60E1";

		/// <summary>
		/// AccessDeniedAntiPassbackViolationEvent
		/// </summary>
		public const string AccessDeniedAntiPassbackViolation = "C62AB4B5-73AE-43FA-86F3-6B7A9CE8ECF3";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Area is armed
		/// </summary>
		public const string AccessDeniedAreaIsArmed = "1D6AD0E5-CE39-456A-87C3-742C0E4C7B37";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Card is archived
		/// </summary>
		public const string AccessDeniedCardIsArchived = "CE900DCE-B6C3-46D2-A908-3F657E6CD092";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Card is disabled
		/// </summary>
		public const string AccessDeniedCardIsDisabled = "FE91798B-7E72-45D4-A06E-20F0CDF9D12C";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Card is lost
		/// </summary>
		public const string AccessDeniedCardIsLost = "AF836DB5-D3FB-4850-9683-9F77E8B73204";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Configuration error
		/// </summary>
		public const string AccessDeniedConfigurationError = "E87D80C9-2C74-4B9D-8733-B6F40EAF208F";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Credential unknown at this device
		/// </summary>
		public const string AccessDeniedCredentialUnknownAtThisDevice = "3955A033-2AA1-4EA9-9796-9A1F8908D4E1";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Door is manually overridden
		/// </summary>
		public const string AccessDeniedDoorIsManuallyOverridden = "F2BE1DC6-60EE-4EFA-AF27-DDE5A2F6E200";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Door not allowed
		/// </summary>
		public const string AccessDeniedDoorNotAllowed = "CBC4597D-192C-4475-AE13-43E1B0F69C62";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Floor not allowed
		/// </summary>
		public const string AccessDeniedFloorNotAllowed = "6A6BB67F-D366-4D35-8500-610C33BD0B97";

		/// <summary>
		/// AccessDeniedGlobalAntiPassbackViolationEvent
		/// </summary>
		public const string AccessDeniedGlobalAntiPassbackViolation = "49A54B5B-E1F3-4391-B2F7-0749249808A7";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Hard Anti-passback violation
		/// </summary>
		public const string AccessDeniedHardAntiPassbackViolation = "18CC87F5-C1D6-47D5-8A20-7269D63DFD0B";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential
		/// </summary>
		public const string AccessDeniedIncompleteCredential = "A6D894E8-866D-47EC-BABC-89434031450F";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential - Missing card
		/// </summary>
		public const string AccessDeniedIncompleteCredentialMissingCard = "73B153B3-BEC8-458D-84A0-287A2478284B";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential - Missing PIN
		/// </summary>
		public const string AccessDeniedIncompleteCredentialMissingPIN = "1A0E6205-7727-433C-B5A3-50804B4A5C7C";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Incomplete credential - PIN entered before card
		/// </summary>
		public const string AccessDeniedIncompleteCredentialPINEnteredBeforeCard = "EA90E113-BB8B-4A3A-AF5E-57F2525E15F3";

		/// <summary>
		/// Access denied for unknown credential at '{0:DeviceIdName}' using credential '{0:Code}' on reader '{0:ReaderIdName}'. Reason: Invalid card format
		/// </summary>
		public const string AccessDeniedInvalidCardFormat = "BAE18B01-EDA5-4C1C-A2C6-B182751B7846";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Invalid issue state
		/// </summary>
		public const string AccessDeniedInvalidIssueState = "1ADA06B6-177C-4D01-87E1-0A97DEBD427F";

		/// <summary>
		/// Access denied to unknown credential at '{0:DeviceIdName}' on keypad '{0:ReaderIdName}'. Reason: Invalid PIN code
		/// </summary>
		public const string AccessDeniedInvalidPINCode = "9D861193-11F9-4C79-9DA2-D199BEB20067";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Invalid site code
		/// </summary>
		public const string AccessDeniedInvalidSiteCode = "6B97980F-9D57-456D-B5C9-3DAD8017B3D6";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Lockout timer active
		/// </summary>
		public const string AccessDeniedLockoutTimerActive = "D5F3AE2E-A123-480E-934A-19CFA17EE06A";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: No alarm control
		/// </summary>
		public const string AccessDeniedNoAlarmControl = "EBA177FE-1FB6-4A11-93CD-A595BDF46DD6";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: No area control
		/// </summary>
		public const string AccessDeniedNoAreaControl = "C3CD594D-69FC-45E1-967F-1197C7530840";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Not enough high security users
		/// </summary>
		public const string AccessDeniedNotEnoughHighSecurityUsers = "9F0017D7-F996-4C8F-8492-8D34216C0487";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Other
		/// </summary>
		public const string AccessDeniedOther = "8205C811-81CC-4703-ABC0-9B6487DA3DC8";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Outside of validity period
		/// </summary>
		public const string AccessDeniedOutsideOfValidityPeriod = "8099C8C3-D62D-4BE5-B896-BFABF5733C4E";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Reader is disabled
		/// </summary>
		public const string AccessDeniedReaderIsDisabled = "54EDC336-519A-4235-B687-02ACE4499F78";

		/// <summary>
		/// Access denied to '{0:PersonIdName}' at '{0:DeviceIdName}' using credential '{0:CredentialIdName}' on reader '{0:ReaderIdName}'. Reason: Timed Anti-passback violation
		/// </summary>
		public const string AccessDeniedTimedAntiPassbackViolation = "A8EBA01E-9052-4311-BFCB-36FDC86F62A4";

		/// <summary>
		/// Access denied for unknown credential "{0:CardCode} ({0:CredentialTypeIdName})" at '{0:DeviceIdName}'.
		/// </summary>
		public const string AccessDeniedUnknownCredential = "A500D010-4546-4392-9037-89748E9D3A09";

		/// <summary>
		/// Access denied for unknown credential at '{0:DeviceIdName}' on keypad '{0:ReaderIdName}'. Reason: Unknown PIN code
		/// </summary>
		public const string AccessDeniedUnknownPINCode = "95FC385C-21DA-4A57-B2CA-72A39A2742F3";

		/// <summary>
		/// AccessGrantedAttendanceEvent
		/// </summary>
		public const string AccessGrantedAttendance = "A3A25D8F-0289-4822-BD55-F5EC9428D65A";

		/// <summary>
		/// Access granted to '{0:PersonIdName}' at '{0:DeviceIdName}' using combined credential at reader '{0:ReaderIdName}'.
		/// </summary>
		public const string AccessGrantedCombinedCredential = "3B4EDD11-AC62-4639-8543-41D538AFB963";

		/// <summary>
		/// Access granted to '{0:PersonIdName}' at '{0:DeviceIdName}' using '{0:CredentialTypeIdName}' '{0:CredentialIdName}' at reader '{0:ReaderIdName}'.
		/// </summary>
		public const string AccessGranted = "16877F05-E96F-48D9-A85A-488BF67D7D18";

		/// <summary>
		/// Access granted with soft anti-passback violation to '{0:PersonIdName}' at '{0:DeviceIdName}' using '{0:CredentialTypeIdName}' '{0:CredentialIdName}' at reader '{0:ReaderIdName}'.
		/// </summary>
		public const string AccessGrantedSoftAntipassbackViolation = "EF52353F-196A-49AC-88C4-C0D5E9CADCE1";

		/// <summary>
		/// Access granted for unknown credential "{0:CardCode} ({0:CredentialTypeIdName})" at '{0:DeviceIdName}'.
		/// </summary>
		public const string AccessGrantedUnknownCredential = "308C4FCA-4790-42F8-AEA1-5CEB8E8E5FC7";

		/// <summary>
		/// Access granted with entry made to '{0:PersonIdName}' at '{0:DeviceIdName}' using '{0:CredentialTypeIdName}' '{0:CredentialIdName}' at reader '{0:ReaderIdName}'.
		/// </summary>
		public const string AccessGrantedWithEntryMade = "9B84EEA4-8BBF-43A3-A12D-D83FCF0365FA";

		/// <summary>
		/// AccessInExitTimeEvent
		/// </summary>
		public const string AccessInExitTime = "7A7BAC23-3505-4FE0-843C-D7D501126E37";

		/// <summary>
		/// '{0:AuthorIdName}' created new access level '{0:AccessLevelIdName}'.
		/// </summary>
		public const string AccessLevelCreated = "B2ACF4AE-9150-4D95-95AE-D86ABBAF127D";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted access level '{0:AccessLevelIdName}'.
		/// </summary>
		public const string AccessLevelDeleted = "9FD6D00D-2310-4399-8082-7C508C47D662";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of access level '{0:AccessLevelIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string AccessLevelPropertyChanged = "81947BC8-934B-45D0-8F17-C77E33BFB7EF";

		/// <summary>
		/// '{0:AuthorIdName}' assigned access point '{0:DeviceIdName}' to the access level '{0:AccessLevelIdName}'
		/// </summary>
		public const string AccessPointAssigned = "C3BC06CF-78E8-4CA9-9683-48A864198ABF";

		/// <summary>
		/// '{0:AuthorIdName}' unassigned access point '{0:DeviceIdName}' from the access level '{0:AccessLevelIdName}'
		/// </summary>
		public const string AccessPointUnassigned = "C252E48E-E9A7-438D-B785-C0DFC953F7B7";

		/// <summary>
		/// AgentAssignedEvent
		/// </summary>
		public const string AgentAssigned = "7EBFE8A2-05C3-4FBD-9DB8-4EED93D78136";

		/// <summary>
		/// Agent '{0:AgentIdName}' connected from '{0:IpAddress}'.
		/// </summary>
		public const string AgentConnected = "6A5FC40D-3CF8-4C0F-90F8-8819E2E81741";

		/// <summary>
		/// {0:AuthorIdName}' created agent '{0:AgentIdName}'.
		/// </summary>
		public const string AgentCreated = "7735EB8A-084F-4191-8870-6321B7DA2C92";

		/// <summary>
		/// '{0:AuthorIdName}' deleted agent '{0:AgentIdName}'.
		/// </summary>
		public const string AgentDeleted = "A5BED946-6223-4F1B-8E9F-52F6247669DA";

		/// <summary>
		/// Agent '{0:AgentIdName}' disconnected from '{0:IpAddress}'.
		/// </summary>
		public const string AgentDisconnected = "51CB3969-11B1-4AED-9BF3-4FD94CDB5220";

		/// <summary>
		/// Agent '{0:AgentIdName}' assigned to group '{0:ParentIdName}' by  '{0:AuthorIdName}'.
		/// </summary>
		public const string AgentGroupAssigned = "5AD9B2EF-6CB3-49CB-99D8-C02F34EA1587";

		/// <summary>
		/// Agent '{0:AgentIdName}' unassigned from group '{0:ParentIdName}' by  '{0:AuthorIdName}'.
		/// </summary>
		public const string AgentGroupUnassigned = "AD2B2D72-D995-4597-90C9-9DFD6DBA584E";

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of agent '{0:AgentIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string AgentPropertyChanged = "F21F3488-F981-4BD5-8222-7A221CDE97E4";

		/// <summary>
		/// AlarmAntimaskingEvent
		/// </summary>
		public const string AlarmAntimasking = "42ED5AB8-7825-438D-8E9C-9EA3916E2398";

		/// <summary>
		/// AlarmCancelledByKeyswitchEvent
		/// </summary>
		public const string AlarmCancelledByKeyswitch = "F2C5D527-5F99-4D0A-9A0F-EEEDC670854A";

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' was cancelled by '{0:PersonIdName}'.
		/// </summary>
		public const string AlarmCancelledByPerson = "F9BF7802-DE12-4ED7-9D30-12ED240FAD80";

		/// <summary>
		/// Duress alarm on '{0:DeviceIdName}' by '{0:PersonIdName}'.
		/// </summary>
		public const string AlarmDuressByPerson = "C8438E2C-8E20-4D0B-AE5F-39860F709E1B";

		/// <summary>
		/// Duress alarm from '{0:DeviceIdName}'.
		/// </summary>
		public const string AlarmDuress = "963B24AD-9E20-475D-B8E6-BD7858AF1282";

		/// <summary>
		/// AlarmDuressResetByUserEvent
		/// </summary>
		public const string AlarmDuressResetByUser = "BB575B45-61DC-4E04-9D91-460110DD8A0C";

		/// <summary>
		/// Alarm on '{0:DeviceIdName}'.
		/// </summary>
		public const string Alarm = "5E34A1E4-665C-48FE-A862-06FFE4BCBAD7";

		/// <summary>
		/// Flooding alarm on '{0:DeviceIdName}'.
		/// </summary>
		public const string AlarmFlooding = "26F4B023-1E56-4F77-99BA-FDB892B0B2E9";

		/// <summary>
		/// Flooding alarm on '{0:DeviceIdName}' restored.
		/// </summary>
		public const string AlarmFloodingRestored = "8A63AA53-CE48-453F-9BF7-E285BE2C718F";

		/// <summary>
		/// AlarmInExitTimeEvent
		/// </summary>
		public const string AlarmInExitTime = "45EBB004-5EA2-4253-8DC6-C5D9B9D54594";

		/// <summary>
		/// AlarmLocalEvent
		/// </summary>
		public const string AlarmLocal = "03EBC7CA-4E24-4A35-8A3C-91CF139532BC";

		/// <summary>
		/// AlarmLocalRecoveredEvent
		/// </summary>
		public const string AlarmLocalRecovered = "97220260-6FC4-4C7D-98FE-DF424CF74F4F";

		/// <summary>
		/// AlarmManagementEvent
		/// </summary>
		public const string AlarmManagement = "3C6F9835-4C17-4435-936A-AADBC52920F5";

		/// <summary>
		/// Panic alarm on '{0:DeviceIdName}'.
		/// </summary>
		public const string AlarmPanic = "17FBDECF-2F5B-4D47-9EB7-1F457DC80B68";

		/// <summary>
		/// Panic alarm on '{0:DeviceIdName}' recovered.
		/// </summary>
		public const string AlarmPanicRecovered = "34DBF031-C631-4514-A318-9A8206C9E315";

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' restored.
		/// </summary>
		public const string AlarmRecovered = "E5F9CEC3-3E7C-401D-AC04-3E988F32D24E";

		/// <summary>
		/// AlarmRecoveredInExitTimeEvent
		/// </summary>
		public const string AlarmRecoveredInExitTime = "544A3928-889C-40E3-9E59-DCCE34330143";

		/// <summary>
		/// AlarmSoonAfterArmEvent
		/// </summary>
		public const string AlarmSoonAfterArm = "6B1AAAF1-826C-48EC-8C45-F4A3052D9F42";

		/// <summary>
		/// AlarmTicketEvent
		/// </summary>
		public const string AlarmTicket = "10C09808-CAEC-4AE3-89CC-ABDC86A120C1";

		/// <summary>
		/// '{0:DeviceIdName}' was armed automatically.
		/// </summary>
		public const string ArmedAutomatically = "B6C4FCA6-63C6-49A2-A4B3-E106CCA9CF85";

		/// <summary>
		/// ArmedAutomaticPostponedByUserEvent
		/// </summary>
		public const string ArmedAutomaticPostponedByUser = "E422831A-EC9C-46F5-A10E-E50D2BCB6C52";

		/// <summary>
		/// ArmedByKeySwitchEvent
		/// </summary>
		public const string ArmedByKeySwitch = "112D883B-D770-4C6A-ACE3-C17AD093C661";

		/// <summary>
		/// '{0:DeviceIdName}' was armed by '{0:PersonIdName}'.
		/// </summary>
		public const string ArmedByPerson = "BBBD8F1B-D1C2-486F-840E-4FB0B1B6444B";

		/// <summary>
		/// ArmedEvent
		/// </summary>
		public const string Armed = "CC667889-49E4-4738-A31B-9393F49AE809";

		/// <summary>
		/// '{0:DeviceIdName}' was forcibly armed by '{0:PersonIdName}'.
		/// </summary>
		public const string ArmedForciblyByPerson = "91D74E6F-20F4-4CE7-AF3A-96FF89017016";

		/// <summary>
		/// ArmFailureTooLateEvent
		/// </summary>
		public const string ArmFailureTooLate = "3C1000DA-2733-421C-B83C-7668B8F86463";

		/// <summary>
		/// ArmedInExitTimeEvent
		/// </summary>
		public const string ArmedInExitTime = "895E29EF-7866-419B-BB11-DAD44DBB6125";

		/// <summary>
		/// ArmedPartiallyByPersonEvent
		/// </summary>
		public const string ArmedPartiallyByPerson = "23770F96-1C93-4635-9591-A694090D0B3F";

		/// <summary>
		/// ArmFailureEvent
		/// </summary>
		public const string ArmFailure = "0645BFB0-CCCA-4A66-9FF7-710683CE0142";

		/// <summary>
		/// '{0:AuthorIdName}' changed owner of credential '{0:CredentialIdName}' held by '{0:HolderIdName}' to '{0:OwnerIdName}'.
		/// </summary>
		public const string AssignedCredentialOwnerChanged = "24C686C1-DBCB-4A78-8002-6DA997689CBD";

		/// <summary>
		/// '{0:AuthorIdName}' changed content of the credential '{0:CredentialIdName}' held by '{0:HolderIdName}' under '{0:OwnerIdName}'.
		/// </summary>
		public const string AssignedTransferableCredentialCodeChanged = "12D2B546-7E54-4746-BEE2-22499DB49FAB";

		/// <summary>
		/// '{0:AuthorIdName}' created credential '{0:CredentialIdName}' with credential type '{0:CategoryIdName}' for '{0:HolderIdName}' into '{0:OwnerIdName}'.
		/// </summary>
		public const string AssignedTransferableCredentialCreated = "FA519999-47CC-457C-9304-DD7B9C8D0845";

		/// <summary>
		/// '{0:AuthorIdName}' deleted '{0:CredentialIdName}' held by '{0:HolderIdName}' into '{0:OwnerIdName}' .
		/// </summary>
		public const string AssignedTransferableCredentialDeleted = "97C0AAFC-0DDB-4566-A822-C3DEC22915C8";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:CredentialIdName}' held by '{0:HolderIdName}' into '{0:OwnerIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string AssignedTransferableCredentialPropertyChanged = "D4389180-673B-4EEB-AD26-D22CCFFCD4F7";

		/// <summary>
		/// AudioDecibelSteepDropEvent
		/// </summary>
		public const string AudioDecibelSteepDrop = "FEB73D1A-C878-4CC6-9C22-DF38578B183B";

		/// <summary>
		/// AudioSignalLostEvent
		/// </summary>
		public const string AudioSignalLost = "1FD1AE43-2291-47B6-93D6-5B8D2DD2203B";

		/// <summary>
		/// Authentication for '{0:PersonIdName}' through SafeConnect failed from IP address '{0:IpAddress}' ('{0:IpAddressDomainName}'), using Portal Account '{0:SafeConnectPortalUserIdName}', SafeConnect Device '{0:SafeConnectDeviceIdName}'.
		/// </summary>
		public const string AuthenticationBySafeConnectFailed = "AFE8F01C-3756-45C7-B40A-041FAEAEF8B2";

		/// <summary>
		/// Authentication for '{0:PersonIdName}' failed from IP address '{0:IpAddress}' ('{0:IpAddressDomainName}').
		/// </summary>
		public const string AuthenticationFailed = "4BD740C3-4378-4D47-B3D1-0FDE27A36701";

		/// <summary>
		/// Authentication for '{0:PersonIdName}' through SafeConnect failed from IP address '{0:IpAddress}' ('{0:IpAddressDomainName}'), using Portal Account '{0:SafeConnectPortalUserIdName}', SafeConnect Device '{0:SafeConnectDeviceIdName}', because current person is not merged with used Portal Account.
		/// </summary>
		public const string AuthenticationFailedPortalUserDoesNotMatch = "5B3B6B3E-983E-4BF6-9743-2A1A2CF644C7";

		/// <summary>
		/// {0:AuthorIdName}' changed acount of person '{0:PersonIdName}' from '{0:OldAccount}' to '{0:Account}'.
		/// </summary>
		public const string AuthenticationLoginAccountChanged = "5C39F24B-85C3-404B-82C3-FC14E19B8C3C";

		/// <summary>
		/// {0:AuthorIdName}' created user account '{0:Account}' for '{0:PersonIdName}'.
		/// </summary>
		public const string AuthenticationLoginCreated = "3D159DEA-CC6E-40AB-9D57-87C3C99A82BC";

		/// <summary>
		/// {0:AuthorIdName}' deleted user account '{0:Account}' from '{0:PersonIdName}'.
		/// </summary>
		public const string AuthenticationLoginDeleted = "3A1CC078-87DE-419A-BA1F-8E71FE0B1E05";

		/// <summary>
		/// {0:AuthorIdName}' changed password of '{0:PersonIdName}'.
		/// </summary>
		public const string AuthenticationLoginPasswordChanged = "C7C0CEEB-6107-448E-970D-797DDFD31FF2";

		/// <summary>
		/// Authentication to '{0:DeviceIdName}' failed.
		/// </summary>
		public const string AuthenticationToDeviceFailed = "FF529B27-9DE1-490E-9FC2-19729A444E42";

		/// <summary>
		/// Authentication to '{0:DeviceIdName}' failed. Reason: Invalid password
		/// </summary>
		public const string AuthenticationToDeviceFailedInvalidPassword = "348B9A95-0FA4-43BB-88B8-C13DB607D920";

		/// <summary>
		/// Authentication to '{0:DeviceIdName}' failed. Reason: Invalid security certificate.
		/// </summary>
		public const string AuthenticationToDeviceFailedInvalidSecurityCertificate = "8D19BB20-F5FB-402B-8399-690BBE8E8669";

		/// <summary>
		/// Authorization level was changed on '{0:DeviceIdName}'.
		/// </summary>
		public const string AuthorizationLevelChanged = "903C94D1-BC4D-4FE4-B6AA-708A91972657";

		/// <summary>
		/// '{0:DeviceIdName}' - low battery.
		/// </summary>
		public const string BatteryLowWarning = "C43D1A39-8D6F-42B2-A405-5762208E54C6";

		/// <summary>
		/// '{0:DeviceIdName}' - low battery restored.
		/// </summary>
		public const string BatteryLowWarningRecovered = "688E866E-A762-4BB0-A8E2-D75D31B81C36";

		/// <summary>
		/// BatteryTestFinishedEvent
		/// </summary>
		public const string BatteryTestFinished = "80792210-0828-42B4-BA79-9FDE92FC021A";

		/// <summary>
		/// BatteryTestStartedEvent
		/// </summary>
		public const string BatteryTestStarted = "11766FC8-6A94-453A-86E0-7F164B26AC43";

		/// <summary>
		/// {0:AuthorIdName}' deleted blob '{0:BlobIdName}' for device '{0:DeviceIdName}'.
		/// </summary>
		public const string BlobDeleted = "A5CCF9F8-1C46-43D9-9678-A7759C8988B6";

		/// <summary>
		/// {0:AuthorIdName}' deleted blob history '{0:BlobIdName}' for device '{0:DeviceIdName}'.
		/// </summary>
		public const string BlobHistoryDeleted = "9558C02C-8C45-4E5B-B6EB-4E3E95659ADC";

		/// <summary>
		/// {0:AuthorIdName}' saved blob '{0:BlobIdName}' for device '{0:DeviceIdName}'.
		/// </summary>
		public const string BlobSaved = "A4148CCA-8FBA-4607-872A-F5EF1C477857";

		/// <summary>
		/// '{0:DeviceIdName}' buzzer disabled.
		/// </summary>
		public const string BuzzerDisabled = "94B08107-492E-4B6C-9E86-B6A335631854";

		/// <summary>
		/// BuzzerEnableEvent
		/// </summary>
		public const string BuzzerEnable = "07C84795-C8EA-4C77-8F9D-795A62225717";

		/// <summary>
		/// BuzzerFailureEvent
		/// </summary>
		public const string BuzzerFailure = "DC6442C2-F162-454F-9525-9F519C1C8624";

		/// <summary>
		/// BuzzerFailureRecoveredEvent
		/// </summary>
		public const string BuzzerFailureRecovered = "127B99F5-23E4-43AC-8964-F701F6F6301B";

		/// <summary>
		/// '{0:DeviceIdName}' buzzer muted.
		/// </summary>
		public const string BuzzerMuted = "7A78D9D3-E87E-4DD2-9E9E-6A4771D4D564";

		/// <summary>
		/// '{0:DeviceIdName}' was bypassed automatically.
		/// </summary>
		public const string BypassAutomatically = "01070FF5-95CA-4D0E-99C6-9F5297414A97";

		/// <summary>
		/// '{0:DeviceIdName}' bypass was cancelled automatically.
		/// </summary>
		public const string BypassCancelAutomatically = "3E93EEB9-77BB-40F1-8260-682D4058828F";

		/// <summary>
		/// '{0:DeviceIdName}' bypass was cancelled by user '{0:PersonIdName}'.
		/// </summary>
		public const string BypassCancel = "B4F76715-7E1A-4986-B884-2247C8472E5A";

		/// <summary>
		/// '{0:DeviceIdName}' was bypassed by user '{0:PersonIdName}'.
		/// </summary>
		public const string Bypass = "B188248F-A76C-4920-8293-6A206B3A13D0";

		/// <summary>
		/// '{0:DeviceIdName}' was bypassed timed (duration {0:Time}).
		/// </summary>
		public const string BypassTimed = "CE2D6AEC-4755-420C-AC24-EFBBCC08F365";

		/// <summary>
		/// '{0:AuthorIdName}' created calendar '{0:CalendarIdName}'
		/// </summary>
		public const string CalendarCreated = "5C44CDE3-CBD4-4D4A-89FC-69B002F3CA67";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of Calendar'{0:CalendarIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string CalendarDataChanged = "8EA6B585-622A-4085-BE78-DD43CF1EDCE7";

		/// <summary>
		/// '{0:AuthorIdName}' deleted calendar '{0:CalendarIdName}'.
		/// </summary>
		public const string CalendarDeleted = "C938D7DF-9EFF-4AE3-839C-FBAC709FA3BB";

		/// <summary>
		/// '{0:AuthorIdName}' changed time restriction for '{0:CalendarIdName}'.
		/// </summary>
		public const string CalendarTimeFrameChanged = "876A3EE5-2A0D-46A9-AE56-BB2E87F68846";

		/// <summary>
		/// CallEvent
		/// </summary>
		public const string Call = "B0FE1950-363D-4F67-85AC-5D628833B835";

		/// <summary>
		/// CallRedirectedEvent
		/// </summary>
		public const string CallRedirected = "2B05E7E8-7F6A-4FBE-965D-9B35876B91E5";

		/// <summary>
		/// '{0:AuthorIdName}' has read card '{0:CardVendorIdName} {0:CardTypeIdName}' on '{0:DeviceIdName}'. Card length: '{0:CodeLength}'. Card code: '{0:CodeHexa}'
		/// </summary>
		public const string CardEnrolledFromReader = "E0944CD1-5660-48FA-9F00-60466A929103";

		/// <summary>
		/// '{0:AuthorIdName}' has read card '{0:CardTypeIdName}' on '{0:DeviceIdName}'. Card length: '{0:CodeLength}'. Card code: '{0:Code}'
		/// </summary>
		public const string CardRead = "63AEBC18-26EF-4EEF-B499-53019297B22E";

		/// <summary>
		/// '{0:DeviceIdName}' closed.
		/// </summary>
		public const string Closed = "FB7660C1-080F-4C15-AB87-A0F86E4C6B46";

		/// <summary>
		/// CodeEnteredEvent
		/// </summary>
		public const string CodeEntered = "3C1CC30A-0F92-4AC9-A764-D1E5522FF9F6";

		/// <summary>
		/// Command '[$msg{0:CommandIdName}$]' from '{0:IssuerPersonIdName}' was delivered to '{0:EntityIdName}'.
		/// </summary>
		public const string CommandDelivered = "A2531D40-563C-4BF1-918A-F259E5304BF3";

		/// <summary>
		/// Command '[$msg{0:CommandIdName}$]' issued by '{0:IssuerPersonIdName}' on '{0:DeviceIdName}' failed. Reason: {0:Description}
		/// </summary>
		public const string CommandFailed = "2AB1583E-2C69-47B5-9EDA-2ADB8569577F";

		/// <summary>
		/// '{0:IssuerPersonIdName}' sent command '[$msg{0:CommandIdName}$]' to '{0:EntityIdName}'.
		/// </summary>
		public const string CommandIssued = "7991BEBC-082E-468F-86E2-EB003C119021";

		/// <summary>
		/// Communication with '{0:DeviceIdName}' lost.
		/// </summary>
		public const string CommunicationLost = "FF840116-375E-42FA-AB22-6CB854373E3D";

		/// <summary>
		/// 'Communication with '{0:DeviceIdName}' restored.
		/// </summary>
		public const string CommunicationRestored = "A5924F10-CE26-4F4E-9586-C4220F3EC17E";

		/// <summary>
		/// CommunicationTestEvent
		/// </summary>
		public const string CommunicationTest = "F334A542-7D2E-46ED-8ED5-13DEB7798B84";

		/// <summary>
		/// ConfigurationChangedEvent
		/// </summary>
		public const string ConfigurationChanged = "8FDFAE5E-0942-43C5-8B1E-082D7C7E4886";

		/// <summary>
		/// ConfigurationChangedTimeEvent
		/// </summary>
		public const string ConfigurationChangedTime = "64DB4011-3E71-4BCA-918E-B4B647BED303";

		/// <summary>
		/// Technician entered into the local configuration of '{0:DeviceIdName}'.
		/// </summary>
		public const string ConfigurationEnteredByTechnician = "DF6198FD-9E95-4BDF-B9D3-2A17381B43EF";

		/// <summary>
		/// {0:PropertyName}' property value on device '{0:DeviceIdName}' has invalid format.
		/// </summary>
		public const string ConfigurationErrorInvalidPropertyValue = "94A44C12-597B-4E27-B22A-FFD9BBE57249";

		/// <summary>
		/// {0:PropertyName}' property value on device '{0:DeviceIdName}' is out of allowed range ('{0:MinValue}' - '{0:MaxValue}').
		/// </summary>
		public const string ConfigurationErrorInvalidPropertyValueOutOfRange = "CD62BF1F-8BAD-413E-958E-C84136E713F9";

		/// <summary>
		/// {0:PropertyName}' property value length on device '{0:DeviceIdName}' is out of allowed range ('{0:MinValue}' - '{0:MaxValue}').
		/// </summary>
		public const string ConfigurationErrorInvalidPropertyValueOutOfRangeLength = "B6E8B506-4FC4-45AF-94DC-ED69F21F2EF2";

		/// <summary>
		/// ConfigurationErrorInvalidTreeEvent
		/// </summary>
		public const string ConfigurationErrorInvalidTree = "7BB12077-8FD4-49F1-936D-B995E2AA4688";

		/// <summary>
		/// Technician exited the configuration of '{0:DeviceIdName}'.
		/// </summary>
		public const string ConfigurationExitedByTechnician = "98D22E70-6DE9-4E58-AD1D-E4106548F170";

		/// <summary>
		/// Connection of '{0:DeviceIdName}' to '{0:DeviceOutIdName}' established.
		/// </summary>
		public const string ConnectionEstablished = "868671A8-F8BD-4D9E-926B-1D7A17128570";

		/// <summary>
		/// Connection between '{0:DeviceIdName}' and '{0:DeviceOutIdName}' interrupted.
		/// </summary>
		public const string ConnectionInterrupted = "85BB81D2-C3D4-4A70-B203-438AE4469408";

		/// <summary>
		/// CredentialCodeChangedEvent
		/// </summary>
		public const string CredentialCodeChanged = "B62D7DB2-18A0-4D50-BB5F-928BC70CA728";

		/// <summary>
		/// CredentialCreatedEvent
		/// </summary>
		public const string CredentialCreated = "80CA6F23-F087-4A78-A212-19F3A136DD23";

		/// <summary>
		/// CredentialDeletedEvent
		/// </summary>
		public const string CredentialDeleted = "CB271518-7378-407F-BE63-B01A9AC860D2";

		/// <summary>
		/// '{0:AuthorIdName}' deactivated '{0:CredentialIdName}' from '{0:HolderIdName}'.
		/// </summary>
		public const string CredentialHolderRemoved = "F37A4E51-4A02-400C-A2EF-67954F209AD8";

		/// <summary>
		/// '{0:AuthorIdName}' activated '{0:CredentialIdName}' to '{0:HolderIdName}'.
		/// </summary>
		public const string CredentialHolderSet = "A45B6615-A082-4863-8D10-91BE05E73B49";

		/// <summary>
		/// CredentialOwnerChanged
		/// </summary>
		public const string CredentialOwnerChanged = "AF6575EF-FB08-4F3A-AFB3-90443D50DC1E";

		/// <summary>
		/// CredentialPropertyChanged
		/// </summary>
		public const string CredentialPropertyChanged = "A9DE982F-BA22-48BA-A098-8D03B7C56506";

		/// <summary>
		/// '{0:AuthorIdName}' combined credentials held by '{0:HolderIdName}'.
		/// </summary>
		public const string CredentialsCombined = "F5161B8A-8169-47AA-ACFA-B8FF34804A3C";

		/// <summary>
		/// '{0:AuthorIdName}' splitted credentials held by '{0:HolderIdName}'.
		/// </summary>
		public const string CredentialsSplitted = "B2E58067-6774-421C-ADDA-E0ED6CC30258";

		/// <summary>
		/// '{0:AuthorIdName}' changed status of credential '{0:CredentialIdName}' from '{0:OldValue}' to '{0:NewValue}'.
		/// </summary>
		public const string CredentialStatusChanged = "AFB0DFE7-B031-47F8-B129-846821D70909";

		/// <summary>
		/// '{0:AuthorIdName}' created credential type '{0:CredentialTypeIdName}'.
		/// </summary>
		public const string CredentialTypeCreated = "DF32F97D-855D-4D29-877D-A2A7070F547F";

		/// <summary>
		/// '{0:AuthorIdName}' deleted credential type '{0:CredentialTypeIdName}'
		/// </summary>
		public const string CredentialTypeDeleted = "C541A634-2B0A-4DDB-831E-EA684E53D20C";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of credential type '{0:CredentialTypeIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string CredentialTypePropertyChanged = "05432761-4F14-41F6-B729-322F5BCD9A0C";

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup failed due insufficient permissions.
		/// </summary>
		public const string DatabaseBackupFailedInsufficientPermissions = "90F3D768-780B-40FB-8388-11E661D1EAE3";

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup failed due to low disk space in target location.
		/// </summary>
		public const string DatabaseBackupFailedLowDiskSpace = "587CB03F-372E-4E61-A45E-33368D8B4E1E";

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup started.
		/// </summary>
		public const string DatabaseBackupStarted = "944DC1A3-66F8-4595-AD82-625549441F8F";

		/// <summary>
		/// [$bak{0:BackupType}$]' database backup succesfully finished.
		/// </summary>
		public const string DatabaseBackupSuccesful = "573E7161-DB68-46F6-8E01-7D9A6CB50D75";

		/// <summary>
		/// '{0:DeviceIdName}' database cleanup failed. Reason: '{0:Description}'
		/// </summary>
		public const string DatabaseCleanupFailed = "4B48D83D-E19D-4F1B-9251-903FD7EBBB31";

		/// <summary>
		/// '{0:DeviceIdName}' database cleanup successfully finished and deleted {0:Amount} events older than {0:Date}. Reduced database size {0:Size}.
		/// </summary>
		public const string DatabaseCleanupFinished = "C55655D3-7EAB-456D-A98B-BE543063E94D";

		/// <summary>
		/// '{0:DeviceIdName}' database cleanup started.
		/// </summary>
		public const string DatabaseCleanupStarted = "AB652AB2-25C4-4CA3-BB39-2F0B0831CAE4";

		/// <summary>
		/// {0:DeviceIdName}' database size reached the configured treshold '{0:Threshold}' GB. Consider further steps to reduce database size for proper system operation.
		/// </summary>
		public const string DatabaseSizeReachedTreshold = "A52BC4B0-9A10-44D2-A6AB-0E4027B45ED8";

		/// <summary>
		/// DefocusDetectedEvent
		/// </summary>
		public const string DefocusDetected = "739B299D-F91A-4AEC-8EA4-F958851454C7";

		/// <summary>
		/// '{0:AuthorIdName}' archived '{0:DeviceIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string DeviceArchived = "1762947A-F613-45F2-9D25-456B28653EC4";

		/// <summary>
		/// '{0:AuthorIdName}' changed category of '{0:DeviceIdName}' from '{0:PreviousCategoryIdName}' to '{0:NewCategoryIdName}'.
		/// </summary>
		public const string DeviceCategoryChanged = "B0B700B3-575D-42D9-B6E0-2618BCC651A7";

		/// <summary>
		/// DeviceColdRestartedEvent
		/// </summary>
		public const string DeviceColdRestarted = "13789D3D-38B7-4C38-BA38-7E773CBCEF76";

		/// <summary>
		/// Configuration retrieval from '{0:DeviceIdName}' failed.
		/// </summary>
		public const string DeviceConfigurationRetrievalFailed = "0268BB1E-5F80-4303-BA0C-18CC293BA0CC";

		/// <summary>
		/// Configuration retrieval from '{0:DeviceIdName}' started.
		/// </summary>
		public const string DeviceConfigurationRetrievalStarted = "3A17AC37-4B44-4B6E-A7FB-1382690A2668";

		/// <summary>
		/// Configuration succesfully retrieved from '{0:DeviceIdName}'.
		/// </summary>
		public const string DeviceConfigurationRetrievalSuccessful = "7ECC32D2-9966-4624-8D6D-217890C07B3E";

		/// <summary>
		/// Configuration sending to '{0:DeviceIdName}' failed.
		/// </summary>
		public const string DeviceConfigurationSendingFailed = "7CC4C2A5-FEFA-4659-B4C2-DA9287862BC0";

		/// <summary>
		/// Configuration sending to '{0:DeviceIdName}' started.
		/// </summary>
		public const string DeviceConfigurationSendingStarted = "1EBDD67B-AC09-4451-B0D2-3EC103C150F0";

		/// <summary>
		/// Configuration succesfully sent to '{0:DeviceIdName}'.
		/// </summary>
		public const string DeviceConfigurationSendingSuccessful = "C104CCA3-CBE5-42A2-A688-E128021033AF";

		/// <summary>
		/// '{0:DeviceIdName}' is connected.
		/// </summary>
		public const string DeviceConnected = "D19C0B6E-B763-4C5F-B297-8B1D926BD601";

		/// <summary>
		/// '{0:AuthorIdName}' created '{0:DeviceIdName}' under '{0:ParentIdName}'.
		/// </summary>
		public const string DeviceCreated = "E1128719-C51C-4098-A5DE-07E8352E7619";

		/// <summary>
		/// DeviceDisabledEvent
		/// </summary>
		public const string DeviceDisabled = "FED87DFA-5476-4E71-ACDE-A1CB389D3D2F";

		/// <summary>
		/// '{0:DeviceIdName}' is disconnected.
		/// </summary>
		public const string DeviceDisconnected = "CE202960-4775-4981-AA65-BBFD5164CAD3";

		/// <summary>
		/// Device '{0:DeviceIdName}' discovered with address '{0:Address}'.
		/// </summary>
		public const string DeviceDiscovered = "B6D335AA-531C-461C-869A-C4992ABEFF1D";

		/// <summary>
		/// Device discovery on '{0:DeviceIdName}' failed.
		/// </summary>
		public const string DeviceDiscoveryFailed = "8B8AAAF9-D8B3-4D3D-83D3-2FE8E21C5445";

		/// <summary>
		/// Device discovery on '{0:DeviceIdName}' started.
		/// </summary>
		public const string DeviceDiscoveryStarted = "D0ED2C35-4E67-4756-A032-3D43EE878BC2";

		/// <summary>
		/// Device discovery on '{0:DeviceIdName}' successfully finished.
		/// </summary>
		public const string DeviceDiscoverySuccessful = "296F1C0C-F985-4425-811F-5BF72FADD7A3";

		/// <summary>
		/// DeviceEnabledEvent
		/// </summary>
		public const string DeviceEnabled = "B0BCD6EA-569F-4527-9F00-E3DB05F765E3";

		/// <summary>
		/// '{0:AuthorIdName}' added '{0:DeviceIdName}' to '{0:LinkIdName}'.
		/// </summary>
		public const string DeviceLinkCreated = "7E01EF31-5156-456F-BC8B-FEDB1DAC06F1";

		/// <summary>
		/// '{0:AuthorIdName}' deleted '{0:DeviceIdName}' from '{0:LinkIdName}'.
		/// </summary>
		public const string DeviceLinkDeleted = "3B1D538C-FC98-45FD-969F-E7869EC3C284";

		/// <summary>
		/// DeviceModeActivatedEvent
		/// </summary>
		public const string DeviceModeActivated = "CC16274A-23CA-4D87-87BA-68ADFD70522A";

		/// <summary>
		/// '{0:AuthorIdName}' changed parent of '{0:DeviceIdName}' from '{0:OldParentIdName}' to '{0:NewParentIdName}'.
		/// </summary>
		public const string DeviceParentChanged = "E4AC25EC-F29B-4895-B5AE-46B4A42AC799";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:DeviceIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string DevicePermanentlyDeleted = "F14A49CD-DC09-4C97-8564-A601505EE937";

		/// <summary>
		/// '{0:AuthorIdName}' changed photo for '{0:DeviceIdName}'.
		/// </summary>
		public const string DevicePhotoChanged = "EAA7A9D5-EB70-4228-9EF3-31CBB57E0209";

		/// <summary>
		/// '{0:AuthorIdName}' uploaded photo for '{0:DeviceIdName}'.
		/// </summary>
		public const string DevicePhotoCreated = "8D9A4533-8092-431F-B52D-9E6FDE547674";

		/// <summary>
		/// '{0:AuthorIdName}' deleted photo for '{0:DeviceIdName}'.
		/// </summary>
		public const string DevicePhotoDeleted = "D972264D-24C4-4DB9-884F-20FB807C4256";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:DeviceIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string DevicePropertyChanged = "E5BFCE29-866B-4200-AC21-FCA7EB0B7195";

		/// <summary>
		/// '{0:DeviceIdName}' restarted.
		/// </summary>
		public const string DeviceRestarted = "4EA06864-BC5A-4741-9261-D9AD8BB544FC";

		/// <summary>
		/// '{0:AuthorIdName}' restored '{0:DeviceIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public const string DeviceRestored = "B842D198-630A-4730-9BA8-45941753A600";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:DeviceIdName}' from '{0:OldValueName}' to '{0:ValueName}'.
		/// </summary>
		public const string DeviceSchedulerPropertyChanged = "B118282A-B2C9-4F78-9A35-3B22F3E01261";

		/// <summary>
		/// DeviceShortSupervisionEvent
		/// </summary>
		public const string DeviceShortSupervision = "7611DE91-7070-4D78-A4C3-AFA7F924BF84";

		/// <summary>
		/// DeviceShortSupervisionRestoredEvent
		/// </summary>
		public const string DeviceShortSupervisionRestored = "54CFC806-E102-46E3-9728-9627B73B11E2";

		/// <summary>
		/// DeviceSupervisionEvent
		/// </summary>
		public const string DeviceSupervision = "44D27B2D-6EEB-4543-A2D8-2E0EE43DEAB4";

		/// <summary>
		/// DeviceSupervisionRestoredEvent
		/// </summary>
		public const string DeviceSupervisionRestored = "D77B9A42-57D5-4396-B376-E15218A57019";

		/// <summary>
		/// DeviceSupportedCredentialTypeAddedEvent
		/// </summary>
		public const string DeviceSupportedCredentialTypeAdded = "15433877-CD20-4290-B5F7-B2ECF780B5F0";

		/// <summary>
		/// DeviceSupportedCredentialTypeRemovedEvent
		/// </summary>
		public const string DeviceSupportedCredentialTypeRemoved = "4996E422-EF5C-4DEC-8219-91F0B2246B90";

		/// <summary>
		/// '{0:DeviceIdName}' turned off.
		/// </summary>
		public const string DeviceTurnedOff = "BE8F7075-195B-42E6-B531-A49727417D71";

		/// <summary>
		/// '{0:DeviceIdName}' turned on.
		/// </summary>
		public const string DeviceTurnedOn = "22457358-2DA6-4295-AFA0-CE6CEBD9056B";

		/// <summary>
		/// '{0:DeviceIdName}' turned on timed (duration {0:Time}).
		/// </summary>
		public const string DeviceTurnedOnTimed = "95AABD18-260B-406C-A8B0-785589B399DB";

		/// <summary>
		/// DiallerRetryAttemptEvent
		/// </summary>
		public const string DiallerRetryAttempt = "7724619A-B37D-4977-BA87-349A5818F483";

		/// <summary>
		/// '{0:DeviceIdName}' was disarmed automatically.
		/// </summary>
		public const string DisarmedAutomatically = "3B4B67B7-1F9D-42E9-A959-74ABB8BC97EE";

		/// <summary>
		/// DisarmedByKeySwitchEvent
		/// </summary>
		public const string DisarmedByKeySwitch = "FBE08A33-F7FB-483A-95BC-285FE5ECABBD";

		/// <summary>
		/// '{0:DeviceIdName}' was disarmed by '{0:PersonIdName}'.
		/// </summary>
		public const string DisarmedByPerson = "EBE14147-89CA-4163-9605-26D9F8F8181A";

		/// <summary>
		/// DisarmedDuringAlarmEvent
		/// </summary>
		public const string DisarmedDuringAlarm = "64A26944-191A-4C22-87D4-8A46212C8C55";

		/// <summary>
		/// DisarmedEvent
		/// </summary>
		public const string Disarmed = "DA769B4B-3D0E-4493-ABFF-DF10E76DE0CD";

		/// <summary>
		/// DisarmedFailureTooEarlyEvent
		/// </summary>
		public const string DisarmedFailureTooEarly = "A4327055-18B5-4CC0-A69C-D1D39BC61333";

		/// <summary>
		/// DisarmedPartiallyByPersonEvent
		/// </summary>
		public const string DisarmedPartiallyByPerson = "4264D9ED-71AF-4EC2-803D-2FB787D6D57B";

		/// <summary>
		/// {0:AuthorIdName}' changed content of document '{0:DocumentIdName}'.
		/// </summary>
		public const string DocumentContentChanged = "2781993F-FB9B-45B1-BB39-487E3EDD36A8";

		/// <summary>
		/// '{0:AuthorIdName}' created document '{0:DocumentIdName}' for '{0:EntityIdName}'
		/// </summary>
		public const string DocumentCreated = "9777D863-8360-4BFE-A522-B3BF595AF544";

		/// <summary>
		/// '{0:AuthorIdName}' deleted document '{0:DocumentIdName}' from '{0:EntityIdName}'
		/// </summary>
		public const string DocumentDeleted = "A35A114F-BACA-46A1-B7D3-59F1CB7AA3A6";

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of document '{0:DocumentIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string DocumentPropertyChanged = "61913069-A702-4505-99B5-A9B175A0DFC0";

		/// <summary>
		/// '{0:DeviceIdName}' closed.
		/// </summary>
		public const string DoorClosed = "2211DEC8-C44B-4703-8E28-3F29FABCB09D";

		/// <summary>
		/// '{0:DeviceIdName}' remotely closed by '{0:PersonIdName}'.
		/// </summary>
		public const string DoorClosedRemotely = "0641421A-DB9D-4E13-B960-A0C35770203B";

		/// <summary>
		/// '{0:DeviceIdName}' locked.
		/// </summary>
		public const string DoorLocked = "63FFB732-E2F5-49FD-93D7-8989FD135ECA";

		/// <summary>
		/// '{0:DeviceIdName}' manual override finished.
		/// </summary>
		public const string DoorManualOverrideEnd = "0E7E9A5E-B7B7-4E61-8EBB-D2DAB718704E";

		/// <summary>
		/// '{0:DeviceIdName}' manual override started.
		/// </summary>
		public const string DoorManualOverrideStart = "4485BBE4-F96D-4DBE-8994-BD14699B7D39";

		/// <summary>
		/// '{0:DeviceIdName}' opened.
		/// </summary>
		public const string DoorOpened = "8CBDA41E-753F-46F3-AA4C-F3468109B9E7";

		/// <summary>
		/// Door '{0:DeviceIdName}' forced open.
		/// </summary>
		public const string DoorOpenedForcibly = "616DC78A-F323-47B6-A2DD-4F58AA927CA7";

		/// <summary>
		/// '{0:DeviceIdName}' remotely opened by '{0:PersonIdName}'.
		/// </summary>
		public const string DoorOpenedRemotely = "5D55A2AD-DDDC-4011-A34D-868E07E7C14D";

		/// <summary>
		/// Door '{0:DeviceIdName}' open too long.
		/// </summary>
		public const string DoorOpenedTooLong = "C75E6055-55C4-4A3B-B42A-289B0E1CD487";

		/// <summary>
		/// '{0:DeviceIdName}' unlocked.
		/// </summary>
		public const string DoorUnlocked = "BC963C71-0317-4E00-A6F5-4D658E2A226E";

		/// <summary>
		/// '{0:DeviceIdName}' unlocked permanently.
		/// </summary>
		public const string DoorUnlockedPermanently = "2DC091AA-AA10-4355-AC1B-2D2299EB15BA";

		/// <summary>
		/// '{0:DeviceIdName}' unlocked timed (duration {0:Time}).
		/// </summary>
		public const string DoorUnlockedTimed = "9531E9EE-2B75-4278-9460-F2CAB0F2AA72";

		/// <summary>
		/// DriverAbortedEvent
		/// </summary>
		public const string DriverAborted = "0C9499ED-7722-42E5-8D5F-9995D373B742";

		/// <summary>
		/// '{0:DeviceIdName}' successfully connected to the device.
		/// </summary>
		public const string DriverConnectedToDevice = "FA937072-D6EC-409A-8CAD-D9098C9F8450";

		/// <summary>
		/// '{0:DeviceIdName}' connecting to the device.
		/// </summary>
		public const string DriverConnectingToDevice = "DDD59441-7F16-48FC-AAA0-DE6A1A46F7AF";

		/// <summary>
		/// Network connection interrupted to '{0:DeviceIdName}'.
		/// </summary>
		public const string DriverConnectionLost = "EE1BA72B-35C5-4887-90FA-046B989CE84D";

		/// <summary>
		/// Network connection with '{0:DeviceIdName}' restored. Number of attempts: '{0:RetriesCount}'
		/// </summary>
		public const string DriverConnectionRestored = "04EBC040-7671-4CD4-9515-2CFCD4C7E347";

		/// <summary>
		/// {0:AuthorIdName}' created driver '{0:DriverIdName}'.
		/// </summary>
		public const string DriverCreated = "16A265CF-49B1-41E7-A85E-3E75089E98A6";

		/// <summary>
		/// {0:AuthorIdName}' deleted driver '{0:DriverIdName}'.
		/// </summary>
		public const string DriverDeleted = "F55625BF-B91C-4C56-A921-75E3B7D6E228";

		/// <summary>
		/// '{0:DeviceIdName}' initiated.
		/// </summary>
		public const string DriverInitiated = "96DDE25B-1584-4A57-ADDB-AE31BA19CF58";

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of driver '{0:DriverIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string DriverPropertyChanged = "3F036DDA-725D-4585-BF3F-9718429732CA";

		/// <summary>
		/// '{0:DeviceIdName}' started.
		/// </summary>
		public const string DriverStarted = "3E0AB9D0-28E8-44B5-941D-F79CA520A43A";

		/// <summary>
		/// {0:DeviceIdName}' failed to start.
		/// </summary>
		public const string DriverStartFailure = "0D00947E-C5D1-42CD-BCF2-FD547C06AD31";

		/// <summary>
		/// DriverStartFailureNotAssignedForAgentEvent
		/// </summary>
		public const string DriverStartFailureNotAssignedForAgent = "97B50B6E-4D1D-4EB6-AF4D-C74C0B022128";

		/// <summary>
		/// '{0:DeviceIdName}' stopped.
		/// </summary>
		public const string DriverStopped = "DCBB941A-5ED8-421B-A105-72466E9C8CB6";

		/// <summary>
		/// Duplicated address '{0:HardwareAddress}' detected between '{0:Device1IdName}' and '{0:Device2IdName}'.
		/// </summary>
		public const string DuplicateAddressDetected = "E45E495A-5DD6-4D95-BACC-9F40EC9423A2";

		/// <summary>
		/// EgressTimeoutEvent
		/// </summary>
		public const string EgressTimeout = "FEDB3F34-E674-4C4B-A6D4-4A1D780CF114";

		/// <summary>
		/// EngineerResetPerformedEvent
		/// </summary>
		public const string EngineerResetPerformed = "5D019AD6-D070-4819-9381-AB9C08AE6C2D";

		/// <summary>
		/// EngineerResetRequiredEvent
		/// </summary>
		public const string EngineerResetRequired = "10AF1D00-DD75-43B0-BB16-54ACC6C1E6C9";

		/// <summary>
		/// {0:AuthorIdName}' created entity definition '{0:EntityDefinitionIdName}'.
		/// </summary>
		public const string EntityDefinitionCreated = "CA5EFE69-6E67-4BC1-923E-4DE0879570E3";

		/// <summary>
		/// {0:AuthorIdName}' deleted entity definition '{0:EntityDefinitionIdName}'.
		/// </summary>
		public const string EntityDefinitionDeleted = "63BC4F15-4851-4215-AFAD-F5BF80AAF021";

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of entity definition '{0:EntityDefinitionIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string EntityDefinitionPropertyChanged = "D6C7BFC6-D408-46C6-9538-68A8977A7926";

		/// <summary>
		/// {0:AuthorIdName}' created event '{0:EventIdName}'.
		/// </summary>
		public const string Created = "1F973A43-B3C8-4D36-BE97-090A83247F91";

		/// <summary>
		/// ExceptionUnhandledEvent
		/// </summary>
		public const string ExceptionUnhandled = "36180AE0-4D30-43D5-A675-516D6FECD52B";

		/// <summary>
		/// Exit button pushed '{0:DeviceIdName}'.
		/// </summary>
		public const string ExitButtonPushed = "08E6D42F-09C4-4341-8C13-E36E7C800CAE";

		/// <summary>
		/// ExitFailureEvent
		/// </summary>
		public const string ExitFailure = "1FF825BE-32DE-4B4F-B5D8-C8700DC54C84";

		/// <summary>
		/// FaceDetectedEvent
		/// </summary>
		public const string FaceDetected = "EDBDE691-33E6-4A13-93D7-076100FCEDA9";

		/// <summary>
		/// '{0:DeviceIdName}' factory default settings successfully restored.
		/// </summary>
		public const string FactoryDefaultCompleted = "A3715322-FB7D-4D61-A9BA-732045587C4E";

		/// <summary>
		/// '{0:DeviceIdName}' factory default reset initiated.
		/// </summary>
		public const string FactoryDefaultInitiated = "B2F32297-5E52-45CB-B94D-194EEE013F76";

		/// <summary>
		/// Failure on '{0:DeviceIdName}'. Description: '{0:Description}'.
		/// </summary>
		public const string Failure = "AA026B38-1F0D-42A4-A9FE-F8E1D8893521";

		/// <summary>
		/// FailureRecoveredEncryptionErrorEvent
		/// </summary>
		public const string FailureRecoveredEncryptionError = "ED072593-0C99-424C-890B-00DBF11B3340";

		/// <summary>
		/// Failure on '{0:DeviceIdName}' restored. Description: '{0:Description}'.
		/// </summary>
		public const string FailureRecovered = "5421310E-6BD2-4976-9A8A-C55840E239CC";

		/// <summary>
		/// '{0:DeviceIdName}' alarm counter value: {0:AlarmCounter}.
		/// </summary>
		public const string FireAlarmCounterValueChanged = "9D6C49C2-8E9A-4A9F-81EB-9A452988F1EA";

		/// <summary>
		/// Fire alarm on '{0:DeviceIdName}'.
		/// </summary>
		public const string FireAlarm = "6F13F677-3DD9-48C1-BE5B-85B4D60C4F89";

		/// <summary>
		/// Fire precondition on '{0:DeviceIdName}'.
		/// </summary>
		public const string FireAlarmPrecondition = "C051F415-AAE3-4179-9E35-F15DA5DC77B3";

		/// <summary>
		/// Fire precondition on '{0:DeviceIdName}' ended.
		/// </summary>
		public const string FireAlarmPreconditionRecovered = "FB62B57C-47A8-48D9-8028-AF0EFA98AEFC";

		/// <summary>
		/// Fire alarm restored on '{0:DeviceIdName}'.
		/// </summary>
		public const string FireAlarmRecovered = "C1E077ED-6300-41D6-A5CE-4EC3DA6A81FA";

		/// <summary>
		/// '{0:DeviceIdName}' fire fighting delay disabled.
		/// </summary>
		public const string FireFightingDelayDisabled = "B1D33FB8-A9B2-45F0-AD85-F4A7F0F9E30E";

		/// <summary>
		/// '{0:DeviceIdName}' fire fighting delay enabled.
		/// </summary>
		public const string FireFightingDelayEnabled = "9D8DEDE4-3731-4621-BE73-65499FD83D47";

		/// <summary>
		/// '{0:DeviceIdName}' fire fighting disabled.
		/// </summary>
		public const string FireFightingDisabled = "7297719D-0C26-42AA-A968-F91A92E0EAAB";

		/// <summary>
		/// FireFightingEnabledEvent
		/// </summary>
		public const string FireFightingEnabled = "9BEA02AD-A527-4DA6-BE0E-A5365544952A";

		/// <summary>
		/// '{0:DeviceIdName}' firmware upgrade successfully completed.
		/// </summary>
		public const string FirmwareUpgradeCompleted = "4741D445-458E-476B-AD8B-2DDA9EB1CEC9";

		/// <summary>
		/// '{0:DeviceIdName}' firmware upgrade started.
		/// </summary>
		public const string FirmwareUpgradeStarted = "F3AEC1C5-9681-46B5-B5A8-D40FEA25239D";

		/// <summary>
		/// '{0:DeviceIdName}' fuse failed.
		/// </summary>
		public const string FuseFailure = "44CD10AA-80E0-44A8-812B-668882F1B9C4";

		/// <summary>
		/// '{0:DeviceIdName}' restored after a fuse failure.
		/// </summary>
		public const string FuseFailureRestored = "08B8CFC7-5EB6-45B3-B695-ACEAECF56004";

		/// <summary>
		/// '{0:AuthorIdName}' assigned '{0:PersonIdName}' to group '{0:GroupIdName}'.
		/// </summary>
		public const string GroupAssigned = "0337435A-7CE7-4C7F-9FF2-8594FBC83E37";

		/// <summary>
		/// '{0:AuthorIdName}' created new group '{0:GroupIdName}'.
		/// </summary>
		public const string GroupCreated = "B2F2FAC9-25DA-4815-AFC3-07C06392F0A1";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:GroupIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string GroupDataChanged = "A93B184B-D839-4B14-97D1-C85C4FFB4ABC";

		/// <summary>
		/// '{0:AuthorIdName}' deleted group '{0:GroupIdName}'.
		/// </summary>
		public const string GroupDeleted = "B2AEEC01-7006-4616-AC79-F882CFD16C5F";

		/// <summary>
		/// '{0:AuthorIdName}' unassigned '{0:PersonIdName}' from group '{0:GroupIdName}'.
		/// </summary>
		public const string GroupUnassigned = "877DE595-AE6F-4266-8CE0-8F26B11D9C4C";

		/// <summary>
		/// '{0:AuthorIdName}' created holiday '{0:HolidayIdName}'.
		/// </summary>
		public const string HolidayCreated = "413A691C-E913-4EC5-84BF-49F043002B9B";

		/// <summary>
		/// '{0:AuthorIdName}' deleted holiday '{0:HolidayIdName}'.
		/// </summary>
		public const string HolidayDeleted = "F6F0B81C-23FC-47E8-9874-164D6D17BD66";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:HolidayIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string HolidayPropertyChanged = "5D97743C-C6ED-4C13-84D2-0D6DC9ED3216";

		/// <summary>
		/// '{0:AuthorIdName}' created a holiday set '{0:HolidaySetIdName}'.
		/// </summary>
		public const string HolidaySetCreated = "523A734C-D76E-45F7-97D0-128B8F5CD8B4";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:HolidaySetIdName}'.
		/// </summary>
		public const string HolidaySetDeleted = "68685A77-F2C6-4C81-939F-231E24FD66DB";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:HolidaySetIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string HolidaySetPropertyChanged = "E208CA73-C3A4-4281-A185-8C08D38B5259";

		/// <summary>
		/// HotSpareExceptionEvent
		/// </summary>
		public const string HotSpareException = "DA79EB95-7058-4B55-9ADA-D8E2EA4933FB";

		/// <summary>
		/// Invalid code attempted too often on '{0:DeviceIdName}'.
		/// </summary>
		public const string IdentificationRepeatedInvalid = "EA83B982-A69B-44C8-A543-C8B2362983D6";

		/// <summary>
		/// IdentityCardReadEvent
		/// </summary>
		public const string IdentityCardRead = "F8544CF5-1DB6-4B71-9D21-ED18562E9A59";

		/// <summary>
		/// IncomingCallEvent
		/// </summary>
		public const string IncomingCall = "C00C48D3-D6B0-4421-9FE9-4B9F031C30EC";

		/// <summary>
		/// IncomingCallFailedEvent
		/// </summary>
		public const string IncomingCallFailed = "2CE3C754-DBFA-437E-814F-5498C057EED8";

		/// <summary>
		/// IncomingCallSuccessfulEvent
		/// </summary>
		public const string IncomingCallSuccessful = "CBF842BB-5C40-4C43-B421-DE5631F0D87F";

		/// <summary>
		/// IncomingEncryptedCallSuccessfulEvent
		/// </summary>
		public const string IncomingEncryptedCallSuccessful = "B899ACF8-9F7C-49DE-8313-8B1B42CE8A7A";

		/// <summary>
		/// IncomingUnencryptedCallSuccessfulEvent
		/// </summary>
		public const string IncomingUnencryptedCallSuccessful = "483BBA2C-8BE9-41A1-881C-861B679ED2DD";

		/// <summary>
		/// '{0:DeviceIdName}' firmware version is incompatible with the driver. Current firmware in device '{0:DeviceFirmware}'.
		/// </summary>
		public const string IncompatibleFirmwareVersion = "38B45EC5-5A78-46D4-8F92-4E1A8E443728";

		/// <summary>
		/// IngressTimeoutEvent
		/// </summary>
		public const string IngressTimeout = "AFB12000-98E8-41E9-8865-A3D7EA3A7F6F";

		/// <summary>
		/// InstructionSetCanceledEvent
		/// </summary>
		public const string InstructionSetCanceled = "04F827DA-B820-4613-BAE6-1F2A5AC42F85";

		/// <summary>
		/// InstructionSetFilledOutEvent
		/// </summary>
		public const string InstructionSetFilledOut = "52B4825B-30D7-4F3D-8DC9-9B5058304060";

		/// <summary>
		/// Failed to run '{0:DeviceIdName}' - insufficient license.
		/// </summary>
		public const string InsufficientLicense = "770359B7-6A5A-4CF5-91CB-2CF855A1443B";

		/// <summary>
		/// Internal communication error to '{0:DeviceIdName}'. Description: {0:Description}'.
		/// </summary>
		public const string InternalCommunicationError = "415CADE0-D28F-4EA3-B3CC-59C940AED0DC";

		/// <summary>
		/// Internal communication error to '{0:DeviceIdName}' restored. Description: {0:Description}'.
		/// </summary>
		public const string InternalCommunicationErrorRestored = "5A8D7695-A512-4CD8-AD0E-EB9AC7FEE0F0";

		/// <summary>
		/// IPConflictEvent
		/// </summary>
		public const string IPConflict = "D116587F-A86C-48C4-9B1F-035CC865D328";

		/// <summary>
		/// '{0:DeviceIdName}' jamming failure.
		/// </summary>
		public const string JammingFailure = "BF77D73F-1D99-45FF-B5BD-A1C6B103AA0B";

		/// <summary>
		/// '{0:DeviceIdName}' restored after a jamming failure.
		/// </summary>
		public const string JammingFailureRestored = "57A08563-1621-4B2D-9A43-C7F0171E89A9";

		/// <summary>
		/// '{0:DeviceIdName}' key turned to 'Off' position.
		/// </summary>
		public const string KeyTurnDisabled = "97EB9345-757D-4A94-B888-B999468E6C93";

		/// <summary>
		/// '{0:DeviceIdName}' key turned to 'On' position.
		/// </summary>
		public const string KeyTurnEnabled = "D9807C22-DBC6-4DC0-BDBE-98BE7B50EDE0";

		/// <summary>
		/// '{0:AuthorIdName}' appended new license file.
		/// </summary>
		public const string LicenseAppended = "CA47E590-F20A-4E3B-9D54-98206598E70E";

		/// <summary>
		/// {0:InstallationIdName} license is corrupted.
		/// </summary>
		public const string LicenseCorrupted = "3B5D827D-DCA5-4BC1-9E69-613B04DB640F";

		/// <summary>
		/// License Events
		/// </summary>
		public const string Licenses = "F0B439CE-8175-4F54-B6DD-1E4803ACFE2A";

		/// <summary>
		/// LineCrossedEvent
		/// </summary>
		public const string LineCrossed = "AD5E5571-6D29-4140-875F-28CCC4E76115";

		/// <summary>
		/// '{0:DeviceIdName}' locked.
		/// </summary>
		public const string Locked = "1084052C-4E40-4809-B0D1-1B45F9FD9E79";

		/// <summary>
		/// '{0:DeviceIdName}' remotely locked by '{0:PersonIdName}'.
		/// </summary>
		public const string LockedRemotely = "DBC8E83B-A723-426B-A338-425D3A827B16";

		/// <summary>
		/// '{0:DeviceIdName}' mains failed.
		/// </summary>
		public const string MainsFailure = "5486FD5B-5777-4476-B40E-D58136D2029C";

		/// <summary>
		/// Restore '{0:DeviceIdName}' after a mains failure.
		/// </summary>
		public const string MainsFailureRecovered = "5025DBE1-706F-48D5-98A1-91209AC4592B";

		/// <summary>
		/// MemoryFailureEvent
		/// </summary>
		public const string MemoryFailure = "3B4347EF-444B-4889-964A-A4E6E76227E3";

		/// <summary>
		/// MemoryFailureRecoveredEvent
		/// </summary>
		public const string MemoryFailureRecovered = "D2B92047-B189-4D28-AD78-BBF8179C50FF";

		/// <summary>
		/// MemoryWarningAlmostFullEvent
		/// </summary>
		public const string MemoryWarningAlmostFull = "37F81BFF-5144-466F-8307-01A44523A63E";

		/// <summary>
		/// MenuEnteredEvent
		/// </summary>
		public const string MenuEntered = "FC039B04-C82E-4A2C-9989-82E053F27B73";

		/// <summary>
		/// MenuExitedEvent
		/// </summary>
		public const string MenuExited = "31124F79-13A4-4CE1-8016-8AA359E8F9AD";

		/// <summary>
		/// Configuration failure '{0:DeviceIdName}': Missing device '{0:DeviceIdName} [${0:MissingDeviceTypeIdName}$]' with address: '{0:Address}'. Detail: {0:Description}
		/// </summary>
		public const string MissingDeviceInTree = "408D04A1-903D-44D3-9E04-C5863D016B4F";

		/// <summary>
		/// MotionDetectedEvent
		/// </summary>
		public const string MotionDetected = "7DF3259C-CAFC-4261-99CC-7ADB031602A4";

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' at subaddress '{0:SubAddressIdName}'.
		/// </summary>
		public const string MultidetectorAlarm = "5E59A427-4988-4260-A085-A5B7B8888C1B";

		/// <summary>
		/// '{0:AuthorIdName}' changed owner of credential '{0:CredentialIdName}' to '{0:OwnerIdName}'.
		/// </summary>
		public const string NonAssignedCredentialOwnerChanged = "60C57E78-1407-4951-A594-82BE2A75F553";

		/// <summary>
		/// {0:AuthorIdName}' changed content of the credential '{0:CredentialIdName}' under '{0:OwnerIdName}'.
		/// </summary>
		public const string NonAssignedTransferableCredentialCodeChanged = "682C8183-1C9F-4180-A18A-3F4A5738C3F5";

		/// <summary>
		/// '{0:AuthorIdName}' created credential '{0:CredentialIdName}' with credential type '{0:CategoryIdName}' into '{0:OwnerIdName}'.
		/// </summary>
		public const string NonAssignedTransferableCredentialCreated = "58D302B0-068C-49A6-9B2F-F1CDB3233226";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:CredentialIdName}' from '{0:OwnerIdName}'.
		/// </summary>
		public const string NonAssignedTransferableCredentialDeleted = "6BE17D47-00AD-48E7-A2BF-3DE014A87892";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:CredentialIdName}' held by '{0:OwnerIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string NonAssignedTransferableCredentialPropertyChanged = "53EBCB7C-566E-45ED-AC71-E07686E93B6B";

		/// <summary>
		/// '{0:AuthorIdName}' changed content of the credential '{0:CredentialIdName}' held by '{0:HolderIdName}'.
		/// </summary>
		public const string NonTransferableCredentialCodeChanged = "BCFBBAF7-2F00-4B03-923F-1E7A1483B064";

		/// <summary>
		/// '{0:AuthorIdName}' created credential '{0:CredentialIdName}' with category '{0:CategoryIdName}' into '{0:HolderIdName}'.
		/// </summary>
		public const string NonTransferableCredentialCreated = "70B1B1FC-5D8A-4469-A8DB-BCF7DE7FF378";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:CredentialIdName}' from '{0:HolderIdName}'.
		/// </summary>
		public const string NonTransferableCredentialDeleted = "35824115-A03A-493F-A103-38669B43945B";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:CredentialIdName}' held by '{0:HolderIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string NonTransferableCredentialPropertyChanged = "0CC8E017-57C0-4772-AE3E-AA17EEF0FA9B";

		/// <summary>
		/// ObjectRemovalDetectedEvent
		/// </summary>
		public const string ObjectRemovalDetected = "96355962-0BC8-43C3-9339-1A456A776808";

		/// <summary>
		/// '{0:DeviceIdName}' opened.
		/// </summary>
		public const string Opened = "832CD291-87E6-4EB0-84E5-CB98988E9DEC";

		/// <summary>
		/// OutgoingCallEvent
		/// </summary>
		public const string OutgoingCall = "3ED68450-9D0F-4D30-BF09-22BC79043455";

		/// <summary>
		/// OutgoingCallFailedEvent
		/// </summary>
		public const string OutgoingCallFailed = "DA58F428-80D3-4B32-A6C0-35AE13DEC4C3";

		/// <summary>
		/// OutgoingCallSuccessfulEvent
		/// </summary>
		public const string OutgoingCallSuccessful = "A1B5522C-3C91-4162-B4D7-9821EA3AEAE7";

		/// <summary>
		/// OutgoingEncryptedCallSuccessfulEvent
		/// </summary>
		public const string OutgoingEncryptedCallSuccessful = "D8988146-4201-403B-A306-DAAD9B8B0C8A";

		/// <summary>
		/// OutgoingUnencryptedCallSuccessfulEvent
		/// </summary>
		public const string OutgoingUnencryptedCallSuccessful = "565560C4-7736-40A6-AD58-CFBB00D86560";

		/// <summary>
		/// OverloadedEvent
		/// </summary>
		public const string Overloaded = "67FFB2D0-BE6B-4A1A-840B-7FDE00F811E9";

		/// <summary>
		/// OverloadedRecoveredEvent
		/// </summary>
		public const string OverloadedRecovered = "A74EC709-0B9F-4CA1-BD10-0A4534D91788";

		/// <summary>
		/// {0:AuthorIdName}' installed package '{0:PackageIdName}' of '{0:Version}' version.
		/// </summary>
		public const string PackageInstalled = "E5986C36-136C-4377-8DB0-1D1F06585006";

		/// <summary>
		/// '{0:AuthorIdName}' uninstalled package '{0:PackageIdName}' of '{0:Version}' version.
		/// </summary>
		public const string PackageUninstalled = "5050B6E9-FB26-458C-8B93-797B79EEC4FB";

		/// <summary>
		/// '{0:AuthorIdName}' archived panel '{0:PanelIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string PanelArchived = "81A2D795-463B-4693-AB52-D157D704C882";

		/// <summary>
		/// {0:AuthorIdName}' created panel '{0:PanelIdName}'.
		/// </summary>
		public const string PanelCreated = "800C3466-799F-43ED-8DB4-F36332E7A25E";

		/// <summary>
		/// '{0:AuthorIdName}' deleted panel '{0:PanelIdName}'.
		/// </summary>
		public const string PanelDeleted = "19E62828-DF24-4A74-9D5E-0C8EF3E4AF03";

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of panel '{0:PanelIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string PanelPropertyChanged = "02D05674-1FB1-4D35-AD57-8C3CC5536874";

		/// <summary>
		/// '{0:AuthorIdName}' restored panel '{0:PanelIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public const string PanelRestored = "E72E8AB2-0E68-4C67-B3E1-2BF5F41713F7";

		/// <summary>
		/// '{0:AuthorIdName}' changed calendar '{0:CalendarIdName}' of permission of person '{0:PersonIdName}'.
		/// </summary>
		public const string PermissionCalendarChanged = "F8F0306A-0722-4891-B26D-74713D580AA4";

		/// <summary>
		/// '{0:AuthorIdName}' denied '{0:PermissionTypeName}' for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public const string PermissionDenied = "BDC14DF4-353D-4900-A6C9-98B23FA26878";

		/// <summary>
		/// '{0:AuthorIdName}' denied '{0:PermissionTypeName}' without inheritance for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public const string PermissionDeniedNonInherited = "E6AFEEF7-1C5F-4717-9FB4-2D35A52A1D7F";

		/// <summary>
		/// '{0:AuthorIdName}' granted '{0:PermissionTypeName}' for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public const string PermissionGranted = "8AE4ECBD-3B40-4250-AF36-90BD28D171B1";

		/// <summary>
		/// '{0:AuthorIdName}' granted '{0:PermissionTypeName}' without inheritance for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public const string PermissionGrantedNotInherited = "0B17F62A-8512-4CA6-A41A-58488DC7F3F7";

		/// <summary>
		/// {0:AuthorIdName}' revoked '{0:PermissionTypeName}' for '{0:EntityIdName}' to '{0:PersonIdName}'.
		/// </summary>
		public const string PermissionRevoked = "117D310E-D15B-4742-B53B-9A093F8EE6FB";

		/// <summary>
		/// '{0:AuthorIdName}' loaded personal data for '{0:PersonIdName}' using identification document reader '{0:DeviceIdName}'.
		/// </summary>
		public const string PersonalDataLoadedUsingReader = "8D95E326-4BD8-45AB-A6AE-B679B57A979D";

		/// <summary>
		/// '{0:AuthorIdName}' archived '{0:PersonIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string PersonArchived = "24AEA4B6-CDF6-4570-ADA4-3C2A7DEF7EA8";

		/// <summary>
		/// '{0:AuthorIdName}' changed category of '{0:PersonIdName}' from '{0:PreviousCategoryIdName}' to '{0:NewCategoryIdName}'.
		/// </summary>
		public const string PersonCategoryChanged = "3563BFA7-2B80-4ACF-BEF9-E9DD9B6787D8";

		/// <summary>
		/// '{0:AuthorIdName}' created '{0:PersonIdName}' under '{0:ParentIdName}'.
		/// </summary>
		public const string PersonCreated = "C967183A-8D42-4C42-9457-47276E008C77";

		/// <summary>
		/// '{0:AuthorIdName}' changed parent of '{0:PersonIdName}' from '{0:OldParentIdName}' to '{0:NewParentIdName}'.
		/// </summary>
		public const string PersonParentChanged = "7C088F4A-CFF7-4F57-911E-EB0BEA3D26B3";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:PersonIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string PersonPermanentlyDeleted = "06666F64-A112-43D2-AB37-6D121C6A17A5";

		/// <summary>
		/// '{0:AuthorIdName}' changed photo for '{0:PersonIdName}'.
		/// </summary>
		public const string PersonPhotoChanged = "BB60B1E4-0E9F-41A6-A69A-6498991DE3E1";

		/// <summary>
		/// '{0:AuthorIdName}' uploaded photo for '{0:PersonIdName}'.
		/// </summary>
		public const string PersonPhotoCreated = "F54852A2-B2C5-4DCA-9420-AF1CE9969549";

		/// <summary>
		/// '{0:AuthorIdName}' deleted photo for '{0:PersonIdName}'.
		/// </summary>
		public const string PersonPhotoDeleted = "E1385C64-39C9-4BAC-87F7-D455A5DED43C";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:PersonIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string PersonPropertyChanged = "F86D0DCB-AF36-4719-B657-1307301440E3";

		/// <summary>
		/// '{0:AuthorIdName}' restored '{0:PersonIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public const string PersonRestored = "E43DC2EC-A43F-4299-85F7-88EE36B0289E";

		/// <summary>
		/// '{0:DeviceIdName}' phone communicator failure.
		/// </summary>
		public const string PhoneCommunicatorFailure = "A4E21598-FAE1-4EEA-B7F7-56DA41592C48";

		/// <summary>
		/// '{0:DeviceIdName}' restored after a phone communicator failure.
		/// </summary>
		public const string PhoneCommunicatorFailureRestored = "6E56B1FF-E981-4A20-869A-983E08F32422";

		/// <summary>
		/// Preset '{0:PresetId}' on '{0:DeviceIdName}' was activated.
		/// </summary>
		public const string PresetActivated = "D67076DC-8DA8-449B-86DA-F7113E33517E";

		/// <summary>
		/// '{0:DeviceIdName}' printer failure.
		/// </summary>
		public const string PrinterFailure = "3999AE09-27F6-4819-B843-58ADFAAAD808";

		/// <summary>
		/// '{0:DeviceIdName}' restored after a printer failure.
		/// </summary>
		public const string PrinterFailureRestored = "DDD69C9C-0BCF-411F-9443-BB794F7B5D62";

		/// <summary>
		/// '{0:AuthorIdName}' created profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfileCreated = "D7535EC0-F9D3-4C81-A9D0-D6939562AC23";

		/// <summary>
		/// '{0:AuthorIdName}' deleted profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfileDeleted = "E28D90CB-C732-42AA-B36B-31DD7EBD97EE";

		/// <summary>
		/// '{0:AuthorIdName}' assigned '{0:DeviceIdName}' to profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfileDeviceAssigned = "B43607B7-2EBC-407E-9607-DD97E5360C52";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of DeviceData '{0:DeviceDataId}' of profile '{0:ProfileIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string ProfileDeviceDataChanged = "9812BFFC-4EC6-42D8-8B72-C922E60B9408";

		/// <summary>
		/// '{0:AuthorIdName}' assigned DeviceType '{0:DeviceTypeIdName}' to profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfileDeviceTypeAssigned = "FB22C131-BF39-4631-B27E-2A8E1A9CDC58";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of DeviceType '{0:DeviceTypeIdName}' of profile '{0:ProfileIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string ProfileDeviceTypeDataChanged = "29E36B15-6982-4E65-89F3-FFE968634E3D";

		/// <summary>
		/// '{0:AuthorIdName}' unassigned DeviceType '{0:DeviceTypeIdName}' from profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfileDeviceTypeUnassigned = "FD89733D-E73F-4A21-8A3B-C619228D571D";

		/// <summary>
		/// '{0:AuthorIdName}' unassigned '{0:DeviceIdName}' from profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfileDeviceUnassigned = "B1299620-21B0-4A02-873B-4EE6B6D1EB4C";

		/// <summary>
		/// '{0:AuthorIdName}' attached person '{0:PersonIdName}' to profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfilePersonAttached = "B6A90C8B-9049-406D-B20B-6AE5B3F16B2E";

		/// <summary>
		/// '{0:AuthorIdName}' dettached person '{0:PersonIdName}' from profile '{0:ProfileIdName}'.
		/// </summary>
		public const string ProfilePersonDettached = "AFF83CEB-87F2-4543-8A69-1AFEA559BFD3";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of profile '{0:ProfileIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string ProfilePropertyChanged = "72C7A0F9-C5F2-4958-BC54-556B676865D4";

		/// <summary>
		/// RearmedAfterAlarmEvent
		/// </summary>
		public const string RearmedAfterAlarm = "511A26E7-7F34-4644-9E44-2A163BE1DC20";

		/// <summary>
		/// '{0:AuthorIdName}' added checkout device '{0:DeviceIdName}' to reception '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionCheckoutDeviceAdded = "0DD6FB48-919F-4D94-BBBA-533F5096C17F";

		/// <summary>
		/// '{0:AuthorIdName}' removed checkout device '{0:DeviceIdName}' from reception '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionCheckoutDeviceRemoved = "65D68D70-5484-4922-A209-A3DB5284FF24";

		/// <summary>
		/// {0:AuthorIdName}' created reception '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionCreated = "6D3FEB30-2674-4DC1-A3CE-1081774B768A";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:ReceptionIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string ReceptionDataChanged = "EB8D15E7-68CB-4F5A-B175-207458193FD9";

		/// <summary>
		/// '{0:AuthorIdName}' deleted reception '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionDeleted = "0BD6EA31-B61C-44A8-B5EC-08836748BD14";

		/// <summary>
		/// '{0:AuthorIdName}' disabled required field '{0:Name}' of '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionRequiredFieldDisabled = "F1A4B9D7-88B5-4A6E-AD6A-9C2C2B3EBE67";

		/// <summary>
		/// '{0:AuthorIdName}' enabled required field '{0:Name}' of '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionRequiredFieldEnabled = "EAC00CA5-A6FC-49DF-A732-8E6768C20520";

		/// <summary>
		/// '{0:AuthorIdName}' added supported credential type '{0:CredentialTypeIdName}' to reception '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionSupportedCredentialTypeAdded = "5F679FAA-3831-4EB9-8112-5101A3504650";

		/// <summary>
		/// '{0:AuthorIdName}' removed supported credential type '{0:CredentialTypeIdName}' from reception '{0:ReceptionIdName}'.
		/// </summary>
		public const string ReceptionSupportedCredentialTypeRemoved = "D7F68F8C-D33D-4695-AC02-A5732445504D";

		/// <summary>
		/// RedialEvent
		/// </summary>
		public const string Redial = "84E48184-F4AB-4136-A96A-F1B27D25AE57";

		/// <summary>
		/// '{0:AuthorIdName}' archived '{0:RegionIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string RegionArchived = "06C4407C-9363-4984-B90C-CE11A89CD080";

		/// <summary>
		/// '{0:AuthorIdName}' created '{0:RegionIdName}' under '{0:ParentIdName}'.
		/// </summary>
		public const string RegionCreated = "E90F5A40-5268-4528-8845-51BBCE6F7258";

		/// <summary>
		/// '{0:AuthorIdName}' added '{0:DeviceIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public const string RegionDeviceLinkCreated = "C39D3FA5-3BAF-474D-873A-4194BDC76F60";

		/// <summary>
		/// '{0:AuthorIdName}' deleted '{0:DeviceIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string RegionDeviceLinkDeleted = "E856D858-3774-42A1-943D-474FEDD8A1E7";

		/// <summary>
		/// RegionEntranceDetectedEvent
		/// </summary>
		public const string RegionEntranceDetected = "2E173666-D01F-4CC1-8560-0C7BDF040DB3";

		/// <summary>
		/// RegionExitingDetectedEvent
		/// </summary>
		public const string RegionExitingDetected = "83E395A9-BA22-44C6-8AF4-DF65265120BE";

		/// <summary>
		/// '{0:AuthorIdName}' changed parent of '{0:RegionIdName}' from '{0:OldParentIdName}' to '{0:NewParentIdName}'.
		/// </summary>
		public const string RegionParentChanged = "07018C3F-B173-41E9-8B38-D58651BFDF87";

		/// <summary>
		/// '{0:AuthorIdName}' permanently deleted '{0:RegionIdName}' from '{0:ParentIdName}'.
		/// </summary>
		public const string RegionPermanentlyDeleted = "53A1DDD7-15E6-45C9-92FE-7C67C15BAB9C";

		/// <summary>
		/// '{0:AuthorIdName}' changed photo for '{0:RegionIdName}'.
		/// </summary>
		public const string RegionPhotoChanged = "E8D21CBB-8727-4A32-BF90-4049F1F8855E";

		/// <summary>
		/// '{0:AuthorIdName}' uploaded photo for '{0:RegionIdName}'.
		/// </summary>
		public const string RegionPhotoCreated = "2ED9DBF3-BDBB-42A5-804B-3E053691616A";

		/// <summary>
		/// '{0:AuthorIdName}' deleted photo for '{0:RegionIdName}'.
		/// </summary>
		public const string RegionPhotoDeleted = "B685968B-D2F8-415E-8620-C334734823D1";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of '{0:RegionIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string RegionPropertyChanged = "DD0C283C-E3B1-4D41-B881-D4B7BA94851A";

		/// <summary>
		/// '{0:AuthorIdName}' restored '{0:RegionIdName}' to '{0:ParentIdName}'.
		/// </summary>
		public const string RegionRestored = "688CBDF2-6A98-4938-B60E-261DD63C6202";

		/// <summary>
		/// '{0:DeviceIdName}' reset setting.
		/// </summary>
		public const string Reset = "2AA56E6F-5872-4E4C-A3B3-DED3FA55CF1F";

		/// <summary>
		/// '{0:DeviceIdName}' restored after a ring failure.
		/// </summary>
		public const string RingFailureRecoveredShunt = "04699580-8652-43A9-893F-2105D6577E7D";

		/// <summary>
		/// '{0:DeviceIdName}' ring failure.
		/// </summary>
		public const string RingFailureShunt = "D2BA629D-73A5-440D-8949-426F3C6AA0A7";

		/// <summary>
		/// '{0:AuthorIdName}' assigned '{0:PersonIdName}' to the '{0:RoleIdName}' role.
		/// </summary>
		public const string RoleAssigned = "C580402C-4A86-4CAC-97CD-DF059F086F1F";

		/// <summary>
		/// '{0:AuthorIdName}' unassigned '{0:PersonIdName}' from the '{0:RoleIdName}' role.
		/// </summary>
		public const string RoleUnassigned = "76DF71A2-CE80-46DB-BE65-53B3CB9A607E";

		/// <summary>
		/// '{0:AuthorIdName}' activated Safe Connect Gateway service.
		/// </summary>
		public const string SafeConnectGatewayActivated = "2DF0CFCB-3F33-4554-8CD4-F21FA112EAFC";

		/// <summary>
		/// '{0:AuthorIdName}' deactivated Safe Connect Gateway service.
		/// </summary>
		public const string SafeConnectGatewayDeactivated = "588F168B-FBE9-470E-B14F-F5128750B9E7";

		/// <summary>
		/// '{0:AuthorIdName}' restarted Safe Connect Gateway service.
		/// </summary>
		public const string SafeConnectGatewayRestarted = "BD81FE54-3842-45C8-90CA-38AF10BEF136";

		/// <summary>
		/// '{0:AuthorIdName}' started Safe Connect Gateway service.
		/// </summary>
		public const string SafeConnectGatewayStarted = "A62EE27F-ECBD-4732-AF7C-DA21E4A97253";

		/// <summary>
		/// '{0:AuthorIdName}' stopped Safe Connect Gateway service.
		/// </summary>
		public const string SafeConnectGatewayStopped = "48CC62E5-632B-4B83-BCEE-837ABC410AF9";

		/// <summary>
		/// SceneChangeSuddenEvent
		/// </summary>
		public const string SceneChangeSudden = "151C1508-7BE6-49C1-A988-DC6DD4AFDA7B";

		/// <summary>
		/// ServiceModeEnteredEvent
		/// </summary>
		public const string ServiceModeEntered = "AE0424E0-2827-45C2-A115-2E7774803585";

		/// <summary>
		/// ServiceModeExitedEvent
		/// </summary>
		public const string ServiceModeExited = "96A34B6F-0225-4FF7-90D2-E608C3E920CF";

		/// <summary>
		/// ServiceOnEvent
		/// </summary>
		public const string ServiceOn = "848EE55C-88DB-43DB-9ED3-64C0EF1C9397";

		/// <summary>
		/// ServiceOutEvent
		/// </summary>
		public const string ServiceOut = "20270D37-6EFA-4542-8114-E24BA5E5E702";

		/// <summary>
		/// '{0:AuthorIdName}' created setting for '{0:EntityIdName}'.
		/// </summary>
		public const string SettingCreated = "46AF00B5-D479-4BDC-AC29-9BA4C48C24BA";

		/// <summary>
		/// '{0:AuthorIdName}' changed property '{0:Name}' of Setting of '{0:EntityIdName}' from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string SettingDataChanged = "F484E4C8-2375-439F-AD5A-E542E65720CA";

		/// <summary>
		/// '{0:AuthorIdName}' deleted setting for '{0:EntityIdName}'.
		/// </summary>
		public const string SettingDeleted = "2B09C462-7A2A-4129-800B-4CFA0E7717A1";

		/// <summary>
		/// SmartRoutineActivatedEvent
		/// </summary>
		public const string SmartRoutineActivated = "5C5513FB-6D50-40B2-BCC0-6B2B8750BE2C";

		/// <summary>
		/// SmartRoutineCreatedEvent
		/// </summary>
		public const string SmartRoutineCreated = "D55A64CB-5C44-47ED-BCC2-8BE44BC0F29C";

		/// <summary>
		/// SmartRoutineDeactivatedEvent
		/// </summary>
		public const string SmartRoutineDeactivated = "581B7086-EBD6-477F-935C-784150AEBA85";

		/// <summary>
		/// SmartRoutineDeletedEvent
		/// </summary>
		public const string SmartRoutineDeleted = "F6A620DC-E1BB-4293-8FE7-313EFADB44B7";

		/// <summary>
		/// SmartRoutineExecutedEvent
		/// </summary>
		public const string SmartRoutineExecuted = "6DDBA642-5990-495C-AA54-BD9ADFED696E";

		/// <summary>
		/// SmartRoutineUpdatedEvent
		/// </summary>
		public const string SmartRoutineUpdated = "9CD520F2-DC36-45A9-8D83-895652474ACC";

		/// <summary>
		/// SMSConnectionTestAutomaticCallEvent
		/// </summary>
		public const string SMSConnectionTestAutomaticCall = "D853B707-3DEE-474A-A5D8-B422A68364AB";

		/// <summary>
		/// SoakTestFinishedEvent
		/// </summary>
		public const string SoakTestFinished = "B27F0306-68E3-47A8-8D15-E96B1518DDDC";

		/// <summary>
		/// SoakTestStartedEvent
		/// </summary>
		public const string SoakTestStarted = "C3C060D9-D687-43C6-82EA-0BFDB3026ADA";

		/// <summary>
		/// '{0:DeviceIdName}' sounder activated.
		/// </summary>
		public const string SounderActivated = "9AA4EDB8-4DBF-4272-B8B4-19A2E0F76C0D";

		/// <summary>
		/// SounderActivationDelayDisabledEvent
		/// </summary>
		public const string SounderActivationDelayDisabled = "D91C1BEF-CA0B-45C2-9953-1BDF0B8D5BA1";

		/// <summary>
		/// SounderActivationDelayEnabledEvent
		/// </summary>
		public const string SounderActivationDelayEnabled = "1C42EC3B-BE61-425C-ADF0-4914C4BE6723";

		/// <summary>
		/// '{0:DeviceIdName}' sounder deactivated.
		/// </summary>
		public const string SounderDeactivated = "BCA33826-2214-47F0-97C4-BC23FB82FAAB";

		/// <summary>
		/// '{0:DeviceIdName}' sounder disabled.
		/// </summary>
		public const string SounderDisabled = "E23AC880-432B-43F1-89E5-0E5125506A16";

		/// <summary>
		/// '{0:DeviceIdName}' sounder enabled.
		/// </summary>
		public const string SounderEnabled = "192953FC-86C5-4198-9B7E-48A105CD6D50";

		/// <summary>
		/// '{0:DeviceIdName}' sounder failure.
		/// </summary>
		public const string SounderFailure = "C301F825-7BF8-4461-96D4-07364F63CA9C";

		/// <summary>
		/// '{0:DeviceIdName}' restored after a sounder failure.
		/// </summary>
		public const string SounderFailureRecovered = "83D7F031-64B4-4DF5-A96D-EA5B57FD0776";

		/// <summary>
		/// SounderMutedEvent
		/// </summary>
		public const string SounderMuted = "E313ED80-E0FC-4F86-A82D-4DFC40C13043";

		/// <summary>
		/// SoundIntensityChangeSuddenEvent
		/// </summary>
		public const string SoundIntensityChangeSudden = "C52E88B6-D118-43B0-A5F9-FBBDC0BF5DB1";

		/// <summary>
		/// SynchronizationFailedEvent
		/// </summary>
		public const string SynchronizationFailed = "53F47CB8-F4E2-4441-9586-AC7F9A7392F1";

		/// <summary>
		/// SynchronizationFinishedEvent
		/// </summary>
		public const string SynchronizationFinished = "CB1B7187-C511-4C56-BB31-6EF82CA0314A";

		/// <summary>
		/// SynchronizationStartedEvent
		/// </summary>
		public const string SynchronizationStarted = "A7F59055-BF84-4CF3-9244-C003906B2783";

		/// <summary>
		/// Tamper on '{0:DeviceIdName}'.
		/// </summary>
		public const string Tamper = "DA81009C-1AAD-4101-93F9-A694F21EAED6";

		/// <summary>
		/// Tamper completed on '{0:DeviceIdName}'.
		/// </summary>
		public const string TamperRecovered = "2C2BC715-4EA4-4078-9291-53733F76428A";

		/// <summary>
		/// TemplateCreatedEvent
		/// </summary>
		public const string TemplateCreated = "292064C8-BA2C-4F4C-AAA7-969AA1B4AE34";

		/// <summary>
		/// TemplateDeletedEvent
		/// </summary>
		public const string TemplateDeleted = "13CB31F6-B0FA-46EB-92CB-B904ADB478F8";

		/// <summary>
		/// TemplateDisabledEvent
		/// </summary>
		public const string TemplateDisabled = "A8CCD1E9-C538-4825-8EA0-1D16F31A6B6F";

		/// <summary>
		/// TemplateEnabledEvent
		/// </summary>
		public const string TemplateEnabled = "A15C2491-18F4-4947-A234-729C6051E8C4";

		/// <summary>
		/// TemplatePrintedEvent
		/// </summary>
		public const string TemplatePrinted = "BCC909A4-8412-4E86-8650-D797AD86253C";

		/// <summary>
		/// TemplateUpdatedEvent
		/// </summary>
		public const string TemplateUpdated = "B1F325C3-DFE7-4316-BE8E-2CCA696F79BB";

		/// <summary>
		/// TestAlarmFinishedSoakEvent
		/// </summary>
		public const string TestAlarmFinishedSoak = "CE8872BE-F553-418F-BF06-463698BD74BC";

		/// <summary>
		/// Alarm on '{0:DeviceIdName}' in test mode.
		/// </summary>
		public const string TestAlarmInTest = "9FBDDC29-52D3-408C-83B7-EAA97F27D6D5";

		/// <summary>
		/// TestAlarmStartedSoakEvent
		/// </summary>
		public const string TestAlarmStartedSoak = "8E3457D4-7D49-4686-B3F2-4CCB1020A31F";

		/// <summary>
		/// TestAutomaticEvent
		/// </summary>
		public const string TestAutomatic = "6B08437C-864F-4191-9801-2442678810C2";

		/// <summary>
		/// TestFailureBatteryEvent
		/// </summary>
		public const string TestFailureBattery = "14AAE8D6-3D65-4085-8807-061DBA24F18C";

		/// <summary>
		/// Failure on '{0:DeviceIdName}' in test mode.
		/// </summary>
		public const string TestFailureInTest = "35E32C0B-472D-4319-BE6B-1962C4B3D0A7";

		/// <summary>
		/// TestFailureRecoveredBatteryEvent
		/// </summary>
		public const string TestFailureRecoveredBattery = "1AF584F1-9FC0-45F6-8BF0-3ED92D35EEC2";

		/// <summary>
		/// Testing of '{0:DeviceIdName}' was finished.
		/// </summary>
		public const string TestFinished = "54EE5A5F-42D3-4706-AE7F-178FA4B4D3E1";

		/// <summary>
		/// Recovery of normal state on '{0:DeviceIdName}' in test mode.
		/// </summary>
		public const string TestNormalInTest = "6C7A315B-D013-48C2-929A-E7020FDD4B8A";

		/// <summary>
		/// '{0:DeviceIdName}' test mode started.
		/// </summary>
		public const string TestStarted = "EBEAF511-BC9B-4783-848C-8BB7B167D4F7";

		/// <summary>
		/// TicketAssignedToPersonEvent
		/// </summary>
		public const string TicketAssignedToPerson = "241294D9-4D12-41F3-AD7A-739900C71DD9";

		/// <summary>
		/// TicketClosedEvent 
		/// </summary>
		public const string TicketClosed = "14B17898-4BB5-49B2-A907-4406E53759FB";

		/// <summary>
		/// TicketCreatedEvent
		/// </summary>
		public const string TicketCreated = "61EFAFE1-EABC-4929-B8A7-4A1C1E8555B1";

		/// <summary>
		/// TicketImageAddedEvent
		/// </summary>
		public const string TicketImageAdded = "E0F9E945-80E6-40A2-B1AB-4976FAD19FF1";

		/// <summary>
		/// TicketNoteAddedEvent
		/// </summary>
		public const string TicketNoteAdded = "3880E875-1D26-41F1-821D-66EF414523D9";

		/// <summary>
		/// TicketResponsiblePersonSetEvent 
		/// </summary>
		public const string TicketResponsiblePersonSet = "B85624D7-F112-41C7-B8B1-71DA04B63A09";

		/// <summary>
		/// TicketStateChangedEvent
		/// </summary>
		public const string TicketStateChanged = "84CEEF42-F0A6-4AEA-A1D2-C92CEF41CCF6";

		/// <summary>
		/// Time set to '{0:DeviceIdName}'. Offset with real time was {0:TimeDiff} minutes.
		/// </summary>
		public const string TimeDifferenceWarningTooBig = "8AA223C5-80B4-49BE-8F2B-1E94E2D39AD9";

		/// <summary>
		/// '{0:DeviceIdName}' switched to T2 time.
		/// </summary>
		public const string TimeSwitchedToT2 = "43EC5AEA-8CDA-48E3-9400-D6CA1460A18C";

		/// <summary>
		/// '{0:AuthorIdName}' changed property Time Zone of Setting of '{0:EntityIdName}' from '[${0:OldValue}$]' to '[${0:Value}$]'.
		/// </summary>
		public const string TimeZoneSettingDataChanged = "BD3FBEB8-8566-456D-A5E6-D8F47EB69B45";

		/// <summary>
		/// {0:AuthorIdName}' changed property '{0:Name}' of trace log info from '{0:OldValue}' to '{0:Value}'.
		/// </summary>
		public const string TraceLogInfoPropertyChanged = "97972458-1874-47F2-848A-F59D37747614";

		/// <summary>
		/// '{0:AuthorIdName}' deleted trace logs.
		/// </summary>
		public const string TraceLogsDeleted = "91587ED1-4892-46CF-BC23-30ECA4651430";

		/// <summary>
		/// '{0:AuthorIdName}' disabled diagnostic trace logging.
		/// </summary>
		public const string TraceLogsDisabled = "3239AE4F-6D12-408D-A2EA-E130A947F3E3";

		/// <summary>
		/// '{0:AuthorIdName}' downloaded trace logs.
		/// </summary>
		public const string TraceLogsDownloaded = "201FEE17-2742-4847-BEEC-99231E258DFB";

		/// <summary>
		/// '{0:AuthorIdName}' enabled diagnostic trace logging.
		/// </summary>
		public const string TraceLogsEnabled = "265B979A-E4F8-4AF4-800A-72A77B943C26";

		/// <summary>
		/// UnattendedBaggageDetectedEvent
		/// </summary>
		public const string UnattendedBaggageDetected = "1E0359CE-B727-463D-BB1C-6ADB106689E5";

		/// <summary>
		/// Technical event on device '{0:DeviceIdName}'. More details: '{0:Description}'
		/// </summary>
		public const string Unknown = "0CE9C379-C844-400E-88EB-D122EA2F3A35";

		/// <summary>
		/// '{0:DeviceIdName}' unlocked.
		/// </summary>
		public const string Unlocked = "7F09746D-11EE-4C04-870B-171F9AA4A343";

		/// <summary>
		/// '{0:DeviceIdName}' remotely unlocked by '{0:PersonIdName}'.
		/// </summary>
		public const string UnlockedRemotely = "ACD7875D-AAE9-4C51-8995-2D3543CD2372";

		/// <summary>
		/// '{0:DeviceIdName}' is unable to recognize the data that has been read. Data: '{0:Data}'
		/// </summary>
		public const string UnrecognizedDataRead = "EB7BB2D7-CE72-4EDE-86C1-461F6C32F4F1";

		/// <summary>
		/// Untrusted assembly: '{0:AssemblyName}' loaded from location: '{0:AssemblyLocation}', reason: '{0:Reason}'
		/// </summary>
		public const string UntrustedAssemblyLoaded = "D6C33A8B-3B2A-4413-8228-7AC956E3FE3D";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' was cancelled by '{0:PersonIdName}'.
		/// </summary>
		public const string UploadCancelled = "8E0F5DA0-36E9-443D-92C3-FF2664B22111";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to communication failure (duration'{0:Time}').
		/// </summary>
		public const string UploadFailedCommunicationFailure = "40191370-35D5-4317-A883-E5CFB9491721";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to busy device (duration'{0:Time}').
		/// </summary>
		public const string UploadFailedDeviceBusy = "7E100DF7-8B40-4376-B81D-9F9F664F2394";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to full memory (duration'{0:Time}').
		/// </summary>
		public const string UploadFailedDeviceMemoryFull = "7346A3A7-852A-4768-B7E6-5F2A1324F070";

		/// <summary>
		/// UploadFailedDuplicatedCredential
		/// </summary>
		public const string UploadFailedDuplicatedCredential = "EBEC866F-72F0-4BB7-9499-2985D05B254F";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to insufficient license on device (duration'{0:Time}').
		/// </summary>
		public const string UploadFailedInsufficientLicenseOnDevice = "A2BFFAEB-E59E-40D0-B1C1-7BDDB6D7AB7B";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to internal failure on device (duration'{0:Time}').
		/// </summary>
		public const string UploadFailedInternalDeviceFailure = "72762327-BB10-4392-A891-510A3F62F6BD";

		/// <summary>
		/// UploadFailedInvalidCredentialEvent
		/// </summary>
		public const string UploadFailedInvalidCredential = "40B0361B-A12F-4D9F-956B-7390AC9418F8";

		/// <summary>
		/// UploadFailedOtherReasonEvent
		/// </summary>
		public const string UploadFailedOtherReason = "A88AEFBF-D324-404B-BB5A-5AF957662DDD";

		/// <summary>
		/// UploadFailedOutOfRangeEvent
		/// </summary>
		public const string UploadFailedOutOfRange = "0B811EDF-8166-4A62-BE9B-1D697AA20016";

		/// <summary>
		/// UploadFailedPersonOutOfRange
		/// </summary>
		public const string UploadFailedPersonOutOfRange = "66AFA94E-61E7-44E0-A0F0-59623ABF1B69";

		/// <summary>
		/// UploadFailedReservedPositonEvent
		/// </summary>
		public const string UploadFailedReservedPositon = "7FB64477-ED0C-4F68-9526-153DA5E6F1F7";

		/// <summary>
		/// UploadFailedTimeoutEvent
		/// </summary>
		public const string UploadFailedTimeout = "E1B5BEAF-2FFE-4048-8EE9-A575845D34E9";

		/// <summary>
		/// UploadFailedTooComplexEvent
		/// </summary>
		public const string UploadFailedTooComplex = "5FCC0D17-D7FE-489D-9243-321C87D95561";

		/// <summary>
		/// UploadFailedValidationEvent
		/// </summary>
		public const string UploadFailedValidation = "75E187ED-33DF-4C81-923D-63DA3B451C71";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' failed due to wrong person configuration (duration'{0:Time}').
		/// </summary>
		public const string UploadFailedWrongPersonConfiguration = "2514ED93-9D40-4256-BABF-5BF03C0E6E0C";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload failed in '{0:DeviceIdName}' (duration'{0:Time}').
		/// </summary>
		public const string UploadFailure = "F85BF498-DBC6-4A64-9DFE-96EDBC3D91DE";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' started.
		/// </summary>
		public const string UploadStarted = "90873C8A-35AA-4B40-8505-6F4413BE035E";

		/// <summary>
		/// '[$UploadType.txt{0:UploadType}$]' upload to '{0:DeviceIdName}' successfully completed (duration'{0:Time}').
		/// </summary>
		public const string UploadSuccessfullyCompleted = "E9A48D05-45CC-48AF-BB27-CE7D82E61705";

		/// <summary>
		/// '{0:PersonIdName}' signed in through SafeConnect from agent '{0:AgentIdName}', IP address '{0:IpAddress}' ('{0:IpAddressDomainName}'), using Portal Account '{0:SafeConnectPortalUserIdName}', SafeConnect Device '{0:SafeConnectDeviceIdName}'.
		/// </summary>
		public const string UserSignedInBySafeConnect = "B76F558D-B461-4330-B17F-3A240623A97E";

		/// <summary>
		/// '{0:PersonIdName}' signed in from agent '{0:AgentIdName}', IP address '{0:IpAddress}' ('{0:IpAddressDomainName}').
		/// </summary>
		public const string UserSignedIn = "12F2EC13-2571-489C-A646-3AE88E839618";

		/// <summary>
		/// '{0:PersonIdName}' signed off from agent '{0:AgentIdName}'.
		/// </summary>
		public const string UserSignedOff = "5BC6F8AD-8696-4F9E-8144-5F79DCB09D92";

		/// <summary>
		/// VehicleRegistrationPlateRecordedEvent
		/// </summary>
		public const string VehicleRegistrationPlateRecorded = "849A13F8-2C62-43F0-A285-B438AED5250F";

		/// <summary>
		/// VideosignalLostEvent
		/// </summary>
		public const string VideosignalLost = "4CB550C8-080A-4F8B-BC68-844BBCA61F3C";

		/// <summary>
		/// VideosignalLostRestoredEvent
		/// </summary>
		public const string VideosignalLostRestored = "2DA6E117-D614-4966-B63C-A2EC93DE2473";

		/// <summary>
		/// VisitCreatedEvent
		/// </summary>
		public const string VisitCreated = "5A2CDF20-4BD4-47EF-956A-A719CCB600DB";

		/// <summary>
		/// VisitDataChangedEvent
		/// </summary>
		public const string VisitDataChanged = "F1B4015A-98A4-45E9-A78E-339344482DFE";

		/// <summary>
		/// VisitEvents
		/// </summary>
		public const string Visits = "1F9FE8A4-B9BA-48E3-8698-15A793C21140";

		/// <summary>
		/// Walk test failed on '{0:DeviceIdName}'.
		/// </summary>
		public const string WalkTestFailed = "9533E816-8511-4ACA-836B-09D395207C0F";

		/// <summary>
		/// Walk test finished on '{0:DeviceIdName}'.
		/// </summary>
		public const string WalkTestFinished = "DD2BDB3E-A061-40F3-8766-64A72F970EB0";

		/// <summary>
		/// Walk test started on '{0:DeviceIdName}'.
		/// </summary>
		public const string WalkTestStarted = "C6728612-3773-426B-81F7-FE4F1B78BE94";

		/// <summary>
		/// Walk test succeeded on '{0:DeviceIdName}'.
		/// </summary>
		public const string WalkTestSucceeded = "E6900E72-D015-4A70-869E-C19333C6EA35";

		/// <summary>
		/// WarningBeforeAutomaticArmingEvent
		/// </summary>
		public const string WarningBeforeAutomaticArming = "19D50F6A-5EE2-4D3D-80E8-18655D4E2813";

		/// <summary>
		/// '{0:DeviceIdName}' warning.
		/// </summary>
		public const string Warning = "AAE50BB8-D89C-4E13-A460-8390563A9BCA";

		/// <summary>
		/// '{0:DeviceIdName}' warning ended.
		/// </summary>
		public const string WarningRecovered = "2741EB67-4351-4803-B221-68867A8566AA";

		/// <summary>
		/// ZoneInActivatedStateEvent
		/// </summary>
		public const string ZoneInActivatedState = "B3653E15-3FC9-401F-B8CC-4E3CC563DE2D";

		/// <summary>
		/// ZoneInNormalStateEvent
		/// </summary>
		public const string ZoneInNormalState = "22C5CE62-7B0B-4B11-AD96-E06C17DBE869";

	}
}