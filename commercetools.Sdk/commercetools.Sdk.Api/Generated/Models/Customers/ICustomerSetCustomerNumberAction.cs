using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCustomerNumberAction))]
    public partial interface ICustomerSetCustomerNumberAction : ICustomerUpdateAction
    {
        string CustomerNumber { get; set; }
    }
}
