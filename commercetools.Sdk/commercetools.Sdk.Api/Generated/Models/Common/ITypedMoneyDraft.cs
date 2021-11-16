using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Common.TypedMoneyDraft))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Api.Models.Common.CentPrecisionMoneyDraft))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Api.Models.Common.HighPrecisionMoneyDraft))]
    public partial interface ITypedMoneyDraft : IMoney
    {
        IMoneyType Type { get; set; }

        int? FractionDigits { get; set; }
    }
}
