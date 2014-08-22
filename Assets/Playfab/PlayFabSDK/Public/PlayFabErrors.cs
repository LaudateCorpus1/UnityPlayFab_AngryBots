using System.Collections.Generic;

namespace PlayFab
{
	/// <summary>
	/// Error codes returned by PlayFabAPIs
	/// </summary>
	public enum PlayFabErrorCode
	{
		Unknown = 1,
		Success = 0,
		InvalidParams = 1000,
		AccountNotFound = 1001,
		AccountBanned = 1002,
		InvalidUsernameOrPassword = 1003,
		InvalidTitleId = 1004,
		InvalidEmailAddress = 1005,
		EmailAddressNotAvailable = 1006,
		InvalidUsername = 1007,
		InvalidPassword = 1008,
		UsernameNotAvailable = 1009,
		InvalidSteamTicket = 1010,
		AccountAlreadyLinked = 1011,
		LinkedAccountAlreadyClaimed = 1012,
		InvalidFacebookToken = 1013,
		AccountNotLinked = 1014,
		FailedByPaymentProvider = 1015,
		CouponCodeNotFound = 1016,
		InvalidContainerItem = 1017,
		ContainerNotOwned = 1018,
		KeyNotOwned = 1019,
		InvalidItemIdInTable = 1020,
		InvalidReceipt = 1021,
		ReceiptAlreadyUsed = 1022,
		ReceiptCancelled = 1023,
		GameNotFound = 1024,
		GameModeNotFound = 1025,
		InvalidGoogleToken = 1026,
		UserIsNotPartOfDeveloper = 1027,
		InvalidTitleForDeveloper = 1028,
		TitleNameConflicts = 1029,
		UserisNotValid = 1030,
		ValueAlreadyExists = 1031,
		BuildNotFound = 1032,
		PlayerNotInGame = 1033,
		InvalidTicket = 1034,
		InvalidDeveloper = 1035,
		InvalidOrderInfo = 1036,
		RegistrationIncomplete = 1037,
		InvalidPlatform = 1038,
		UnknownError = 1039,
		SteamApplicationNotOwned = 1040,
		WrongSteamAccount = 1041,
		TitleNotActivated = 1042,
		RegistrationSessionNotFound = 1043,
		NoSuchMod = 1044,
		FileNotFound = 1045,
		DuplicateEmail = 1046,
		ItemNotFound = 1047,
		ItemNotOwned = 1048,
		ItemNotRecycleable = 1049,
		ItemNotAffordable = 1050,
		InvalidVirtualCurrency = 1051,
		WrongVirtualCurrency = 1052,
		WrongPrice = 1053,
		NonPositiveValue = 1054,
		InvalidRegion = 1055,
		RegionAtCapacity = 1056,
		ServerFailedToStart = 1057,
		NameNotAvailable = 1058,
		InsufficientFunds = 1059,
		InvalidDeviceID = 1060,
		InvalidPushNotificationToken = 1061,
		NoRemainingUses = 1062,
		InvalidPaymentProvider = 1063,
		PurchaseInitializationFailure = 1064,
		DuplicateUsername = 1065,
		InvalidBuyerInfo = 1066,
		NoGameModeParamsSet = 1067,
		TooLong = 1068,
		ReservedWord = 1069,
		InvalidBodyValue = 1070,
		InvalidRequest = 1071,
		ReservedEvent = 1072,
		InvalidUserStatistics = 1073,
		NotAuthenticated = 1074,
		StreamAlreadyExists = 1075,
		ErrorCreatingStream = 1076,
		StreamNotFound = 1077,
		InvalidAccount = 1078,
		DisplayNameUpdatesNotEnabledForTitle = 1079,
		PurchaseDoesNotExist = 1080,
		InvalidPurchaseTransactionStatus = 1081,
		APINotEnabledForGameClientAccess = 1082
	}
	
	public class PlayFabError
    {
        public int HttpCode;
		public string HttpStatus;
		public PlayFabErrorCode Error;
		public string ErrorMessage;
		public Dictionary<string, List<string> > ErrorDetails;
    };
	
	public delegate void ErrorCallback(PlayFabError error);
	
}