namespace commercetools.Api.Models.Products
{
    public class LongAttribute: Attribute, GenericAttribute<long>
    {
        public long GetValue() => (long)Value;
    }
}