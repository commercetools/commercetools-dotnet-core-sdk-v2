using System;
using System.Collections.Generic;

namespace commercetools.Sdk.Api.Models.Products
{
    public class NestedAttribute : Attribute, IGenericAttribute<List<IAttribute>>
    {
        public Type GetValueType() => typeof(List<IAttribute>);

        public List<IAttribute> GetValue() => (List<IAttribute>)Value;
    }
}