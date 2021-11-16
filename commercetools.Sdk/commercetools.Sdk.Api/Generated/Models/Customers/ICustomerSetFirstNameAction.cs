using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetFirstNameAction))]
    public partial interface ICustomerSetFirstNameAction : ICustomerUpdateAction
    {
        string FirstName { get; set;}
    }
}
