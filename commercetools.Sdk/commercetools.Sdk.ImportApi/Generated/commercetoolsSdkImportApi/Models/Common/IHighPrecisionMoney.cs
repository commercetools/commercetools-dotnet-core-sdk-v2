using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.HighPrecisionMoney))]
    public partial interface IHighPrecisionMoney : ITypedMoney
    {
        long PreciseAmount { get; set; }

    }
}
