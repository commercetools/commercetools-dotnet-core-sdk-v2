using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Common.TypedMoney))]
    [SubTypeDiscriminator("centPrecision", typeof(commercetools.ImportApi.Models.Common.Money))]
    [SubTypeDiscriminator("highPrecision", typeof(commercetools.ImportApi.Models.Common.HighPrecisionMoney))]
    public partial interface ITypedMoney
    {
        IMoneyType Type { get; set; }

        int? FractionDigits { get; set; }

        long CentAmount { get; set; }

        string CurrencyCode { get; set; }
    }
}
