using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerChangeEmailAction))]
    public partial interface ICustomerChangeEmailAction : ICustomerUpdateAction
    {
        string Email { get; set; }
    }
}
