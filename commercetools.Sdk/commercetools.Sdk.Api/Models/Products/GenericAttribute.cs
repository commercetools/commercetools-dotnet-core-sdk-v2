namespace commercetools.Api.Models.Products
{
    public interface GenericAttribute<T>: IAttribute
    {
        T GetValue();
    }
}