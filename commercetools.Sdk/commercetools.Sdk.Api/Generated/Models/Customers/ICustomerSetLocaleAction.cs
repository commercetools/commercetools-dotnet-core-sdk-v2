using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetLocaleAction))]
    public partial interface ICustomerSetLocaleAction : ICustomerUpdateAction
    {
        string Locale { get; set; }
    }
}
