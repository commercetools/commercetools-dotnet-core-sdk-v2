using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.MoneyAttribute))]
    public partial interface IMoneyAttribute : IAttribute
    {
        ITypedMoney Value { get; set;}
    }
}
