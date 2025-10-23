using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Common.TypedMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Sdk.HistoryApi.Models.Common.CentPrecisionMoney))]
    public partial interface ITypedMoney : IMoney
    {
        IMoneyType Type { get; set; }

        int FractionDigits { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Common.CentPrecisionMoney CentPrecision(Action<commercetools.Sdk.HistoryApi.Models.Common.CentPrecisionMoney> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.CentPrecisionMoney();
            init?.Invoke(t);
            return t;
        }
    }
}
