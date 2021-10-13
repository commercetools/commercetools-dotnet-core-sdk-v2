namespace commercetools.Api.Models.Products
{
    public class BooleanAttribute : Attribute, GenericAttribute<bool>
    {
        public bool GetValue() => (bool)Value;
    }
}