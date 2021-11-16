namespace commercetools.Api.Models.Projects
{
    public partial class ExternalOAuth : IExternalOAuth
    {
        public string Url { get; set;}
        
        public string AuthorizationHeader { get; set;}
    }
}
