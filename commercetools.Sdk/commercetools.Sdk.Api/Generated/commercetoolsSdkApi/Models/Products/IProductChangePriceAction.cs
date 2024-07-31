using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductChangePriceAction))]
    public partial interface IProductChangePriceAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        IPriceDraft Price { get; set; }

        bool? Staged { get; set; }

    }
}
