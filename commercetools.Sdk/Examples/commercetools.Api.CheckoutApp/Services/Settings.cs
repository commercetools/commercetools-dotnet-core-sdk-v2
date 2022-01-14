namespace commercetools.Api.CheckoutApp.Services
{
    public class Settings
    {
        public const int ExpireInDays = 2;
        public const string TokenKey = "CTP_TokenKey";
        public const string UserNameKey = "CTP_Username";
        public const string PasswordKey = "CTP_Password";
        public const string AnonymousKey = "CTP_AnonymousId";
        public static string ProjectKey { get; set; }
    }
}