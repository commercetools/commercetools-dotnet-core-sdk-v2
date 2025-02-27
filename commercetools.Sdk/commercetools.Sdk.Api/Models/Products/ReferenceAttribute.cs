using System;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;

namespace commercetools.Sdk.Api.Models.Products
{
    public class ReferenceAttribute : Attribute, IGenericAttribute<IReference>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(IReference);

        public IReference GetValue() => (IReference)Value;
    }
}