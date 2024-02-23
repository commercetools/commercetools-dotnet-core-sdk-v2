using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.TypedMoneyDraft))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Sdk.Api.Models.Common.CentPrecisionMoneyDraft))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft))]
    public partial interface ITypedMoneyDraft : IMoney
    {
        IMoneyType Type { get; set; }

        int? FractionDigits { get; set; }

        new long CentAmount { get; set; }

        static commercetools.Sdk.Api.Models.Common.CentPrecisionMoneyDraft CentPrecision(Action<commercetools.Sdk.Api.Models.Common.CentPrecisionMoneyDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Common.CentPrecisionMoneyDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft HighPrecision(Action<commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
