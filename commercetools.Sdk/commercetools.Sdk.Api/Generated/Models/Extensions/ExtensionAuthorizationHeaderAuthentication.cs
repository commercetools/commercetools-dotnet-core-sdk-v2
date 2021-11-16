namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionAuthorizationHeaderAuthentication : IExtensionAuthorizationHeaderAuthentication
    {
        public string Type { get; set; }

        public string HeaderValue { get; set; }
        public ExtensionAuthorizationHeaderAuthentication()
        {
            this.Type = "AuthorizationHeader";
        }
    }
}
