using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.MoneyField))]
    public partial interface IMoneyField : ICustomField
    {
        ITypedMoney Value { get; set;}
    }
}
