using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetCategoryOrderHintAction))]
    public partial interface IProductSetCategoryOrderHintAction : IProductUpdateAction
    {
        string CategoryId { get; set; }

        string OrderHint { get; set; }

        bool? Staged { get; set; }

    }
}
