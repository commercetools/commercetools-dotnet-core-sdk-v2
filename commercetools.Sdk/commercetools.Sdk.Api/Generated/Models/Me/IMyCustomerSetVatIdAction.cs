using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerSetVatIdAction))]
    public partial interface IMyCustomerSetVatIdAction : IMyCustomerUpdateAction
    {
        string VatId { get; set;}
    }
}
