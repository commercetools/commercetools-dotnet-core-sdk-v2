using System;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Sdk.Api.Models.Products
{
    public class MoneyAttribute : Attribute, IGenericAttribute<ITypedMoney>
    {
        public Type GetValueType() => typeof(ITypedMoney);

        public ITypedMoney GetValue() => (ITypedMoney)Value;
    }
}