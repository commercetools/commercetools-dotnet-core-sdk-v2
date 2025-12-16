using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Common.DiscountTypeCombination))]
    [SubTypeDiscriminator("BestDeal", typeof(commercetools.Sdk.HistoryApi.Models.Common.BestDeal))]
    [SubTypeDiscriminator("Stacking", typeof(commercetools.Sdk.HistoryApi.Models.Common.Stacking))]
    public partial interface IDiscountTypeCombination
    {
        string Type { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Common.BestDeal BestDeal(Action<commercetools.Sdk.HistoryApi.Models.Common.BestDeal> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.BestDeal();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.HistoryApi.Models.Common.Stacking Stacking(Action<commercetools.Sdk.HistoryApi.Models.Common.Stacking> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.Stacking();
            init?.Invoke(t);
            return t;
        }
    }
}
