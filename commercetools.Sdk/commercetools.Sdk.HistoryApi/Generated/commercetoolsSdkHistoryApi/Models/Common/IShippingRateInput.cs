using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingRateInput))]
    public partial interface IShippingRateInput
    {
        string Type { get; set; }

    }
}
