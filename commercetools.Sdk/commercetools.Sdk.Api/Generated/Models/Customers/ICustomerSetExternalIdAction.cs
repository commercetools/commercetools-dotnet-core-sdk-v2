using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetExternalIdAction))]
    public partial interface ICustomerSetExternalIdAction : ICustomerUpdateAction
    {
        string ExternalId { get; set; }

    }
}
