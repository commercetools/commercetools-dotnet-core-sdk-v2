using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetExternalIdAction))]
    public partial interface ICustomerSetExternalIdAction : ICustomerUpdateAction
    {
        string ExternalId { get; set;}
    }
}
