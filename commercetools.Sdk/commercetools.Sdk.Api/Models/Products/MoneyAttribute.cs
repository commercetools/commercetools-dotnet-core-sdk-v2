using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Products
{
    public class MoneyAttribute: Attribute, GenericAttribute<ITypedMoney>
    {
        public ITypedMoney GetValue() => (ITypedMoney)Value;
    }
}