using System;

namespace commercetools.Sdk.Api.Models.Products
{
    public class LongAttribute : Attribute, IGenericAttribute<long>
    {
        public Type GetValueType() => typeof(long);

        public long GetValue() => (long)Value;
        
        public static implicit operator DecimalAttribute(LongAttribute value)
        {
            return new DecimalAttribute() { Name = value.Name, Value = Convert.ToDecimal(value.Value)};
        }
    }
}