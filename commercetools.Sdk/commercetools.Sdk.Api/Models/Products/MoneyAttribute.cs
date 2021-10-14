using System;
using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Products
{
    public class MoneyAttribute: Attribute, IGenericAttribute<ITypedMoney>
    {
        public Type GetValueType() => typeof(ITypedMoney);

        public ITypedMoney GetValue() => (ITypedMoney)Value;
    }
}