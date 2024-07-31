using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetSearchKeywordsAction))]
    public partial interface IProductSetSearchKeywordsAction : IProductUpdateAction
    {
        ISearchKeywords SearchKeywords { get; set; }

        bool? Staged { get; set; }

    }
}
