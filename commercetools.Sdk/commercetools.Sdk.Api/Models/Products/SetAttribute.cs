using System;
using System.Collections.Generic;

namespace commercetools.Api.Models.Products
{
    public class SetAttribute<T> : Attribute, IGenericAttribute<List<T>>
    {
        public Type GetValueType() => typeof(List<T>);

        public List<T> GetValue() => (List<T>)Value;
    }
}