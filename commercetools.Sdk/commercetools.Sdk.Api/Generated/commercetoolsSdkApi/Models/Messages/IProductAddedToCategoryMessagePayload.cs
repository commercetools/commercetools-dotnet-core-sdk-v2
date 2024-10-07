using commercetools.Sdk.Api.Models.Categories;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductAddedToCategoryMessagePayload))]
    public partial interface IProductAddedToCategoryMessagePayload : IMessagePayload
    {
        ICategoryReference Category { get; set; }

        bool Staged { get; set; }

    }
}
