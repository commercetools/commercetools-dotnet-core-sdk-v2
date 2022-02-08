using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.AzureFunctionsAuthentication))]
    public partial interface IAzureFunctionsAuthentication : IHttpDestinationAuthentication
    {
        string Key { get; set; }
    }
}
