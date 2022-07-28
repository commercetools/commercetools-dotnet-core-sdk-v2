using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetTitleAction))]
    public partial interface ICustomerSetTitleAction : ICustomerUpdateAction
    {
        string Title { get; set; }

    }
}
