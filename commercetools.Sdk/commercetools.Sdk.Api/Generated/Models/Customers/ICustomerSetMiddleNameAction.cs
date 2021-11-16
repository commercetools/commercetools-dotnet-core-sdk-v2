using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetMiddleNameAction))]
    public partial interface ICustomerSetMiddleNameAction : ICustomerUpdateAction
    {
        string MiddleName { get; set; }
    }
}
