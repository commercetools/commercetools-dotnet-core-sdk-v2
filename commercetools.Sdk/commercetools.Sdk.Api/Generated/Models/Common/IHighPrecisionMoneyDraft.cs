using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.HighPrecisionMoneyDraft))]
    public partial interface IHighPrecisionMoneyDraft : ITypedMoneyDraft
    {
        long PreciseAmount { get; set; }

        new long CentAmount { get; set; }
    }
}
