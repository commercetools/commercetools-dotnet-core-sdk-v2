using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.HighPrecisionMoney))]
    public partial interface IHighPrecisionMoney : ITypedMoney
    {
        long PreciseAmount { get; set; }

        new int FractionDigits { get; set; }

    }
}
