using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Common.TypedMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.Sdk.ImportApi.Models.Common.Money))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.Sdk.ImportApi.Models.Common.HighPrecisionMoney))]
    public partial interface ITypedMoney
    {
        IMoneyType Type { get; set; }

        int? FractionDigits { get; set; }

        long CentAmount { get; set; }

        string CurrencyCode { get; set; }
    }
}
