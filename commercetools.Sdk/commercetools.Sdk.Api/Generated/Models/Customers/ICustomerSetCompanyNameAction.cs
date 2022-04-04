using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerSetCompanyNameAction))]
    public partial interface ICustomerSetCompanyNameAction : ICustomerUpdateAction
    {
        string CompanyName { get; set; }
    }
}
