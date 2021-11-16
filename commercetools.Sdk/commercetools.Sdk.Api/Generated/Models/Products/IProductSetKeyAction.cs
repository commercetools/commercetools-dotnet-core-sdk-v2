using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetKeyAction))]
    public partial interface IProductSetKeyAction : IProductUpdateAction
    {
        string Key { get; set;}
    }
}
