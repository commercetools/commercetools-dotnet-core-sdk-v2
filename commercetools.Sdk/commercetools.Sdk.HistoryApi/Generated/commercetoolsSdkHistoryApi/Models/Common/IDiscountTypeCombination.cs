using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountTypeCombination))]
    public partial interface IDiscountTypeCombination
    {
        string Type { get; set; }

    }
}
