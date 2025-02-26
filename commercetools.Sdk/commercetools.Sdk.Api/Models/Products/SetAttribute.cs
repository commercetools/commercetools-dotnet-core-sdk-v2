using System;
using System.Collections.Generic;
using commercetools.Sdk.Api.Models.ProductTailorings;

namespace commercetools.Sdk.Api.Models.Products
{
    public class SetAttribute<T> : Attribute, IGenericAttribute<List<T>>, IProductTailoringAttribute
    {
        public Type GetValueType() => typeof(List<T>);

        public List<T> GetValue() => (List<T>)Value;
    }
}