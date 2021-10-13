namespace commercetools.Api.Models.Products
{
    public class StringAttribute : Attribute, GenericAttribute<string>
    {
        public string GetValue() => (string)Value;
    }
}