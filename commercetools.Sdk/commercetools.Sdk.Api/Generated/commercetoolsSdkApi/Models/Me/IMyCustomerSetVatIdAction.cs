using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerSetVatIdAction))]
    public partial interface IMyCustomerSetVatIdAction : IMyCustomerUpdateAction
    {
        string VatId { get; set; }

    }
}
