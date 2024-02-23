using System;

namespace commercetools.Sdk.Api.Models.Products
{
    public class BooleanAttribute : Attribute, IGenericAttribute<bool>
    {
        public Type GetValueType() => typeof(bool);

        public bool GetValue() => (bool)Value;
    }
}