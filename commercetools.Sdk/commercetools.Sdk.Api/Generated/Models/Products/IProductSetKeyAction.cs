using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetKeyAction))]
    public partial interface IProductSetKeyAction : IProductUpdateAction
    {
        string Key { get; set; }

    }
}
