using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.CentPrecisionMoneyDraft))]
    public partial interface ICentPrecisionMoneyDraft : ITypedMoneyDraft
    {
        new int? FractionDigits { get; set; }

    }
}
