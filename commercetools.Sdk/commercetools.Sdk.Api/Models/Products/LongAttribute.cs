using System;

namespace commercetools.Api.Models.Products
{
    public class LongAttribute: Attribute, IGenericAttribute<long>
    {
        public Type GetValueType() => typeof(long);

        public long GetValue() => (long)Value;
    }
}