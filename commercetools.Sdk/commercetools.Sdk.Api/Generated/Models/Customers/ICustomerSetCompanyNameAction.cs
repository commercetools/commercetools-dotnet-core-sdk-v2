using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetCompanyNameAction))]
    public partial interface ICustomerSetCompanyNameAction : ICustomerUpdateAction
    {
        string CompanyName { get; set;}
    }
}
