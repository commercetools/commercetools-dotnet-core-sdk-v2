using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetSalutationAction))]
    public partial interface ICustomerSetSalutationAction : ICustomerUpdateAction
    {
        string Salutation { get; set;}
    }
}
