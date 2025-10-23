using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CentPrecisionMoney))]
    public partial interface ICentPrecisionMoney : ITypedMoney
    {
        new int FractionDigits { get; set; }

    }
}
