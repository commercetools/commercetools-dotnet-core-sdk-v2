namespace commercetools.Base.Client
{
    public interface IClientConfiguration
    {
        string ClientId { get; set; }

        string ClientSecret { get; set; }

        string Scope { get; set; }

        string ProjectKey { get; set; }

        string AuthorizationBaseAddress { get; set; }

        string ApiBaseAddress { get; set; }
    }
}
