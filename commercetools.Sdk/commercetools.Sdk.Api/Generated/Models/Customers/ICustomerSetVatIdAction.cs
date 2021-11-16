using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetVatIdAction))]
    public partial interface ICustomerSetVatIdAction : ICustomerUpdateAction
    {
        string VatId { get; set;}
    }
}
