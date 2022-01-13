using System;

namespace commercetools.Api.Models.Products
{
    public class BooleanAttribute : Attribute, IGenericAttribute<bool>
    {
        public Type GetValueType() => typeof(bool);

        public bool GetValue() => (bool)Value;
    }
}