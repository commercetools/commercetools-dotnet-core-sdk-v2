using System;

namespace commercetools.Api.Models.Products
{
    public class StringAttribute : Attribute, IGenericAttribute<string>
    {
        public Type GetValueType() => typeof(string);

        public string GetValue() => (string)Value;
    }
}