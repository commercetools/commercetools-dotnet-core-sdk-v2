using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.MoneyAttribute))]
    public partial interface IMoneyAttribute : IAttribute
    {
        ITypedMoney Value { get; set; }

    }
}
