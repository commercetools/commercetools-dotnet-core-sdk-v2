using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.MoneyField))]
    public partial interface IMoneyField : ICustomField
    {
        ITypedMoney Value { get; set; }

    }
}
