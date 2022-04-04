using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoneyDraft))]
    public partial interface IHighPrecisionMoneyDraft : ITypedMoneyDraft
    {
        long PreciseAmount { get; set; }

        new long CentAmount { get; set; }
    }
}
