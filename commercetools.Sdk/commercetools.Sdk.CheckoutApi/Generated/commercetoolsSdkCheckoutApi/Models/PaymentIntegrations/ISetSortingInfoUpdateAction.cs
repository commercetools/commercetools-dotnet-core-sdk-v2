using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetSortingInfoUpdateAction))]
    public partial interface ISetSortingInfoUpdateAction : IPaymentIntegrationUpdateAction
    {
        ISortingInfo SortingInfo { get; set; }

    }
}
