using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.BestDeal))]
    public partial interface IBestDeal : IDiscountTypeCombination
    {
        string ChosenDiscountType { get; set; }

    }
}
