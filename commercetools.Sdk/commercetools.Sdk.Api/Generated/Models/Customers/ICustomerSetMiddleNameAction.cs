using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetMiddleNameAction))]
    public partial interface ICustomerSetMiddleNameAction : ICustomerUpdateAction
    {
        string MiddleName { get; set; }
    }
}
