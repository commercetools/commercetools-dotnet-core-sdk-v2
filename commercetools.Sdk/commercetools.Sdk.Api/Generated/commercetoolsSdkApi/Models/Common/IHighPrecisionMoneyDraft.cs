using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft))]
    public partial interface IHighPrecisionMoneyDraft : ITypedMoneyDraft
    {
        new int FractionDigits { get; set; }

        long PreciseAmount { get; set; }

        new long CentAmount { get; set; }

    }
}
