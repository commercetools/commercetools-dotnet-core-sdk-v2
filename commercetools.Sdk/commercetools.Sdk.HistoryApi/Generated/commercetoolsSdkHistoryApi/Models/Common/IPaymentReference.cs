using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.PaymentReference))]
    public partial interface IPaymentReference : IReference
    {
        new string Id { get; set; }

    }
}
