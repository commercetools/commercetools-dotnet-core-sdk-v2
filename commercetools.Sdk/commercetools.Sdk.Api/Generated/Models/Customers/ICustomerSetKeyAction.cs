using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetKeyAction))]
    public partial interface ICustomerSetKeyAction : ICustomerUpdateAction
    {
        string Key { get; set;}
    }
}
