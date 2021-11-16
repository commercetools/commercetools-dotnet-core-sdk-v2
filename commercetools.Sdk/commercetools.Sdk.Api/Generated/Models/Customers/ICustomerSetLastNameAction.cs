using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetLastNameAction))]
    public partial interface ICustomerSetLastNameAction : ICustomerUpdateAction
    {
        string LastName { get; set; }
    }
}
