using System;

namespace commercetools.Sdk.Api.Models.Products
{
    public class DecimalAttribute : Attribute, IGenericAttribute<decimal>
    {
        public Type GetValueType() => typeof(decimal);

        public decimal GetValue() => (decimal)Value;

        public static implicit operator LongAttribute(DecimalAttribute value)
        {
            return new LongAttribute() { Name = value.Name, Value = Convert.ToInt64(value.Value) };
        }
    }
}