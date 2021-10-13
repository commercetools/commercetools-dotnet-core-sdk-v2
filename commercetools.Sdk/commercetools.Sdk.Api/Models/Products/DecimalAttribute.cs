namespace commercetools.Api.Models.Products
{
    public class DecimalAttribute : Attribute, GenericAttribute<decimal>
    {
        public decimal GetValue() => (decimal)Value;
    }
}