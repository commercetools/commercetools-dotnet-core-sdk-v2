namespace commercetools.Api.Models.Extensions
{
    public partial class AuthorizationHeaderAuthentication : IAuthorizationHeaderAuthentication
    {
        public string Type { get; set; }

        public string HeaderValue { get; set; }
        public AuthorizationHeaderAuthentication()
        {
            this.Type = "AuthorizationHeader";
        }
    }
}
