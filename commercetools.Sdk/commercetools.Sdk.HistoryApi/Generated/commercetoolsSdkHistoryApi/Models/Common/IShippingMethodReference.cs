using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingMethodReference))]
    public partial interface IShippingMethodReference : IReference
    {
        new string Id { get; set; }

    }
}
