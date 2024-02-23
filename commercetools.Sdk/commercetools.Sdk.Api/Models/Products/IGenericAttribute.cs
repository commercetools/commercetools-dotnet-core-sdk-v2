namespace commercetools.Sdk.Api.Models.Products
{
    public interface IGenericAttribute<T> : IAttribute, IGenericTypeAttribute
    {
        T GetValue();
    }
}