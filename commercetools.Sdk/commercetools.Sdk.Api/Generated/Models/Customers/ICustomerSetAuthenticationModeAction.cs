using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetAuthenticationModeAction))]
    public partial interface ICustomerSetAuthenticationModeAction : ICustomerUpdateAction
    {
        IAuthenticationMode AuthMode { get; set; }

        string Password { get; set; }
    }
}
