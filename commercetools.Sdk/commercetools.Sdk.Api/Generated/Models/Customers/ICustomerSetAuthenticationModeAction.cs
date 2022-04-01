using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetAuthenticationModeAction))]
    public partial interface ICustomerSetAuthenticationModeAction : ICustomerUpdateAction
    {
        IAuthenticationMode AuthMode { get; set; }

        string Password { get; set; }
    }
}
