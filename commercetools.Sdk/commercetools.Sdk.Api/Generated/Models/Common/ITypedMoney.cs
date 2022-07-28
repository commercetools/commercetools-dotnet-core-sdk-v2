using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.TypedMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Sdk.Api.Models.Common.CentPrecisionMoney))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoney))]
    public partial interface ITypedMoney : IMoney
    {
        IMoneyType Type { get; set; }

        int FractionDigits { get; set; }

        static commercetools.Sdk.Api.Models.Common.CentPrecisionMoney CentPrecision(Action<commercetools.Sdk.Api.Models.Common.CentPrecisionMoney> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Common.CentPrecisionMoney();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Common.HighPrecisionMoney HighPrecision(Action<commercetools.Sdk.Api.Models.Common.HighPrecisionMoney> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Common.HighPrecisionMoney();
            init?.Invoke(t);
            return t;
        }
    }
}
