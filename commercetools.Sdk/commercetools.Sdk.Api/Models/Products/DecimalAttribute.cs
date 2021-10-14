using System;

namespace commercetools.Api.Models.Products
{
    public class DecimalAttribute : Attribute, IGenericAttribute<decimal>
    {
        public Type GetValueType() => typeof(decimal);

        public decimal GetValue() => (decimal)Value;
    }
}