using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerChangePassword))]
    public partial interface ICustomerChangePassword
    {
        string Id { get; set; }

        long Version { get; set; }

        string CurrentPassword { get; set; }

        string NewPassword { get; set; }
    }
}
