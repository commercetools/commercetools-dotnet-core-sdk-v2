using commercetools.Base.CustomAttributes;


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
    }
}
