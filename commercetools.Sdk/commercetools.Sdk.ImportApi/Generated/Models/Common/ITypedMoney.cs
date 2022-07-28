using System;
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

        static commercetools.Sdk.ImportApi.Models.Common.Money CentPrecision(Action<commercetools.Sdk.ImportApi.Models.Common.Money> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.Money();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Common.HighPrecisionMoney HighPrecision(Action<commercetools.Sdk.ImportApi.Models.Common.HighPrecisionMoney> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Common.HighPrecisionMoney();
            init?.Invoke(t);
            return t;
        }
    }
}
