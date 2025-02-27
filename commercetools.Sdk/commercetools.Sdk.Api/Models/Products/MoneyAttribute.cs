using System;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;

namespace commercetools.Sdk.Api.Models.Products
{
    public class MoneyAttribute : Attribute, IGenericAttribute<ITypedMoney>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(ITypedMoney);

        public ITypedMoney GetValue() => (ITypedMoney)Value;
    }
}