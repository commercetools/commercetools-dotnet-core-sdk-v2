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
    }
}
